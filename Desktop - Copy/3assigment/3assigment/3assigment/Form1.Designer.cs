namespace _3assigment
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
            System.Windows.Forms.Label lblelectricity;
            this.lblpriceperunit = new System.Windows.Forms.Label();
            this.lblcurrentreading = new System.Windows.Forms.Label();
            this.lblprevious = new System.Windows.Forms.Label();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblamount = new System.Windows.Forms.Label();
            this.lbltaxamount = new System.Windows.Forms.Label();
            this.lblelect = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblTotalbill = new System.Windows.Forms.Label();
            this.lblfood1 = new System.Windows.Forms.Label();
            lblelectricity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblpriceperunit
            // 
            this.lblpriceperunit.AutoSize = true;
            this.lblpriceperunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpriceperunit.Location = new System.Drawing.Point(38, 155);
            this.lblpriceperunit.Name = "lblpriceperunit";
            this.lblpriceperunit.Size = new System.Drawing.Size(215, 26);
            this.lblpriceperunit.TabIndex = 7;
            this.lblpriceperunit.Text = "Enter price per unit";
            // 
            // lblcurrentreading
            // 
            this.lblcurrentreading.AutoSize = true;
            this.lblcurrentreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrentreading.Location = new System.Drawing.Point(20, 112);
            this.lblcurrentreading.Name = "lblcurrentreading";
            this.lblcurrentreading.Size = new System.Drawing.Size(236, 26);
            this.lblcurrentreading.TabIndex = 6;
            this.lblcurrentreading.Text = "Enter current reading";
            // 
            // lblprevious
            // 
            this.lblprevious.AutoSize = true;
            this.lblprevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprevious.Location = new System.Drawing.Point(12, 72);
            this.lblprevious.Name = "lblprevious";
            this.lblprevious.Size = new System.Drawing.Size(261, 26);
            this.lblprevious.TabIndex = 5;
            this.lblprevious.Text = "Enter previous Reading";
            // 
            // txtPrevious
            // 
            this.txtPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevious.Location = new System.Drawing.Point(286, 72);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(272, 30);
            this.txtPrevious.TabIndex = 11;
            // 
            // txtcurrent
            // 
            this.txtcurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurrent.Location = new System.Drawing.Point(286, 111);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(275, 30);
            this.txtcurrent.TabIndex = 10;
            // 
            // txtunitprice
            // 
            this.txtunitprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtunitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunitprice.Location = new System.Drawing.Point(286, 147);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(275, 30);
            this.txtunitprice.TabIndex = 9;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(286, 31);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(275, 30);
            this.txtCustomer.TabIndex = 8;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(282, 213);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(203, 43);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "calculate Bill";
            this.btncalculate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(262, 349);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(338, 27);
            this.lblamount.TabIndex = 21;
            this.lblamount.Text = "                                                      ";
            // 
            // lbltaxamount
            // 
            this.lbltaxamount.AutoSize = true;
            this.lbltaxamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaxamount.Location = new System.Drawing.Point(76, 345);
            this.lbltaxamount.Name = "lbltaxamount";
            this.lbltaxamount.Size = new System.Drawing.Size(153, 26);
            this.lbltaxamount.TabIndex = 20;
            this.lbltaxamount.Text = "Tax Amount: ";
            // 
            // lblelect
            // 
            this.lblelect.AutoSize = true;
            this.lblelect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelect.Location = new System.Drawing.Point(262, 323);
            this.lblelect.Name = "lblelect";
            this.lblelect.Size = new System.Drawing.Size(320, 27);
            this.lblelect.TabIndex = 19;
            this.lblelect.Text = "                                                   ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(262, 380);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(320, 27);
            this.lbltotal.TabIndex = 18;
            this.lbltotal.Text = "                                                   ";
            // 
            // lblelectricity
            // 
            lblelectricity.AutoSize = true;
            lblelectricity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblelectricity.Location = new System.Drawing.Point(50, 319);
            lblelectricity.Name = "lblelectricity";
            lblelectricity.Size = new System.Drawing.Size(202, 26);
            lblelectricity.TabIndex = 17;
            lblelectricity.Text = "Electricity usage: ";
            // 
            // lblTotalbill
            // 
            this.lblTotalbill.AutoSize = true;
            this.lblTotalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalbill.Location = new System.Drawing.Point(112, 380);
            this.lblTotalbill.Name = "lblTotalbill";
            this.lblTotalbill.Size = new System.Drawing.Size(119, 26);
            this.lblTotalbill.TabIndex = 16;
            this.lblTotalbill.Text = "Total Bill: ";
            // 
            // lblfood1
            // 
            this.lblfood1.AutoSize = true;
            this.lblfood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood1.Location = new System.Drawing.Point(12, 39);
            this.lblfood1.Name = "lblfood1";
            this.lblfood1.Size = new System.Drawing.Size(244, 26);
            this.lblfood1.TabIndex = 4;
            this.lblfood1.Text = "Enter customer Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lbltaxamount);
            this.Controls.Add(this.lblelect);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(lblelectricity);
            this.Controls.Add(this.lblTotalbill);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblpriceperunit);
            this.Controls.Add(this.lblcurrentreading);
            this.Controls.Add(this.lblprevious);
            this.Controls.Add(this.lblfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpriceperunit;
        private System.Windows.Forms.Label lblcurrentreading;
        private System.Windows.Forms.Label lblprevious;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lbltaxamount;
        private System.Windows.Forms.Label lblelect;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblTotalbill;
        private System.Windows.Forms.Label lblfood1;
    }
}

