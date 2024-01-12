using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormTest_Graphic
{
    public partial class frmPaint : Form
    {
        Graphics g = null;
        Pen pen = null;
        Brush brush = null;
        Bitmap bmCanvas = null;

        int dMode = 0;//0:not 1:pen 2:line 3:rect 4:circle 5:text
        int dFlag = 0;//0:open(안누른상태), 1:pressed(마우스버튼누른상태)
        Point p1, p2, p3;
        Point cp1, cp2, cp3; //screen 좌표계 
     

        public frmPaint()
        {
            InitializeComponent();
            //g = canvas.CreateGraphics();
            pen = new Pen(Color.Red, 1.0f);//1.0f는 선두께 
                                           //brush = new Brush(Color.Green);  brush는 인터페이스여서 인스턴스화 할 수 없다고 함 
            frmPaint_ResizeEnd(null, null);

        }

        //sender 는 canvas 에서 보내는 것 
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            dFlag = 1;//눌렸을 때  
            //p1.X = e.X; p1.Y = e.Y; 
            p1 = e.Location;
            p2 = e.Location;
            p3 = e.Location;    
            cp1 = PointToScreen(p1);//현재의 좌표계를 로컬 창 좌표계로 변환시켜줌
            cp2 = cp3 = cp1 = ((Control)sender).PointToScreen(p1);                   
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            dFlag = 0;//안눌렸을 때  

            switch(dMode){
                case 2: //Line draw 
                    g.DrawLine(pen, p1, e.Location);
                    canvas.Invalidate(); //선그리기 할 때 DELAY가 생기면 

                    break;
                default:
                    break;
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //마우스 포인터가 프로그램 창을 벗어났을 때는 수행 없음 
            if (e.X < 0 || e.Y < 0 || e.X > canvas.Width || e.Y > canvas.Height) {
                return;
            }
            if (dFlag != 0)
            {
                switch (dMode)
                {
                    //case 0:                   
                    //    break;
                    case 1: //pen draw
                        g.DrawLine(pen, p1, e.Location);                       
                        p1 = e.Location;
                        canvas.Invalidate();//선그리기 할 때 DELAY가 생기면 

                        break;
                    case 2://line draw
                        cp3 = PointToScreen (e.Location);   
                        ControlPaint.DrawReversibleLine(cp1, cp2, DefaultBackColor);
                        ControlPaint.DrawReversibleLine(cp1, cp3, DefaultBackColor);

                        cp2 = cp3;
                        
                        //p2 = e.Location;
                        //g.DrawLine(pen,p1,e.Location);
                        break;
                    case 3://rect draw          
                    case 4://circle draw        
                    default: break;
                }
            }
            //canvas.Invalidate();
            string str = $"{e.X} x {e.Y}";
            sblabel1.Text = str;
        }

        private void menuShape_Click(object sender, EventArgs e)
        {
            dMode = 1;//연필그리기
            sblabel4.Text = "연필그리기";
        }

        private void menuLine_Click(object sender, EventArgs e)
        {
            dMode = 2;//선그리기 
            sblabel4.Text = "선그리기";
        }

        private void menuRect_Click(object sender, EventArgs e)
        {
            dMode = 3;//사각형 그리기 
            sblabel4.Text = "사각형 그리기 ";
        }

        private void menuCircle_Click(object sender, EventArgs e)
        {
            dMode = 4;//원 그리기 
            sblabel4.Text = "원 그리기 ";
        }

        private void frmPaint_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) { 
                frmPaint_ResizeEnd(sender, e);
            }
        }

        //private void sinGraphToolStripMenuItem_Click(object sender, EventArgs e)
        private void menuTestSine_Click(object sender, EventArgs e)
        {
            //g.Clear(DefaultBackColor);
            //canvas.Invalidate();
            menuErase_Click(sender, e);
            List<double> data = new List<double>();
            for (int i = 0; i < 360; i++) {
                //PI = 3.141592Math.PI
                data.Add(Math.Sin(3.141592/180*i));
            }

            int left=0, top=0, right=canvas.Width, bottom= canvas.Height;
            int range = right - left - 40;
            int step = range / 360;
            int amp = (bottom - 20)/2 ;
            int xOffset = 20;
            int yOffset = bottom / 2;
            
            g.DrawLine(pen, new Point(left+20, bottom/2),new Point(right-20, bottom/2));
            g.DrawLine(pen, new Point(left+20,10),new Point(left+20, bottom-10));
            PointF p1, p2;
            p1 = new PointF(xOffset, yOffset);  //최초의 시작 위치 

            for (int i = 0; i < 360; i++) {
                p2 = new PointF(i * step+xOffset, ((float)(data[i]*amp+yOffset)));
                data.Add(Math.Sin(i));
                g.DrawLine(pen,p1, p2); 
                p1 = p2;
            }
            canvas.Invalidate();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "MS-SQL Database file|*.mdf";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
               
                string fn = openFileDialog1.FileName;
                FileStream fs = new FileStream(fn, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                //string data = sr.ReadToEnd();

                string dayData = "";
                int price = 0;
                List<double> data = new List<double>();


                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                    

                    if (line != null)
                    {
                        string[] subs = line.Split(',');
                        //dayData = subs[1];
                        dayData = subs[1].Substring(1, subs[1].Length-2);
                        Console.WriteLine(dayData);
                        price = int.Parse(dayData);
                        //price = Convert.ToInt32(dayData);
                        Console.WriteLine(price);

                        menuErase_Click(sender, e);
                        data.Add(price);

                    }

                    int left = 0, top = 0, right = canvas.Width, bottom = canvas.Height;
                    int range = right - left - 40;
                    int step = range / 1600;
                    int amp = (bottom - 20) / 2;
                    int xOffset = 20;
                    int yOffset = bottom / 2;

                    g.DrawLine(pen, new Point(left + 20, bottom / 2), new Point(right - 20, bottom / 2));
                    g.DrawLine(pen, new Point(left + 20, 10), new Point(left + 20, bottom - 10));
                    PointF p1, p2;
                    p1 = new PointF(xOffset, yOffset);  //최초의 시작 위치 

                    for (int i = 0; i < 1600; i++)
                    {
                        p2 = new PointF(i * step + xOffset, ((float)(data[i] * amp + yOffset)));
                        //data.Add(Math.Sin(i));
                        g.DrawLine(pen, p1, p2);
                        p1 = p2;
                    }
                    canvas.Invalidate();

                }


                sr.Close();
                fs.Close();


               }
        }

        private void menuText_Click(object sender, EventArgs e)
        {
            dMode = 5;//문자 쓰기 
            sblabel4.Text = "문자쓰기 ";
        }

        private void frmPaint_ResizeEnd(object sender, EventArgs e)
        {
            int draw_X = canvas.Width, draw_Y = canvas.Height;
            if (bmCanvas == null)
            {
                bmCanvas = new Bitmap(draw_X, draw_Y);
                canvas.Image = bmCanvas;
            }
            else
            {
                Bitmap tBmp = new Bitmap(draw_X, draw_Y);//어떤 이미지가 없음
                Graphics tg = Graphics.FromImage(tBmp);
                tg.DrawImage(bmCanvas, 0, 0);
                bmCanvas.Dispose();
                bmCanvas = tBmp;
                canvas.Image = bmCanvas;
            }
            g = Graphics.FromImage(bmCanvas);
        }

            private void menuErase_Click(object sender, EventArgs e)
        {
            sblabel4.Text = "모두지우기 ";
        }



        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red);
            Point p1 = new Point(Left, Top);    
            Point p2 = new Point(Right, Bottom);
            Point p3 = new Point(Left, Bottom);
            Point p4 = new Point(Right, Top);
            g.DrawLine(pen, p1, p2);
            g.DrawLine (pen, p3, p4);   

        }
    }
}
