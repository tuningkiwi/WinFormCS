using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class formDBmanager : Form
    {
        public formDBmanager()
        {
            InitializeComponent();
        }

        string GetFileName(string sPath)
        {
            string[] sa = sPath.Split('\\');
            return sa[sa.Length - 1];   
        }


        string sConn;
        SqlConnection sqlConnect = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();   
        private void menuOpen_Click(object sender, EventArgs e)
        {
            //DB SELECT
            openFileDialog1.Filter = "MS-SQL Database file|*.mdf";
            if (DialogResult.OK == openFileDialog1.ShowDialog()) {
                //string sconn = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\EMBEDDED\\source\\repos\\winapp\\WinFormCS\\WindowsFormsApp2\\myDB.mdf;Integrated Security=True;Connect Timeout=30";
                //string sconn = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EMBEDDED\source\repos\winapp\WinFormCS\WindowsFormsApp2\myDB.mdf;Integrated Security=True;Connect Timeout=30";
                //경로 저장
                sConn = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={openFileDialog1.FileName};Integrated Security=True;Connect Timeout=30";
                sqlConnect.ConnectionString = sConn;
                
                sqlConnect.Open();
                sqlCommand.Connection = sqlConnect;
                sbLabel1.Text = GetFileName(openFileDialog1.FileName);
                sbLabel1.BackColor = Color.DarkOliveGreen;
            }


        }

        public string[] RunSql(string sql)
        {
            sqlCommand.CommandText = sql;
            if (sql.Trim().ToLower().Substring(0, 6) == "select")
            {
                SqlDataReader sr = sqlCommand.ExecuteReader();

                //열의 갯수만큼 반복함 
                for (int i = 0; i < sr.FieldCount; i++)
                {
                    string colName = sr.GetName(i);

                    //추가되는 컬럼의 프로그래밍상 접근 이름, 표시되는 이름 
                    //데이터뷰에 컬럼 생성
                    dataView.Columns.Add(colName, colName);
                }
            }

            //sr에는 sql 커맨드로 보여지는 데이터들이 저장되어 있음
            SqlDataReader sr = sqlCommand.ExecuteReader();

            //열의 갯수만큼 반복함 
            for (int i = 0; i < sr.FieldCount; i++)
            {
                string colName = sr.GetName(i);

                //추가되는 컬럼의 프로그래밍상 접근 이름, 표시되는 이름 
                //데이터뷰에 컬럼 생성
                dataView.Columns.Add(colName, colName);
            }

            for (; sr.Read();)
            { //한줄씩 읽어서 처리를 해라 
                string str = "";
                int nRow = dataView.Rows.Add(); //row1개 추가, row가 몇개 생성됐는지 return     
                for (int i = 0; i < sr.FieldCount; i++)
                {
                    //sr로부터 i번째 col 의 값을 가져오고 
                    object obj = sr.GetValue(i);

                    //dataview 어디에 저장할지 설정
                    dataView.Rows[nRow].Cells[i].Value = obj;

                    //첫번째 열의 경우 
                    if (i == 0)
                    {
                        str += $"{obj}";
                    }
                    else
                    {//2번째 이상 컬럼의 경우 
                        str += $",{obj}";
                    }


                }

            }
        }


        private void SQLaction_Click(object sender, EventArgs e)
        {
            string sql = "Select * from person";
            sqlCommand.CommandText = sql;

            //sr에는 sql 커맨드로 보여지는 데이터들이 저장되어 있음
            SqlDataReader sr = sqlCommand.ExecuteReader();

            //열의 갯수만큼 반복함 
            for(int i =0; i <sr.FieldCount; i++) {
                string colName = sr.GetName(i);

                //추가되는 컬럼의 프로그래밍상 접근 이름, 표시되는 이름 
                //데이터뷰에 컬럼 생성
                dataView.Columns.Add(colName, colName);
            }

            for(;sr.Read(); ) { //한줄씩 읽어서 처리를 해라 
                string str = "";
                 int nRow = dataView.Rows.Add(); //row1개 추가, row가 몇개 생성됐는지 return     
                for(int i = 0; i  < sr.FieldCount; i++) {
                    //sr로부터 i번째 col 의 값을 가져오고 
                    object obj = sr.GetValue(i);

                    //dataview 어디에 저장할지 설정
                    dataView.Rows[nRow].Cells[i].Value = obj;   

                    //첫번째 열의 경우 
                    if (i == 0)
                    {
                        str += $"{obj}";
                    }
                    else {//2번째 이상 컬럼의 경우 
                        str += $",{obj}";
                    }

                    
                }
                tbSQL.Text += str +"\r\n";   
            }
        }
    }
}
