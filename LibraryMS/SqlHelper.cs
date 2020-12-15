using Sunny.UI;
using System;
using System.Collections;
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


        public static string ReTime(string data, int str)
        {
            DateTime dt = DateTime.Parse(data);
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int n = DateTime.DaysInMonth(year, month);
            int k = day + str;
            if (k > n)
            {
                day = str - (n - day);
                month = month + 1;
                if (month > 12)
                {
                    month = 1;
                    year = year + 1;
                }
            }
            else
            {
                day = day + str;
            }
            string c = year + "-" + month + "-" + day;
            return c;
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
                        return comm.ExecuteScalar().ToString();
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

        /// <summary>
        /// 数据库有连接操作，获取查询结果，返回指定查询列的值
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="columnName">指定查询的列名</param>
        /// <returns></returns>
        public static ArrayList DataReader(string sql, string columnName)
        {
            SqlConnection conn = new SqlConnection(GetSqlConnectionString());
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader sdr = comm.ExecuteReader();
            ArrayList arr = new ArrayList(1);
            while (sdr.Read())
            {
                arr.Add(sdr[columnName].ToString().Trim());
            }
            sdr.Close();
            conn.Close();
            return arr;
        }
    }
}
