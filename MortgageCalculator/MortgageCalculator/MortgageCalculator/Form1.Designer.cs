namespace MortgageCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.LAmountTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.interestLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.InterestRateTb = new System.Windows.Forms.TextBox();
            this.MortageSchedLb = new System.Windows.Forms.ListBox();
            this.MonthlyTermCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalPaymentTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amount:";
            // 
            // LAmountTb
            // 
            this.LAmountTb.Location = new System.Drawing.Point(90, 59);
            this.LAmountTb.Name = "LAmountTb";
            this.LAmountTb.Size = new System.Drawing.Size(87, 20);
            this.LAmountTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monthly Term:\r\n";
            // 
            // interestLbl
            // 
            this.interestLbl.AutoSize = true;
            this.interestLbl.Location = new System.Drawing.Point(21, 89);
            this.interestLbl.Name = "interestLbl";
            this.interestLbl.Size = new System.Drawing.Size(62, 13);
            this.interestLbl.TabIndex = 5;
            this.interestLbl.Text = "Interest (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amortization Schedule: (amounts paid)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calculate the loan details:";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(77, 143);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(89, 35);
            this.CalculateBtn.TabIndex = 4;
            this.CalculateBtn.Text = "Calculate Schedule";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // InterestRateTb
            // 
            this.InterestRateTb.Location = new System.Drawing.Point(90, 87);
            this.InterestRateTb.Name = "InterestRateTb";
            this.InterestRateTb.Size = new System.Drawing.Size(87, 20);
            this.InterestRateTb.TabIndex = 2;
            // 
            // MortageSchedLb
            // 
            this.MortageSchedLb.FormattingEnabled = true;
            this.MortageSchedLb.HorizontalScrollbar = true;
            this.MortageSchedLb.Location = new System.Drawing.Point(197, 59);
            this.MortageSchedLb.Name = "MortageSchedLb";
            this.MortageSchedLb.Size = new System.Drawing.Size(569, 251);
            this.MortageSchedLb.TabIndex = 18;
            // 
            // MonthlyTermCb
            // 
            this.MonthlyTermCb.FormattingEnabled = true;
            this.MonthlyTermCb.Items.AddRange(new object[] {
            "120",
            "240",
            "360"});
            this.MonthlyTermCb.Location = new System.Drawing.Point(90, 116);
            this.MonthlyTermCb.Name = "MonthlyTermCb";
            this.MonthlyTermCb.Size = new System.Drawing.Size(87, 21);
            this.MonthlyTermCb.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Amount Repaid:";
            // 
            // TotalPaymentTb
            // 
            this.TotalPaymentTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPaymentTb.Location = new System.Drawing.Point(100, 264);
            this.TotalPaymentTb.Name = "TotalPaymentTb";
            this.TotalPaymentTb.ReadOnly = true;
            this.TotalPaymentTb.Size = new System.Drawing.Size(87, 20);
            this.TotalPaymentTb.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 320);
            this.Controls.Add(this.MonthlyTermCb);
            this.Controls.Add(this.MortageSchedLb);
            this.Controls.Add(this.InterestRateTb);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.TotalPaymentTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interestLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LAmountTb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mortgage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LAmountTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label interestLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TextBox InterestRateTb;
        private System.Windows.Forms.ListBox MortageSchedLb;
        private System.Windows.Forms.ComboBox MonthlyTermCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalPaymentTb;
    }
}

