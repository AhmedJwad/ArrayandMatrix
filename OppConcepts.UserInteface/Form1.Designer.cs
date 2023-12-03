namespace OppConcepts.UserInteface
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtYear = new TextBox();
            txtMonth = new TextBox();
            txtDay = new TextBox();
            btnInsert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 89);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Month:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 160);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Day:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(200, 43);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "please insert a year";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 3;
            txtYear.TextChanged += txtYear_TextChanged;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(200, 86);
            txtMonth.Name = "txtMonth";
            txtMonth.PlaceholderText = "please insert a month";
            txtMonth.Size = new Size(125, 27);
            txtMonth.TabIndex = 4;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(200, 153);
            txtDay.Name = "txtDay";
            txtDay.PlaceholderText = "please insert a day";
            txtDay.Size = new Size(125, 27);
            txtDay.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(126, 250);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(176, 29);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Create";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 296);
            Controls.Add(btnInsert);
            Controls.Add(txtDay);
            Controls.Add(txtMonth);
            Controls.Add(txtYear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtYear;
        private TextBox txtMonth;
        private TextBox txtDay;
        private Button btnInsert;
    }
}