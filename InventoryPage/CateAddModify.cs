using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Co_Manage_Sys.InventoryPage
{
    public partial class CateAddModify : Form
    {
        public bool isModify;
        public string TempCateName;
        string sqlstr;
        DBLink er = new DBLink();//连接数据
        public CateAddModify()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 判断是修改还是添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_Click_1(object sender, EventArgs e)
        {
            //判断
            if (isModify)
            {
                Text = "修改";
                Modification();//修改
            }
            else
            {
                Text = "添加";
                accretion();//添加
            }
        }
        
        /// <summary>
        /// dgv添加方法
        /// </summary>
        public void accretion()
        {
            try
            {
                er.OpenConnection();
                sqlstr = string.Format("insert into Category(CateName,Description) " +"values('{0}', '{1}')", CateNameTb.Text.Trim(), DescTb.Text.Trim());
                SqlCommand shu = new SqlCommand(sqlstr, er.Connection);
                int sun = shu.ExecuteNonQuery();
                if (sun > 0)
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("添加失败!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("出现错误，可能已经存在该条数据！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// 修改时绑定窗口数据
        /// </summary>
        public void padding()
        {
            er.OpenConnection();
            sqlstr = string.Format("select * from Category where CateName = '{0}'", TempCateName);
            SqlCommand shu = new SqlCommand(sqlstr, er.Connection);
            SqlDataReader read = shu.ExecuteReader();
            while (read.Read())
            {
                CateNameTb.Text = read[0].ToString();
                DescTb.Text = read[1].ToString();
            }
            er.CloseConnection();
        }

        /// <summary>
        /// 保存修改后的数据
        /// </summary>
        public void Modification()
        {
            SqlCommand sCom;
            er.OpenConnection();
            sqlstr = string.Format("alter table Inventory NoCheck ConstRaint FK_Inventory_Category;");
            sCom = new SqlCommand(sqlstr, er.Connection);
            sCom.ExecuteNonQuery();

            sqlstr = string.Format("update Inventory set CateName = '{0}' where CateName = '{1}'", CateNameTb.Text.Trim(), TempCateName);
            sCom = new SqlCommand(sqlstr, er.Connection);
            int temp = sCom.ExecuteNonQuery();
            if (temp > 0)
            {
                sqlstr = string.Format("update Category set CateName = '{0}', Description = '{1}' where CateName = '{2}'", CateNameTb.Text.Trim(), DescTb.Text.Trim(), TempCateName);
                SqlCommand sun = new SqlCommand(sqlstr, er.Connection);
                int shu = sun.ExecuteNonQuery();
                if (shu > 0)
                {
                    sqlstr = string.Format("alter table Inventory Check ConstRaint FK_Inventory_Category;");
                    sCom = new SqlCommand(sqlstr, er.Connection);
                    sCom.ExecuteNonQuery();
                    MessageBox.Show("修改成功！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("修改失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("没有修改被应用！","信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 下拉框赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CateAddModify_Load(object sender, EventArgs e)
        {
            //判断
            if (TempCateName != null)
            {
                Text = "修改";
                padding();//赋值
            }
            else
                Text = "添加";
        }

    }
}
