using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private int _percentMode = 0;
        private bool _useInflation = false;
        private double _inflation = 0;

        private void radioSimple_CheckedChanged(object sender, EventArgs e)
        {
            _percentMode = 0;
            iChart1.Invalidate();
        }

        private void radioExact_CheckedChanged(object sender, EventArgs e)
        {
            _percentMode = 1;
            iChart1.Invalidate();
        }

        private void radioCommercial_CheckedChanged(object sender, EventArgs e)
        {
            _percentMode = 2;
            iChart1.Invalidate();
        }

        private void Calculate(object sender, EventArgs e)
        {

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
            return 1000*Math.Pow(1+0.15*(_percentMode+1), t)*(_useInflation?Math.Pow(1+_inflation,t):1);
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
            //
        }
    }
}
