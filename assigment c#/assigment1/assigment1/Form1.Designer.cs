namespace assigment1
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
            this.txtdayofweek = new System.Windows.Forms.TextBox();
            this.txtdayofmonth = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dayoftheweek = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.dayofmonth = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.dateoutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdayofweek
            // 
            this.txtdayofweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayofweek.Location = new System.Drawing.Point(542, 57);
            this.txtdayofweek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdayofweek.Multiline = true;
            this.txtdayofweek.Name = "txtdayofweek";
            this.txtdayofweek.Size = new System.Drawing.Size(215, 40);
            this.txtdayofweek.TabIndex = 0;
            // 
            // txtdayofmonth
            // 
            this.txtdayofmonth.Location = new System.Drawing.Point(542, 173);
            this.txtdayofmonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdayofmonth.Multiline = true;
            this.txtdayofmonth.Name = "txtdayofmonth";
            this.txtdayofmonth.Size = new System.Drawing.Size(185, 29);
            this.txtdayofmonth.TabIndex = 1;
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(542, 107);
            this.txtmonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmonth.Multiline = true;
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(215, 34);
            this.txtmonth.TabIndex = 2;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(542, 211);
            this.txtyear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtyear.Multiline = true;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(185, 43);
            this.txtyear.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "show data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 333);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dayoftheweek
            // 
            this.dayoftheweek.AutoSize = true;
            this.dayoftheweek.Location = new System.Drawing.Point(180, 71);
            this.dayoftheweek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayoftheweek.Name = "dayoftheweek";
            this.dayoftheweek.Size = new System.Drawing.Size(235, 25);
            this.dayoftheweek.TabIndex = 6;
            this.dayoftheweek.Text = "enter the day od the week";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(180, 101);
            this.month.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(254, 25);
            this.month.TabIndex = 7;
            this.month.Text = "enter the name of the month";
            this.month.Click += new System.EventHandler(this.label2_Click);
            // 
            // dayofmonth
            // 
            this.dayofmonth.AutoSize = true;
            this.dayofmonth.Location = new System.Drawing.Point(180, 130);
            this.dayofmonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayofmonth.Name = "dayofmonth";
            this.dayofmonth.Size = new System.Drawing.Size(311, 25);
            this.dayofmonth.TabIndex = 8;
            this.dayofmonth.Text = "enter the numeric day of the month";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(180, 170);
            this.year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(131, 25);
            this.year.TabIndex = 9;
            this.year.Text = "enter the year";
            // 
            // dateoutput
            // 
            this.dateoutput.AutoSize = true;
            this.dateoutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateoutput.Location = new System.Drawing.Point(505, 285);
            this.dateoutput.Name = "dateoutput";
            this.dateoutput.Size = new System.Drawing.Size(237, 25);
            this.dateoutput.TabIndex = 10;
            this.dateoutput.Text = "                                             ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 562);
            this.Controls.Add(this.dateoutput);
            this.Controls.Add(this.year);
            this.Controls.Add(this.dayofmonth);
            this.Controls.Add(this.month);
            this.Controls.Add(this.dayoftheweek);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayofmonth);
            this.Controls.Add(this.txtdayofweek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdayofweek;
        private System.Windows.Forms.TextBox txtdayofmonth;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label dayoftheweek;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label dayofmonth;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label dateoutput;
    }
}

