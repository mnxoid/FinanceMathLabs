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
    using Row = Tuple<DateTime, DateTime, double>;
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

        public delegate void ChangeHandler(ChangeArgs c);
        public event ChangeHandler Change;

        private void button1_Click(object sender, EventArgs e)
        {
            XClick?.Invoke(this, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Change?.Invoke(new ChangeArgs {ChangeFirst = dateTimePicker1.Value});
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Change?.Invoke(new ChangeArgs { ChangeSecond = dateTimePicker2.Value });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Change?.Invoke(new ChangeArgs { ChangePercent = textBox1.Text });
        }

        public class ChangeArgs
        {
            public DateTime ChangeFirst;
            public DateTime ChangeSecond;
            public string ChangePercent;
        }
    }
}
