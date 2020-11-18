using Sunny.UI;
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

namespace LibraryMS.usermain
{
    public partial class borrowmsg : Sunny.UI.UIForm
    {
        public borrowmsg()
        {
            InitializeComponent();
        }
        string bookid1;
        private void borrowmsg_Load(object sender, EventArgs e)
        {
            string sql = "select * from borrowmsg where userid='" + global.username + "'";
            SqlHelper.setGDV(sql,borrowmsgGV);
        }

        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            
            bookid.Text = borrowmsgGV[1, borrowmsgGV.CurrentCell.RowIndex].Value.ToString();
            bookname.Text= borrowmsgGV[2, borrowmsgGV.CurrentCell.RowIndex].Value.ToString();
        }
        
        private void uiButton1_Click(object sender, EventArgs e)
        {
            string sql = "delete from borrowmsg where bookid='" + bookid.Text + "'";
            bookid1 = bookid.Text;
           int com= SqlHelper.ExecuteNonQuery(sql);
            if(com>0)
            {
                UIMessageBox.Show("归还成功");
                string s = "可供借阅";
                string sql3 = "update bookcase set state='" + s + "' where id='" + bookid1 + "'";
                SqlHelper.ExecuteNonQuery(sql3);
                string sql1 = "select * from borrowmsg where userid='" + global.username + "'";
                SqlHelper.setGDV(sql1, borrowmsgGV);



            }
            else
            {
                UIMessageBox.Show("归还失败");
            }
        }

        private void borrowmsg_FormClosing(object sender, FormClosingEventArgs e)
        {
            new ReaderMain().Show();
        }
    }
}
 
 