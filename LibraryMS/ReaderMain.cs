using LibraryMS.usermain;
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
            global.borrowednum = (int)SqlHelper.ExecuteScalar(sql1);
                       
        
            borrowed.Text = "借阅情况："+global.borrowednum+"本";
            string sql2 = "select numbers from usertype,users where usertype.typename=users.role and users.id='" + global.username + "'";
            global.borrowingnum = (int)SqlHelper.ExecuteScalar(sql2);//当前角色总共可借数量
            global.canborrownum = global.borrowingnum - global.borrowednum;//如今可借
            borrowing.Text = "可借阅次数：" + global.canborrownum;
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
    }
}
