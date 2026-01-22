namespace CheckWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            chkSubscribe = new CheckBox();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            btnShowSelection = new Button();
            SuspendLayout();
            // 
            // chkSubscribe
            // 
            chkSubscribe.AutoSize = true;
            chkSubscribe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkSubscribe.ForeColor = Color.MediumBlue;
            chkSubscribe.Location = new Point(300, 80);
            chkSubscribe.Name = "chkSubscribe";
            chkSubscribe.Size = new Size(187, 23);
            chkSubscribe.TabIndex = 0;
            chkSubscribe.Text = "Subscribe to Newsletter";
            chkSubscribe.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Font = new Font("Segoe UI", 10F);
            radioMale.Location = new Point(320, 130);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(57, 23);
            radioMale.TabIndex = 1;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Font = new Font("Segoe UI", 10F);
            radioFemale.Location = new Point(320, 165);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(70, 23);
            radioFemale.TabIndex = 2;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // btnShowSelection
            // 
            btnShowSelection.BackColor = Color.MediumSlateBlue;
            btnShowSelection.FlatStyle = FlatStyle.Flat;
            btnShowSelection.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnShowSelection.ForeColor = Color.White;
            btnShowSelection.Location = new Point(320, 210);
            btnShowSelection.Name = "btnShowSelection";
            btnShowSelection.Size = new Size(150, 35);
            btnShowSelection.TabIndex = 3;
            btnShowSelection.Text = "Show Selection";
            btnShowSelection.UseVisualStyleBackColor = false;
            btnShowSelection.Click += btnShowSelection_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(978, 527);
            Controls.Add(btnShowSelection);
            Controls.Add(radioFemale);
            Controls.Add(radioMale);
            Controls.Add(chkSubscribe);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "User Preferences";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox chkSubscribe;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Button btnShowSelection;
    }
}
