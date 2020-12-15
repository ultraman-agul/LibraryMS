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
    public partial class recommand : Sunny.UI.UIForm
    {
        public recommand()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            string sql = "insert into recommand(name,author,publish,type,reason) values('" + name.Text + "','" + author.Text + "','" + type.Text + "','" + publish.Text + "','" + reason.Text + "')";
            int s=SqlHelper.ExecuteNonQuery(sql);
            if (s > 0)
            {
                UIMessageBox.Show("推荐成功，等待管理员审核");
            }
            else
            {
                UIMessageBox.Show("推荐失败");
            }
        }

        // 读者荐购
        private void yes_Click_1(object sender, EventArgs e)
        {
            string sql = "insert into recommend (name, author, type,publish,reason) values('" + name.Text.Trim() + "','" + author.Text.Trim() + "','"+  type.Text.Trim() + "','" +publish.Text.Trim() + "','" + reason.Text.Trim() + "')";
            SqlHelper.ExecuteNonQuery(sql);
            UIMessageBox.ShowSuccess("推荐成功，感谢您的推荐！");
            name.Text = author.Text = publish.Text = type.Text = reason.Text = "";
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void recommand_Load(object sender, EventArgs e)
        {
            SqlHelper.setGDV("select top 5 id 编号,bookName 书籍名称,bookType 书籍类型,bookNumber 库存,author 作者,publishCompany 出版社,publishDate 出版日期 from book order by publishDate desc", uiDataGridView1);
        }
    }
}
