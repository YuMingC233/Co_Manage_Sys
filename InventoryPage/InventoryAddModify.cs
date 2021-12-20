using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Co_Manage_Sys.InventoryPage
{
    public partial class InventoryAddModify : Form
    {
        public bool isModify;
        public int InvID;
        string sqlstr;
        string[] TextBoxContent = new string[9];
        SqlDataAdapter adapt;
        public InventoryAddModify()
        {
            InitializeComponent();
        }
        DBLink er = new DBLink();//连接数据库

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventoryAddModify_Load(object sender, EventArgs e)
        {
            
            ComboBoxBind();
            if (isModify)
            {
                // 修改
                Text = "修改";
                modification();
                NameTb.WaterText = null;
                SpecifTb.WaterText = null;
                AddedValueTb.WaterText = null;
                OriginTb.WaterText = null;
                unitMoneyTb.WaterText = null;
                BrandTb.WaterText = null;
                RemarkTb.WaterText = null;
                unitMeasureCb.SelectedIndex = unitMeasureCb.Items.Count - 1;
            }
            else
            {
                // 添加
                NameTb.WaterText = "请输入货物名称";
                CategoryCb.SelectedIndex = 0;
                unitMeasureCb.SelectedIndex = 0;
                SpecifTb.WaterText = "请输入规格（如50ml，50kg）";
                AddedValueTb.WaterText = "此为附加规格，可选输入";
                OriginTb.WaterText = "请输入产地";
                unitMoneyTb.WaterText = "请输入单价";
                BrandTb.WaterText = "输入产品品牌";
                RemarkTb.WaterText = "输入备注";
            }
        }


        /// <summary>
        /// 赋初值
        /// </summary>
        public void modification()
        {
            er.OpenConnection();
            sqlstr = string.Format("select Name, Specif, Origin, CateName, Quantity, unitPrice, sumPrice, Brand, Description " +
                                   "from Inventory " +
                                   "where ID = {0}", InvID);
            SqlCommand smn = new SqlCommand(sqlstr, er.Connection);
            SqlDataReader read = smn.ExecuteReader();
            while (read.Read())
            {
                NameTb.Text = read[0].ToString();
                SpecifTb.Text = read[1].ToString();
                OriginTb.Text = read[2].ToString();
                CategoryCb.Text = read[3].ToString();
                QuantityTb.Text = read[4].ToString();
                unitMoneyTb.Text = read[5].ToString();
                SumMoneyTb.Text = read[6].ToString();
                BrandTb.Text = read[7].ToString();
                RemarkTb.Text = read[8].ToString();
            }
            er.CloseConnection();
        }

        /// <summary>
        /// 修改数据库中的数据
        /// </summary>
        public void amend()
        {
            SqlCommand smn;
            try
            {
                er.OpenConnection();
                sqlstr = string.Format("update Inventory " +
                                       "set Name = '{0}', Specif = '{1}', Origin = '{2}', CateName = '{3}', Quantity = {4}," +
                                       "unitPrice = {5}, sumPrice = {6}, Brand = '{7}', Description = '{8}' " +
                                       "where ID = {9}"
                                       , TextBoxContent[0], TextBoxContent[2], TextBoxContent[3], TextBoxContent[1], 
                                         TextBoxContent[4], TextBoxContent[5], TextBoxContent[6], TextBoxContent[7],
                                         TextBoxContent[8], InvID);
                smn = new SqlCommand(sqlstr, er.Connection);
                int num = smn.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("修改成功!","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("出现错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void GetTbText()
        {
            TextBoxContent[0] = NameTb.Text.Trim();                 // 名称
            TextBoxContent[1] = CategoryCb.Text.Trim();     // 类别
            if (unitMeasureCb.SelectedIndex == unitMeasureCb.Items.Count - 1)
                TextBoxContent[2] = SpecifTb.Text.Trim();               // 规格
            else
                TextBoxContent[2] = SpecifTb.Text.Trim() + unitMeasureCb.Text;               // 规格
            if (AddedValueTb.TextLength != 0)
                TextBoxContent[2] += "（" + AddedValueTb.Text.Trim() + "）";
            TextBoxContent[3] = OriginTb.Text.Trim();               // 产地
            TextBoxContent[4] = QuantityTb.Text.Trim();             // 总量
            TextBoxContent[5] = unitMoneyTb.Text.Trim();            // 单价
            TextBoxContent[7] = BrandTb.Text.Trim();                // 品牌
            TextBoxContent[8] = RemarkTb.Text.Trim();               // 备注
        }

        /// <summary>
        /// 检查必要输入框中是否有留空与是否重复
        /// </summary>
        /// <returns></returns>
        public bool empty()
        {
            if (TextBoxContent[0].Equals(""))
            {
                MessageBox.Show("物料名称不能为空!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (CategoryCb.SelectedIndex == 0)
            {
                MessageBox.Show("请选择类别!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (TextBoxContent[2].Equals(""))
            {
                MessageBox.Show("规格不能为空!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (TextBoxContent[4].Equals(""))
            {
                MessageBox.Show("货物总量不能为空!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (repetition())
            {
                MessageBox.Show("物料名称和规格与数据库重复,请在修改页中修改已有信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;
            }
            else
                return true;
        }
        
        /// <summary>
        /// 查找数据库中是否有相同名称与规格的货物
        /// </summary>
        /// <returns></returns>
        public bool repetition()
        {
            GetTbText();
            er.OpenConnection();
            sqlstr = string.Format("select COUNT(*) " +
                                   "from Inventory " +
                                   "where Name = '{0}' and Specif = '{1}' and Origin = '{2}'", TextBoxContent[0], TextBoxContent[2], TextBoxContent[3]);
            SqlCommand smn = new SqlCommand(sqlstr, er.Connection);
            int shu = (int)smn.ExecuteScalar();
            if (shu > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// 下拉框绑定值
        /// </summary>
        public void ComboBoxBind()
        {
            try
            {
                DataSet ds = new DataSet();
                string sqlCode = "select CateName from Category";
                adapt = new SqlDataAdapter(sqlCode, er.Connection);
                adapt.Fill(ds, "Category");

                DataRow dr = ds.Tables["Category"].NewRow();
                dr[0] = "请选择";

                ds.Tables["Category"].Rows.InsertAt(dr, 0);

                CategoryCb.DataSource = ds.Tables["Category"];
                CategoryCb.DisplayMember = "CateName";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                er.CloseConnection();
            }
        }

        /// <summary>
        /// 添加货物
        /// </summary>
        public void append()
        {
            if (TextBoxContent[5].Equals(string.Empty) || TextBoxContent[6].Equals(string.Empty))
            {
                er.OpenConnection();
                sqlstr = string.Format("insert into Inventory(Name, Specif, Origin, CateName, Quantity, unitPrice, sumPrice, Brand, Description) " +
                                       "values('{0}','{1}','{2}','{3}',{4},{5}, {6},'{7}','{8}')"
                                       , TextBoxContent[0], TextBoxContent[2], TextBoxContent[3], TextBoxContent[1], TextBoxContent[4], 0, 0, TextBoxContent[7], TextBoxContent[8]);
                SqlCommand smn = new SqlCommand(sqlstr, er.Connection);
                int shu = smn.ExecuteNonQuery();
                if (shu > 0)
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTb();
                }
                else
                {
                    MessageBox.Show("添加失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                er.OpenConnection();
                sqlstr = string.Format("insert into Inventory(Name, Specif, Origin, CateName, Quantity, unitPrice, sumPrice, Brand, Description) " +
                                       "values('{0}','{1}','{2}','{3}',{4},{5}, {6},'{7}','{8}')"
                                       , TextBoxContent[0], TextBoxContent[2], TextBoxContent[3], TextBoxContent[1], TextBoxContent[4], TextBoxContent[5], TextBoxContent[6],
                                         TextBoxContent[7], TextBoxContent[8]);
                SqlCommand smn = new SqlCommand(sqlstr, er.Connection);
                int shu = smn.ExecuteNonQuery();
                if (shu > 0)
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTb();
                }
                else
                {
                    MessageBox.Show("添加失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        //
        /// <summary>
        /// 计算总金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unit1_TextChanged(object sender, EventArgs e)
        {
            GetTbText();
            if (!TextBoxContent[4].Equals(string.Empty) && !TextBoxContent[5].Equals(string.Empty))
            {
                SumMoneyTb.Text = Convert.ToString(Convert.ToDouble(QuantityTb.Text) * Convert.ToDouble(unitMoneyTb.Text));
            }
            TextBoxContent[6] = SumMoneyTb.Text;
        }

        /// <summary>
        /// 判断是添加还是修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, EventArgs e)
        {
            GetTbText();
            if (isModify && empty())
            {
                amend();
            }
            else if (empty())
            {
                append();
            }
        }
        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            ClearTb();
        }

        private void ClearTb()
        {
            NameTb.Text = "";
            CategoryCb.SelectedIndex = 0;
            unitMeasureCb.SelectedIndex = 0;
            SpecifTb.Text = "";
            AddedValueTb.Text = string.Empty;
            OriginTb.Text = "";
            QuantityTb.Value = 1;
            unitMoneyTb.Text = "";
            BrandTb.Text = "";
            RemarkTb.Text = "";
            SumMoneyTb.Text = "";
        }

        /// <summary>
        /// 限制输入的字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
            //小数点的处理。
            if (e.KeyChar == 46)                           //小数点
            {
                if (unitMoneyTb.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(unitMoneyTb.Text, out oldf);
                    b2 = float.TryParse(unitMoneyTb.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
        /// <summary>
        /// 限制输入的字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8) // 如果按下的键位为数字或退格键，执行代码块
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
    }
}
