using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS.usermain
{
    public partial class messageB : Sunny.UI.UIForm
    {
        public messageB()
        {
            InitializeComponent();
        }
        int index = 0;
       public static string sql = "select * from messageB";
        DataTable dt = SqlHelper.ExecuteDataTable(sql);
        private void messageB_Load(object sender, EventArgs e)
        {
            if (dt.Rows.Count <= 0)
            {
                uiLabel1.Text = "";
                uiLabel2.Text = "";
                uiLabel3.Text = "";
                uiLabel4.Text = "";
                uiLabel5.Text = "";
                uiLabel6.Text = "";
                uiLabel7.Text = "";
                uiLabel8.Text = "";
                uiLabel9.Text = "";
            }
            else if(dt.Rows.Count==1)
            {
                uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                uiLabel2.Text = dt.Rows[index]["date"].ToString();
                uiLabel3.Text = dt.Rows[index]["message"].ToString();
                uiLabel4.Text = "";
                uiLabel5.Text = "";
                uiLabel6.Text = "";
                uiLabel7.Text = "";
                uiLabel8.Text = "";
                uiLabel9.Text = "";

            }
            else if (dt.Rows.Count == 2)
            {
                uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                uiLabel2.Text = dt.Rows[index]["date"].ToString();
                uiLabel3.Text = dt.Rows[index]["message"].ToString();
                uiLabel4.Text = dt.Rows[index + 1]["userid"].ToString();
                uiLabel5.Text = dt.Rows[index + 1]["date"].ToString();
                uiLabel6.Text = dt.Rows[index + 1]["message"].ToString();
                uiLabel7.Text = "";
                uiLabel8.Text = "";
                uiLabel9.Text = "";
            }
            
            else
            {


                uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                uiLabel2.Text = dt.Rows[index]["date"].ToString();
                uiLabel3.Text = dt.Rows[index]["message"].ToString();
                uiLabel4.Text = dt.Rows[index + 1]["userid"].ToString();
                uiLabel5.Text = dt.Rows[index + 1]["date"].ToString();
                uiLabel6.Text = dt.Rows[index + 1]["message"].ToString();
                uiLabel7.Text = dt.Rows[index + 2]["userid"].ToString();
                uiLabel8.Text = dt.Rows[index + 2]["date"].ToString();
                uiLabel9.Text = dt.Rows[index + 2]["message"].ToString();
            }
        }
        private void uiButton1_Click(object sender, EventArgs e)
        {
            index -= 3;
            if (index < 0)
            {
                UIMessageBox.Show("没有数据！");
                index += 3;
            }
            if (index == 0 && dt.Rows.Count >= 3)
            {
                uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                uiLabel2.Text = dt.Rows[index]["date"].ToString();
                uiLabel3.Text = dt.Rows[index]["message"].ToString();
                uiLabel4.Text = dt.Rows[index + 1]["userid"].ToString();
                uiLabel5.Text = dt.Rows[index + 1]["date"].ToString();
                uiLabel6.Text = dt.Rows[index + 1]["message"].ToString();
                uiLabel7.Text = dt.Rows[index + 2]["userid"].ToString();
                uiLabel8.Text = dt.Rows[index + 2]["date"].ToString();
                uiLabel9.Text = dt.Rows[index + 2]["message"].ToString();
            }
          else if (index % dt.Rows.Count < 0 || dt.Rows.Count % index <0 || index >= dt.Rows.Count)
            {
                uiLabel1.Text = "";
                uiLabel2.Text = "";
                uiLabel3.Text = "";
                uiLabel4.Text = "";
                uiLabel5.Text = "";
                uiLabel6.Text = "";
                uiLabel7.Text = "";
                uiLabel8.Text = "";
                uiLabel9.Text = "";
            }
            else if (index % dt.Rows.Count == 1)
            {
                uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                uiLabel2.Text = dt.Rows[index]["date"].ToString();
                uiLabel3.Text = dt.Rows[index]["message"].ToString();
                uiLabel4.Text = "";
                uiLabel5.Text = "";
                uiLabel6.Text = "";
                uiLabel7.Text = "";
                uiLabel8.Text = "";
                uiLabel9.Text = "";

            }
            else if (index % dt.Rows.Count == 2)
            {
                uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                uiLabel2.Text = dt.Rows[index]["date"].ToString();
                uiLabel3.Text = dt.Rows[index]["message"].ToString();
                uiLabel4.Text = dt.Rows[index + 1]["userid"].ToString();
                uiLabel5.Text = dt.Rows[index + 1]["date"].ToString();
                uiLabel6.Text = dt.Rows[index + 1]["message"].ToString();
                uiLabel7.Text = "";
                uiLabel8.Text = "";
                uiLabel9.Text = "";
            }

            else
            {


                uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                uiLabel2.Text = dt.Rows[index]["date"].ToString();
                uiLabel3.Text = dt.Rows[index]["message"].ToString();
                uiLabel4.Text = dt.Rows[index + 1]["userid"].ToString();
                uiLabel5.Text = dt.Rows[index + 1]["date"].ToString();
                uiLabel6.Text = dt.Rows[index + 1]["message"].ToString();
                uiLabel7.Text = dt.Rows[index + 2]["userid"].ToString();
                uiLabel8.Text = dt.Rows[index + 2]["date"].ToString();
                uiLabel9.Text = dt.Rows[index + 2]["message"].ToString();
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            index += 3;
            if (dt.Rows.Count > index)
            {


                if (index == 0 && dt.Rows.Count >= 3)
                {
                    uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                    uiLabel2.Text = dt.Rows[index]["date"].ToString();
                    uiLabel3.Text = dt.Rows[index]["message"].ToString();
                    uiLabel4.Text = dt.Rows[index + 1]["userid"].ToString();
                    uiLabel5.Text = dt.Rows[index + 1]["date"].ToString();
                    uiLabel6.Text = dt.Rows[index + 1]["message"].ToString();
                    uiLabel7.Text = dt.Rows[index + 2]["userid"].ToString();
                    uiLabel8.Text = dt.Rows[index + 2]["date"].ToString();
                    uiLabel9.Text = dt.Rows[index + 2]["message"].ToString();
                }
                else if (index % dt.Rows.Count < 0 || dt.Rows.Count % index < 0 || index >= dt.Rows.Count)
                {
                    uiLabel1.Text = "";
                    uiLabel2.Text = "";
                    uiLabel3.Text = "";
                    uiLabel4.Text = "";
                    uiLabel5.Text = "";
                    uiLabel6.Text = "";
                    uiLabel7.Text = "";
                    uiLabel8.Text = "";
                    uiLabel9.Text = "";
                }
                else if (index % dt.Rows.Count == 1)
                {
                    uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                    uiLabel2.Text = dt.Rows[index]["date"].ToString();
                    uiLabel3.Text = dt.Rows[index]["message"].ToString();
                    uiLabel4.Text = "";
                    uiLabel5.Text = "";
                    uiLabel6.Text = "";
                    uiLabel7.Text = "";
                    uiLabel8.Text = "";
                    uiLabel9.Text = "";

                }
                else if (index % dt.Rows.Count == 2)
                {
                    uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                    uiLabel2.Text = dt.Rows[index]["date"].ToString();
                    uiLabel3.Text = dt.Rows[index]["message"].ToString();
                    uiLabel4.Text = dt.Rows[index + 1]["userid"].ToString();
                    uiLabel5.Text = dt.Rows[index + 1]["date"].ToString();
                    uiLabel6.Text = dt.Rows[index + 1]["message"].ToString();
                    uiLabel7.Text = "";
                    uiLabel8.Text = "";
                    uiLabel9.Text = "";
                }

                else
                {


                    uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                    uiLabel2.Text = dt.Rows[index]["date"].ToString();
                    uiLabel3.Text = dt.Rows[index]["message"].ToString();
                    uiLabel4.Text = dt.Rows[index + 1]["userid"].ToString();
                    uiLabel5.Text = dt.Rows[index + 1]["date"].ToString();
                    uiLabel6.Text = dt.Rows[index + 1]["message"].ToString();
                    uiLabel7.Text = dt.Rows[index + 2]["userid"].ToString();
                    uiLabel8.Text = dt.Rows[index + 2]["date"].ToString();
                    uiLabel9.Text = dt.Rows[index + 2]["message"].ToString();
                }
            }
            else
            {
                index -= 3;
                UIMessageBox.Show("没有数据!");
            }

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                UIMessageBox.Show("留言不能为空！");

            }
            else
            {
                string sql="insert into messageB(userid,date,message) values('"+global.username+"','"+DateTime.Now.ToString()+"','"+textBox1.Text.Trim()+"')";
                if (SqlHelper.ExecuteNonQuery(sql) > 0)
                {
                    UIMessageBox.Show("发布成功！");
                }
                else
                {
                    UIMessageBox.Show("发布失败！");
                }
                        string sql1 = "select * from messageB";
        DataTable dt = SqlHelper.ExecuteDataTable(sql1);
    }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            int index = 0;
              string sql = "select * from messageB where userid='"+global.username+"'";
              DataTable dt = SqlHelper.ExecuteDataTable(sql);
            if (dt.Rows.Count <= 0)
            {
                uiLabel1.Text = "";
                uiLabel2.Text = "";
                uiLabel3.Text = "";
                uiLabel4.Text = "";
                uiLabel5.Text = "";
                uiLabel6.Text = "";
                uiLabel7.Text = "";
                uiLabel8.Text = "";
                uiLabel9.Text = "";
            }
            else if (dt.Rows.Count == 1)
            {
                uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                uiLabel2.Text = dt.Rows[index]["date"].ToString();
                uiLabel3.Text = dt.Rows[index]["message"].ToString();
                uiLabel4.Text = "";
                uiLabel5.Text = "";
                uiLabel6.Text = "";
                uiLabel7.Text = "";
                uiLabel8.Text = "";
                uiLabel9.Text = "";

            }
            else if (dt.Rows.Count == 2)
            {
                uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                uiLabel2.Text = dt.Rows[index]["date"].ToString();
                uiLabel3.Text = dt.Rows[index]["message"].ToString();
                uiLabel4.Text = dt.Rows[index + 1]["userid"].ToString();
                uiLabel5.Text = dt.Rows[index + 1]["date"].ToString();
                uiLabel6.Text = dt.Rows[index + 1]["message"].ToString();
                uiLabel7.Text = "";
                uiLabel8.Text = "";
                uiLabel9.Text = "";
            }

            else
            {


                uiLabel1.Text = dt.Rows[index]["userid"].ToString();
                uiLabel2.Text = dt.Rows[index]["date"].ToString();
                uiLabel3.Text = dt.Rows[index]["message"].ToString();
                uiLabel4.Text = dt.Rows[index + 1]["userid"].ToString();
                uiLabel5.Text = dt.Rows[index + 1]["date"].ToString();
                uiLabel6.Text = dt.Rows[index + 1]["message"].ToString();
                uiLabel7.Text = dt.Rows[index + 2]["userid"].ToString();
                uiLabel8.Text = dt.Rows[index + 2]["date"].ToString();
                uiLabel9.Text = dt.Rows[index + 2]["message"].ToString();
            }
        }
    }
}
