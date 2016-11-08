namespace Lab1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCommercial = new System.Windows.Forms.RadioButton();
            this.radioExact = new System.Windows.Forms.RadioButton();
            this.radioSimple = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textInflation = new System.Windows.Forms.TextBox();
            this.radioInflationOn = new System.Windows.Forms.RadioButton();
            this.radioInflationOff = new System.Windows.Forms.RadioButton();
            this.iChart1 = new iChartLib.iChart();
            this.radioPV = new System.Windows.Forms.RadioButton();
            this.radioFV = new System.Windows.Forms.RadioButton();
            this.textPV = new System.Windows.Forms.TextBox();
            this.textFV = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.intervalPercentage1 = new Lab1.IntervalPercentage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCommercial);
            this.groupBox1.Controls.Add(this.radioExact);
            this.groupBox1.Controls.Add(this.radioSimple);
            this.groupBox1.Location = new System.Drawing.Point(12, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нарахування відсотків";
            // 
            // radioCommercial
            // 
            this.radioCommercial.AutoSize = true;
            this.radioCommercial.Location = new System.Drawing.Point(7, 66);
            this.radioCommercial.Name = "radioCommercial";
            this.radioCommercial.Size = new System.Drawing.Size(84, 17);
            this.radioCommercial.TabIndex = 2;
            this.radioCommercial.Text = "Комерційне";
            this.radioCommercial.UseVisualStyleBackColor = true;
            this.radioCommercial.CheckedChanged += new System.EventHandler(this.radioCommercial_CheckedChanged);
            // 
            // radioExact
            // 
            this.radioExact.AutoSize = true;
            this.radioExact.Location = new System.Drawing.Point(7, 43);
            this.radioExact.Name = "radioExact";
            this.radioExact.Size = new System.Drawing.Size(55, 17);
            this.radioExact.TabIndex = 1;
            this.radioExact.Text = "Точне";
            this.radioExact.UseVisualStyleBackColor = true;
            this.radioExact.CheckedChanged += new System.EventHandler(this.radioExact_CheckedChanged);
            // 
            // radioSimple
            // 
            this.radioSimple.AutoSize = true;
            this.radioSimple.Checked = true;
            this.radioSimple.Location = new System.Drawing.Point(7, 20);
            this.radioSimple.Name = "radioSimple";
            this.radioSimple.Size = new System.Drawing.Size(73, 17);
            this.radioSimple.TabIndex = 0;
            this.radioSimple.TabStop = true;
            this.radioSimple.Text = "Звичайне";
            this.radioSimple.UseVisualStyleBackColor = true;
            this.radioSimple.CheckedChanged += new System.EventHandler(this.radioSimple_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textInflation);
            this.groupBox2.Controls.Add(this.radioInflationOn);
            this.groupBox2.Controls.Add(this.radioInflationOff);
            this.groupBox2.Location = new System.Drawing.Point(12, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Інфляція";
            // 
            // textInflation
            // 
            this.textInflation.Enabled = false;
            this.textInflation.Location = new System.Drawing.Point(91, 41);
            this.textInflation.Name = "textInflation";
            this.textInflation.Size = new System.Drawing.Size(100, 20);
            this.textInflation.TabIndex = 2;
            this.textInflation.TextChanged += new System.EventHandler(this.textInflation_TextChanged_1);
            this.textInflation.Leave += new System.EventHandler(this.textInflation_TextChanged);
            // 
            // radioInflationOn
            // 
            this.radioInflationOn.AutoSize = true;
            this.radioInflationOn.Location = new System.Drawing.Point(9, 42);
            this.radioInflationOn.Name = "radioInflationOn";
            this.radioInflationOn.Size = new System.Drawing.Size(76, 17);
            this.radioInflationOn.TabIndex = 1;
            this.radioInflationOn.Text = "Ввімкнути";
            this.radioInflationOn.UseVisualStyleBackColor = true;
            this.radioInflationOn.CheckedChanged += new System.EventHandler(this.radioInflationOn_CheckedChanged);
            // 
            // radioInflationOff
            // 
            this.radioInflationOff.AutoSize = true;
            this.radioInflationOff.Checked = true;
            this.radioInflationOff.Location = new System.Drawing.Point(9, 19);
            this.radioInflationOff.Name = "radioInflationOff";
            this.radioInflationOff.Size = new System.Drawing.Size(74, 17);
            this.radioInflationOff.TabIndex = 0;
            this.radioInflationOff.TabStop = true;
            this.radioInflationOff.Text = "Вимкнути";
            this.radioInflationOff.UseVisualStyleBackColor = true;
            this.radioInflationOff.CheckedChanged += new System.EventHandler(this.radioInflationOff_CheckedChanged);
            // 
            // iChart1
            // 
            this.iChart1.ChartColor = System.Drawing.Color.DarkSlateBlue;
            this.iChart1.Draggable = false;
            this.iChart1.From = -5D;
            this.iChart1.Interactive = true;
            this.iChart1.LeftPadding = 60;
            this.iChart1.Location = new System.Drawing.Point(544, 12);
            this.iChart1.Name = "iChart1";
            this.iChart1.Parametric = false;
            this.iChart1.RightPadding = 30;
            this.iChart1.Size = new System.Drawing.Size(638, 464);
            this.iChart1.Step = 0.1D;
            this.iChart1.TabIndex = 3;
            this.iChart1.To = 5D;
            // 
            // radioPV
            // 
            this.radioPV.AutoSize = true;
            this.radioPV.Checked = true;
            this.radioPV.Location = new System.Drawing.Point(11, 20);
            this.radioPV.Name = "radioPV";
            this.radioPV.Size = new System.Drawing.Size(39, 17);
            this.radioPV.TabIndex = 5;
            this.radioPV.TabStop = true;
            this.radioPV.Text = "PV";
            this.radioPV.UseVisualStyleBackColor = true;
            this.radioPV.CheckedChanged += new System.EventHandler(this.radioPV_CheckedChanged);
            // 
            // radioFV
            // 
            this.radioFV.AutoSize = true;
            this.radioFV.Location = new System.Drawing.Point(11, 43);
            this.radioFV.Name = "radioFV";
            this.radioFV.Size = new System.Drawing.Size(38, 17);
            this.radioFV.TabIndex = 6;
            this.radioFV.Text = "FV";
            this.radioFV.UseVisualStyleBackColor = true;
            this.radioFV.CheckedChanged += new System.EventHandler(this.radioFV_CheckedChanged);
            // 
            // textPV
            // 
            this.textPV.Location = new System.Drawing.Point(56, 19);
            this.textPV.Name = "textPV";
            this.textPV.Size = new System.Drawing.Size(259, 20);
            this.textPV.TabIndex = 7;
            this.textPV.TextChanged += new System.EventHandler(this.textPV_TextChanged);
            this.textPV.Leave += new System.EventHandler(this.textPV_Leave);
            // 
            // textFV
            // 
            this.textFV.Enabled = false;
            this.textFV.Location = new System.Drawing.Point(56, 42);
            this.textFV.Name = "textFV";
            this.textFV.Size = new System.Drawing.Size(259, 20);
            this.textFV.TabIndex = 8;
            this.textFV.TextChanged += new System.EventHandler(this.textFV_TextChanged);
            this.textFV.Leave += new System.EventHandler(this.textFV_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textFV);
            this.groupBox3.Controls.Add(this.textPV);
            this.groupBox3.Controls.Add(this.radioFV);
            this.groupBox3.Controls.Add(this.radioPV);
            this.groupBox3.Location = new System.Drawing.Point(217, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 71);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Змінні (вибрана - відома)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Location = new System.Drawing.Point(217, 386);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 46);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Середня відсоткова ставка";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(11, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(304, 20);
            this.textBox4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Обчислити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calculate);
            // 
            // intervalPercentage1
            // 
            this.intervalPercentage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intervalPercentage1.Location = new System.Drawing.Point(12, 12);
            this.intervalPercentage1.Name = "intervalPercentage1";
            this.intervalPercentage1.Size = new System.Drawing.Size(526, 291);
            this.intervalPercentage1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.iChart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.intervalPercentage1);
            this.Name = "Form1";
            this.Text = "Розрахунки за  змінною ставкою";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private IntervalPercentage intervalPercentage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCommercial;
        private System.Windows.Forms.RadioButton radioExact;
        private System.Windows.Forms.RadioButton radioSimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textInflation;
        private System.Windows.Forms.RadioButton radioInflationOn;
        private System.Windows.Forms.RadioButton radioInflationOff;
        private iChartLib.iChart iChart1;
        private System.Windows.Forms.RadioButton radioPV;
        private System.Windows.Forms.RadioButton radioFV;
        private System.Windows.Forms.TextBox textPV;
        private System.Windows.Forms.TextBox textFV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
    }
}

