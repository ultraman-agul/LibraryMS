using Sunny.UI;
using System;
using System.Data.SqlClient;

namespace LibraryMS.usermain
{
    public partial class borrowbook : Sunny.UI.UIForm
    {
        public borrowbook()
        {
            InitializeComponent();
        }

        private void borrowbook_Load(object sender, EventArgs e)
        {
            string sql = "select * from book";
            SqlHelper.setGDV(sql, mainGV);
            bookcid.Enabled = bookid.Enabled = bookcname.Enabled = borrow.Enabled = false;

        }

        private void search_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (bookname.Text.Trim()!= null)
            {
                 sql="select * from book where bookName like '%"+bookname.Text.Trim()+"%'";
            }
            else
            {
                sql = "select * from book";
            }
            SqlHelper.setGDV(sql, mainGV);
        }

      



        private void bookcsae_SelectIndexChange(object sender, int index)
        {
            borrow.Enabled = true;
            bookcid.Text = bookcase[0, bookcase.CurrentCell.RowIndex].Value.ToString();
            bookid.Text= bookcase[1, bookcase.CurrentCell.RowIndex].Value.ToString();
            bookcname.Text= mainGV[1, mainGV.CurrentCell.RowIndex].Value.ToString();

        }

        private void borrow_Click(object sender, EventArgs e)
        {
            if (global.canborrownum <= 0)
            {
                UIMessageBox.Show("借阅数量已达上限");

            }
            else
            {
                string sql2 = "select state from bookcase where caseid='" + bookcid.Text + "'";
                string state = (string)SqlHelper.ExecuteScalar(sql2);


                if (state=="可供借阅")
                {
                    string sql = "insert into borrowmsg(bookid,bookname,userid,username,borrowtime,isbacktime) values('" + bookid.Text.Trim() + "','" + bookcname.Text.Trim() + "','" + global.username + "','" + global.name + "','" + global.nowdate + "','" + global.nowdate + "')";
                    int n = SqlHelper.ExecuteNonQuery(sql);
                    if (n > 0)
                    {
                        UIMessageBox.Show("借阅成功");
                        string sql3="update bookcase set state='"+global.nowdate+"' where caseid='"+bookcid.Text+"'";
                        SqlHelper.ExecuteNonQuery(sql3);
                        string sql4 = "select * from bookcase";
                        SqlHelper.setGDV(sql4, bookcase);

                    }
                    else
                    {
                        UIMessageBox.Show("借阅失败");
                    }
                }
                else {
                   UIMessageBox.Show("该图书已被借阅");

                } 
            }
        }

        private void mainGV_SelectIndexChange(object sender, int index)
        {
            string id= mainGV[0, mainGV.CurrentCell.RowIndex].Value.ToString();
            string sql = "select * from bookcase where id='" + id + "'";
            SqlHelper.setGDV(sql,bookcase);
        }

        private void borrowbook_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            new ReaderMain().Show();
        }
    }
}
