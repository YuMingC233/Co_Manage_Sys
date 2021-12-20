using CCWin;
using Co_Manage_Sys.InventoryPage;
using System;
using System.Windows.Forms;

namespace Co_Manage_Sys
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class Main_Form : CCSkinMain
    {
        /// <summary>
        /// 声明用户名称变量
        /// </summary>
        public string ID;
        public string[] OrderId = new string[2]; 

        public Main_Form()
        {
            InitializeComponent();
        }

        #region 此窗体控件事件

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_Admin_Load(object sender, EventArgs e)
        {
            TabShow.SelectedIndex = 0;
            Cargo_TabC.SelectedIndex = 0;
            JudgeTab();
        }

        /// <summary>
        /// 当窗体关闭时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// 点击关闭按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Close();        // 关闭窗口
        }

        /// <summary>
        /// 点击最大化按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaxWin_Btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;        // 最大化窗体
            MaxWin_Btn.Visible = false;                     // 将最大化按钮的显示状态设置为隐藏
        }

        /// <summary>
        /// 点击还原页面大小按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NormalWin_Btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;           // 还原窗体
            MaxWin_Btn.Visible = true;                      // 将最大化按钮的显示状态设置为显示
        }

        /// <summary>
        /// 点击最小化按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Min_Btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;           // 最小化窗体
            MaxWin_Btn.Visible = true;                      // 将最大化按钮的显示状态设置为显示
        }
        #endregion

        #region 选择TabPage显示控件事件
        TabPage tab;

        /// <summary>
        /// 第一层Tab Page切换事件
        /// </summary>
        public void JudgeTab()
        {
            tab = Cargo_TabC.TabPages[0];
            tab.Controls.Clear();// 移除子页中的所有控件
            InventoryForm _if = new InventoryForm(this);
            _if.FormBorderStyle = FormBorderStyle.None;
            _if.TopLevel = false;
            _if.Dock = DockStyle.Fill;
            tab.Controls.Add(_if);
            _if.WindowState = FormWindowState.Maximized;//如果windowState设置为最大化，添加到tabPage中时，winform不会显示出来
            _if.Show();
        }

        private void TabShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            JudgeTab();
        }

        #endregion

        #region 子选项卡中的所有选择显示事件

        /// <summary>
        /// 货物标签页切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cargo_TabC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Choice = Cargo_TabC.SelectedIndex;
            if (Choice == 0)
            {
                tab = Cargo_TabC.TabPages[0];
                tab.Controls.Clear();               // 移除子页中的所有控件
                InventoryForm Inf = new InventoryForm(this);
                Inf.FormBorderStyle = FormBorderStyle.None;
                Inf.TopLevel = false;
                Inf.Dock = DockStyle.Fill;
                tab.Controls.Add(Inf);
                Inf.WindowState = FormWindowState.Maximized;//如果windowState设置为最大化，添加到tabPage中时，winform不会显示出来
                Inf.Show();
            }
            else if (Choice == 1)
            {
                tab = Cargo_TabC.TabPages[1];
                tab.Controls.Clear();               // 移除子页中的所有控件
                InventoryAddModify iam = new InventoryAddModify();
                iam.isModify = false;
                iam.FormBorderStyle = FormBorderStyle.None;
                iam.TopLevel = false;
                iam.Dock = DockStyle.Fill;
                tab.Controls.Add(iam);
                iam.WindowState = FormWindowState.Maximized;//如果windowState设置为最大化，添加到tabPage中时，winform不会显示出来
                iam.Show();
            }
            else if (Choice == 2)
            {
                int a = 0;
                tab = Cargo_TabC.TabPages[2];
                tab.Controls.Clear();               // 移除子页中的所有控件
                if (int.TryParse(ID, out a) == false || ID.Equals(string.Empty))
                {
                    MessageBox.Show("请在货物列表中选择货物！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cargo_TabC.SelectedIndex = 0;
                }
                else
                {
                    InventoryAddModify scma = new InventoryAddModify();
                    scma.isModify = true;
                    scma.InvID = Convert.ToInt32(ID);
                    scma.FormBorderStyle = FormBorderStyle.None;
                    scma.TopLevel = false;
                    scma.Dock = DockStyle.Fill;
                    tab.Controls.Add(scma);
                    scma.WindowState = FormWindowState.Maximized;//如果windowState设置为最大化，添加到tabPage中时，winform不会显示出来
                    scma.Show();
                }
            }
            else if (Choice == 3)
            {
                tab = Cargo_TabC.TabPages[3];
                tab.Controls.Clear();               // 移除子页中的所有控件
                CategoryForm cf = new CategoryForm(this);
                cf.FormBorderStyle = FormBorderStyle.None;
                cf.TopLevel = false;
                cf.Dock = DockStyle.Fill;
                tab.Controls.Add(cf);
                cf.WindowState = FormWindowState.Maximized;//如果windowState设置为最大化，添加到tabPage中时，winform不会显示出来
                cf.Show();
            }
            else if (Choice == 4)
            {
                tab = Cargo_TabC.TabPages[4];
                tab.Controls.Clear();               // 移除子页中的所有控件
                CateAddModify cam = new CateAddModify();
                cam.isModify = false;
                cam.FormBorderStyle = FormBorderStyle.None;
                cam.TopLevel = false;
                cam.Dock = DockStyle.Fill;
                tab.Controls.Add(cam);
                cam.WindowState = FormWindowState.Maximized;//如果windowState设置为最大化，添加到tabPage中时，winform不会显示出来
                cam.Show();
            }
            else if (Choice == 5)
            {
                int a = 0;
                tab = Cargo_TabC.TabPages[5];
                tab.Controls.Clear();               // 移除子页中的所有控件
                if (int.TryParse(ID, out a) == true || ID == null)
                {
                    MessageBox.Show("请在类别列表中选择类别！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cargo_TabC.SelectedIndex = 3;
                }
                else
                {
                    CateAddModify er = new CateAddModify();
                    er.isModify = true;
                    er.TempCateName = ID;
                    er.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    er.TopLevel = false;
                    er.Dock = DockStyle.Fill;
                    tab.Controls.Add(er);
                    er.WindowState = FormWindowState.Maximized;//如果windowState设置为最大化，添加到tabPage中时，winform不会显示出来
                    er.Show();
                }
            }
        }
        #endregion

        #region 页面切换方法

        /// <summary>
        /// 货物管理切换页面
        /// </summary>
        /// <param name="ID">传入的货物ID</param>
        /// <param name="PageNum">标签页码</param>
        public void SwitchPage_CargoInfo(string ID, int PageNum)
        {
            this.ID = ID;
            Cargo_TabC.SelectedIndex = PageNum;
        }

        #endregion
    }
}
