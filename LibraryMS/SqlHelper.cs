using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public class SqlHelper
    {
        public static string GetSqlConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sqlConnection"].ToString();
        }
        //适合增删改操作，返回影响条数
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(GetSqlConnectionString()))
            {
                using (SqlCommand comm = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        comm.CommandText = sql;
                        if (parameters != null)
                            comm.Parameters.AddRange(parameters);
                        return comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        if (conn != null && conn.State != ConnectionState.Closed)
                            conn.Close();
                    }

                }
            }
        }
        //查询操作，返回查询结果中的第一行第一列的值
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(GetSqlConnectionString()))
            {
                using (SqlCommand comm = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        comm.CommandText = sql;
                        if (parameters != null)
                            comm.Parameters.AddRange(parameters);
                        return comm.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        if (conn != null && conn.State != ConnectionState.Closed)
                            conn.Close();
                    }
                }
            }
        }
        //Adapter调整，查询操作，返回DataTable 
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, GetSqlConnectionString()))
            {
                DataTable dt = new DataTable();
                if (parameters != null)
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                adapter.Fill(dt);
                return dt;
            }
        }

        // 执行查询多行多列的数据的方法：ExecuteReader
        public static SqlDataReader ExecuteReader(string sqlText)
        {
            //SqlDataReader要求，它读取数据的时候有，它独占它的SqlConnection对象，而且SqlConnection必须是Open状态
            SqlConnection conn = new SqlConnection(GetSqlConnectionString());//不要释放连接，因为后面还需要连接打开状态
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd = new SqlCommand(sqlText, conn);
            SqlDataReader sdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
           // System.Data.CommandBehavior.CloseConnection ：//关闭dataReader时,同时也把与它相关联的Connection连接也一起关闭
            return sdr;

            //CommandBehavior.CloseConnection当SqlDataReader释放的时候，顺便把SqlConnection对象也释放掉

        }

        // MD5数据加密
        public static string MD5Hash(string str)
        {
            string pwd = "";
            MD5 md5 = MD5.Create();
            byte[] s = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));
            for(var i = 0; i < s.Length; i++)
            {
                pwd += s[i].ToString("X");
            }
            return pwd;
        }

        // 查询数据库，填充到datagridview中
        public static void setGDV(string sql,DataGridView gdv)
        {
            SqlConnection conn = new SqlConnection(SqlHelper.GetSqlConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gdv.DataSource = dt;
            conn.Close();
        }

        // 查询数据库，填充到combobox中
        public static void setCBB(string sql, string columnName, UIComboBox cbb)
        {
            SqlConnection conn = new SqlConnection(SqlHelper.GetSqlConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cbb.DataSource = dt;
            cbb.ValueMember = columnName;
            conn.Close();
        }
    }
}
