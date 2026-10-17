namespace _5assigment
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
            this.txtnumberbaggage = new System.Windows.Forms.TextBox();
            this.lblbaggageweight = new System.Windows.Forms.Label();
            this.txtnumberoftickets = new System.Windows.Forms.TextBox();
            this.lblnumberoftickets = new System.Windows.Forms.Label();
            this.lblpassengername = new System.Windows.Forms.Label();
            this.txtpassengerage = new System.Windows.Forms.TextBox();
            this.lblpassengerage = new System.Windows.Forms.Label();
            this.checkedbusiness = new System.Windows.Forms.RadioButton();
            this.checkednormalclass = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpassengername = new System.Windows.Forms.TextBox();
            this.checkfirstclass = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checktravel = new System.Windows.Forms.CheckBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Airlinebookingdetails = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnumberbaggage
            // 
            this.txtnumberbaggage.Location = new System.Drawing.Point(275, 166);
            this.txtnumberbaggage.Name = "txtnumberbaggage";
            this.txtnumberbaggage.Size = new System.Drawing.Size(241, 35);
            this.txtnumberbaggage.TabIndex = 10;
            // 
            // lblbaggageweight
            // 
            this.lblbaggageweight.AutoSize = true;
            this.lblbaggageweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaggageweight.Location = new System.Drawing.Point(74, 166);
            this.lblbaggageweight.Name = "lblbaggageweight";
            this.lblbaggageweight.Size = new System.Drawing.Size(179, 25);
            this.lblbaggageweight.TabIndex = 9;
            this.lblbaggageweight.Text = "Baggage weight: ";
            // 
            // txtnumberoftickets
            // 
            this.txtnumberoftickets.Location = new System.Drawing.Point(274, 118);
            this.txtnumberoftickets.Name = "txtnumberoftickets";
            this.txtnumberoftickets.Size = new System.Drawing.Size(241, 35);
            this.txtnumberoftickets.TabIndex = 8;
            // 
            // lblnumberoftickets
            // 
            this.lblnumberoftickets.AutoSize = true;
            this.lblnumberoftickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberoftickets.Location = new System.Drawing.Point(74, 130);
            this.lblnumberoftickets.Name = "lblnumberoftickets";
            this.lblnumberoftickets.Size = new System.Drawing.Size(206, 25);
            this.lblnumberoftickets.TabIndex = 7;
            this.lblnumberoftickets.Text = "Number of Tickets : ";
            // 
            // lblpassengername
            // 
            this.lblpassengername.AutoSize = true;
            this.lblpassengername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassengername.Location = new System.Drawing.Point(56, 46);
            this.lblpassengername.Name = "lblpassengername";
            this.lblpassengername.Size = new System.Drawing.Size(184, 25);
            this.lblpassengername.TabIndex = 5;
            this.lblpassengername.Text = "Passenger Name:";
            this.lblpassengername.Click += new System.EventHandler(this.l_Click);
            // 
            // txtpassengerage
            // 
            this.txtpassengerage.Location = new System.Drawing.Point(275, 77);
            this.txtpassengerage.Name = "txtpassengerage";
            this.txtpassengerage.Size = new System.Drawing.Size(241, 35);
            this.txtpassengerage.TabIndex = 3;
            // 
            // lblpassengerage
            // 
            this.lblpassengerage.AutoSize = true;
            this.lblpassengerage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassengerage.Location = new System.Drawing.Point(74, 87);
            this.lblpassengerage.Name = "lblpassengerage";
            this.lblpassengerage.Size = new System.Drawing.Size(164, 25);
            this.lblpassengerage.TabIndex = 1;
            this.lblpassengerage.Text = "Passenger age:";
            // 
            // checkedbusiness
            // 
            this.checkedbusiness.AutoSize = true;
            this.checkedbusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedbusiness.Location = new System.Drawing.Point(351, 83);
            this.checkedbusiness.Name = "checkedbusiness";
            this.checkedbusiness.Size = new System.Drawing.Size(181, 29);
            this.checkedbusiness.TabIndex = 9;
            this.checkedbusiness.TabStop = true;
            this.checkedbusiness.Text = "Business class";
            this.checkedbusiness.UseVisualStyleBackColor = true;
            this.checkedbusiness.CheckedChanged += new System.EventHandler(this.checkedhight_CheckedChanged);
            // 
            // checkednormalclass
            // 
            this.checkednormalclass.AutoSize = true;
            this.checkednormalclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkednormalclass.Location = new System.Drawing.Point(184, 83);
            this.checkednormalclass.Name = "checkednormalclass";
            this.checkednormalclass.Size = new System.Drawing.Size(161, 29);
            this.checkednormalclass.TabIndex = 8;
            this.checkednormalclass.TabStop = true;
            this.checkednormalclass.Text = "Normal class";
            this.checkednormalclass.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtnumberbaggage);
            this.groupBox1.Controls.Add(this.lblbaggageweight);
            this.groupBox1.Controls.Add(this.txtnumberoftickets);
            this.groupBox1.Controls.Add(this.lblnumberoftickets);
            this.groupBox1.Controls.Add(this.lblpassengername);
            this.groupBox1.Controls.Add(this.txtpassengerage);
            this.groupBox1.Controls.Add(this.txtpassengername);
            this.groupBox1.Controls.Add(this.lblpassengerage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 253);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal information";
            // 
            // txtpassengername
            // 
            this.txtpassengername.Location = new System.Drawing.Point(275, 36);
            this.txtpassengername.Name = "txtpassengername";
            this.txtpassengername.Size = new System.Drawing.Size(241, 35);
            this.txtpassengername.TabIndex = 2;
            // 
            // checkfirstclass
            // 
            this.checkfirstclass.AutoSize = true;
            this.checkfirstclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkfirstclass.Location = new System.Drawing.Point(24, 83);
            this.checkfirstclass.Name = "checkfirstclass";
            this.checkfirstclass.Size = new System.Drawing.Size(133, 29);
            this.checkfirstclass.TabIndex = 7;
            this.checkfirstclass.TabStop = true;
            this.checkfirstclass.Text = "first Class";
            this.checkfirstclass.UseVisualStyleBackColor = true;
            this.checkfirstclass.CheckedChanged += new System.EventHandler(this.checkstandard_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedbusiness);
            this.groupBox2.Controls.Add(this.checkednormalclass);
            this.groupBox2.Controls.Add(this.checkfirstclass);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 139);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Travel Class";
            // 
            // checktravel
            // 
            this.checktravel.AutoSize = true;
            this.checktravel.Location = new System.Drawing.Point(45, 63);
            this.checktravel.Name = "checktravel";
            this.checktravel.Size = new System.Drawing.Size(468, 33);
            this.checktravel.TabIndex = 11;
            this.checktravel.Text = "Add Travel insurance ($25 per ticket)";
            this.checktravel.UseVisualStyleBackColor = true;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checktravel);
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Controls.Add(this.btncalculate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 187);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional options ";
            // 
            // Airlinebookingdetails
            // 
            this.Airlinebookingdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Airlinebookingdetails.FormattingEnabled = true;
            this.Airlinebookingdetails.ItemHeight = 26;
            this.Airlinebookingdetails.Location = new System.Drawing.Point(621, 30);
            this.Airlinebookingdetails.Name = "Airlinebookingdetails";
            this.Airlinebookingdetails.Size = new System.Drawing.Size(267, 446);
            this.Airlinebookingdetails.TabIndex = 18;
            this.Airlinebookingdetails.SelectedIndexChanged += new System.EventHandler(this.lisboxbooking_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Airlinebookingdetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumberbaggage;
        private System.Windows.Forms.Label lblbaggageweight;
        private System.Windows.Forms.TextBox txtnumberoftickets;
        private System.Windows.Forms.Label lblnumberoftickets;
        private System.Windows.Forms.Label lblpassengername;
        private System.Windows.Forms.TextBox txtpassengerage;
        private System.Windows.Forms.Label lblpassengerage;
        private System.Windows.Forms.RadioButton checkedbusiness;
        private System.Windows.Forms.RadioButton checkednormalclass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpassengername;
        private System.Windows.Forms.RadioButton checkfirstclass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checktravel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox Airlinebookingdetails;
    }
}

