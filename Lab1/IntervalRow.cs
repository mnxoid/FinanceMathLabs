using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    //using Row = Tuple<DateTime, DateTime, double>;
    public partial class IntervalRow : UserControl
    {
        public IntervalRow()
        {
            InitializeComponent();
        }

        public IntervalRow(Row r)
        {
            InitializeComponent();
            dateTimePicker1.Value = r.Item1;
            dateTimePicker2.Value = r.Item2;
            textBox1.Text = r.Item3.ToString(CultureInfo.InvariantCulture);
        }

        public event EventHandler XClick;

        public delegate void ChangeHandler(object sender, ChangeArgs c);
        public event ChangeHandler Change;

        private void button1_Click(object sender, EventArgs e)
        {
            XClick?.Invoke(this, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Change?.Invoke(this, new ChangeArgs {ChangeFirst = dateTimePicker1.Value});
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Change?.Invoke(this, new ChangeArgs { ChangeSecond = dateTimePicker2.Value });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double val;
            bool success = double.TryParse(textBox1.Text, out val);
            if (success)
            {
                Change?.Invoke(this, new ChangeArgs { ChangePercent = val });
            }
            else
            {
                textBox1.Text = @"ПОМИЛКА";
                MessageBox.Show(@"Введено некоректне значення!");
            }
        }

        public class ChangeArgs
        {
            public DateTime? ChangeFirst;
            public DateTime? ChangeSecond;
            public double? ChangePercent;
        }

        public void ChangeVals(Row row)
        {
            dateTimePicker1.Value = row.Item1;
            dateTimePicker2.Value = row.Item2;
            textBox1.Text = row.Item3.ToString(CultureInfo.InvariantCulture);
        }

        public DateTime First => dateTimePicker1.Value;
        public DateTime Second => dateTimePicker2.Value;
        public double Percent => double.Parse(textBox1.Text);

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            double val;
            bool success = double.TryParse(textBox1.Text, out val);
            if (success)
            {
                Change?.Invoke(this, new ChangeArgs { ChangePercent = val });
            }
        }
    }
}
