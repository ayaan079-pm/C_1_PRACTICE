namespace _44assigment
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
            this.lisboxbooking = new System.Windows.Forms.ListBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtnumberguest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumbernight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtguestage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.checkbreakfast = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.checkstandard = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedhight = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkednormal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lisboxbooking
            // 
            this.lisboxbooking.FormattingEnabled = true;
            this.lisboxbooking.ItemHeight = 20;
            this.lisboxbooking.Location = new System.Drawing.Point(573, 26);
            this.lisboxbooking.Name = "lisboxbooking";
            this.lisboxbooking.Size = new System.Drawing.Size(267, 464);
            this.lisboxbooking.TabIndex = 14;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(405, 141);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(97, 46);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // txtnumberguest
            // 
            this.txtnumberguest.Location = new System.Drawing.Point(280, 160);
            this.txtnumberguest.Name = "txtnumberguest";
            this.txtnumberguest.Size = new System.Drawing.Size(241, 35);
            this.txtnumberguest.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of guest: ";
            // 
            // txtnumbernight
            // 
            this.txtnumbernight.Location = new System.Drawing.Point(280, 124);
            this.txtnumbernight.Name = "txtnumbernight";
            this.txtnumbernight.Size = new System.Drawing.Size(241, 35);
            this.txtnumbernight.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of nights : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Guest name:";
            // 
            // txtguestage
            // 
            this.txtguestage.Location = new System.Drawing.Point(275, 77);
            this.txtguestage.Name = "txtguestage";
            this.txtguestage.Size = new System.Drawing.Size(241, 35);
            this.txtguestage.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(275, 36);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(241, 35);
            this.txtname.TabIndex = 2;
            // 
            // checkbreakfast
            // 
            this.checkbreakfast.AutoSize = true;
            this.checkbreakfast.Location = new System.Drawing.Point(45, 63);
            this.checkbreakfast.Name = "checkbreakfast";
            this.checkbreakfast.Size = new System.Drawing.Size(434, 33);
            this.checkbreakfast.TabIndex = 11;
            this.checkbreakfast.Text = "Breakfast(10 per guest per nights)";
            this.checkbreakfast.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkbreakfast);
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Controls.Add(this.btncalculate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-12, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 205);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional options ";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(239, 141);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(96, 44);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(26, 136);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(152, 50);
            this.btncalculate.TabIndex = 9;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // checkstandard
            // 
            this.checkstandard.AutoSize = true;
            this.checkstandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkstandard.Location = new System.Drawing.Point(37, 83);
            this.checkstandard.Name = "checkstandard";
            this.checkstandard.Size = new System.Drawing.Size(121, 29);
            this.checkstandard.TabIndex = 7;
            this.checkstandard.TabStop = true;
            this.checkstandard.Text = "standard";
            this.checkstandard.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guest age:";
            // 
            // checkedhight
            // 
            this.checkedhight.AutoSize = true;
            this.checkedhight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedhight.Location = new System.Drawing.Point(288, 83);
            this.checkedhight.Name = "checkedhight";
            this.checkedhight.Size = new System.Drawing.Size(87, 29);
            this.checkedhight.TabIndex = 9;
            this.checkedhight.TabStop = true;
            this.checkedhight.Text = "Hight";
            this.checkedhight.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedhight);
            this.groupBox2.Controls.Add(this.checkednormal);
            this.groupBox2.Controls.Add(this.checkstandard);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 139);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Type";
            // 
            // checkednormal
            // 
            this.checkednormal.AutoSize = true;
            this.checkednormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkednormal.Location = new System.Drawing.Point(168, 83);
            this.checkednormal.Name = "checkednormal";
            this.checkednormal.Size = new System.Drawing.Size(105, 29);
            this.checkednormal.TabIndex = 8;
            this.checkednormal.TabStop = true;
            this.checkednormal.Text = "Normal";
            this.checkednormal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnumberguest);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnumbernight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtguestage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 253);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 611);
            this.Controls.Add(this.lisboxbooking);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lisboxbooking;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtnumberguest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumbernight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtguestage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.CheckBox checkbreakfast;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.RadioButton checkstandard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton checkedhight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton checkednormal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

