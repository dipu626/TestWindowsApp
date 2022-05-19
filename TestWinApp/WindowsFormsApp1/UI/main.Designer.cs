
namespace WindowsFormsApp1
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
            this.introductionTxtBx = new System.Windows.Forms.TextBox();
            this.ucDateTimePicker = new WindowsFormsApp1.UserControls.DateTimePickerWithDeleteButton();
            this.finalResultBtn = new System.Windows.Forms.Button();
            this.SetDtpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // introductionTxtBx
            // 
            this.introductionTxtBx.BackColor = System.Drawing.Color.White;
            this.introductionTxtBx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.introductionTxtBx.Location = new System.Drawing.Point(301, 21);
            this.introductionTxtBx.Name = "introductionTxtBx";
            this.introductionTxtBx.Size = new System.Drawing.Size(144, 20);
            this.introductionTxtBx.TabIndex = 0;
            this.introductionTxtBx.Text = "Welcome to Test Application";
            // 
            // ucDateTimePicker
            // 
            this.ucDateTimePicker.Location = new System.Drawing.Point(57, 87);
            this.ucDateTimePicker.Name = "ucDateTimePicker";
            this.ucDateTimePicker.Size = new System.Drawing.Size(284, 72);
            this.ucDateTimePicker.TabIndex = 1;
            // 
            // finalResultBtn
            // 
            this.finalResultBtn.Location = new System.Drawing.Point(135, 175);
            this.finalResultBtn.Name = "finalResultBtn";
            this.finalResultBtn.Size = new System.Drawing.Size(75, 23);
            this.finalResultBtn.TabIndex = 2;
            this.finalResultBtn.Text = "Final Result";
            this.finalResultBtn.UseVisualStyleBackColor = true;
            this.finalResultBtn.Click += new System.EventHandler(this.finalResultBtn_Click);
            // 
            // SetDtpBtn
            // 
            this.SetDtpBtn.Location = new System.Drawing.Point(28, 175);
            this.SetDtpBtn.Name = "SetDtpBtn";
            this.SetDtpBtn.Size = new System.Drawing.Size(91, 23);
            this.SetDtpBtn.TabIndex = 3;
            this.SetDtpBtn.Text = "Set DateTime";
            this.SetDtpBtn.UseVisualStyleBackColor = true;
            this.SetDtpBtn.Click += new System.EventHandler(this.SetDtpBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetDtpBtn);
            this.Controls.Add(this.finalResultBtn);
            this.Controls.Add(this.ucDateTimePicker);
            this.Controls.Add(this.introductionTxtBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox introductionTxtBx;
        private UserControls.DateTimePickerWithDeleteButton ucDateTimePicker;
        private System.Windows.Forms.Button finalResultBtn;
        private System.Windows.Forms.Button SetDtpBtn;
    }
}

