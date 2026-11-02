namespace payroll_with_overtime
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtgrosspay = new System.Windows.Forms.TextBox();
            this.txtpayrate = new System.Windows.Forms.TextBox();
            this.txthoursworked = new System.Windows.Forms.TextBox();
            this.lblgrosspay = new System.Windows.Forms.Label();
            this.lblpayrate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btncalculate);
            this.groupBox1.Controls.Add(this.txtgrosspay);
            this.groupBox1.Controls.Add(this.txtpayrate);
            this.groupBox1.Controls.Add(this.txthoursworked);
            this.groupBox1.Controls.Add(this.lblgrosspay);
            this.groupBox1.Controls.Add(this.lblpayrate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The payroll with overtime";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(515, 318);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(200, 42);
            this.btnexit.TabIndex = 17;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(309, 318);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(200, 42);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(22, 318);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(271, 42);
            this.btncalculate.TabIndex = 15;
            this.btncalculate.Text = "Calculate gross pay";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click_1);
            // 
            // txtgrosspay
            // 
            this.txtgrosspay.Location = new System.Drawing.Point(187, 193);
            this.txtgrosspay.Name = "txtgrosspay";
            this.txtgrosspay.Size = new System.Drawing.Size(287, 39);
            this.txtgrosspay.TabIndex = 14;
            // 
            // txtpayrate
            // 
            this.txtpayrate.Location = new System.Drawing.Point(228, 113);
            this.txtpayrate.Name = "txtpayrate";
            this.txtpayrate.Size = new System.Drawing.Size(256, 39);
            this.txtpayrate.TabIndex = 13;
            // 
            // txthoursworked
            // 
            this.txthoursworked.Location = new System.Drawing.Point(228, 53);
            this.txthoursworked.Name = "txthoursworked";
            this.txthoursworked.Size = new System.Drawing.Size(256, 39);
            this.txthoursworked.TabIndex = 12;
            // 
            // lblgrosspay
            // 
            this.lblgrosspay.AutoSize = true;
            this.lblgrosspay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosspay.Location = new System.Drawing.Point(43, 189);
            this.lblgrosspay.Name = "lblgrosspay";
            this.lblgrosspay.Size = new System.Drawing.Size(127, 29);
            this.lblgrosspay.TabIndex = 11;
            this.lblgrosspay.Text = "Gross pay:";
            // 
            // lblpayrate
            // 
            this.lblpayrate.AutoSize = true;
            this.lblpayrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayrate.Location = new System.Drawing.Point(43, 109);
            this.lblpayrate.Name = "lblpayrate";
            this.lblpayrate.Size = new System.Drawing.Size(179, 29);
            this.lblpayrate.TabIndex = 10;
            this.lblpayrate.Text = "Hourly pay rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hours worked:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtgrosspay;
        private System.Windows.Forms.TextBox txtpayrate;
        private System.Windows.Forms.TextBox txthoursworked;
        private System.Windows.Forms.Label lblgrosspay;
        private System.Windows.Forms.Label lblpayrate;
        private System.Windows.Forms.Label label1;
    }
}

