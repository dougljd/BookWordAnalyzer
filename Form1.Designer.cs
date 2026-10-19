namespace BookWordAnalyzer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBook1 = new Label();
            lblBook2 = new Label();
            txtBook2 = new TextBox();
            txtBook1 = new TextBox();
            btnBrowse2 = new Button();
            btnAnalyze = new Button();
            btnBrowse1 = new Button();
            lstBook2 = new ListBox();
            lstBook1 = new ListBox();
            SuspendLayout();
            // 
            // lblBook1
            // 
            lblBook1.AutoSize = true;
            lblBook1.Location = new Point(12, 9);
            lblBook1.Name = "lblBook1";
            lblBook1.Size = new Size(68, 25);
            lblBook1.TabIndex = 0;
            lblBook1.Text = "Book 1";
            // 
            // lblBook2
            // 
            lblBook2.AutoSize = true;
            lblBook2.Location = new Point(414, 9);
            lblBook2.Name = "lblBook2";
            lblBook2.Size = new Size(68, 25);
            lblBook2.TabIndex = 1;
            lblBook2.Text = "Book 2";
            // 
            // txtBook2
            // 
            txtBook2.Location = new Point(414, 51);
            txtBook2.Name = "txtBook2";
            txtBook2.Size = new Size(362, 31);
            txtBook2.TabIndex = 2;
            // 
            // txtBook1
            // 
            txtBook1.Location = new Point(12, 51);
            txtBook1.Name = "txtBook1";
            txtBook1.Size = new Size(363, 31);
            txtBook1.TabIndex = 3;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(504, 394);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(112, 34);
            btnBrowse2.TabIndex = 4;
            btnBrowse2.Text = "Browse...";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(348, 394);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(112, 34);
            btnAnalyze.TabIndex = 5;
            btnAnalyze.Text = "Analyze Books";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnBrowse1
            // 
            btnBrowse1.Location = new Point(172, 394);
            btnBrowse1.Name = "btnBrowse1";
            btnBrowse1.Size = new Size(112, 34);
            btnBrowse1.TabIndex = 6;
            btnBrowse1.Text = "Browse...";
            btnBrowse1.UseVisualStyleBackColor = true;
            btnBrowse1.Click += btnBrowse1_Click;
            // 
            // lstBook2
            // 
            lstBook2.FormattingEnabled = true;
            lstBook2.ItemHeight = 25;
            lstBook2.Location = new Point(414, 97);
            lstBook2.Name = "lstBook2";
            lstBook2.Size = new Size(362, 279);
            lstBook2.TabIndex = 7;
            // 
            // lstBook1
            // 
            lstBook1.FormattingEnabled = true;
            lstBook1.ItemHeight = 25;
            lstBook1.Location = new Point(12, 97);
            lstBook1.Name = "lstBook1";
            lstBook1.Size = new Size(363, 279);
            lstBook1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBook1);
            Controls.Add(lstBook2);
            Controls.Add(btnBrowse1);
            Controls.Add(btnAnalyze);
            Controls.Add(btnBrowse2);
            Controls.Add(txtBook1);
            Controls.Add(txtBook2);
            Controls.Add(lblBook2);
            Controls.Add(lblBook1);
            Name = "Form1";
            Text = "Jonathan Douglas Book Analysis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBook1;
        private Label lblBook2;
        private TextBox txtBook2;
        private TextBox txtBook1;
        private Button btnBrowse2;
        private Button btnAnalyze;
        private Button btnBrowse1;
        private ListBox lstBook2;
        private ListBox lstBook1;
    }
}
