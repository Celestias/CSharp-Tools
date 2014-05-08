namespace ParagraphTool
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
            this.DirectionsLbl1 = new System.Windows.Forms.Label();
            this.ReverseParaBtn = new System.Windows.Forms.Button();
            this.AlphaBtn = new System.Windows.Forms.Button();
            this.SHA384Btn = new System.Windows.Forms.Button();
            this.rtfInputTb = new System.Windows.Forms.RichTextBox();
            this.RevWordsBtn = new System.Windows.Forms.Button();
            this.OutputTb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DirectionsLbl1
            // 
            this.DirectionsLbl1.AutoSize = true;
            this.DirectionsLbl1.Location = new System.Drawing.Point(17, 16);
            this.DirectionsLbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DirectionsLbl1.Name = "DirectionsLbl1";
            this.DirectionsLbl1.Size = new System.Drawing.Size(263, 34);
            this.DirectionsLbl1.TabIndex = 2;
            this.DirectionsLbl1.Text = "Enter your paragraph of text then select \r\none of the formatting options below:";
            // 
            // ReverseParaBtn
            // 
            this.ReverseParaBtn.Location = new System.Drawing.Point(16, 160);
            this.ReverseParaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReverseParaBtn.Name = "ReverseParaBtn";
            this.ReverseParaBtn.Size = new System.Drawing.Size(100, 47);
            this.ReverseParaBtn.TabIndex = 4;
            this.ReverseParaBtn.Text = "Reverse\r\nParagraph\r\n\r\n";
            this.ReverseParaBtn.UseVisualStyleBackColor = true;
            this.ReverseParaBtn.Click += new System.EventHandler(this.ReverseParaBtn_Click);
            // 
            // AlphaBtn
            // 
            this.AlphaBtn.Location = new System.Drawing.Point(236, 160);
            this.AlphaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AlphaBtn.Name = "AlphaBtn";
            this.AlphaBtn.Size = new System.Drawing.Size(100, 46);
            this.AlphaBtn.TabIndex = 5;
            this.AlphaBtn.Text = "Alpha Sorted";
            this.AlphaBtn.UseVisualStyleBackColor = true;
            this.AlphaBtn.Click += new System.EventHandler(this.AlphaBtn_Click);
            // 
            // SHA384Btn
            // 
            this.SHA384Btn.Location = new System.Drawing.Point(344, 161);
            this.SHA384Btn.Margin = new System.Windows.Forms.Padding(4);
            this.SHA384Btn.Name = "SHA384Btn";
            this.SHA384Btn.Size = new System.Drawing.Size(100, 46);
            this.SHA384Btn.TabIndex = 6;
            this.SHA384Btn.Text = "SHA-384";
            this.SHA384Btn.UseVisualStyleBackColor = true;
            this.SHA384Btn.Click += new System.EventHandler(this.SHA384Btn_Click);
            // 
            // rtfInputTb
            // 
            this.rtfInputTb.AcceptsTab = true;
            this.rtfInputTb.Location = new System.Drawing.Point(16, 59);
            this.rtfInputTb.Margin = new System.Windows.Forms.Padding(4);
            this.rtfInputTb.MaxLength = 140;
            this.rtfInputTb.Name = "rtfInputTb";
            this.rtfInputTb.Size = new System.Drawing.Size(428, 93);
            this.rtfInputTb.TabIndex = 7;
            this.rtfInputTb.Text = "";
            // 
            // RevWordsBtn
            // 
            this.RevWordsBtn.Location = new System.Drawing.Point(128, 160);
            this.RevWordsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RevWordsBtn.Name = "RevWordsBtn";
            this.RevWordsBtn.Size = new System.Drawing.Size(100, 47);
            this.RevWordsBtn.TabIndex = 8;
            this.RevWordsBtn.Text = "Reverse \r\nWords";
            this.RevWordsBtn.UseVisualStyleBackColor = true;
            this.RevWordsBtn.Click += new System.EventHandler(this.RevWordsBtn_Click);
            // 
            // OutputTb
            // 
            this.OutputTb.Location = new System.Drawing.Point(20, 223);
            this.OutputTb.Name = "OutputTb";
            this.OutputTb.ReadOnly = true;
            this.OutputTb.Size = new System.Drawing.Size(424, 93);
            this.OutputTb.TabIndex = 9;
            this.OutputTb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 348);
            this.Controls.Add(this.OutputTb);
            this.Controls.Add(this.RevWordsBtn);
            this.Controls.Add(this.rtfInputTb);
            this.Controls.Add(this.SHA384Btn);
            this.Controls.Add(this.AlphaBtn);
            this.Controls.Add(this.ReverseParaBtn);
            this.Controls.Add(this.DirectionsLbl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Paragraph Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DirectionsLbl1;
        private System.Windows.Forms.Button ReverseParaBtn;
        private System.Windows.Forms.Button AlphaBtn;
        private System.Windows.Forms.Button SHA384Btn;
        private System.Windows.Forms.RichTextBox rtfInputTb;
        private System.Windows.Forms.Button RevWordsBtn;
        private System.Windows.Forms.RichTextBox OutputTb;
    }
}

