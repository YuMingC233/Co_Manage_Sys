using System.Data;
using System.Data.SqlClient;

namespace Co_Manage_Sys
{
    /// <summary>
    /// 此类维护数据库连接字符串，和 Connection 对象
    /// </summary>
    public class DBLink
    {
        // 数据库连接字符串
        private string connString = @"Data Source=ASUNA\SQLEXPRESS;Initial Catalog=SCT_WH_DataBase;Integrated Security=True";

        // 数据库连接 Connection 对象
        private SqlConnection connection;

        /// <summary>
        /// Connection对象
        /// </summary>
        public SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connString);
                }
                return connection;
            }
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
            }
        }
    }
}
