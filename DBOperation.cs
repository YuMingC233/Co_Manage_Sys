using System;
using System.Data;
using System.Data.SqlClient;

namespace Co_Manage_Sys.Aiden_Connor
{
    /// <summary>
    /// 所有窗体的逻辑处理部分
    /// </summary>
    class DBOperation
    {
        /// <summary>
        /// 声明一大堆变量
        /// </summary>
        DBLink dba = new DBLink();
        DBLink dbu = new DBLink();
        SqlCommand Scom;
        string sqlCode;
        SqlDataReader Sread;
        DataSet ds;
        SqlDataAdapter Adapt;
    }
}
