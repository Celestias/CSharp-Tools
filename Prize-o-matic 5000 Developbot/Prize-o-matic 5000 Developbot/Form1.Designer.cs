namespace Prize
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
            this.determineWinBtn = new System.Windows.Forms.Button();
            this.StudentNameTb = new System.Windows.Forms.TextBox();
            this.StudentCourseTb = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.consoleLbl = new System.Windows.Forms.Label();
            this.Course1Cb = new System.Windows.Forms.CheckBox();
            this.Course2Cb = new System.Windows.Forms.CheckBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.StudentNameLbl = new System.Windows.Forms.Label();
            this.StudentCourseLbl = new System.Windows.Forms.Label();
            this.StudentNameAndCourseTb = new System.Windows.Forms.TextBox();
            this.RandWinnersTb = new System.Windows.Forms.TextBox();
            this.studentlistLbl = new System.Windows.Forms.Label();
            this.winnersLbl = new System.Windows.Forms.Label();
            this.SetWinnersUd = new System.Windows.Forms.NumericUpDown();
            this.priceCountlbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.duplicatesTb = new System.Windows.Forms.TextBox();
            this.StudentListCtLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SetWinnersUd)).BeginInit();
            this.SuspendLayout();
            // 
            // determineWinBtn
            // 
            this.determineWinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.determineWinBtn.Location = new System.Drawing.Point(12, 245);
            this.determineWinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.determineWinBtn.Name = "determineWinBtn";
            this.determineWinBtn.Size = new System.Drawing.Size(149, 49);
            this.determineWinBtn.TabIndex = 0;
            this.determineWinBtn.Text = "Determine Winners";
            this.determineWinBtn.UseVisualStyleBackColor = true;
            this.determineWinBtn.Click += new System.EventHandler(this.determineWinBtn_Click);
            // 
            // StudentNameTb
            // 
            this.StudentNameTb.BackColor = System.Drawing.SystemColors.Info;
            this.StudentNameTb.Location = new System.Drawing.Point(12, 81);
            this.StudentNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentNameTb.MaxLength = 25;
            this.StudentNameTb.Name = "StudentNameTb";
            this.StudentNameTb.Size = new System.Drawing.Size(172, 22);
            this.StudentNameTb.TabIndex = 1;
            this.StudentNameTb.Tag = "Student Field";
            // 
            // StudentCourseTb
            // 
            this.StudentCourseTb.BackColor = System.Drawing.SystemColors.Info;
            this.StudentCourseTb.Location = new System.Drawing.Point(12, 130);
            this.StudentCourseTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentCourseTb.MaxLength = 25;
            this.StudentCourseTb.Name = "StudentCourseTb";
            this.StudentCourseTb.Size = new System.Drawing.Size(171, 22);
            this.StudentCourseTb.TabIndex = 2;
            this.StudentCourseTb.Tag = "Course Field";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(203, 81);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(108, 71);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add Student";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // consoleLbl
            // 
            this.consoleLbl.AutoSize = true;
            this.consoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLbl.ForeColor = System.Drawing.Color.Red;
            this.consoleLbl.Location = new System.Drawing.Point(12, 154);
            this.consoleLbl.Name = "consoleLbl";
            this.consoleLbl.Size = new System.Drawing.Size(0, 17);
            this.consoleLbl.TabIndex = 4;
            // 
            // Course1Cb
            // 
            this.Course1Cb.AutoSize = true;
            this.Course1Cb.Location = new System.Drawing.Point(13, 191);
            this.Course1Cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Course1Cb.Name = "Course1Cb";
            this.Course1Cb.Size = new System.Drawing.Size(272, 21);
            this.Course1Cb.TabIndex = 5;
            this.Course1Cb.Tag = "Learn To Program: The Fundamentals";
            this.Course1Cb.Text = "Learn To Program: The Fundamentals";
            this.Course1Cb.UseVisualStyleBackColor = true;
            this.Course1Cb.Visible = false;
            this.Course1Cb.CheckedChanged += new System.EventHandler(this.Course1Cb_CheckedChanged);
            // 
            // Course2Cb
            // 
            this.Course2Cb.AutoSize = true;
            this.Course2Cb.Location = new System.Drawing.Point(13, 218);
            this.Course2Cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Course2Cb.Name = "Course2Cb";
            this.Course2Cb.Size = new System.Drawing.Size(244, 21);
            this.Course2Cb.TabIndex = 6;
            this.Course2Cb.Tag = "Beginning C# Game Programming";
            this.Course2Cb.Text = "Beginning C# Game Programming";
            this.Course2Cb.UseVisualStyleBackColor = true;
            this.Course2Cb.Visible = false;
            this.Course2Cb.CheckedChanged += new System.EventHandler(this.Course2Cb_CheckedChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(171, 245);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(149, 49);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // StudentNameLbl
            // 
            this.StudentNameLbl.AutoSize = true;
            this.StudentNameLbl.Location = new System.Drawing.Point(12, 58);
            this.StudentNameLbl.Name = "StudentNameLbl";
            this.StudentNameLbl.Size = new System.Drawing.Size(140, 17);
            this.StudentNameLbl.TabIndex = 8;
            this.StudentNameLbl.Text = "Enter Student Name:";
            // 
            // StudentCourseLbl
            // 
            this.StudentCourseLbl.AutoSize = true;
            this.StudentCourseLbl.Location = new System.Drawing.Point(16, 111);
            this.StudentCourseLbl.Name = "StudentCourseLbl";
            this.StudentCourseLbl.Size = new System.Drawing.Size(136, 17);
            this.StudentCourseLbl.TabIndex = 9;
            this.StudentCourseLbl.Text = "Enter Course Name:";
            // 
            // StudentNameAndCourseTb
            // 
            this.StudentNameAndCourseTb.BackColor = System.Drawing.SystemColors.Info;
            this.StudentNameAndCourseTb.Location = new System.Drawing.Point(340, 80);
            this.StudentNameAndCourseTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentNameAndCourseTb.MaxLength = 500;
            this.StudentNameAndCourseTb.Multiline = true;
            this.StudentNameAndCourseTb.Name = "StudentNameAndCourseTb";
            this.StudentNameAndCourseTb.ReadOnly = true;
            this.StudentNameAndCourseTb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StudentNameAndCourseTb.Size = new System.Drawing.Size(432, 214);
            this.StudentNameAndCourseTb.TabIndex = 10;
            // 
            // RandWinnersTb
            // 
            this.RandWinnersTb.BackColor = System.Drawing.SystemColors.Info;
            this.RandWinnersTb.Location = new System.Drawing.Point(12, 370);
            this.RandWinnersTb.Margin = new System.Windows.Forms.Padding(4);
            this.RandWinnersTb.MaxLength = 500;
            this.RandWinnersTb.Multiline = true;
            this.RandWinnersTb.Name = "RandWinnersTb";
            this.RandWinnersTb.ReadOnly = true;
            this.RandWinnersTb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RandWinnersTb.Size = new System.Drawing.Size(472, 226);
            this.RandWinnersTb.TabIndex = 11;
            // 
            // studentlistLbl
            // 
            this.studentlistLbl.AutoSize = true;
            this.studentlistLbl.Location = new System.Drawing.Point(323, 62);
            this.studentlistLbl.Name = "studentlistLbl";
            this.studentlistLbl.Size = new System.Drawing.Size(171, 17);
            this.studentlistLbl.TabIndex = 12;
            this.studentlistLbl.Text = "Student List: (individuals):";
            // 
            // winnersLbl
            // 
            this.winnersLbl.AutoSize = true;
            this.winnersLbl.Location = new System.Drawing.Point(8, 351);
            this.winnersLbl.Name = "winnersLbl";
            this.winnersLbl.Size = new System.Drawing.Size(592, 17);
            this.winnersLbl.TabIndex = 13;
            this.winnersLbl.Text = "Prize Winners List  (Max 1 Prize Per Student - Multiple entries increases chances" +
                " of winning!)";
            // 
            // SetWinnersUd
            // 
            this.SetWinnersUd.BackColor = System.Drawing.SystemColors.Info;
            this.SetWinnersUd.Location = new System.Drawing.Point(169, 308);
            this.SetWinnersUd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetWinnersUd.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.SetWinnersUd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SetWinnersUd.Name = "SetWinnersUd";
            this.SetWinnersUd.Size = new System.Drawing.Size(44, 22);
            this.SetWinnersUd.TabIndex = 14;
            this.SetWinnersUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priceCountlbl
            // 
            this.priceCountlbl.AutoSize = true;
            this.priceCountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCountlbl.Location = new System.Drawing.Point(16, 313);
            this.priceCountlbl.Name = "priceCountlbl";
            this.priceCountlbl.Size = new System.Drawing.Size(138, 17);
            this.priceCountlbl.TabIndex = 15;
            this.priceCountlbl.Text = "Number of Prizes:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 5);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(452, 50);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "Add each Student and Course, then set a maximum prize count for the\nPrize-o-Matic" +
                " 5000 to roll for winners!";
            // 
            // duplicatesTb
            // 
            this.duplicatesTb.BackColor = System.Drawing.SystemColors.Info;
            this.duplicatesTb.Location = new System.Drawing.Point(493, 370);
            this.duplicatesTb.Margin = new System.Windows.Forms.Padding(4);
            this.duplicatesTb.Multiline = true;
            this.duplicatesTb.Name = "duplicatesTb";
            this.duplicatesTb.ReadOnly = true;
            this.duplicatesTb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.duplicatesTb.Size = new System.Drawing.Size(279, 226);
            this.duplicatesTb.TabIndex = 18;
            // 
            // StudentListCtLbl
            // 
            this.StudentListCtLbl.AutoSize = true;
            this.StudentListCtLbl.Location = new System.Drawing.Point(490, 62);
            this.StudentListCtLbl.Name = "StudentListCtLbl";
            this.StudentListCtLbl.Size = new System.Drawing.Size(16, 17);
            this.StudentListCtLbl.TabIndex = 19;
            this.StudentListCtLbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 609);
            this.Controls.Add(this.StudentListCtLbl);
            this.Controls.Add(this.duplicatesTb);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.priceCountlbl);
            this.Controls.Add(this.SetWinnersUd);
            this.Controls.Add(this.winnersLbl);
            this.Controls.Add(this.studentlistLbl);
            this.Controls.Add(this.RandWinnersTb);
            this.Controls.Add(this.StudentNameAndCourseTb);
            this.Controls.Add(this.StudentCourseLbl);
            this.Controls.Add(this.StudentNameLbl);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.Course2Cb);
            this.Controls.Add(this.Course1Cb);
            this.Controls.Add(this.consoleLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.StudentCourseTb);
            this.Controls.Add(this.StudentNameTb);
            this.Controls.Add(this.determineWinBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Self-Developbot Prize-o-Matic 5000";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SetWinnersUd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button determineWinBtn;
        private System.Windows.Forms.TextBox StudentNameTb;
        private System.Windows.Forms.TextBox StudentCourseTb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label consoleLbl;
        private System.Windows.Forms.CheckBox Course1Cb;
        private System.Windows.Forms.CheckBox Course2Cb;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label StudentNameLbl;
        private System.Windows.Forms.Label StudentCourseLbl;
        private System.Windows.Forms.TextBox StudentNameAndCourseTb;
        private System.Windows.Forms.TextBox RandWinnersTb;
        private System.Windows.Forms.Label studentlistLbl;
        private System.Windows.Forms.Label winnersLbl;
        private System.Windows.Forms.NumericUpDown SetWinnersUd;
        private System.Windows.Forms.Label priceCountlbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox duplicatesTb;
        private System.Windows.Forms.Label StudentListCtLbl;
    }
}

