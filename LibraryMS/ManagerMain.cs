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
        private void uiPanel2_Click(object sender, EventArgs e)
        {

        }

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
                    
                    break;
                case 1:
                   
                    break;
                case 2:
                    
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
    }
}
