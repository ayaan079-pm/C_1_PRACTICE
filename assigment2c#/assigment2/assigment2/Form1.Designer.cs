namespace assigment2
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
            this.year = new System.Windows.Forms.Label();
            this.dayofmonth = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.dayoftheweek = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtdayofmonth = new System.Windows.Forms.TextBox();
            this.txtdayofweek = new System.Windows.Forms.TextBox();
            this.dateoutput = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(193, 220);
            this.year.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(131, 25);
            this.year.TabIndex = 13;
            this.year.Text = "enter the year";
            // 
            // dayofmonth
            // 
            this.dayofmonth.AutoSize = true;
            this.dayofmonth.Location = new System.Drawing.Point(168, 166);
            this.dayofmonth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dayofmonth.Name = "dayofmonth";
            this.dayofmonth.Size = new System.Drawing.Size(311, 25);
            this.dayofmonth.TabIndex = 12;
            this.dayofmonth.Text = "enter the numeric day of the month";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(168, 130);
            this.month.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(254, 25);
            this.month.TabIndex = 11;
            this.month.Text = "enter the name of the month";
            // 
            // dayoftheweek
            // 
            this.dayoftheweek.AutoSize = true;
            this.dayoftheweek.Location = new System.Drawing.Point(168, 92);
            this.dayoftheweek.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dayoftheweek.Name = "dayoftheweek";
            this.dayoftheweek.Size = new System.Drawing.Size(235, 25);
            this.dayoftheweek.TabIndex = 10;
            this.dayoftheweek.Text = "enter the day od the week";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(520, 260);
            this.txtyear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtyear.Multiline = true;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(245, 53);
            this.txtyear.TabIndex = 17;
            // 
            // txtmonth
            // 
            this.txtmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.Location = new System.Drawing.Point(520, 130);
            this.txtmonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtmonth.Multiline = true;
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(285, 42);
            this.txtmonth.TabIndex = 16;
            // 
            // txtdayofmonth
            // 
            this.txtdayofmonth.Location = new System.Drawing.Point(520, 212);
            this.txtdayofmonth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtdayofmonth.Multiline = true;
            this.txtdayofmonth.Name = "txtdayofmonth";
            this.txtdayofmonth.Size = new System.Drawing.Size(245, 35);
            this.txtdayofmonth.TabIndex = 15;
            // 
            // txtdayofweek
            // 
            this.txtdayofweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayofweek.Location = new System.Drawing.Point(520, 68);
            this.txtdayofweek.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtdayofweek.Multiline = true;
            this.txtdayofweek.Name = "txtdayofweek";
            this.txtdayofweek.Size = new System.Drawing.Size(285, 49);
            this.txtdayofweek.TabIndex = 14;
            // 
            // dateoutput
            // 
            this.dateoutput.AutoSize = true;
            this.dateoutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateoutput.Location = new System.Drawing.Point(515, 371);
            this.dateoutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateoutput.Name = "dateoutput";
            this.dateoutput.Size = new System.Drawing.Size(237, 25);
            this.dateoutput.TabIndex = 18;
            this.dateoutput.Text = "                                             ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 459);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 44);
            this.button2.TabIndex = 20;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "show data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateoutput);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayofmonth);
            this.Controls.Add(this.txtdayofweek);
            this.Controls.Add(this.year);
            this.Controls.Add(this.dayofmonth);
            this.Controls.Add(this.month);
            this.Controls.Add(this.dayoftheweek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label dayofmonth;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label dayoftheweek;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtdayofmonth;
        private System.Windows.Forms.TextBox txtdayofweek;
        private System.Windows.Forms.Label dateoutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

