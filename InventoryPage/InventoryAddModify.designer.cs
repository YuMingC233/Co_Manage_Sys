namespace Co_Manage_Sys.InventoryPage
{
    partial class InventoryAddModify
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.清除 = new System.Windows.Forms.GroupBox();
            this.BrandTb = new CCWin.SkinControl.SkinWaterTextBox();
            this.SumMoneyTb = new CCWin.SkinControl.SkinWaterTextBox();
            this.RemarkTb = new CCWin.SkinControl.SkinWaterTextBox();
            this.unitMoneyTb = new CCWin.SkinControl.SkinWaterTextBox();
            this.CategoryCb = new System.Windows.Forms.ComboBox();
            this.OriginTb = new CCWin.SkinControl.SkinWaterTextBox();
            this.SpecifTb = new CCWin.SkinControl.SkinWaterTextBox();
            this.add = new CCWin.SkinControl.SkinButton();
            this.button2 = new CCWin.SkinControl.SkinButton();
            this.NameTb = new CCWin.SkinControl.SkinWaterTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BasicInfoGroup = new System.Windows.Forms.GroupBox();
            this.AddedValueTb = new CCWin.SkinControl.SkinWaterTextBox();
            this.QuantityTb = new System.Windows.Forms.NumericUpDown();
            this.unitMeasureCb = new System.Windows.Forms.ComboBox();
            this.清除.SuspendLayout();
            this.BasicInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTb)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "类别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "规格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "产地";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "货物总量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "单价";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "总金额";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "品牌";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "备注";
            // 
            // 清除
            // 
            this.清除.Controls.Add(this.BrandTb);
            this.清除.Controls.Add(this.SumMoneyTb);
            this.清除.Controls.Add(this.label8);
            this.清除.Controls.Add(this.RemarkTb);
            this.清除.Controls.Add(this.unitMoneyTb);
            this.清除.Controls.Add(this.label9);
            this.清除.Controls.Add(this.label11);
            this.清除.Controls.Add(this.label12);
            this.清除.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.清除.Location = new System.Drawing.Point(227, 365);
            this.清除.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.清除.Name = "清除";
            this.清除.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.清除.Size = new System.Drawing.Size(529, 302);
            this.清除.TabIndex = 25;
            this.清除.TabStop = false;
            this.清除.Text = "货物价值相关（可为空）";
            // 
            // BrandTb
            // 
            this.BrandTb.Location = new System.Drawing.Point(204, 152);
            this.BrandTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrandTb.Name = "BrandTb";
            this.BrandTb.Size = new System.Drawing.Size(234, 27);
            this.BrandTb.TabIndex = 8;
            this.BrandTb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.BrandTb.WaterText = "";
            // 
            // SumMoneyTb
            // 
            this.SumMoneyTb.Location = new System.Drawing.Point(204, 96);
            this.SumMoneyTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SumMoneyTb.Name = "SumMoneyTb";
            this.SumMoneyTb.ReadOnly = true;
            this.SumMoneyTb.Size = new System.Drawing.Size(234, 27);
            this.SumMoneyTb.TabIndex = 0;
            this.SumMoneyTb.TabStop = false;
            this.SumMoneyTb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SumMoneyTb.WaterText = "";
            // 
            // RemarkTb
            // 
            this.RemarkTb.Location = new System.Drawing.Point(204, 203);
            this.RemarkTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemarkTb.Multiline = true;
            this.RemarkTb.Name = "RemarkTb";
            this.RemarkTb.Size = new System.Drawing.Size(234, 86);
            this.RemarkTb.TabIndex = 9;
            this.RemarkTb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.RemarkTb.WaterText = "";
            // 
            // unitMoneyTb
            // 
            this.unitMoneyTb.Location = new System.Drawing.Point(204, 40);
            this.unitMoneyTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unitMoneyTb.Name = "unitMoneyTb";
            this.unitMoneyTb.Size = new System.Drawing.Size(234, 27);
            this.unitMoneyTb.TabIndex = 7;
            this.unitMoneyTb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.unitMoneyTb.WaterText = "";
            this.unitMoneyTb.TextChanged += new System.EventHandler(this.unit1_TextChanged);
            this.unitMoneyTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unit1_KeyPress);
            // 
            // CategoryCb
            // 
            this.CategoryCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCb.FormattingEnabled = true;
            this.CategoryCb.Location = new System.Drawing.Point(204, 267);
            this.CategoryCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategoryCb.Name = "CategoryCb";
            this.CategoryCb.Size = new System.Drawing.Size(234, 28);
            this.CategoryCb.TabIndex = 6;
            // 
            // OriginTb
            // 
            this.OriginTb.Location = new System.Drawing.Point(204, 217);
            this.OriginTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OriginTb.Name = "OriginTb";
            this.OriginTb.Size = new System.Drawing.Size(234, 27);
            this.OriginTb.TabIndex = 5;
            this.OriginTb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.OriginTb.WaterText = "";
            // 
            // SpecifTb
            // 
            this.SpecifTb.Location = new System.Drawing.Point(204, 88);
            this.SpecifTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpecifTb.Name = "SpecifTb";
            this.SpecifTb.Size = new System.Drawing.Size(112, 27);
            this.SpecifTb.TabIndex = 2;
            this.SpecifTb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SpecifTb.WaterText = "";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.add.DownBack = null;
            this.add.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.IsDrawBorder = false;
            this.add.IsDrawGlass = false;
            this.add.Location = new System.Drawing.Point(412, 691);
            this.add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add.MouseBack = null;
            this.add.Name = "add";
            this.add.NormlBack = null;
            this.add.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.add.Size = new System.Drawing.Size(70, 30);
            this.add.TabIndex = 10;
            this.add.Text = "提交";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.button2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button2.DownBack = null;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IsDrawBorder = false;
            this.button2.IsDrawGlass = false;
            this.button2.Location = new System.Drawing.Point(521, 691);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.MouseBack = null;
            this.button2.Name = "button2";
            this.button2.NormlBack = null;
            this.button2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.button2.Size = new System.Drawing.Size(70, 30);
            this.button2.TabIndex = 11;
            this.button2.TabStop = false;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(204, 41);
            this.NameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(234, 27);
            this.NameTb.TabIndex = 1;
            this.NameTb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.NameTb.WaterText = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "物料名称";
            // 
            // BasicInfoGroup
            // 
            this.BasicInfoGroup.Controls.Add(this.AddedValueTb);
            this.BasicInfoGroup.Controls.Add(this.QuantityTb);
            this.BasicInfoGroup.Controls.Add(this.unitMeasureCb);
            this.BasicInfoGroup.Controls.Add(this.CategoryCb);
            this.BasicInfoGroup.Controls.Add(this.label2);
            this.BasicInfoGroup.Controls.Add(this.NameTb);
            this.BasicInfoGroup.Controls.Add(this.label6);
            this.BasicInfoGroup.Controls.Add(this.label3);
            this.BasicInfoGroup.Controls.Add(this.OriginTb);
            this.BasicInfoGroup.Controls.Add(this.label5);
            this.BasicInfoGroup.Controls.Add(this.SpecifTb);
            this.BasicInfoGroup.Controls.Add(this.label4);
            this.BasicInfoGroup.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BasicInfoGroup.Location = new System.Drawing.Point(227, 24);
            this.BasicInfoGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BasicInfoGroup.Name = "BasicInfoGroup";
            this.BasicInfoGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BasicInfoGroup.Size = new System.Drawing.Size(529, 322);
            this.BasicInfoGroup.TabIndex = 24;
            this.BasicInfoGroup.TabStop = false;
            this.BasicInfoGroup.Text = "货物基本信息";
            // 
            // AddedValueTb
            // 
            this.AddedValueTb.Location = new System.Drawing.Point(204, 123);
            this.AddedValueTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddedValueTb.Name = "AddedValueTb";
            this.AddedValueTb.Size = new System.Drawing.Size(234, 27);
            this.AddedValueTb.TabIndex = 3;
            this.AddedValueTb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AddedValueTb.WaterText = "";
            // 
            // QuantityTb
            // 
            this.QuantityTb.Location = new System.Drawing.Point(204, 167);
            this.QuantityTb.Name = "QuantityTb";
            this.QuantityTb.Size = new System.Drawing.Size(113, 27);
            this.QuantityTb.TabIndex = 4;
            this.QuantityTb.ThousandsSeparator = true;
            this.QuantityTb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // unitMeasureCb
            // 
            this.unitMeasureCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitMeasureCb.FormattingEnabled = true;
            this.unitMeasureCb.Items.AddRange(new object[] {
            "/瓶",
            "g/瓶",
            "/包",
            "/袋",
            "/kg",
            "自定义"});
            this.unitMeasureCb.Location = new System.Drawing.Point(323, 88);
            this.unitMeasureCb.Name = "unitMeasureCb";
            this.unitMeasureCb.Size = new System.Drawing.Size(115, 28);
            this.unitMeasureCb.TabIndex = 0;
            this.unitMeasureCb.TabStop = false;
            // 
            // InventoryAddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 750);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.清除);
            this.Controls.Add(this.BasicInfoGroup);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InventoryAddModify";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "添加";
            this.Load += new System.EventHandler(this.InventoryAddModify_Load);
            this.清除.ResumeLayout(false);
            this.清除.PerformLayout();
            this.BasicInfoGroup.ResumeLayout(false);
            this.BasicInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox 清除;
        private CCWin.SkinControl.SkinWaterTextBox BrandTb;
        private CCWin.SkinControl.SkinWaterTextBox SumMoneyTb;
        private CCWin.SkinControl.SkinWaterTextBox unitMoneyTb;
        private CCWin.SkinControl.SkinWaterTextBox RemarkTb;
        private CCWin.SkinControl.SkinWaterTextBox OriginTb;
        private CCWin.SkinControl.SkinWaterTextBox SpecifTb;
        private CCWin.SkinControl.SkinButton add;
        private CCWin.SkinControl.SkinButton button2;
        private System.Windows.Forms.ComboBox CategoryCb;
        private CCWin.SkinControl.SkinWaterTextBox NameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox BasicInfoGroup;
        private System.Windows.Forms.NumericUpDown QuantityTb;
        private System.Windows.Forms.ComboBox unitMeasureCb;
        private CCWin.SkinControl.SkinWaterTextBox AddedValueTb;
    }
}