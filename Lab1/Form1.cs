using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            iChart1.SetFunc(x=>Func(x));
            iChart1.From = 0;
            iChart1.To = 5000;
            temps = Temps();
            intervalPercentage1.Change += IntervalPercentage1_Change;
        }

        private void IntervalPercentage1_Change(object sender, EventArgs e)
        {
            temps = Temps();
            iChart1.To = temps.Aggregate((a, b) => a + b);
            iChart1.Invalidate();
        }

        private int _calcMode = 0;
        private bool _useInflation = false;
        private double _inflation = 0;
        private Func<Row, double> _deltaTime = SimpleDeltaTime;
        // ReSharper disable once InconsistentNaming
        private double T = 360;
        // ReSharper disable once InconsistentNaming
        private double PV = 10000;
        // ReSharper disable once InconsistentNaming
        private double FV = 0;
        private List<double> temps; 

        private static double SimpleDeltaTime(Row row)
        {
            return (row.Item2.Year - row.Item1.Year)*360 + (row.Item2.Month - row.Item1.Month)*30 +
                   (row.Item2.Day - row.Item1.Day);
        }

        private static double ExactDeltaTime(Row row)
        {
            return (row.Item2.Year - row.Item1.Year)*365 + row.Item2.DayOfYear - row.Item1.DayOfYear;
        }

        private void radioSimple_CheckedChanged(object sender, EventArgs e)
        {
            T = 360;
            _deltaTime = SimpleDeltaTime;
            temps = Temps();
            iChart1.Invalidate();
        }

        private void radioExact_CheckedChanged(object sender, EventArgs e)
        {
            T = 365;
            _deltaTime = ExactDeltaTime;
            temps = Temps();
            iChart1.Invalidate();
        }

        private void radioCommercial_CheckedChanged(object sender, EventArgs e)
        {
            T = 360;
            _deltaTime = ExactDeltaTime;
            temps = Temps();
            iChart1.Invalidate();
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (_calcMode == 1)
            {
                PV = 1;
                var multiplier = Func(iChart1.To);
                PV = FV/multiplier;
                textPV.Text = PV.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                FV = Func(iChart1.To);
                textFV.Text = FV.ToString(CultureInfo.InvariantCulture);
            }
            /*var avg =
                Math.Pow(
                    temps.Select((x, i) => Math.Pow(1 + intervalPercentage1.Rows[i].Item3/100, temps[i]/T))
                        .Aggregate((a, b) => a*b), 1/iChart1.To/T) - 1;*/
            double avg = 1;
            for (var i = 0; i < temps.Count; i++)
            {
                avg *= Math.Pow(1 + intervalPercentage1.Rows[i].Item3/100, temps[i]/T);
            }
            avg = Math.Pow(avg, 1/(temps.Aggregate((a, b) => a + b)/T)) - 1;
            textBox4.Text = (avg*100).ToString(CultureInfo.InvariantCulture);
        }

        private void textInflation_TextChanged(object sender, EventArgs e)
        {
            double val;
            bool success = double.TryParse(textInflation.Text, out val);
            if (success)
            {
                _inflation = val;
                iChart1.Invalidate();
            }
            else
            {
                textInflation.Text = @"ПОМИЛКА";
                MessageBox.Show(@"Введено некоректне значення!");
            }
        }

        private double Func(double t)
        {
            double tRes = t;
            if(_calcMode==1 && PV==0) Calculate(1,new EventArgs());
            
            double multiplier = 1;
            int i=0;
            for (i = 0; i < temps.Count; i++)
            {
                if (t > temps[i])
                {
                    multiplier *= 1 + intervalPercentage1.Rows[i].Item3/100*temps[i]/T;
                    t -= temps[i];
                }
                else
                {
                    break;
                }
            }
            if (t >= 1 && i < intervalPercentage1.Rows.Count)
            {
                multiplier *= 1 + intervalPercentage1.Rows[i].Item3 / 100 * t / T;
            }
            if (_useInflation)
            {
                multiplier *= 1 + _inflation/100*tRes/T;
            }
            return PV*multiplier;
        }

        private void radioInflationOn_CheckedChanged(object sender, EventArgs e)
        {
            _useInflation = true;
            textInflation.Enabled = true;
            iChart1.Invalidate();
        }

        private void radioInflationOff_CheckedChanged(object sender, EventArgs e)
        {
            _useInflation = false;
            textInflation.Enabled = false;
            iChart1.Invalidate();
        }

        private void radioPV_CheckedChanged(object sender, EventArgs e)
        {
            textFV.Enabled = false;
            textPV.Enabled = true;
            _calcMode = 0;
        }

        private void radioFV_CheckedChanged(object sender, EventArgs e)
        {
            textPV.Enabled = false;
            textFV.Enabled = true;
            _calcMode = 1;
        }

        private void textInflation_TextChanged_1(object sender, EventArgs e)
        {
            double val;
            bool success = double.TryParse(textInflation.Text, out val);
            if (success)
            {
                _inflation = val;
                iChart1.Invalidate();
            }
        }

        private List<double> Temps()
        {
            return intervalPercentage1.Rows.Select(row => _deltaTime(row)).ToList();
        }

        private void textPV_Leave(object sender, EventArgs e)
        {
            double val;
            bool success = double.TryParse(textPV.Text, out val);
            if (success)
            {
                PV = val;
                iChart1.Invalidate();
            }
            else
            {
                textPV.Text = @"ПОМИЛКА";
                MessageBox.Show(@"Введено некоректне значення!");
            }
        }

        private void textPV_TextChanged(object sender, EventArgs e)
        {
            double val;
            bool success = double.TryParse(textPV.Text, out val);
            if (success)
            {
                PV = val;
                iChart1.Invalidate();
            }
        }

        private void textFV_Leave(object sender, EventArgs e)
        {
            double val;
            bool success = double.TryParse(textFV.Text, out val);
            if (success)
            {
                FV = val;
                iChart1.Invalidate();
            }
            else
            {
                textFV.Text = @"ПОМИЛКА";
                MessageBox.Show(@"Введено некоректне значення!");
            }
        }

        private void textFV_TextChanged(object sender, EventArgs e)
        {
            double val;
            bool success = double.TryParse(textFV.Text, out val);
            if (success)
            {
                FV = val;
                iChart1.Invalidate();
            }
        }
    }
}
