using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace terminal
{
    public partial class frmTerminal : Form
    {
        public frmTerminal()
        {
            InitializeComponent();
        }

        // c/c++ 함수 포인터  
        delegate void AddTextCB(string str);//addText 를 대리하는  콜백함수 

        //serialPort1_DataReceived에 사용되는 
        void AddText(string s) {

            if (tbTerm.InvokeRequired)
            {
                AddTextCB cb = new AddTextCB(AddText);
                object[] arg = new object[] { s };// arg는 argument list  
                Invoke(cb, arg); //재호출이 된다 
                //재호출 되는 시점에서 tbTerm.InvokeRequired = false가 되고, 
                //else 로 넘어간다 
            }
            else {
                tbTerm.Text += s;
            }

        }

        string StrComm =""; 
        
        void OpenPort() {
            serialPort1.Open();
            sbLabel1.Text = StrComm;
            sbLabel1.BackColor = Color.Green;
            AddText(StrComm); 
        }


        private void menuConfig_Click(object sender, EventArgs e)
        {
            frmConfig dlg = new frmConfig(2,0,0,0,1);//초기값 전달 
            if (dlg.ShowDialog() == DialogResult.OK) {
                serialPort1.PortName = dlg.cmbPort.Text;
                serialPort1.BaudRate = int.Parse(dlg.cmbBaud.Text);

                //parity는 프로그램에 저장된 enum 타입이다
                //그래서 System.IO.Ports.Parity형으로 전환 필요 
                serialPort1.Parity = (System.IO.Ports.Parity)dlg.cmbParity.SelectedIndex;
                serialPort1.DataBits = int.Parse(dlg.cmbData.Text);
                serialPort1.StopBits = (System.IO.Ports.StopBits)dlg.cmbStop.SelectedIndex;
                //오픈 포트 명령 문자열 
                StrComm = $"{serialPort1.PortName}:{serialPort1.BaudRate}{dlg.cmbParity.Text[0]}{serialPort1.DataBits}{dlg.cmbData.Text}";
                OpenPort();
            }
           
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //read 
            string str = serialPort1.ReadExisting();
            AddText(str);

            //write


        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            string sendCmd = "3";
            serialPort1.Write(sendCmd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sendCmd = "1";
            serialPort1.Write(sendCmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sendCmd = "2";
            serialPort1.Write(sendCmd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sendCmd = "3";
            serialPort1.Write(sendCmd);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sendCmd = "4";
            serialPort1.Write(sendCmd);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sendCmd = "5";
            serialPort1.Write(sendCmd);
        }
    }
}
