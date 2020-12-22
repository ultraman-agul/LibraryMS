using LibraryMS.usermain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class ReaderMain : Sunny.UI.UIForm
    {
        public ReaderMain()
        {
            InitializeComponent();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Login().Show();
        }

        private void ReaderMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ReaderMain_Load(object sender, EventArgs e)
        {
            string sql="select name from users where id='"+global.username+"'";

             SqlDataReader data = SqlHelper.ExecuteReader(sql);
            if (data.Read())
            {
                global.name=name.Text = data["name"].ToString();
            }
            string sql1 = "select count(*) from borrowmsg where userid= '" + global.username + "'";
            global.borrowednum =Convert.ToInt32(SqlHelper.ExecuteScalar(sql1));          
        
            borrowed.Text = "借阅情况："+global.borrowednum+"本";
            string sql2 = "select numbers from usertype,users where usertype.typename=users.role and users.id='" + global.username + "'";
            string sql3 = "select days from usertype,users where usertype.typename=users.role and users.id='" + global.username + "'";
            global.borrowingnum = Convert.ToInt32(SqlHelper.ExecuteScalar(sql2));//当前角色总共可借数量
            global.days= Convert.ToInt32(SqlHelper.ExecuteScalar(sql3));
            global.canborrownum = global.borrowingnum - global.borrowednum;//如今可借
            borrowing.Text = "可借数量：" + global.canborrownum;

            //判断是该归还座位
            string now = DateTime.Now.ToString("yyyy-MM-dd");

            string sqlid = "select seatid from reseat where isbacktime < " + "'"+now+"'";
            string sqlloc = "select location from reseat where isbacktime < " + "'" + now + "'";
            ArrayList arr = SqlHelper.DataReader(sqlid, "seatid");
            ArrayList arr1 = SqlHelper.DataReader(sqlloc, "location");

            string sql4 = "delete from reseat where isbacktime<'" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
            SqlHelper.ExecuteNonQuery(sql4);

            string sql5;
            for(int i = 0; i < arr.Count; i++)
            {
                sql5 = "update seat set state=0 where seatno ='" + arr[i].ToString() +"' and location = '" + arr1[i].ToString() +"'";
                SqlHelper.ExecuteNonQuery(sql5);
            }
        }

        private void uiImageButton3_Click(object sender, EventArgs e)
        {
            new borrowmsg().Show();
            this.Hide();
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            new usermsg().Show();
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new borrowbook().Show();
            
        }

        private void uiImageButton4_Click(object sender, EventArgs e)
        {
            new recommand().ShowDialog();
        }

        private void uiImageButton5_Click(object sender, EventArgs e)
        {
            new seat().Show();
        }

        private void uiImageButton6_Click(object sender, EventArgs e)
        {
            new messageB().Show();
        }
    }
}
