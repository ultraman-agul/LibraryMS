using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sunny.UI;

namespace LibraryMS.usermain
{ 

    public partial class usermsg : Sunny.UI.UIForm
    {
        public usermsg()
        {
            InitializeComponent();
        }

        private void usermsg_Load(object sender, EventArgs e)
        {
            string sql = "select * from users where id='" + global.username + "'";
            SqlDataReader data = SqlHelper.ExecuteReader(sql);
            if (data.Read())
            {
                id.Text = global.username.ToString();
                name.Text = data["name"].ToString();
                sex.Text = data["sex"].ToString();
                psd.Text = "";
                email.Text = data["email"].ToString();
                role.Text = data["role"].ToString();
                id.Enabled = name.Enabled = sex.Enabled = psd.Enabled = email.Enabled = role.Enabled = false;
            }     
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            name.Enabled = sex.Enabled = psd.Enabled = email.Enabled = role.Enabled = true;
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            string sql = "update users set name = '" + name.Text + "', sex = '" + sex.Text + "',email = '" + email.Text + "', role = '" + role.Text + "',pwd = '"+ SqlHelper.MD5Hash(psd.Text) +"' where id = '" + id.Text + "'";
            SqlHelper.ExecuteNonQuery(sql);
            UIMessageBox.ShowSuccess("修改成功");
            id.Enabled = name.Enabled = sex.Enabled = psd.Enabled = email.Enabled = role.Enabled = false;
        }
    }
}
