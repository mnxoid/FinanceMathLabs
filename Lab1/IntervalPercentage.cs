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
    //using Row = Tuple<DateTime,DateTime,double>;
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
                c.Change += OnRowChange;
                panel1.Controls.Add(c);
            }
            Invalidate();
        }

        private void OnRowChange(object sender, IntervalRow.ChangeArgs c)
        {
            var n = panel1.Controls.Count - 1;
            var i = n - panel1.Controls.IndexOf((Control) sender);
            bool prev = i > 0;
            bool next = i < Rows.Count - 1;
            if (c.ChangeFirst != null)
            {
                Rows[i].Item1 = (DateTime) c.ChangeFirst;
                if (prev)
                {
                    Rows[i - 1].Item2 = Rows[i].Item1;
                    ((IntervalRow) panel1.Controls[n - i + 1]).ChangeVals(Rows[i - 1]);
                }

            }
            if (c.ChangeSecond != null)
            {
                Rows[i].Item2 = (DateTime)c.ChangeSecond;
                if (next)
                {
                    Rows[i + 1].Item1 = Rows[i].Item2;
                    ((IntervalRow)panel1.Controls[n - i - 1]).ChangeVals(Rows[i + 1]);
                }
            }
            if (c.ChangePercent != null)
            {
                Rows[i].Item3 = (double)c.ChangePercent;
            }
        }

        private void OnXClick(object sender, EventArgs eventArgs)
        {
            var n = panel1.Controls.Count - 1;
            var i = n - panel1.Controls.IndexOf((Control)sender);
            bool prev = i > 0;
            if (prev)
            {
                Rows[i - 1].Item2 = ((IntervalRow) sender).Second;
                ((IntervalRow)panel1.Controls[n - i + 1]).ChangeVals(Rows[i - 1]);
            }
            Rows.RemoveAt(panel1.Controls.Count-1-panel1.Controls.IndexOf((Control)sender));
            panel1.Controls.Remove((Control)sender);
        }

        public List<Row> Rows=new List<Row>
        {
            new Row(new DateTime(2016,1,1), DateTime.Today, 15)
        };

        private void button1_Click(object sender, EventArgs e)
        {
            Row r = new Row(DateTime.Today, DateTime.Today, 20);
            Rows.Add(r);
            IntervalRow c = new IntervalRow(r) {Dock = DockStyle.Top};
            c.XClick += OnXClick;
            c.Change += OnRowChange;
            panel1.Controls.Add(c);
            panel1.Controls.SetChildIndex(c,0);
            panel1.Invalidate();
        }
    }
}
