using System.Data;
using System.Data.SqlClient;

namespace Co_Manage_Sys
{
    /// <summary>
    /// ����ά�����ݿ������ַ������� Connection ����
    /// </summary>
    public class DBLink
    {
        // ���ݿ������ַ���
        private string connString = @"Data Source=ASUNA\SQLEXPRESS;Initial Catalog=SCT_WH_DataBase;Integrated Security=True";

        // ���ݿ����� Connection ����
        private SqlConnection connection;

        /// <summary>
        /// Connection����
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
        /// �����ݿ�����
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
        /// �ر����ݿ�����
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
