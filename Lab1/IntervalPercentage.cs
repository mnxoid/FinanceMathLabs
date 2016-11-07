using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    using Row = Tuple<DateTime,DateTime,double>;
    public partial class IntervalPercentage : UserControl
    {
        public IntervalPercentage()
        {
            InitializeComponent();
            panel1.Controls.Clear();
            foreach (Row row in Rows)
            {
                IntervalRow c = new IntervalRow(row) {Dock = DockStyle.Top};
                c.XClick += OnXClick;
                panel1.Controls.Add(c);
            }
            Invalidate();
        }

        private void OnXClick(object sender, EventArgs eventArgs)
        {
            panel1.Controls.Remove((Control)sender);
        }

        public List<Row> Rows=new List<Row>
        {
            new Row(new DateTime(2016,1,1), DateTime.Today, 15)
        };

        private void button1_Click(object sender, EventArgs e)
        {
            IntervalRow c = new IntervalRow(new Row(DateTime.Today, DateTime.Today, 20)) {Dock = DockStyle.Top};
            c.XClick += OnXClick;
            panel1.Controls.Add(c);
            panel1.Controls.SetChildIndex(c,0);
            panel1.Invalidate();
        }
    }
}
