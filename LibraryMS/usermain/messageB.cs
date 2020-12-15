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
        public int index = 10;
        public int rowcount;
        private void messageB_Load(object sender, EventArgs e)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from messageB");
            rowcount = dt.Rows.Count;
            int temp = index - 10;
            string sql = "select top 10 * from messageB where id not in (select top "+temp+" id from messageB)";
            SqlHelper.setGDV(sql, uiDataGridView1);
        }
        //上一行
        private void uiButton1_Click(object sender, EventArgs e)
        {
            index -= 10;
            if(index >= 10)
            {
                int temp = index - 10;
                string sql = "select top 10 * from messageB where id not in (select top " + temp + " id from messageB)";
                SqlHelper.setGDV(sql, uiDataGridView1);
            }
            else
            {
                UIMessageBox.Show("已经是第一页");
                index += 10;
            }

        }

        // 下一页
        private void uiButton2_Click(object sender, EventArgs e)
        {
            index += 10;
            if (index > 10 && index < rowcount+10)
            {
                int temp = index - 10;
                string sql = "select top 10 * from messageB where id not in (select top " + temp + " id from messageB)";
                SqlHelper.setGDV(sql, uiDataGridView1);
            }
            else if(index > rowcount)
            {
                UIMessageBox.Show("已经是最后一页");
                index -= 10;
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
                string sql = "insert into messageB(userid,date,message) values('" + global.username + "','" + DateTime.Now.ToString().Substring(0,10) +"','"+textBox1.Text.Trim()+"')";
                if (SqlHelper.ExecuteNonQuery(sql) > 0)
                {
                    UIMessageBox.Show("发布成功！");
                }
                else
                {
                    UIMessageBox.Show("发布失败！");
                }
        }
        }

        // 我的留言
        private void uiButton4_Click(object sender, EventArgs e)
        {
            string sql = "select * from messageB where userid='"+global.username+"'";
            SqlHelper.setGDV(sql, uiDataGridView1);
        }
    }
}
