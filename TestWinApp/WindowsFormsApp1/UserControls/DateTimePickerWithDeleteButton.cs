using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public partial class DateTimePickerWithDeleteButton : UserControl
    {
        public DateTimePickerWithDeleteButton()
        {
            InitializeComponent();
        }

        public EventHandler DateTimePicker_ValueChanged;

        public DateTime Value
        {
            get { return dtPicker.Value; }
            set { dtPicker.Value = value; }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            dtPicker.Value = DateTime.Today;
            dtPicker.Checked = false;
            showDateTimeBox.Text = string.Empty;
            showDateTimeBox.Visible = true;
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            if (dtPicker.Value != DateTime.FromOADate(0))
            {
                dtPicker.Checked = true;
                showDateTimeBox.Text = string.Empty;
                showDateTimeBox.Visible = false;
            }
            else
            {
                dtPicker.Checked = false;
                showDateTimeBox.Text = string.Empty;
                showDateTimeBox.Visible = true;
            }
            DateTimePicker_ValueChanged?.Invoke(this, e);
        }

        private void showDateTimeBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                if (showDateTimeBox.Text.Length == 2)
                {
                    Console.Beep();
                    showDateTimeBox.Text = showDateTimeBox.Text.Remove(showDateTimeBox.Text.Length - 1);
                    showDateTimeBox.SelectionStart = showDateTimeBox.Text.Length;
                }
            }
            else if (e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D9)
            {
                int.TryParse(showDateTimeBox.Text, out int day);
                dtPicker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, day);
                showDateTimeBox.Visible = false;
            }
            else
            {
                Console.Beep();
                showDateTimeBox.Text = showDateTimeBox.Text.Remove(showDateTimeBox.Text.Length - 1);
                showDateTimeBox.SelectionStart = showDateTimeBox.Text.Length;
            }
        }

        public void SetDtpValue(DateTime dt)
        {
            if (dt == DateTime.FromOADate(0))
            {
                dtPicker.Checked = false;
                dtPicker.Value = DateTime.Today;
            }
            else
            {
                dtPicker.Checked = true;
                dtPicker.Value = dt;
            }
        }

        public DateTime? GetDtpValue()
        {
            if (dtPicker.Checked) return dtPicker.Value;
            return null;
        }

        private void dtPicker_CloseUp(object sender, EventArgs e)
        {
            if (dtPicker.Value == DateTime.FromOADate(0))
            {
                dtPicker.Checked = false;
                showDateTimeBox.Text = string.Empty;
                showDateTimeBox.Visible = true;
                return;
            }
            if (showDateTimeBox.Visible == true)
            {
                showDateTimeBox.Visible = false;
                dtPicker.Checked = true;
                dtPicker.Focus();
            }
        }
    }
}
