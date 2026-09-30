namespace tryassigment
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
            this.lblfood1 = new System.Windows.Forms.Label();
            this.lblpricefood1 = new System.Windows.Forms.Label();
            this.lblfood2 = new System.Windows.Forms.Label();
            this.lblprice2 = new System.Windows.Forms.Label();
            this.txtfoodname1 = new System.Windows.Forms.TextBox();
            this.txtpricefood2 = new System.Windows.Forms.TextBox();
            this.txtfoodname2 = new System.Windows.Forms.TextBox();
            this.txtpricefood1 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblTotalamount = new System.Windows.Forms.Label();
            this.lblsalestax = new System.Windows.Forms.Label();
            this.largelbl = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblsales = new System.Windows.Forms.Label();
            this.lbltipsamount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfood1
            // 
            this.lblfood1.AutoSize = true;
            this.lblfood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood1.Location = new System.Drawing.Point(153, 67);
            this.lblfood1.Name = "lblfood1";
            this.lblfood1.Size = new System.Drawing.Size(166, 25);
            this.lblfood1.TabIndex = 0;
            this.lblfood1.Text = "Enter name food1";
            this.lblfood1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpricefood1
            // 
            this.lblpricefood1.AutoSize = true;
            this.lblpricefood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpricefood1.Location = new System.Drawing.Point(153, 100);
            this.lblpricefood1.Name = "lblpricefood1";
            this.lblpricefood1.Size = new System.Drawing.Size(159, 25);
            this.lblpricefood1.TabIndex = 1;
            this.lblpricefood1.Text = "Enter price food1";
            // 
            // lblfood2
            // 
            this.lblfood2.AutoSize = true;
            this.lblfood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood2.Location = new System.Drawing.Point(153, 142);
            this.lblfood2.Name = "lblfood2";
            this.lblfood2.Size = new System.Drawing.Size(166, 25);
            this.lblfood2.TabIndex = 2;
            this.lblfood2.Text = "Enter name food2";
            // 
            // lblprice2
            // 
            this.lblprice2.AutoSize = true;
            this.lblprice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice2.Location = new System.Drawing.Point(143, 183);
            this.lblprice2.Name = "lblprice2";
            this.lblprice2.Size = new System.Drawing.Size(159, 25);
            this.lblprice2.TabIndex = 3;
            this.lblprice2.Text = "Enter price food2";
            // 
            // txtfoodname1
            // 
            this.txtfoodname1.Location = new System.Drawing.Point(385, 68);
            this.txtfoodname1.Name = "txtfoodname1";
            this.txtfoodname1.Size = new System.Drawing.Size(185, 26);
            this.txtfoodname1.TabIndex = 4;
            // 
            // txtpricefood2
            // 
            this.txtpricefood2.Location = new System.Drawing.Point(385, 184);
            this.txtpricefood2.Name = "txtpricefood2";
            this.txtpricefood2.Size = new System.Drawing.Size(185, 26);
            this.txtpricefood2.TabIndex = 5;
            // 
            // txtfoodname2
            // 
            this.txtfoodname2.Location = new System.Drawing.Point(385, 141);
            this.txtfoodname2.Name = "txtfoodname2";
            this.txtfoodname2.Size = new System.Drawing.Size(185, 26);
            this.txtfoodname2.TabIndex = 6;
            // 
            // txtpricefood1
            // 
            this.txtpricefood1.Location = new System.Drawing.Point(385, 99);
            this.txtpricefood1.Name = "txtpricefood1";
            this.txtpricefood1.Size = new System.Drawing.Size(185, 26);
            this.txtpricefood1.TabIndex = 7;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(274, 228);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(203, 43);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "calculate the prize";
            this.btncalculate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblTotalamount
            // 
            this.lblTotalamount.AutoSize = true;
            this.lblTotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalamount.Location = new System.Drawing.Point(51, 407);
            this.lblTotalamount.Name = "lblTotalamount";
            this.lblTotalamount.Size = new System.Drawing.Size(132, 25);
            this.lblTotalamount.TabIndex = 9;
            this.lblTotalamount.Text = "Total amount:";
            this.lblTotalamount.Click += new System.EventHandler(this.lblTotalamount_Click);
            // 
            // lblsalestax
            // 
            this.lblsalestax.AutoSize = true;
            this.lblsalestax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalestax.Location = new System.Drawing.Point(80, 347);
            this.lblsalestax.Name = "lblsalestax";
            this.lblsalestax.Size = new System.Drawing.Size(103, 25);
            this.lblsalestax.TabIndex = 10;
            this.lblsalestax.Text = "sales Tax:";
            // 
            // largelbl
            // 
            this.largelbl.AutoSize = true;
            this.largelbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.largelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largelbl.Location = new System.Drawing.Point(187, 289);
            this.largelbl.Name = "largelbl";
            this.largelbl.Size = new System.Drawing.Size(383, 42);
            this.largelbl.TabIndex = 11;
            this.largelbl.Text = "                                                                                 " +
    "            \r\n                                                        \r\n";
            this.largelbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Location = new System.Drawing.Point(201, 407);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(215, 22);
            this.lbltotal.TabIndex = 12;
            this.lbltotal.Text = "                                                   ";
            // 
            // lblsales
            // 
            this.lblsales.AutoSize = true;
            this.lblsales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsales.Location = new System.Drawing.Point(189, 347);
            this.lblsales.Name = "lblsales";
            this.lblsales.Size = new System.Drawing.Size(227, 22);
            this.lblsales.TabIndex = 13;
            this.lblsales.Text = "                                                      ";
            // 
            // lbltipsamount
            // 
            this.lbltipsamount.AutoSize = true;
            this.lbltipsamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipsamount.Location = new System.Drawing.Point(71, 372);
            this.lbltipsamount.Name = "lbltipsamount";
            this.lbltipsamount.Size = new System.Drawing.Size(126, 25);
            this.lbltipsamount.TabIndex = 14;
            this.lbltipsamount.Text = "Tips amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(201, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "                                                      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltipsamount);
            this.Controls.Add(this.lblsales);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.largelbl);
            this.Controls.Add(this.lblsalestax);
            this.Controls.Add(this.lblTotalamount);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtpricefood1);
            this.Controls.Add(this.txtfoodname2);
            this.Controls.Add(this.txtpricefood2);
            this.Controls.Add(this.txtfoodname1);
            this.Controls.Add(this.lblprice2);
            this.Controls.Add(this.lblfood2);
            this.Controls.Add(this.lblpricefood1);
            this.Controls.Add(this.lblfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfood1;
        private System.Windows.Forms.Label lblpricefood1;
        private System.Windows.Forms.Label lblfood2;
        private System.Windows.Forms.Label lblprice2;
        private System.Windows.Forms.TextBox txtfoodname1;
        private System.Windows.Forms.TextBox txtpricefood2;
        private System.Windows.Forms.TextBox txtfoodname2;
        private System.Windows.Forms.TextBox txtpricefood1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblTotalamount;
        private System.Windows.Forms.Label lblsalestax;
        private System.Windows.Forms.Label largelbl;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblsales;
        private System.Windows.Forms.Label lbltipsamount;
        private System.Windows.Forms.Label label2;
    }
}

