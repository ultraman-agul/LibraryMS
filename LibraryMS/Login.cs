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

namespace LibraryMS
{
    public partial class Login : Sunny.UI.UIForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            uiRadioButton1.Checked = true;
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string pwd = SqlHelper.MD5Hash(uiTextBox2.Text);
            string flag = uiRadioButton1.Checked ? "admin" : "users";
            string sql = "select * from " + flag + " where id = '" + uiTextBox1.Text + "' and pwd = '" + pwd + "'";
            object result = SqlHelper.ExecuteScalar(sql);
            if (result != null)
            {
                global.role = result.ToString();
                global.username = uiTextBox1.Text;
                if (flag == "admin")
                {
                    UIMessageBox.ShowSuccess("登录成功");
                    this.Hide();
                    new ManagerMain().Show();
                }
                else if (flag == "users")
                {
                    UIMessageBox.ShowSuccess("登录成功");
                    this.Hide();
                    new ReaderMain().Show(); 
                    this.Visible = false;

                }          
            }
            else
            {
                UIMessageBox.ShowError("用户名或密码错误");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }
    }
}
