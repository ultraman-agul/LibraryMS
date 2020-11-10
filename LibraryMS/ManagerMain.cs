using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        #region 读者管理
        private void ManagerMain_Load(object sender, EventArgs e)
        {
            uiRadioButton1.Checked = true; // 默认性别单选按钮
            uiLabel1.Text += global.username;
            // 填充gridview1
            string sql = "select id 编号, name 姓名, sex 性别, email 邮箱, role 角色 from users";
            SqlHelper.setGDV(sql, uiDataGridView1);
            // 图书分类填充到cbb中
            SqlHelper.setCBB("select TypeName as good from bookType", "good", booktypecbb);
        }

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
                    uiComboBox1.SelectedIndex = uiComboBox1.Items.IndexOf("学生");
                    string sql1 = "select id 编号, name 姓名, sex 性别, email 邮箱, role 角色 from users";
                    SqlHelper.setGDV(sql1, uiDataGridView2);
                    break;
            }
        }

        // 添加用户
        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            string beChecked = uiRadioButton1.Checked ? uiRadioButton1.Text : uiRadioButton2.Text;
            if (name.Text != null && pwd.Text != null && beChecked != null && email.Text != null && cbb.SelectedText.ToString() != null)
            {
                string newpwd = SqlHelper.MD5Hash(pwd.Text);
                string sql = "insert into users (name, pwd, sex, email, role) values ('" + name.Text + "','" + newpwd + "','" + beChecked + "','" + email.Text + "','" + cbb.SelectedItem.ToString() + "')";
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
            string sql = "update users set name = '" + uiTextBox3.Text + "', sex = '" + beChecked + "',email = '" + uiTextBox1.Text + "', role = '" + uiComboBox1.Text + "' where id = '" + stunumber.Text + "'";
            SqlHelper.ExecuteNonQuery(sql);
            UIMessageBox.ShowSuccess("修改成功");
            SqlHelper.setGDV("select id 编号, name 姓名, sex 性别, email 邮箱, role 角色 from users", uiDataGridView2);
        }

        // 选择当前行的数据
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
            uiComboBox1.SelectedIndex = uiComboBox1.Items.IndexOf(roleStr);
        }

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
                    SqlHelper.setCBB(sql4, "TYPE",uiComboBox2);
                    break;
                case 3:
                    string sql2 = "select bookType 编号, typeName 分类名称 from bookType";
                    SqlHelper.setGDV(sql2, uiDataGridView5);
                    break;
            }
        }

        // 修改分类
        private void uiSymbolButton9_Click(object sender, EventArgs e)
        {
            string typeid = uiDataGridView5[0, uiDataGridView5.CurrentCell.RowIndex].Value.ToString();
            string sql = "update bookType set typeName = '" + typetext.Text + "' where bookType = '" + typeid + "'";
            SqlHelper.ExecuteNonQuery(sql);
            UIMessageBox.ShowSuccess("修改成功");
            SqlHelper.setGDV("select bookType 编号, typeName 分类名称 from bookType", uiDataGridView5);
        }

        private void uiDataGridView5_SelectIndexChange(object sender, int index)
        {
            typetext.Text = uiDataGridView5[1, uiDataGridView5.CurrentCell.RowIndex].Value.ToString();
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

        #endregion

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
            }
        }


        // 修改
        private void uiSymbolButton10_Click_1(object sender, EventArgs e)
        {
            string id = tushucaozuoDV[0, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            string sql = "update book set bookName = '" + nametb.Text + "',author = '" + authertb.Text +
                "',bookNumber = '" + numbertb.Text + "',publishCompany = '" + publishcompany.Text + "',publishDate = '" + uiDatePicker2.Text +"',bookType='"+uiComboBox2.SelectedText+"',pages = '"+pagestb.Text+"',wordsNumber = '"+ wordstb.Text +"' where id = '" + id + "'";
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

        // 查找
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

        private void tushucaozuoDV_SelectIndexChange(object sender, int index)
        {
            nametb.Text = tushucaozuoDV[1, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            authertb.Text = tushucaozuoDV[2, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            numbertb.Text = tushucaozuoDV[3, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            publishcompany.Text = tushucaozuoDV[4, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            string selecttext = tushucaozuoDV[6, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            uiComboBox2.Text = selecttext;
            uiDatePicker2.Text = tushucaozuoDV[5, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            pagestb.Text = tushucaozuoDV[7, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
            wordstb.Text = tushucaozuoDV[8, tushucaozuoDV.CurrentCell.RowIndex].Value.ToString();
        }
    }
}
