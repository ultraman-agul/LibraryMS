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
            string sql = "select * from " + flag + " where name = '" + uiTextBox1.Text + "' and pwd = '" + pwd + "'";
            object result = SqlHelper.ExecuteScalar(sql);
            if (result != null)
            {
                global.username = uiTextBox1.Text;
                global.role = result.ToString();
                //new MainForm().Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }
    }
}
