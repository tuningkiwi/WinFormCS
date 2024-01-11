using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
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

        ArrayList ColName = new ArrayList();
        List<object[]> RunSql(string sql)
        {
            //List<object[]> result = new List<object[]> { };
            List<object[]> result = new List<object[]>();

            sqlCommand.CommandText = sql;

                if (sql.Trim().ToLower().Substring(0, 6) == "select")
                {
                    SqlDataReader sr = sqlCommand.ExecuteReader();
                    //열의 갯수만큼 반복함 
                    ColName.Clear();//이전 sql처리문에 의한 컬럼 정보 삭제 
                    for (int i = 0; i < sr.FieldCount; i++)
                    {
                        ColName.Add(sr.GetName(i));
                        //추가되는 컬럼의 프로그래밍상 접근 이름, 표시되는 이름
                        //데이터뷰에 컬럼 생성
                        //dataView.Columns.Add(colName, colName);
                    }


                    while (sr.Read())
                    { //한줄씩 읽어서 처리를 해라 
                        object[] oarr = new object[sr.FieldCount];
                        sr.GetValues(oarr);
                        result.Add(oarr);

                        //string str = "";
                        //int nRow = dataView.Rows.Add(); //row1개 추가, row가 몇개 생성됐는지 return     
                        //for (int i = 0; i < sr.FieldCount; i++)
                        //{
                        //    //sr로부터 i번째 col 의 값을 가져오고 
                        //    object obj = sr.GetValue(i);
                        //    //if (i == 0) str = $"{obj}";
                        //    if (i == 0) str = obj.ToString();
                        //    else
                        //    {
                        //        str = ","+ obj.ToString();
                        //    }

                        //    //dataview 어디에 저장할지 설정
                        //    dataView.Rows[nRow].Cells[i].Value = obj;
                        //}
                    }
                    sr.Close();

                }
                else
                {//insert update delete 
                    int n = sqlCommand.ExecuteNonQuery();
                }

            sbLabel3.Text = "Excute OK";
            return result;
        }


        private void menuRun_Click(object sender, EventArgs e)
        {
            //string sql = "Select * from person";

            string sql = tbSQL.SelectedText;
            if (sql == "") sql = tbSQL.Text;

            try {
                List<object[]> result = RunSql(sql);
                if (result == null) return;

                dataView.Rows.Clear();
                dataView.Columns.Clear();


                for (int i = 0; i < ColName.Count; i++)
                {
                    string colName = ColName[i].ToString();

                    //추가되는 컬럼의 프로그래밍상 접근 이름, 표시되는 이름 
                    //데이터뷰에 컬럼 생성
                    dataView.Columns.Add(colName, colName);
                }
            

                for (int i = 0; i  < result.Count; i++) {
                    //sr로부터 i번째 col 의 값을 가져오고 
                    int nRow = dataView.Rows.Add();
                    object[] row = result[i];
                    for (int j = 0; j < row.Count(); j++) {
                        //dataview 어디에 저장할지 설정
                        dataView.Rows[nRow].Cells[j].Value = row[j];
                    }
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbSQL.Text += "\r\n"+ex.Message;

                sbLabel3.AutoSize = true;
                sbLabel3.Text = ex.Message;
                return;
            }

        }

        private void menuFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) {
                
                tbSQL.Font = fontDialog1.Font;
                sbLabel2.Text = tbSQL.Font.Name;

            }    
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string str = tbSQL.Text;
                string fn = saveFileDialog1.FileName;
                FileStream fs = new FileStream(fn, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write(str);
                sw.Close();
                fs.Close();
            }
        }
    }
}
