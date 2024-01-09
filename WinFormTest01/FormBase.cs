using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest01
{
    public partial class FormBase : Form
    {
        int EncMode=0;//0:UTF-8 , 1: ANSI
        Encoding enc = Encoding.UTF8;

        public FormBase()
        {
            InitializeComponent();
            if (EncMode == 0) {
                menuUTF8_Click(null, null);
            }else if(EncMode == 1) { 
                menuANSI_Click(null, null); 
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            menuOpen_Click(sender,e);
        }

        

        private void menuOpen_Click(object sender, EventArgs e)
        {
            //open 버튼을 클릭하면, 아래의 다이얼로그를 보여줘라 
            //mfc 에서는 doModal로 실행시켰음 
            //enc = Encoding.UTF8;//윈도우즈 디폴트 설정 

            DialogResult ret = openFileDialog1.ShowDialog(this);
            if (ret == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                FileStream fs = new FileStream(fn, FileMode.Open);
                StreamReader sr = new StreamReader(fs, enc);

                tbMemo.Text += sr.ReadToEnd();
                sr.Close();
                fs.Close();
                //while( !sr.EndOfStream ) { 
                //    string line = sr.ReadLine();
                //    if( line != null ) { 
                //        tbMemo.Text += line; 
                //    }
                //}

            }
        }

        private void menuANSI_Click(object sender, EventArgs e)
        {
            //UTF8->> ANSI
            sbLabel1.Text = "ANSI";
            menuANSI.Checked = true;
            menuUTF8.Checked = false;

            enc = Encoding.Default;

            //Encoding ascii = Encoding.Default;
            Encoding ansi = Encoding.GetEncoding(949);
            Encoding unicode = Encoding.Unicode;

            // Convert the string into a byte array.
            byte[] unicodeBytes = unicode.GetBytes(tbMemo.Text);

            // Perform the conversion from one encoding to the other.
            byte[] ansiBytes = Encoding.Convert(unicode, ansi, unicodeBytes);

            String decodedString = ansi.GetString(ansiBytes);

            // Convert the new byte[] into a char[] and then into a string.
            char[] ansiChars = new char[ansi.GetCharCount(ansiBytes, 0, ansiBytes.Length)];
            ansi.GetChars(ansiBytes, 0, ansiBytes.Length, ansiChars, 0);
            string ansiString = new string(ansiChars);

            // Display the strings created before and after the conversion.
            //Console.WriteLine("Original string: {0}", tbMemo.Text);
            //Console.WriteLine("Ascii converted string: {0}", asciiString);

            //tbMemo.Text = ansiString;
            tbMemo.Text = decodedString;


            //Display the strings created before and after the conversion.
            //Console.WriteLine("Original string: {0}", tbMemo.Text);


            //Console.WriteLine("Ascii converted string: {0}", asciiString);

        }

        private void menuUTF8_Click(object sender, EventArgs e)
        {
            sbLabel1.Text = "UTF-8";
            menuANSI.Checked = false;
            menuUTF8.Checked = true;

            enc = Encoding.UTF8;

        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            DialogResult ret = saveFileDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                FileStream fs = new FileStream(fn, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, enc);
                sw.Write(tbMemo.Text);  
                sw.Close();
                fs.Close();

            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            DialogResult re = about.ShowDialog();   
            if (re == DialogResult.OK) {
                tbMemo.Text = "ok";
                sbLabel2.Text = "About OK";
            } else if(re== DialogResult.Cancel)
            {
                tbMemo.Text = "cancel";
                sbLabel2.Text = "About CANCEL";

            }

        }
    }
}
