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
            string sql = "select id 图书编号,bookName 图书名称,bookType 图书类型,bookNumber 馆藏数量,author 作者,publishCompany 出版社,publishDate 出版日期,pages 页数,wordsNumber 字数 from book";
            SqlHelper.setGDV(sql, mainGV);
            bookcid.Enabled = bookid.Enabled = bookcname.Enabled = borrow.Enabled = false;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (bookname.Text.Trim()!= "")
            {
                 sql= "select id 图书编号,bookName 图书名称,bookType 图书类型,bookNumber 馆藏数量,author 作者,publishCompany 出版社,publishDate 出版日期,pages 页数,wordsNumber 字数 from book where bookName like '%" + bookname.Text.Trim()+"%'";
            }
            else
            {
                sql = "select id 图书编号,bookName 图书名称,bookType 图书类型,bookNumber 馆藏数量,author 作者,publishCompany 出版社,publishDate 出版日期,pages 页数,wordsNumber 字数 from book";
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
            string sqln = "select count(*) from borrowmsg where userid='" + global.username + "'";
            int num = Convert.ToInt32(SqlHelper.ExecuteScalar(sqln));
            string d = global.nowdate;
            int y = global.days;
            string date = SqlHelper.ReTime(d,y);
            if (global.borrowingnum <= num) 
            {
                UIMessageBox.Show("借阅数量已达上限");
            }
            else
            {
                string sql2 = "select state from bookcase where caseid='" + bookcid.Text + "'";
                string state = (string)SqlHelper.ExecuteScalar(sql2);
                if (state=="可供借阅")
                {
                    string sql = "insert into borrowmsg(caseid,bookid,bookname,userid,username,borrowtime,isbacktime) values('"+bookcid.Text+"','" + bookid.Text.Trim() + "','" + bookcname.Text.Trim() + "','" + global.username + "','" + global.name + "','" + global.nowdate + "','" + date + "')";
                    int n = SqlHelper.ExecuteNonQuery(sql);
                    if (n > 0)
                    {
                        UIMessageBox.Show("借阅成功");
                        string s = date + "应还";
                        string sql3="update bookcase set state='"+s+"' where caseid='"+bookcid.Text+"'";
                        SqlHelper.ExecuteNonQuery(sql3);
                        string sql4 = "select caseid 索书号,id 图书编号,address 馆藏地址,state 借阅状态 from bookcase where caseid='" + bookcid.Text+"'";
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
            string sql = "select caseid 索书号,id 图书编号,address 馆藏地址,state 借阅状态 from bookcase where id='" + id + "'";
            SqlHelper.setGDV(sql,bookcase);
        }

        private void borrowbook_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            new ReaderMain().Show();
        }
    }
}
