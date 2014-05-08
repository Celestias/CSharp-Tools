namespace WoW_Web_API_Tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GETBtn = new System.Windows.Forms.Button();
            this.EnterIdTb = new System.Windows.Forms.TextBox();
            this.GetControllerUD = new System.Windows.Forms.NumericUpDown();
            this.ApiSelectCbo = new System.Windows.Forms.ComboBox();
            this.userLbl1 = new System.Windows.Forms.Label();
            this.RndIdCb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultRptTb = new System.Windows.Forms.TextBox();
            this.ResetRptBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GetControllerUD)).BeginInit();
            this.SuspendLayout();
            // 
            // GETBtn
            // 
            this.GETBtn.Location = new System.Drawing.Point(13, 152);
            this.GETBtn.Name = "GETBtn";
            this.GETBtn.Size = new System.Drawing.Size(101, 23);
            this.GETBtn.TabIndex = 4;
            this.GETBtn.Text = "Send GET";
            this.GETBtn.UseVisualStyleBackColor = true;
            this.GETBtn.Click += new System.EventHandler(this.GetRequest_Click);
            // 
            // EnterIdTb
            // 
            this.EnterIdTb.Location = new System.Drawing.Point(13, 75);
            this.EnterIdTb.MaxLength = 99999;
            this.EnterIdTb.Name = "EnterIdTb";
            this.EnterIdTb.Size = new System.Drawing.Size(120, 20);
            this.EnterIdTb.TabIndex = 2;
            // 
            // GetControllerUD
            // 
            this.GetControllerUD.Location = new System.Drawing.Point(14, 126);
            this.GetControllerUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.GetControllerUD.Name = "GetControllerUD";
            this.GetControllerUD.Size = new System.Drawing.Size(120, 20);
            this.GetControllerUD.TabIndex = 3;
            this.GetControllerUD.ValueChanged += new System.EventHandler(this.GetControllerUD_ValueChanged);
            // 
            // ApiSelectCbo
            // 
            this.ApiSelectCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApiSelectCbo.FormattingEnabled = true;
            this.ApiSelectCbo.Items.AddRange(new object[] {
            "Item",
            "Item Set"});
            this.ApiSelectCbo.Location = new System.Drawing.Point(12, 28);
            this.ApiSelectCbo.Name = "ApiSelectCbo";
            this.ApiSelectCbo.Size = new System.Drawing.Size(121, 21);
            this.ApiSelectCbo.TabIndex = 1;
            // 
            // userLbl1
            // 
            this.userLbl1.AutoSize = true;
            this.userLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl1.Location = new System.Drawing.Point(15, 56);
            this.userLbl1.Name = "userLbl1";
            this.userLbl1.Size = new System.Drawing.Size(99, 13);
            this.userLbl1.TabIndex = 5;
            this.userLbl1.Text = "Enter an Item Id | or";
            // 
            // RndIdCb
            // 
            this.RndIdCb.AutoSize = true;
            this.RndIdCb.Location = new System.Drawing.Point(141, 55);
            this.RndIdCb.Name = "RndIdCb";
            this.RndIdCb.Size = new System.Drawing.Size(91, 17);
            this.RndIdCb.TabIndex = 6;
            this.RndIdCb.Text = "Randomize Id";
            this.RndIdCb.UseVisualStyleBackColor = true;
            this.RndIdCb.CheckedChanged += new System.EventHandler(this.RndIdCb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Specify number of GET requests";
            // 
            // ResultRptTb
            // 
            this.ResultRptTb.Location = new System.Drawing.Point(10, 189);
            this.ResultRptTb.Multiline = true;
            this.ResultRptTb.Name = "ResultRptTb";
            this.ResultRptTb.ReadOnly = true;
            this.ResultRptTb.Size = new System.Drawing.Size(212, 88);
            this.ResultRptTb.TabIndex = 7;
            this.ResultRptTb.Text = "Results:";
            // 
            // ResetRptBtn
            // 
            this.ResetRptBtn.Location = new System.Drawing.Point(122, 152);
            this.ResetRptBtn.Name = "ResetRptBtn";
            this.ResetRptBtn.Size = new System.Drawing.Size(102, 23);
            this.ResetRptBtn.TabIndex = 5;
            this.ResetRptBtn.Text = "Reset Report";
            this.ResetRptBtn.UseVisualStyleBackColor = true;
            this.ResetRptBtn.Click += new System.EventHandler(this.ResetRptBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select a WoW API from the list:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetRptBtn);
            this.Controls.Add(this.ResultRptTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RndIdCb);
            this.Controls.Add(this.userLbl1);
            this.Controls.Add(this.ApiSelectCbo);
            this.Controls.Add(this.GetControllerUD);
            this.Controls.Add(this.EnterIdTb);
            this.Controls.Add(this.GETBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "WoW API Web Request Tool";
            ((System.ComponentModel.ISupportInitialize)(this.GetControllerUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GETBtn;
        private System.Windows.Forms.TextBox EnterIdTb;
        private System.Windows.Forms.NumericUpDown GetControllerUD;
        private System.Windows.Forms.ComboBox ApiSelectCbo;
        private System.Windows.Forms.Label userLbl1;
        private System.Windows.Forms.CheckBox RndIdCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultRptTb;
        private System.Windows.Forms.Button ResetRptBtn;
        private System.Windows.Forms.Label label2;
    }
}

