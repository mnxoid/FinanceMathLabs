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
            this.intervalPercentage1 = new Lab1.IntervalPercentage();
            this.SuspendLayout();
            // 
            // intervalPercentage1
            // 
            this.intervalPercentage1.Location = new System.Drawing.Point(185, 56);
            this.intervalPercentage1.Name = "intervalPercentage1";
            this.intervalPercentage1.Size = new System.Drawing.Size(526, 291);
            this.intervalPercentage1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 476);
            this.Controls.Add(this.intervalPercentage1);
            this.Name = "Form1";
            this.Text = "Розрахунки за  змінною ставкою";
            this.ResumeLayout(false);

        }

        #endregion

        private IntervalPercentage intervalPercentage1;
    }
}

