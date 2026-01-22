namespace CalculatorApp
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            label4 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(421, 105);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(421, 152);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 0;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b1.Location = new Point(311, 211);
            b1.Name = "b1";
            b1.Size = new Size(75, 34);
            b1.TabIndex = 1;
            b1.Text = "+";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b2.Location = new Point(446, 211);
            b2.Name = "b2";
            b2.Size = new Size(75, 34);
            b2.TabIndex = 1;
            b2.Text = "-";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b3.Location = new Point(311, 277);
            b3.Name = "b3";
            b3.Size = new Size(75, 32);
            b3.TabIndex = 1;
            b3.Text = "*";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b4.Location = new Point(446, 277);
            b4.Name = "b4";
            b4.Size = new Size(75, 32);
            b4.TabIndex = 1;
            b4.Text = "/";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 111);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 2;
            label1.Text = "NUM 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 158);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 2;
            label2.Text = "NUM 2";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(408, 340);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(329, 41);
            label4.Name = "label4";
            label4.Size = new Size(145, 30);
            label4.TabIndex = 2;
            label4.Text = "CALCULATOR";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(234, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 426);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(b2);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Label label1;
        private Label label2;
        private Label lblResult;
        private Label label4;
        private Panel panel1;
    }
}
