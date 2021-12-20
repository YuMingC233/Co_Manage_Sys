namespace Co_Manage_Sys.InventoryPage
{
    partial class CateAddModify
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
            this.category = new System.Windows.Forms.Label();
            this.describe = new System.Windows.Forms.Label();
            this.CateNameTb = new CCWin.SkinControl.SkinWaterTextBox();
            this.DescTb = new CCWin.SkinControl.SkinWaterTextBox();
            this.submit = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(294, 60);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(67, 15);
            this.category.TabIndex = 1;
            this.category.Text = "类别名称";
            // 
            // describe
            // 
            this.describe.AutoSize = true;
            this.describe.Location = new System.Drawing.Point(324, 124);
            this.describe.Name = "describe";
            this.describe.Size = new System.Drawing.Size(37, 15);
            this.describe.TabIndex = 2;
            this.describe.Text = "描述";
            // 
            // CateNameTb
            // 
            this.CateNameTb.Location = new System.Drawing.Point(397, 57);
            this.CateNameTb.Name = "CateNameTb";
            this.CateNameTb.Size = new System.Drawing.Size(240, 25);
            this.CateNameTb.TabIndex = 5;
            this.CateNameTb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.CateNameTb.WaterText = "名称";
            // 
            // DescTb
            // 
            this.DescTb.Location = new System.Drawing.Point(397, 118);
            this.DescTb.Multiline = true;
            this.DescTb.Name = "DescTb";
            this.DescTb.Size = new System.Drawing.Size(323, 158);
            this.DescTb.TabIndex = 6;
            this.DescTb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.DescTb.WaterText = "描述";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Transparent;
            this.submit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.submit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.submit.DownBack = null;
            this.submit.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.IsDrawBorder = false;
            this.submit.IsDrawGlass = false;
            this.submit.Location = new System.Drawing.Point(513, 318);
            this.submit.MouseBack = null;
            this.submit.Name = "submit";
            this.submit.NormlBack = null;
            this.submit.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.submit.Size = new System.Drawing.Size(75, 34);
            this.submit.TabIndex = 7;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click_1);
            // 
            // CateAddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 398);
            this.ControlBox = false;
            this.Controls.Add(this.submit);
            this.Controls.Add(this.DescTb);
            this.Controls.Add(this.CateNameTb);
            this.Controls.Add(this.describe);
            this.Controls.Add(this.category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CateAddModify";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "添加";
            this.Load += new System.EventHandler(this.CateAddModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label describe;
        private CCWin.SkinControl.SkinWaterTextBox CateNameTb;
        private CCWin.SkinControl.SkinWaterTextBox DescTb;
        private CCWin.SkinControl.SkinButton submit;
    }
}