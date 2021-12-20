namespace Co_Manage_Sys.InventoryPage
{
    partial class InventoryForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Searct_Tb = new CCWin.SkinControl.SkinWaterTextBox();
            this.SearchBtn = new CCWin.SkinControl.SkinButton();
            this.AddBtn = new CCWin.SkinControl.SkinButton();
            this.DeleteBtn = new CCWin.SkinControl.SkinButton();
            this.ModifyBtn = new CCWin.SkinControl.SkinButton();
            this.dgv = new CCWin.SkinControl.SkinDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.货物ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物料名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产地 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货物总量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品牌 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Searct_Tb
            // 
            this.Searct_Tb.Location = new System.Drawing.Point(102, 34);
            this.Searct_Tb.Name = "Searct_Tb";
            this.Searct_Tb.Size = new System.Drawing.Size(221, 27);
            this.Searct_Tb.TabIndex = 8;
            this.Searct_Tb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Searct_Tb.WaterText = "支持模糊查询与ID查询";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.SearchBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.SearchBtn.DownBack = null;
            this.SearchBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.IsDrawBorder = false;
            this.SearchBtn.IsDrawGlass = false;
            this.SearchBtn.Location = new System.Drawing.Point(344, 32);
            this.SearchBtn.MouseBack = null;
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.NormlBack = null;
            this.SearchBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.SearchBtn.Size = new System.Drawing.Size(59, 30);
            this.SearchBtn.TabIndex = 9;
            this.SearchBtn.Text = "搜索";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.AddBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AddBtn.DownBack = null;
            this.AddBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.IsDrawBorder = false;
            this.AddBtn.IsDrawGlass = false;
            this.AddBtn.Location = new System.Drawing.Point(735, 34);
            this.AddBtn.MouseBack = null;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NormlBack = null;
            this.AddBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.AddBtn.Size = new System.Drawing.Size(59, 30);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "添加";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.DeleteBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.DeleteBtn.DownBack = null;
            this.DeleteBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteBtn.IsDrawBorder = false;
            this.DeleteBtn.IsDrawGlass = false;
            this.DeleteBtn.Location = new System.Drawing.Point(833, 34);
            this.DeleteBtn.MouseBack = null;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NormlBack = null;
            this.DeleteBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.DeleteBtn.Size = new System.Drawing.Size(59, 30);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModifyBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.ModifyBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ModifyBtn.DownBack = null;
            this.ModifyBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModifyBtn.ForeColor = System.Drawing.Color.White;
            this.ModifyBtn.IsDrawBorder = false;
            this.ModifyBtn.IsDrawGlass = false;
            this.ModifyBtn.Location = new System.Drawing.Point(930, 34);
            this.ModifyBtn.MouseBack = null;
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.NormlBack = null;
            this.ModifyBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.ModifyBtn.Size = new System.Drawing.Size(59, 31);
            this.ModifyBtn.TabIndex = 12;
            this.ModifyBtn.Text = "修改";
            this.ModifyBtn.UseVisualStyleBackColor = false;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnFont = null;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 26;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.货物ID,
            this.物料名称,
            this.规格,
            this.产地,
            this.类别,
            this.货物总量,
            this.单价,
            this.总金额,
            this.品牌,
            this.备注});
            this.dgv.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv.HeadFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.LineNumber = false;
            this.dgv.LineNumberForeColor = System.Drawing.Color.Black;
            this.dgv.Location = new System.Drawing.Point(25, 86);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(1012, 411);
            this.dgv.SkinGridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv.TabIndex = 13;
            this.dgv.TitleBack = null;
            this.dgv.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgv.TitleBackColorEnd = System.Drawing.Color.White;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "搜索";
            // 
            // 货物ID
            // 
            this.货物ID.DataPropertyName = "ID";
            this.货物ID.FillWeight = 30F;
            this.货物ID.HeaderText = "ID";
            this.货物ID.MinimumWidth = 6;
            this.货物ID.Name = "货物ID";
            this.货物ID.ReadOnly = true;
            // 
            // 物料名称
            // 
            this.物料名称.DataPropertyName = "Name";
            this.物料名称.FillWeight = 120F;
            this.物料名称.HeaderText = "物料名称";
            this.物料名称.MinimumWidth = 6;
            this.物料名称.Name = "物料名称";
            this.物料名称.ReadOnly = true;
            // 
            // 规格
            // 
            this.规格.DataPropertyName = "Specif";
            this.规格.FillWeight = 110F;
            this.规格.HeaderText = "规格";
            this.规格.MinimumWidth = 6;
            this.规格.Name = "规格";
            this.规格.ReadOnly = true;
            // 
            // 产地
            // 
            this.产地.DataPropertyName = "Origin";
            this.产地.FillWeight = 50F;
            this.产地.HeaderText = "产地";
            this.产地.MinimumWidth = 6;
            this.产地.Name = "产地";
            this.产地.ReadOnly = true;
            // 
            // 类别
            // 
            this.类别.DataPropertyName = "CateName";
            this.类别.FillWeight = 80.01337F;
            this.类别.HeaderText = "类别";
            this.类别.MinimumWidth = 6;
            this.类别.Name = "类别";
            this.类别.ReadOnly = true;
            // 
            // 货物总量
            // 
            this.货物总量.DataPropertyName = "Quantity";
            this.货物总量.FillWeight = 60F;
            this.货物总量.HeaderText = "货物总量";
            this.货物总量.MinimumWidth = 6;
            this.货物总量.Name = "货物总量";
            this.货物总量.ReadOnly = true;
            // 
            // 单价
            // 
            this.单价.DataPropertyName = "unitPrice";
            this.单价.FillWeight = 60F;
            this.单价.HeaderText = "单价";
            this.单价.MinimumWidth = 6;
            this.单价.Name = "单价";
            this.单价.ReadOnly = true;
            // 
            // 总金额
            // 
            this.总金额.DataPropertyName = "sumPrice";
            this.总金额.FillWeight = 80.01337F;
            this.总金额.HeaderText = "总金额(不含税)";
            this.总金额.MinimumWidth = 6;
            this.总金额.Name = "总金额";
            this.总金额.ReadOnly = true;
            // 
            // 品牌
            // 
            this.品牌.DataPropertyName = "Brand";
            this.品牌.FillWeight = 80.01337F;
            this.品牌.HeaderText = "品牌";
            this.品牌.MinimumWidth = 6;
            this.品牌.Name = "品牌";
            this.品牌.ReadOnly = true;
            this.品牌.Visible = false;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "Description";
            this.备注.FillWeight = 80.01337F;
            this.备注.HeaderText = "备注";
            this.备注.MinimumWidth = 6;
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 522);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ModifyBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Searct_Tb);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InventoryForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "货物信息";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinWaterTextBox Searct_Tb;
        private CCWin.SkinControl.SkinButton SearchBtn;
        private CCWin.SkinControl.SkinButton AddBtn;
        private CCWin.SkinControl.SkinButton DeleteBtn;
        private CCWin.SkinControl.SkinButton ModifyBtn;
        private CCWin.SkinControl.SkinDataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货物ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产地;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货物总量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品牌;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}

