using Co_Manage_Sys.Aiden_Connor;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Co_Manage_Sys.InventoryPage
{
    public partial class CategoryForm : Form
    {
        private Main_Form mfa;
        DBLink er = new DBLink();//链接数据库
        DataSet db = new DataSet();//零食仓库
        SqlDataAdapter com;
        int mouseX = 0;
        int mouseY = 0;
        DialogResult RSS;
        string sqlstr;
        public CategoryForm(Main_Form mfa)
        {
            this.mfa = mfa;
            InitializeComponent();
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ShowAll();
        }

        /// <summary>
        /// 查询信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        /// <summary>
        /// 添加按钮切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            mfa.SwitchPage_CargoInfo("", 4);
        }

        /// <summary>
        /// 删除按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete1_Click(object sender, EventArgs e)
        {
            RSS = MessageBox.Show(this, "确定要删除选中行？删除选中行类别时注意替换原类别中所有货物！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (RSS)
            {
                case DialogResult.Yes:
                    if (delete() > 0)
                    {
                        MessageBox.Show("成功删除选中行数据！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAll();//载入用户数据
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        /// <summary>
        /// 切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            int RowIndex = dgv.CurrentRow.Index;
            string ClientName = dgv[0, RowIndex].Value.ToString();
            mfa.SwitchPage_CargoInfo(ClientName, 5);
        }

        /// <summary>
        /// dgv绑定数据
        /// </summary>
        public void ShowAll()
        {
            er.OpenConnection();
            sqlstr = "select * from Category";
            com = new SqlDataAdapter(sqlstr, er.Connection);
            if (db.Tables["Category"] != null)
            {
                db.Tables["Category"].Clear();
            }

            com.Fill(db, "Category");

            if (db.Tables["Category"].Columns.Count != 3)
            {
                //为已有DataTable添加一新列
                DataColumn dc = new DataColumn("操作", typeof(string));
                dc.DefaultValue = "编辑 | 删除";
                dc.ReadOnly = true;
                db.Tables["Category"].Columns.Add(dc);
            }
            dgv.DataSource = db.Tables["Category"];
        }

        /// <summary>
        /// 点击获取单元格值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                switch (dgv.Columns[e.ColumnIndex].Name)
                {
                    case "操作":
                        Rectangle rc = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);//单元格区域的矩形
                        if (0 < mouseX && mouseX < rc.Width / 2)
                        {
                            string _UID = dgv[0, e.RowIndex].Value.ToString();
                            mfa.SwitchPage_CargoInfo(_UID, 5);
                        }
                        else if (rc.Width > mouseX && mouseX > rc.Width / 2)
                        {
                            #region 删除选中的行

                            //获取在同一行第一列的单元格中的字段值 
                            RSS = MessageBox.Show(this, "确定要删除选中行？删除选中行类别时注意替换原类别中所有货物！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            switch (RSS)
                            {
                                case DialogResult.Yes:
                                    if (delete() > 0)
                                    {
                                        MessageBox.Show("成功删除选中行数据！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ShowAll();//载入用户数据
                                    }
                                    break;
                                case DialogResult.No:
                                    break;
                            }
                            #endregion
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// 点击获取单元格鼠标位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void display_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex != -1)
            {
                if (dgv.Columns[e.ColumnIndex].Name == "操作")
                {
                    mouseX = e.X;
                    mouseY = e.Y;
                }
            }
        }

        /// <summary>
        /// 删除方法
        /// </summary>
        /// <returns></returns>
        public int delete()
        {
            try
            {
                int RowIndex = dgv.CurrentRow.Index;
                string ClientName = dgv[0, RowIndex].Value.ToString();

                er.OpenConnection();

                string sqlstr = string.Format("alter table Inventory NoCheck ConstRaint FK_Inventory_Category;");
                SqlCommand shu = new SqlCommand(sqlstr, er.Connection);
                shu.ExecuteNonQuery();

                sqlstr = string.Format("delete Inventory where CateName = '{0}';" +
                                       "delete Category where CateName = '{0}';",
                                        ClientName);
                shu = new SqlCommand(sqlstr, er.Connection);
                int sun = shu.ExecuteNonQuery();
                if (sun > 0)
                {
                    sqlstr = string.Format("alter table Inventory Check ConstRaint FK_Inventory_Category;");
                    SqlCommand sh = new SqlCommand(sqlstr, er.Connection);
                    sh.ExecuteNonQuery();
                    return sun;
                }
                else
                {
                    MessageBox.Show("删除失败!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("删除失败!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        /// <summary>
        /// 查询方法
        /// </summary>
        public void Search()
        {
            sqlstr = string.Format("select * from Category where CateName like '%{0}%'", SearchTb.Text.Trim());
            com = new SqlDataAdapter(sqlstr, er.Connection);
            if (db.Tables["Category"] != null)
            {
                db.Tables["Category"].Clear();
            }
            com.Fill(db, "Category");
            dgv.DataSource = db.Tables["Category"];
        }
    }
}
