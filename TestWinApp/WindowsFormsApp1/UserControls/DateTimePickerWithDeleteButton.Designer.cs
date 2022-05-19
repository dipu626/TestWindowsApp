
namespace WindowsFormsApp1.UserControls
{
    partial class DateTimePickerWithDeleteButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.showDateTimeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(254)))));
            this.dtPicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.dtPicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtPicker.CustomFormat = "dd.MM.yyyy";
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(59, 19);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(86, 20);
            this.dtPicker.TabIndex = 0;
            this.dtPicker.CloseUp += new System.EventHandler(this.dtPicker_CloseUp);
            this.dtPicker.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(148, 17);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(28, 23);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "X";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // showDateTimeBox
            // 
            this.showDateTimeBox.Location = new System.Drawing.Point(60, 20);
            this.showDateTimeBox.Name = "showDateTimeBox";
            this.showDateTimeBox.Size = new System.Drawing.Size(68, 20);
            this.showDateTimeBox.TabIndex = 2;
            this.showDateTimeBox.Visible = false;
            this.showDateTimeBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.showDateTimeBox_KeyUp);
            // 
            // DateTimePickerWithDeleteButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showDateTimeBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dtPicker);
            this.Name = "DateTimePickerWithDeleteButton";
            this.Size = new System.Drawing.Size(320, 107);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox showDateTimeBox;
    }
}
