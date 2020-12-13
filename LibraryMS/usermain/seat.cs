using Sunny.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS.usermain
{
    public partial class seat : Sunny.UI.UIForm
    {
        public seat()
        {
            InitializeComponent();
        }

        private void seat_Load(object sender, EventArgs e)
        {
            string sql = "select * from seat";
            SqlHelper.setGDV(sql, uiDataGridView1);
        }

        //预约
        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            if((SqlHelper.ExecuteScalar("select haveseat from users where id=" + global.username)).ToString() != "")
            {
                UIMessageBox.ShowInfo("不可再预约");
            }
            else
            {
                string sql = "update seat set state = 1 where id=" + id + ";update users set haveseat = "+id+" where id=" + global.username;
                if(SqlHelper.ExecuteNonQuery(sql)>0)
                {
                    UIMessageBox.ShowSuccess("预约成功！");
                }
                SqlHelper.setGDV("select * from seat", uiDataGridView1);
            }
        }
        // 座位id
        protected int id;

        // 选择某个座位事件
        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            if((SqlHelper.ExecuteScalar("select haveseat from users where id=" + global.username)).ToString() == "")
            {
                id = Convert.ToInt32(uiDataGridView1[0, uiDataGridView1.CurrentCell.RowIndex].Value.ToString());
                string location = uiDataGridView1[1, uiDataGridView1.CurrentCell.RowIndex].Value.ToString();
                string state = uiDataGridView1[2, uiDataGridView1.CurrentCell.RowIndex].Value.ToString();
                uiTextBox1.Text = location + " | " + id.ToString();
                uiImageButton1.Enabled = state == "1" ?  false : true;
            }
            else
            {
                 UIMessageBox.ShowInfo("不可再预约");
                uiImageButton1.Enabled = false;
            }
        }

        // 位置选择
        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from seat where location = '";
            switch (uiComboBox1.SelectedIndex)
            {
                case 0:
                    sql += "一楼东'";
                    break;
                case 1:
                    sql += "二楼西'";
                    break;
                case 2:
                    sql += "三楼东'";
                    break;
            }
            SqlHelper.setGDV(sql, uiDataGridView1);
        }

        // 归还
        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            string userseatid = (SqlHelper.ExecuteScalar("select haveseat from users where id=" + global.username)).ToString();
            if(userseatid=="")
            {
                UIMessageBox.ShowSuccess("当前没有预约座位");
            }
            else
            {
                string sql = "update seat set state = 0 where id=" + userseatid + ";";
                string sql1= "update users set haveseat = null where id=" + global.username;
                SqlHelper.ExecuteNonQuery(sql1);
                if (SqlHelper.ExecuteNonQuery(sql) > 0)
                {
                    UIMessageBox.ShowSuccess("归还成功！");
                }
                SqlHelper.setGDV("select * from seat", uiDataGridView1);
            }
        }
    }
}
