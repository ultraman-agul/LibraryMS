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
using Sunny.UI;

namespace LibraryMS
{
    public partial class ManagerMain : Sunny.UI.UIForm
    {
        #region 加载
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Visible = false;
        }
        
        private void ManagerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManagerMain_Load(object sender, EventArgs e)
        {
            uiRadioButton1.Checked = true; // 默认性别单选按钮
            uiLabel1.Text += global.username;
            // 填充gridview1
            string sql = "select id 编号, name 姓名, sex 性别, email 邮箱, role 角色 from users";
            SqlHelper.setGDV(sql, uiDataGridView1);
            // 图书分类填充到cbb中
            SqlHelper.setCBB("select TypeName as good from bookType", "good", booktypecbb);
            SqlHelper.setCBB("select typename from usertype", "typename", cbb);
            SqlHelper.setCBB("select TypeName as good from bookType", "good", booktype);
            SqlHelper.setCBB("select typeName as good from usertype", "good", role);
            SqlHelper.setCBB("select distinct location from seat", "location", loc);
            

        }
        #endregion

        #region 填充Gradview
        private void uiTabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabindex = uiTabControl3.SelectedIndex;
            switch(tabindex)
            {
                case 0:
                    string sql = "select id 编号, name 姓名, sex 性别, email 邮箱, role 角色 from users";
                    SqlHelper.setGDV(sql, uiDataGridView1);
                    break;
                case 1:
                    uiRadioButton1.Checked = true;
                    cbb.SelectedIndex = cbb.Items.IndexOf("学生");
                    break;
                case 2:
                    uiRadioButton4.Checked = true;
                    role.SelectedIndex = role.Items.IndexOf("学生");
                    string sql1 = "select id 编号, name 姓名, sex 性别, email 邮箱, role 角色 from users";
                    SqlHelper.setGDV(sql1, uiDataGridView2);
                    break;
                case 3:
                    string sql2 = "select id 编号, typename 姓名, days 可借天数, numbers 数量 from usertype";
                    SqlHelper.setGDV(sql2, uiDataGridView6);
                    break;

            }
        }
        private void uiTabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            int tabindex = uiTabControl1.SelectedIndex;
            switch (tabindex)
            {

                case 0:
                    string sql1 = "select id 编号, bookName 书名, author 作者,bookNumber 数量, publishCompany 出版社, publishDate 出版时间, bookType 类型, pages 页数, wordsNumber 字数 from book";
                    SqlHelper.setGDV(sql1, uiDataGridView4);
                    break;
                case 2:
                    string sql2 = "select id 编号, bookName 书名, author 作者,bookNumber 数量, publishCompany 出版社, publishDate 出版时间, bookType 类型, pages 页数, wordsNumber 字数 from book";
                    SqlHelper.setGDV(sql2, tushucaozuoDV);
                    break;
                case 3:
                    string sql3 = "select  booktype 类型编号,  typename 类型名字 from booktype";
                    SqlHelper.setGDV(sql3, uiDataGridView5);
                    break;
                case 4:
                    string sql4 = "select caseid 编号, id 书架编号, address 藏书地址,state 借阅状态 from bookcase";
                    SqlHelper.setGDV(sql4, uiDataGridView7);
                    break;


            }
        }
        private void uiTabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabindex = uiTabControl1.SelectedIndex;
            switch (tabindex)
            {

                case 0:
                    string sql1 = "select id 编号, bookName 书名, author 作者,bookNumber 数量, publishCompany 出版社, publishDate 出版时间, bookType 类型, pages 页数, wordsNumber 字数 from book";
                    SqlHelper.setGDV(sql1, uiDataGridView4);
                    break;
                case 2:
                    string sql2 = "select id 编号, bookName 书名, author 作者,bookNumber 数量, publishCompany 出版社, publishDate 出版时间, bookType 类型, pages 页数, wordsNumber 字数 from book";
                    SqlHelper.setGDV(sql2, tushucaozuoDV);
                    break;
                case 3:
                    string sql3 = "select  booktype 类型编号,  typename 类型名字 from booktype";
                    SqlHelper.setGDV(sql3, uiDataGridView5);
                    break;
                case 4:
                    string sql4 = "select caseid 编号, id 书架编号, address 藏书地址,state 借阅状态 from bookcase";
                    SqlHelper.setGDV(sql4, uiDataGridView7);
                    break;


            }
        } 

        #endregion

        #region 用户管理
        // 添加用户
        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            string beChecked = uiRadioButton1.Checked ? uiRadioButton1.Text : uiRadioButton2.Text;
            if (name.Text != null && pwd.Text != null && beChecked != null && email.Text != null && cbb.SelectedText.ToString() != null)
            {
                string newpwd = SqlHelper.MD5Hash(pwd.Text);
                string sql = "insert into users (name, pwd, sex, email, role) values ('" + name.Text + "','" + newpwd + "','" + beChecked + "','" + email.Text + "','" + cbb.SelectedValue + "')";
                SqlHelper.ExecuteNonQuery(sql);
                UIMessageBox.Show("注册成功！");
            }
            else
            {
                UIMessageBox.Show("请填写完整信息！");
            }
            name.Text = "";
            pwd.Text = "";
            email.Text = "";
        }

        // 查找
        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            string sql = "select id 编号, name 姓名, sex 性别, email 邮箱, role 角色 from users where id = '" + stunumber.Text.Trim() + "'";
            SqlHelper.setGDV(sql, uiDataGridView2);
        }
        
        // 修改
        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            string beChecked = uiRadioButton4.Checked ? uiRadioButton4.Text : uiRadioButton3.Text;
            string sql = "update users set name = '" + uiTextBox3.Text + "', sex = '" + beChecked + "',email = '" + uiTextBox1.Text + "', role = '" + role.Text + "' where id = '" + stunumber.Text + "'";
            SqlHelper.ExecuteNonQuery(sql);
            UIMessageBox.ShowSuccess("修改成功");
            SqlHelper.setGDV("select id 编号, name 姓名, sex 性别, email 邮箱, role 角色 from users", uiDataGridView2);
        }

        // 选择当前行的数据


        // 删除用户
        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            SqlHelper.ExecuteNonQuery("delete from users where id = '" + uiDataGridView2[0, uiDataGridView2.CurrentCell.RowIndex].Value.ToString() +"'");
            UIMessageBox.ShowSuccess("删除成功！");
            SqlHelper.setGDV("select id 编号, name 姓名, sex 性别, email 邮箱, role 角色 from users", uiDataGridView2);
        }
        #endregion

        #region 图书分类管理
        // 分类 --添加
        private void uiSymbolButton10_Click(object sender, EventArgs e)
        {
            if(typetext.Text.Trim()!= null)
            {
                string sql = "insert into bookType (typeName) values ('" + typetext.Text.Trim() + "')";
                SqlHelper.ExecuteNonQuery(sql);
                UIMessageBox.ShowSuccess("添加分类成功");
                SqlHelper.setGDV("select bookType 编号, typeName 分类名称 from bookType", uiDataGridView5);
            }
            
        }

        private void uiTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabindex = uiTabControl1.SelectedIndex;
            switch (tabindex)
            {
                case 0:
                    string sql1 = "select id 编号, bookName 书名, author 作者,bookNumber 数量, publishCompany 出版社, publishDate 出版时间, bookType 类型, pages 页数, wordsNumber 字数 from book";
                    SqlHelper.setGDV(sql1, uiDataGridView4);
                    break;
                case 1:
                    booktypecbb.SelectedIndex = 1;
                    break;
                case 2:
                    string sql3 = "select id 编号, bookName 书名, author 作者,bookNumber 数量, publishCompany 出版社, publishDate 出版时间, bookType 类型, pages 页数, wordsNumber 字数 from book";
                    SqlHelper.setGDV(sql3, tushucaozuoDV);
                    string sql4 = "select typeName as TYPE from bookType";
                    SqlHelper.setCBB(sql4, "TYPE",booktype);
                    break;
                case 3:
                    string sql2 = "select bookType 编号, typeName 分类名称 from bookType";
                    SqlHelper.setGDV(sql2, uiDataGridView5);
                    break;
                case 4:
                    string sql3y = "select caseid 书架编号, id 图书编号,address 藏书地址,state 借阅状态 from bookcase";
                    SqlHelper.setGDV(sql3y, uiDataGridView7);
                    break;

            }
        }

        // 修改图书分类
        private void uiSymbolButton9_Click(object sender, EventArgs e)
        {
            string typeid = uiDataGridView5[0, uiDataGridView5.CurrentCell.RowIndex].Value.ToString();
            string sql = "update bookType set typeName = '" + typetext.Text + "' where bookType = '" + typeid + "'";
            SqlHelper.ExecuteNonQuery(sql);
            UIMessageBox.ShowSuccess("修改成功");
            SqlHelper.setGDV("select bookType 编号, typeName 分类名称 from bookType", uiDataGridView5);
        }


        private void deletebtn_Click(object sender, EventArgs e)
        {
            SqlHelper.ExecuteNonQuery("delete from bookType where bookType = '" + uiDataGridView5[0, uiDataGridView5.CurrentCell.RowIndex].Value.ToString() + "'");
            UIMessageBox.ShowSuccess("删除成功！");
            SqlHelper.setGDV("select bookType 编号, typeName 分类名称 from bookType", uiDataGridView5);
        }
        #endregion

        #region 添加图书/图书操作
        //添加
        private void uiSymbolButton7_Click(object sender, EventArgs e)
        {
            string sql = "insert into book(bookName,author,bookNumber,publishCompany,publishDate,bookType,pages,wordsNumber) values('" + bnameTB.Text.Trim() +"','"+ authorTB.Text.Trim() +"','"+ bookNumTB.Text.Trim() +"','"+ publishCTB.Text.Trim() +"','" + uiDatePicker1.Text.Trim() + "','"+ booktypecbb.SelectedValue + "','" + pages.Text +"','"+ words.Text +"')";
            if(SqlHelper.ExecuteNonQuery(sql) > 0)
            {
                UIMessageBox.ShowSuccess("添加成功！");
            }
            bnameTB.Text = "";
            authorTB.Text = "";
            bookNumTB.Text = "";
            publishCTB.Text = "";
            pages.Text = "";
            words.Text = "";
        }

        


        //选择填充数据到图书信息总览和用户总览
        private void uiTabControlMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabmenuindex = uiTabControlMenu1.SelectedIndex;
            switch(tabmenuindex)
            {
                case 0:
                    // 填充gridview1
                    string sql = "select id 编号, name 姓名, sex 性别, email 邮箱, role 角色 from users";
                    SqlHelper.setGDV(sql, uiDataGridView1);
                    break;
                case 1:
                    string sql1 = "select id 编号, bookName 书名, author 作者,bookNumber 数量, publishCompany 出版社, publishDate 出版时间, bookType 类型, pages 页数, wordsNumber 字数 from book";
                    SqlHelper.setGDV(sql1, uiDataGridView4);
                    break;
                case 2:
                    string sql2 = "select * from seat";
                    SqlHelper.setGDV(sql2, seatmsg);
                    break;

                case 3:
                    string sql3 = "select caseid 索书号,bookid 图书编号,bookname 书名,userid 读者账号,username 读者姓名,borrowtime 借阅时间,isbacktime 还书时间 from borrowmsg";
                    SqlHelper.setGDV(sql3, borrowedmsg);
                    break;
                case 4:
                    // 读者推荐
                    SqlHelper.setGDV("select id 编号, name 书籍名称, author 作者,type 书籍类型,publish 出版社,reason 推荐理由 from recommend", uiDataGridView9);
                    break;
                case 5:
                    string sqladmin = "select * from admin where id='" + global.username + "'";
                    SqlDataReader data = SqlHelper.ExecuteReader(sqladmin);

                    if (data.Read())
                    {
                        uiTextBox10.Text = global.username.ToString();
                        uiTextBox9.Text = data["name"].ToString();
                        sex1.Text = data["sex"].ToString();
                        psd1.Text = "";
                        uiTextBox8.Text = data["email"].ToString();
                        id.Enabled = name.Enabled = sex1.Enabled = psd1.Enabled = uiTextBox8.Enabled = false;
                    }
                    break;
            }
        }


        // 修改
        private void uiSymbolButton10_Click_1(object sender, EventArgs e)
        {
            string id = tushucaozuoDV[0, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            string sql = "update book set bookName = '" + nametb.Text + "',author = '" + authertb.Text +
                "',bookNumber = '" + numbertb.Text + "',publishCompany = '" + publishcompany.Text + "',publishDate = '" + uiDatePicker2.Text +"',bookType='"+booktype.SelectedText+"',pages = '"+pagestb.Text+"',wordsNumber = '"+ wordstb.Text +"' where id = '" + id + "'";
            SqlHelper.ExecuteNonQuery(sql);
            UIMessageBox.ShowSuccess("修改成功");
            SqlHelper.setGDV("select id 编号, bookName 书名, author 作者,bookNumber 数量, publishCompany 出版社, publishDate 出版时间, bookType 类型, pages 页数, wordsNumber 字数 from book", tushucaozuoDV);
        }

        // 删除图书
        private void uiSymbolButton9_Click_1(object sender, EventArgs e)
        {
            SqlHelper.ExecuteNonQuery("delete from book where id = '" + tushucaozuoDV[0, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString() + "'");
            UIMessageBox.ShowSuccess("删除成功！");
            SqlHelper.setGDV("select id 编号, bookName 书名, author 作者,bookNumber 数量, publishCompany 出版社, publishDate 出版时间, bookType 类型, pages 页数, wordsNumber 字数 from book", tushucaozuoDV);
        }

        // 根据书名查找图书信息
        private void searchbtn_Click(object sender, EventArgs e)
        {
            if(nametb.Text.Trim() != null)
            {
                string sql = "select id 编号, bookName 书名, author 作者,bookNumber 数量, publishCompany 出版社, publishDate 出版时间, bookType 类型, pages 页数, wordsNumber 字数 from book where bookName = '" + nametb.Text.Trim() + "'";
                SqlHelper.setGDV(sql, tushucaozuoDV);
            }
            else
            {
                UIMessageBox.ShowWarning("请输入书籍名称进行查找");
            }
        }
        //点击Gradview在Textbox查询数据
        private void tushucaozuoDV_SelectIndexChange(object sender, int index)
        {
            nametb.Text = tushucaozuoDV[1, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            authertb.Text = tushucaozuoDV[2, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            numbertb.Text = tushucaozuoDV[3, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            publishcompany.Text = tushucaozuoDV[4, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            string selecttext = tushucaozuoDV[6, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            booktype.Text = selecttext;
            uiDatePicker2.Text = tushucaozuoDV[5, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            pagestb.Text = tushucaozuoDV[7, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            wordstb.Text = tushucaozuoDV[8, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
        }


        #endregion

        #region 读者类型操作
        //用户类型添加
        private void uiSymbolButton8_Click(object sender, EventArgs e)
        {
            if (usertypename.Text.Trim() != null)
            {
                string sql = "insert into usertype (typename,days,numbers) values ('" + usertypename.Text.Trim() + "','" + days.Text.Trim() + "','" + numbers.Text.Trim() + "')";
                SqlHelper.ExecuteNonQuery(sql);
                UIMessageBox.ShowSuccess("添加分类成功");
                SqlHelper.setGDV("select id 编号, typename 分类名称,days 天数,numbers 可借数量 from usertype", uiDataGridView6);
            }
        }
        //用户类型修改
        private void uiSymbolButton12_Click(object sender, EventArgs e)
        {
            string typeid = uiDataGridView6[0, uiDataGridView6.CurrentCell.RowIndex].Value.ToString();
            string sql = "update usertype set typename = '" + usertypename.Text + "',days= '" + days.Text + "',numbers= '" + numbers.Text + "' where id = '" + typeid + "'";
            SqlHelper.ExecuteNonQuery(sql);
            UIMessageBox.ShowSuccess("修改成功");
            SqlHelper.setGDV("select id 编号, typename 分类名称,days 可借天数,numbers 数量 from usertype", uiDataGridView6);

        }
        //用户类型删除
        private void uiSymbolButton11_Click(object sender, EventArgs e)
        {
            SqlHelper.ExecuteNonQuery("delete from usertype where id = '" + uiDataGridView6[0, uiDataGridView6.CurrentCell.RowIndex].Value.ToString() + "'");
            UIMessageBox.ShowSuccess("删除成功！");
            SqlHelper.setGDV("select id 编号, typename 分类名称,days 可借天数,numbers 数量 from usertype", uiDataGridView6);

        }
        #endregion

        #region 选择当前行的数据进行填充

        private void uiDataGridView2_SelectIndexChange(object sender, int index)
        {
            stunumber.Text = uiDataGridView2[0, uiDataGridView2.CurrentCell.RowIndex].Value.ToString();
            uiTextBox3.Text = uiDataGridView2[1, uiDataGridView2.CurrentCell.RowIndex].Value.ToString();
            string sexStr = uiDataGridView2[2, uiDataGridView2.CurrentCell.RowIndex].Value.ToString();
            if (uiRadioButton1.Text == sexStr)
            {
                uiRadioButton1.Checked = true;
            }
            else
            {
                uiRadioButton2.Checked = true;
            }
            uiTextBox1.Text = uiDataGridView2[3, uiDataGridView2.CurrentCell.RowIndex].Value.ToString();
            string roleStr = uiDataGridView2[4, uiDataGridView2.CurrentCell.RowIndex].Value.ToString();
            role.SelectedIndex = role.Items.IndexOf(roleStr);
        }

        private void uiDataGridView5_SelectIndexChange(object sender, int index)
        {
            typetext.Text = uiDataGridView5[1, uiDataGridView5.CurrentCell.RowIndex].Value.ToString();
        }
        private void uiDataGridView6_SelectIndexChange(object sender, int index)
        {
            id.Text = uiDataGridView6[0, uiDataGridView6.CurrentCell.RowIndex].Value.ToString();
            usertypename.Text = uiDataGridView6[1, uiDataGridView6.CurrentCell.RowIndex].Value.ToString();
            days.Text = uiDataGridView6[2, uiDataGridView6.CurrentCell.RowIndex].Value.ToString();
            numbers.Text = uiDataGridView6[3, uiDataGridView6.CurrentCell.RowIndex].Value.ToString();
        }
        

        private void uiDataGridView7_SelectIndexChange(object sender, int index)
        {
            bookid.Text = uiDataGridView7[1, uiDataGridView7.CurrentCell.RowIndex].Value.ToString();
            caseid.Text = uiDataGridView7[0, uiDataGridView7.CurrentCell.RowIndex].Value.ToString();
            address.Text = uiDataGridView7[2, uiDataGridView7.CurrentCell.RowIndex].Value.ToString();
            state.Text = uiDataGridView7[3, uiDataGridView7.CurrentCell.RowIndex].Value.ToString();
        }
        #endregion


        #region 书架管理
        private void uiSymbolButton8_Click_1(object sender, EventArgs e)
        {
            string sql = "insert into bookcase values('" +caseid.Text.Trim() +"','" + bookid.Text.Trim()+"','" +address.Text.Trim() +"','" + state.Text.Trim()+"')";
            if (SqlHelper.ExecuteNonQuery(sql) > 0)
            {
                UIMessageBox.ShowSuccess("添加成功！");
                caseid.Text = "";
                bookid.Text = "";
                address.Text = "";
                state.Text = "";
                SqlHelper.setGDV("select caseid 编号, id 书架编号, address 藏书地址,state 借阅状态 from bookcase", uiDataGridView7);
            }
            else
            {
                UIMessageTip.ShowError("添加失败");
            }

        }

        private void uiSymbolButton12_Click_1(object sender, EventArgs e)
        {
            string id = uiDataGridView7[0, uiDataGridView7.CurrentCell.RowIndex].Value.ToString();
            string sql = "update bookcase set id = '" + bookid.Text + "',address = '" + address.Text.Trim() +"',state='"+state.Text.Trim()+"' where caseid = '" + id + "'";
            SqlHelper.ExecuteNonQuery(sql);
            UIMessageBox.ShowSuccess("修改成功");
            SqlHelper.setGDV("select caseid 编号, id 书架编号, address 藏书地址,state 借阅状态 from bookcase", uiDataGridView7);

        }

        private void uiSymbolButton11_Click_1(object sender, EventArgs e)
        {
            string id = uiDataGridView7[0, uiDataGridView7.CurrentCell.RowIndex].Value.ToString();
            string sql = "delete from bookcase where caseid = '" + id + "'";
            SqlHelper.ExecuteNonQuery(sql);
            UIMessageBox.ShowSuccess("删除成功");
            SqlHelper.setGDV("select caseid 编号, id 书架编号, address 藏书地址,state 借阅状态 from bookcase", uiDataGridView7);
        }


        #endregion


        #region 座位预约管理
        private void bind()
        {
            string sql = "select * from seat";

           // sql += uiComboBox1.SelectedItem + "'";

            SqlHelper.setGDV(sql, seatmsg);
        }

        private void type()
        {
          
            SqlHelper.setCBB("select distinct location from seat", "location", loc);

        }

        private void uiTabControl2_MouseClick(object sender, MouseEventArgs e)
        {
            type();
            //座位预约信息
            SqlHelper.setGDV("select id 编号,seatid 座位号, location 位置,userid 读者编号,retime 预约时间,isbacktime 归还时间  from reseat", uiDataGridView8);
        }

        private void seatmsg_SelectionChanged(object sender, EventArgs e)
        {
            seatno.Enabled = reseat.Enabled = classroom.Enabled = false;
            label1.Text = seatmsg[0, seatmsg.CurrentCell.RowIndex].Value.ToString();
            seatno.Text = seatmsg[1, seatmsg.CurrentCell.RowIndex].Value.ToString();
            reseat.Text = seatmsg[3, seatmsg.CurrentCell.RowIndex].Value.ToString();
            classroom.Text = seatmsg[2, seatmsg.CurrentCell.RowIndex].Value.ToString();

        }

        private void xiugai_Click(object sender, EventArgs e)
        {
            seatno.Enabled = reseat.Enabled = classroom.Enabled = true;

        }

        private void add_Click(object sender, EventArgs e)
        {
            seatno.Enabled = reseat.Enabled = classroom.Enabled = true;
            seatno.Text = reseat.Text = classroom.Text = null;
            global.state = "add";
            type();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string sql = "delete from seat where id='" + label1.Text + "'";
          int s=  SqlHelper.ExecuteNonQuery(sql);
            if (s > 0)
            {
                UIMessageBox.Show("删除成功！");
                bind();
            }
            else
            {
                UIMessageBox.Show("删除失败！"); bind();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (global.state == "add")
            {
                string sql = "insert into seat(seatno,location,state) values('"+ seatno.Text + "','"+classroom.Text+"','"+reseat.Text+"')";
                int s = SqlHelper.ExecuteNonQuery(sql);
                if (s > 0)
                {
                    UIMessageBox.Show("添加成功！"); bind(); type();
                }
                else
                {
                    UIMessageBox.Show("添加失败！"); bind();
                }
            }
            else
            {
                string sql = "update seat set seatno='" + seatno.Text + "',location='" + classroom.Text + "',state='" + reseat.Text + "'where id='"+label1.Text+"'";
                int s = SqlHelper.ExecuteNonQuery(sql);
                if (s > 0)
                {
                    UIMessageBox.Show("修改成功！"); bind();
                }
                else
                {
                    UIMessageBox.Show("修改失败！"); bind();
                }
            }
        }

        private void loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //type();
            string sql = "select * from seat where location = '"+loc.Text+"'";

           // label1.Text = loc.SelectedItem.ToString();

            SqlHelper.setGDV(sql, seatmsg);
        }

        #endregion

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s = uiComboBox1.SelectedIndex;
            switch (s)
            {
                case 0:
                    string sql3 = "select caseid 索书号,bookid 图书编号,bookname 书名,userid 读者账号,username 读者姓名,borrowtime 借阅时间,isbacktime 还书时间 from borrowmsg";
                    SqlHelper.setGDV(sql3, borrowedmsg);
                    break;
                case 1:
                    string sql1 = "select caseid 索书号,bookid 图书编号,bookname 书名,userid 读者账号,username 读者姓名,borrowtime 借阅时间,isbacktime 还书时间 from borrowmsg where isbacktime<'"+DateTime.Now+"'";
                    SqlHelper.setGDV(sql1, borrowedmsg);
                    break;
               
            }
        }

        // 添加管理员
        private void uiSymbolButton6_Click(object sender, EventArgs e)
        {
           
            string beChecked = uiRadioButton6.Checked ? uiRadioButton6.Text : uiRadioButton5.Text;
            if (uiTextBox6.Text != null && uiTextBox5.Text != null && beChecked != null && uiTextBox4.Text != null)
            {
                string pwd = SqlHelper.MD5Hash(uiTextBox5.Text.ToString());
                string sql = "insert into admin(name,pwd,sex,email) values('" + uiTextBox6.Text.ToString() + "','" + pwd + "','"+beChecked+"','"+uiTextBox4.Text.ToString().Trim()+"') ";
                SqlHelper.ExecuteNonQuery(sql);
                UIMessageBox.Show("添加成功！");
            }
            else
            {
                UIMessageBox.Show("请填写完整信息！");
            }
            uiTextBox6.Text = "";
            uiTextBox5.Text = "";
            uiTextBox4.Text = "";
        }
        
        // 修改
        private void uiButton6_Click(object sender, EventArgs e)
        {
            uiTextBox9.Enabled = sex1.Enabled = psd1.Enabled = uiTextBox8.Enabled = true;
        }

        // 保存
        private void uiButton7_Click(object sender, EventArgs e)
        {
            string sqlsave = "update admin set name = '" + uiTextBox9.Text + "', sex = '" + sex1.Text + "',email = '" + uiTextBox8.Text + "',pwd = '" + SqlHelper.MD5Hash(psd1.Text) + "' where id = '" + uiTextBox10.Text + "'";
            SqlHelper.ExecuteNonQuery(sqlsave);
            UIMessageBox.ShowSuccess("修改成功");
            id.Enabled = name.Enabled = sex1.Enabled = psd1.Enabled = email.Enabled = role.Enabled = false;
        }

        private void tabPage18_Click(object sender, EventArgs e)
        {

        }
    }
}

