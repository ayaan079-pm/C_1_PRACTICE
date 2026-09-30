namespace _1assigment
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
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtdayofmonth = new System.Windows.Forms.TextBox();
            this.txtdayofweek = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.Label();
            this.dayofmonth = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.dayoftheweek = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateoutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(503, 307);
            this.txtyear.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtyear.Multiline = true;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(410, 48);
            this.txtyear.TabIndex = 21;
            // 
            // txtmonth
            // 
            this.txtmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.Location = new System.Drawing.Point(488, 182);
            this.txtmonth.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtmonth.Multiline = true;
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(393, 44);
            this.txtmonth.TabIndex = 20;
            // 
            // txtdayofmonth
            // 
            this.txtdayofmonth.Location = new System.Drawing.Point(503, 238);
            this.txtdayofmonth.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtdayofmonth.Multiline = true;
            this.txtdayofmonth.Name = "txtdayofmonth";
            this.txtdayofmonth.Size = new System.Drawing.Size(378, 45);
            this.txtdayofmonth.TabIndex = 19;
            // 
            // txtdayofweek
            // 
            this.txtdayofweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayofweek.Location = new System.Drawing.Point(488, 122);
            this.txtdayofweek.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtdayofweek.Multiline = true;
            this.txtdayofweek.Name = "txtdayofweek";
            this.txtdayofweek.Size = new System.Drawing.Size(393, 48);
            this.txtdayofweek.TabIndex = 18;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(187, 310);
            this.year.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(145, 26);
            this.year.TabIndex = 25;
            this.year.Text = "enter the year";
            // 
            // dayofmonth
            // 
            this.dayofmonth.AutoSize = true;
            this.dayofmonth.Location = new System.Drawing.Point(155, 253);
            this.dayofmonth.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.dayofmonth.Name = "dayofmonth";
            this.dayofmonth.Size = new System.Drawing.Size(349, 26);
            this.dayofmonth.TabIndex = 24;
            this.dayofmonth.Text = "enter the numeric day of the month";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(187, 187);
            this.month.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(285, 26);
            this.month.TabIndex = 23;
            this.month.Text = "enter the name of the month";
            // 
            // dayoftheweek
            // 
            this.dayoftheweek.AutoSize = true;
            this.dayoftheweek.Location = new System.Drawing.Point(197, 141);
            this.dayoftheweek.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.dayoftheweek.Name = "dayoftheweek";
            this.dayoftheweek.Size = new System.Drawing.Size(261, 26);
            this.dayoftheweek.TabIndex = 22;
            this.dayoftheweek.Text = "enter the day od the week";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 453);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 44);
            this.button2.TabIndex = 27;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 45);
            this.button1.TabIndex = 26;
            this.button1.Text = "show data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateoutput
            // 
            this.dateoutput.AutoSize = true;
            this.dateoutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateoutput.Location = new System.Drawing.Point(530, 388);
            this.dateoutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateoutput.Name = "dateoutput";
            this.dateoutput.Size = new System.Drawing.Size(282, 26);
            this.dateoutput.TabIndex = 28;
            this.dateoutput.Text = "                                             ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 584);
            this.Controls.Add(this.dateoutput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.dayofmonth);
            this.Controls.Add(this.month);
            this.Controls.Add(this.dayoftheweek);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayofmonth);
            this.Controls.Add(this.txtdayofweek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "vvvv";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtdayofmonth;
        private System.Windows.Forms.TextBox txtdayofweek;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label dayofmonth;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label dayoftheweek;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dateoutput;
    }
}

