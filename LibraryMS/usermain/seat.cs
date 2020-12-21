using Sunny.UI;
using System;
using System.Collections;
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
    public partial class seat : Sunny.UI.UIForm
    {
        public seat()
        {
            InitializeComponent();
        }

        private void seat_Load(object sender, EventArgs e)
        {
            string sql = "select id 编号,seatno 座位号,location 位置,state 预约状态 from seat";
            SqlHelper.setGDV(sql, uiDataGridView1);
            string sql3 = "select * from reseat where userid= '" + global.username + "'";
            SqlDataReader sdr = SqlHelper.ExecuteReader(sql3);
            if (sdr.Read())
            {
                loc.Text = sdr["location"].ToString();
                seatno.Text = sdr["seatid"].ToString();
            }
            SqlHelper.setCBB("select distinct location from seat", "location", uiComboBox1);
        }

        //预约
        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            string sql1= "select count(*) from reseat where userid= '"+ global.username+"'";
            int n = Convert.ToInt32(SqlHelper.ExecuteScalar(sql1));
            if (n>0 )
            {
                UIMessageBox.ShowInfo("您已预约了座位，无法再预约");
            }
            else
            {
                string sql4= "select state from seat where seatno='" + id + "' and location='"+location+"'";
                if (SqlHelper.ExecuteScalar(sql4).ToString() == "True")
                {

                    UIMessageBox.Show("该座位已经被预约！");
                }
                else { 
                string sql2="insert into reseat(seatid,location,userid,username,retime,isbacktime) values('"+id+"','"+location+"','" + global.username + "','" + global.name + "','"+DateTime.Now.ToString("yyyy-MM-dd")+"','"+SqlHelper.ReTime(DateTime.Now.ToString("yyyy-MM-dd"),1)+"')";
                string sql = "update seat set state = 1 where seatno='" + id + "' and location='" + location + "'";
                    if (SqlHelper.ExecuteNonQuery(sql) > 0)
                    {
                        if (SqlHelper.ExecuteNonQuery(sql2) > 0)
                        {
                            UIMessageBox.ShowSuccess("预约成功！");
                            string sql3 = "select * from reseat where userid= '" + global.username + "'";
                            SqlDataReader sdr = SqlHelper.ExecuteReader(sql3);
                            if (sdr.Read())
                            {
                                loc.Text = sdr["location"].ToString();
                                seatno.Text = sdr["seatid"].ToString();
                            }

                        }
                    }
                }
                SqlHelper.setGDV("select id 编号,seatno 座位号,location 位置,state 预约状态 from seat", uiDataGridView1);
            }
        }
        // 座位id
        protected int id;
        protected string location;

        // 选择某个座位事件
        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            if(Convert.ToInt32((SqlHelper.ExecuteScalar("select count(*) from reseat where userid= '" + global.username + "'")))<=0 )
            {
                id = Convert.ToInt32(uiDataGridView1[1, uiDataGridView1.CurrentCell.RowIndex].Value.ToString());
                location = uiDataGridView1[2, uiDataGridView1.CurrentCell.RowIndex].Value.ToString();
                string state = uiDataGridView1[3, uiDataGridView1.CurrentCell.RowIndex].Value.ToString();
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
            string sql = "select id 编号,seatno 座位号,location 位置,state 预约状态 from seat where location = '" + uiComboBox1.Text + "'";


            SqlHelper.setGDV(sql, uiDataGridView1);
        }

        // 归还
        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32((SqlHelper.ExecuteScalar("select count(*) from reseat where userid= '" + global.username + "'"))) <= 0)
            {
                UIMessageBox.ShowSuccess("当前没有预约座位");
            }
            else
            {
                string sql = "update seat set state = 0 where seatno='" + seatno.Text + "' and location='"+loc.Text+"'";
                string sql1 = "delete from reseat where userid='" + global.username + "'";
               
                
                if (SqlHelper.ExecuteNonQuery(sql) > 0)
                {
                    if (SqlHelper.ExecuteNonQuery(sql1) > 0)
                    {

                    
                        UIMessageBox.ShowSuccess("取消成功！");
                        seatno.Text =" ";
                       loc.Text = " ";
                    }
                }
                SqlHelper.setGDV("select id 编号,seatno 座位号,location 位置,state 预约状态 from seat", uiDataGridView1);
            }
        }
    }
}
