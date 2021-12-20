using Co_Manage_Sys.Aiden_Connor;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Co_Manage_Sys.InventoryPage
{
    public partial class InventoryForm : Form
    {
        private Main_Form mfa;
        //连接数据库
        DBLink db = new DBLink();
        DataSet sb = new DataSet();
        SqlDataAdapter adapt;
        int mouseX = 0;
        int mouseY = 0;
        DialogResult RSS;

        public InventoryForm(Main_Form mfa)
        {
            this.mfa = mfa;
            InitializeComponent();
        }


        /// <summary>
        /// 数据初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Bind();
        }

        /// <summary>
        /// dgv绑定数据
        /// </summary>
        private void Bind()
        {
            db.OpenConnection();
            string sqlste = "select * from Inventory";
            adapt = new SqlDataAdapter(sqlste, db.Connection);

            if (sb.Tables["Inventory"] != null)
            {
                sb.Tables["Inventory"].Clear();
            }

            adapt.Fill(sb, "Inventory");

            if (sb.Tables["Inventory"].Columns.Count != 13)
            {
                //为已有DataTable添加一新列
                DataColumn dc = new DataColumn("操作", typeof(string));
                dc.DefaultValue = "编辑 | 删除";
                dc.ReadOnly = true;
                sb.Tables["Inventory"].Columns.Add(dc);
            }
            dgv.DataSource = sb.Tables["Inventory"];
            db.CloseConnection();
        }

        /// <summary>
        /// 添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            mfa.SwitchPage_CargoInfo("", 1);
        }

        /// <summary>
        /// 修改按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            int RowIndex = dgv.CurrentRow.Index;
            string ClientName = dgv[0, RowIndex].Value.ToString();
            mfa.SwitchPage_CargoInfo(ClientName, 2);
        }

        /// <summary>
        /// 删除按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否删除？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (Delete() > 0)
                {
                    Bind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("删除失败!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 删除信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否删除？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Delete() > 0)
                    Bind();
                else
                    MessageBox.Show("数据删除出错！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 删除方法
        /// </summary>
        /// <returns></returns>
        public int Delete()
        {
            int RowIndex = dgv.CurrentRow.Index;
            string ClientName = dgv[0, RowIndex].Value.ToString();
            try
            {
                string sql = string.Format("delete Inventory where ID = {0}",
                                           ClientName);
                db.OpenConnection();
                SqlCommand com = new SqlCommand(sql, db.Connection);
                int a = com.ExecuteNonQuery();
                if (a > 0)
                    return a;
                else
                    return -1;
            }
            catch (Exception)
            {
                return -1;
                throw;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        /// <summary>
        /// 搜索按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (sb.Tables["Cargo_Info"] != null)
            {
                sb.Tables["Cargo_Info"].Clear();
            }
            string tempText = Searct_Tb.Text.ToString().Trim();
            int outTempText;
            if (int.TryParse(tempText, out outTempText))
            {
                Search(tempText);
            }
            else
            {
                Search();
            }
        }

        /// <summary>
        /// 查询方法
        /// </summary>
        public void Search()
        {
            db.OpenConnection();
            string sqlste = string.Format(
                            "select * " +
                            "from Inventory " +
                            "where Name like '%{0}%' or Origin like '%{0}%' or " +
                            "Specif like '%{0}%' or CateName like '%{0}%'", Searct_Tb.Text);
            adapt = new SqlDataAdapter(sqlste, db.Connection);

            if (sb.Tables["Inventory"] != null)
            {
                sb.Tables["Inventory"].Clear();
            }

            adapt.Fill(sb, "Inventory");
            dgv.DataSource = sb.Tables["Inventory"];
            db.CloseConnection();
        }


        /// <summary>
        /// 查询方法
        /// </summary>
        public void Search(string tempSearchText)
        {
            db.OpenConnection();
            string sqlste = string.Format(
                            "select * " +
                            "from Inventory " +
                            "where ID = {0}", tempSearchText);
            adapt = new SqlDataAdapter(sqlste, db.Connection);
            if (sb.Tables["Inventory"] != null)
            {
                sb.Tables["Inventory"].Clear();
            }
            adapt.Fill(sb, "Inventory");
            dgv.DataSource = sb.Tables["Inventory"];
            db.CloseConnection();
        }

        /// <summary>
        /// 点击单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                            mfa.SwitchPage_CargoInfo(_UID, 2);
                        }
                        else if (rc.Width > mouseX && mouseX > rc.Width / 2)
                        {
                            #region 删除选中的行

                            //获取在同一行第一列的单元格中的字段值 
                            string _UID = dgv[0, e.RowIndex].Value.ToString();
                            string _Uname = dgv[1, e.RowIndex].Value.ToString();
                            RSS = MessageBox.Show(this, "确定要删除选中行( 货物ID为" + _UID + "：,名称为：" + _Uname + " )的货物？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            switch (RSS)
                            {
                                case DialogResult.Yes:
                                    if (Delete() > 0)
                                        MessageBox.Show("成功删除选中行数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Bind();
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
        /// 点击单元格获取鼠标位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
    }
}
