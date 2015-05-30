using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Jiaheng.House2.Vote.Ado.Net
{
    public class DBHelper
    {
        public DBHelper()
        {
            connectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["default"].ToString();
        }

        string connectionString;

        #region 执行一个查询，并返回结果集

        /// <summary>
        /// 执行一个查询，并返回结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>查询结果集</returns>
        protected DataTable ExecuteDataTable(string sql)
        {
            return ExecuteDataTable(sql, CommandType.Text, null);
        }

        /// <summary>
        /// 执行一个查询，并返回结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <returns>查询结果集</returns>
        protected DataTable ExecuteDataTable(string sql, CommandType commandType)
        {
            return ExecuteDataTable(sql, commandType, null);
        }

        /// <summary>
        /// 执行一个查询，并返回结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns>查询结果集</returns>
        protected DataTable ExecuteDataTable(string sql, CommandType commandType, SqlParameter[] parameters)
        {
            //实例化DataTable，用于装载查询结果集
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    //指定CommandType
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    //实例化SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    //填充DataTable
                    adapter.Fill(data);
                }
            }
            return data;

        }

        #endregion

        #region 返回一个DataReader对象实例

        /// <summary>
        /// 返回一个DataReader对象实例
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>DataReader对象实例</returns>
        protected SqlDataReader ExecuteReader(string sql)
        {
            return ExecuteReader(sql, CommandType.Text, null);
        }

        /// <summary>
        /// 返回一个DataReader对象实例
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <returns>DataReader对象实例</returns>
        protected SqlDataReader ExecuteReader(string sql, CommandType commandType)
        {
            return ExecuteReader(sql, commandType, null);
        }

        /// <summary>
        /// 返回一个DataReader对象实例
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns>DataReader对象实例</returns>
        protected SqlDataReader ExecuteReader(string sql, CommandType commandType, SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            connection.Open();
            //参数CommandBehavior.CloseConnection表示，关闭Reader对象的同时关闭Connection对象
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
        #endregion

        #region 执行查询结果，返回第一行的第一列

        /// <summary>
        /// 执行查询结果，返回第一行的第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>返回第一行的第一列</returns>
        protected object ExecuteScalar(string sql)
        {
            return ExecuteScalar(sql, CommandType.Text, null);
        }

        /// <summary>
        /// 执行查询结果，返回第一行的第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <returns>返回第一行的第一列</returns>
        protected object ExecuteScalar(string sql, CommandType commandType)
        {
            return ExecuteScalar(sql, commandType, null);
        }

        /// <summary>
        /// 执行查询结果，返回第一行的第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns>返回第一行的第一列</returns>
        protected object ExecuteScalar(string sql, CommandType commandType, SqlParameter[] parameters)
        {
            object result = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }

                    connection.Open();
                    result = command.ExecuteScalar();
                }

            }
            return result;
        }

        #endregion

        #region 对数据库进行增删改操作

        /// <summary>
        /// 对数据库进行增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>返回受影响的函数</returns>
        protected int ExecuteNonQuery(string sql)
        {
            return ExecuteNonQuery(sql, CommandType.Text, null);
        }

        /// <summary>
        /// 对数据库进行增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <returns>返回受影响的函数</returns>
        protected int ExecuteNonQuery(string sql, CommandType commandType)
        {
            return ExecuteNonQuery(sql, commandType, null);
        }

        /// <summary>
        /// 对数据库进行增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns>返回受影响的函数</returns>
        protected int ExecuteNonQuery(string sql, CommandType commandType, SqlParameter[] parameters)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    connection.Open();
                    count = command.ExecuteNonQuery();
                }

            }
            return count;

        }
        #endregion

        #region 对数据库进行事务处理
        protected bool TransactionSqls(string[] sqls)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                //启动一个事务
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        try
                        {
                            cmd.Transaction = transaction;
                            foreach (var sql in sqls)
                            {
                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                            }
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return false;
                        }

                    }
                }
            }
        }
        #endregion

    }
}
