namespace Co_Manage_Sys.InventoryPage
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTb = new CCWin.SkinControl.SkinWaterTextBox();
            this.AddBtn = new CCWin.SkinControl.SkinButton();
            this.delete1 = new CCWin.SkinControl.SkinButton();
            this.ModifyBtn = new CCWin.SkinControl.SkinButton();
            this.SearchBtn = new CCWin.SkinControl.SkinButton();
            this.dgv = new CCWin.SkinControl.SkinDataGridView();
            this.类别名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.描述 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "类别名称";
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(126, 28);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(213, 25);
            this.SearchTb.TabIndex = 7;
            this.SearchTb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SearchTb.WaterText = "输入类别名称";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.AddBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AddBtn.DownBack = null;
            this.AddBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.IsDrawBorder = false;
            this.AddBtn.IsDrawGlass = false;
            this.AddBtn.Location = new System.Drawing.Point(744, 25);
            this.AddBtn.MouseBack = null;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NormlBack = null;
            this.AddBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.AddBtn.Size = new System.Drawing.Size(69, 30);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "添加";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // delete1
            // 
            this.delete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete1.BackColor = System.Drawing.Color.Transparent;
            this.delete1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.delete1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.delete1.DownBack = null;
            this.delete1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.delete1.ForeColor = System.Drawing.Color.White;
            this.delete1.IsDrawBorder = false;
            this.delete1.IsDrawGlass = false;
            this.delete1.Location = new System.Drawing.Point(938, 25);
            this.delete1.MouseBack = null;
            this.delete1.Name = "delete1";
            this.delete1.NormlBack = null;
            this.delete1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.delete1.Size = new System.Drawing.Size(69, 30);
            this.delete1.TabIndex = 9;
            this.delete1.Text = "删除";
            this.delete1.UseVisualStyleBackColor = false;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModifyBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.ModifyBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ModifyBtn.DownBack = null;
            this.ModifyBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.ModifyBtn.ForeColor = System.Drawing.Color.White;
            this.ModifyBtn.IsDrawBorder = false;
            this.ModifyBtn.IsDrawGlass = false;
            this.ModifyBtn.Location = new System.Drawing.Point(842, 25);
            this.ModifyBtn.MouseBack = null;
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.NormlBack = null;
            this.ModifyBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.ModifyBtn.Size = new System.Drawing.Size(69, 30);
            this.ModifyBtn.TabIndex = 10;
            this.ModifyBtn.Text = "修改";
            this.ModifyBtn.UseVisualStyleBackColor = false;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.SearchBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.SearchBtn.DownBack = null;
            this.SearchBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.IsDrawBorder = false;
            this.SearchBtn.IsDrawGlass = false;
            this.SearchBtn.Location = new System.Drawing.Point(357, 25);
            this.SearchBtn.MouseBack = null;
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.NormlBack = null;
            this.SearchBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.SearchBtn.Size = new System.Drawing.Size(65, 30);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.Text = "搜索";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.类别名称,
            this.描述});
            this.dgv.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dgv.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv.HeadFont = new System.Drawing.Font("微软雅黑", 9.5F);
            this.dgv.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.LineNumberForeColor = System.Drawing.Color.Black;
            this.dgv.Location = new System.Drawing.Point(23, 83);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(1012, 378);
            this.dgv.SkinGridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv.TabIndex = 12;
            this.dgv.TitleBack = null;
            this.dgv.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgv.TitleBackColorEnd = System.Drawing.Color.White;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.display_CellContentClick);
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.display_CellMouseClick);
            // 
            // 类别名称
            // 
            this.类别名称.DataPropertyName = "CateName";
            this.类别名称.HeaderText = "类别名称";
            this.类别名称.MinimumWidth = 6;
            this.类别名称.Name = "类别名称";
            // 
            // 描述
            // 
            this.描述.DataPropertyName = "Description";
            this.描述.HeaderText = "描述";
            this.描述.MinimumWidth = 6;
            this.描述.Name = "描述";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 485);
            this.ControlBox = false;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ModifyBtn);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CategoryForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "货物分类";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinWaterTextBox SearchTb;
        private CCWin.SkinControl.SkinButton AddBtn;
        private CCWin.SkinControl.SkinButton delete1;
        private CCWin.SkinControl.SkinButton ModifyBtn;
        private CCWin.SkinControl.SkinButton SearchBtn;
        private CCWin.SkinControl.SkinDataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 描述;
    }
}