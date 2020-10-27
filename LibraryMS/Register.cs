using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class Register : Sunny.UI.UIForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            uiRadioButton1.Checked = true;
            cbb.SelectedIndex = cbb.Items.IndexOf("学生");
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            string beChecked = uiRadioButton1.Checked ? uiRadioButton1.Text : uiRadioButton2.Text;
            if (name.Text != null && pwd.Text != null && beChecked != null && email.Text != null && cbb.SelectedText.ToString() != null)
            {
                string newpwd = SqlHelper.MD5Hash(pwd.Text);
                string sql = "insert into users (name, pwd, sex, email, role) values ('" + name.Text + "','" + newpwd + "','" + beChecked + "','" + email.Text + "','" + cbb.SelectedText.ToString() + "')";
                SqlHelper.ExecuteNonQuery(sql);
                UIMessageBox.Show("注册成功！");
                this.Visible = false;
                new Login().Show();
            }
            else
            {
                UIMessageBox.Show("请填写完整信息！");
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Login().Show();
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
