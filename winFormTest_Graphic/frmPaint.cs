using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        int dMode = 0;//0:not 1:pen 2:line 3:rect 4:circle 5:text
        int dFlag = 0;//0:open(안누른상태), 1:pressed(마우스버튼누른상태)
        Point p1, p2, p3;

        public frmPaint()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
            pen = new Pen(Color.Red, 1.0f);
            //brush = new Brush(Color.Green);  brush는 인터페이스여서 인스턴스화 할 수 없다고 함 
        
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {

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

        private void menuText_Click(object sender, EventArgs e)
        {
            dMode = 5;//문자 쓰기 
            sblabel4.Text = "문자쓰기 ";
        }

        private void menuErase_Click(object sender, EventArgs e)
        {
            sblabel4.Text = "모두지우기 ";
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            string str = $"{e.X} x {e.Y}";
            sblabel1.Text = str ;   
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
