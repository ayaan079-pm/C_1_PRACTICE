namespace assigment.files
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnDeleteOneItem = new System.Windows.Forms.Button();
            this.btnwriteline = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnreadblock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnreadline = new System.Windows.Forms.Button();
            this.btnWriteAsync = new System.Windows.Forms.Button();
            this.btnWriteAllText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(615, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 324);
            this.listBox1.TabIndex = 17;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(370, 413);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(126, 34);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(266, 299);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(176, 34);
            this.button7.TabIndex = 15;
            this.button7.Text = "delete files";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnDeleteOneItem
            // 
            this.btnDeleteOneItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOneItem.Location = new System.Drawing.Point(248, 234);
            this.btnDeleteOneItem.Name = "btnDeleteOneItem";
            this.btnDeleteOneItem.Size = new System.Drawing.Size(205, 35);
            this.btnDeleteOneItem.TabIndex = 14;
            this.btnDeleteOneItem.Text = "Delete One Item";
            this.btnDeleteOneItem.UseVisualStyleBackColor = true;
            this.btnDeleteOneItem.Click += new System.EventHandler(this.btnDeleteOneItem_Click);
            // 
            // btnwriteline
            // 
            this.btnwriteline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwriteline.Location = new System.Drawing.Point(297, 52);
            this.btnwriteline.Name = "btnwriteline";
            this.btnwriteline.Size = new System.Drawing.Size(126, 34);
            this.btnwriteline.TabIndex = 13;
            this.btnwriteline.Text = "writeline";
            this.btnwriteline.UseVisualStyleBackColor = true;
            this.btnwriteline.Click += new System.EventHandler(this.btnwriteline_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(104, 413);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(126, 34);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnreadblock
            // 
            this.btnreadblock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadblock.Location = new System.Drawing.Point(74, 219);
            this.btnreadblock.Name = "btnreadblock";
            this.btnreadblock.Size = new System.Drawing.Size(126, 34);
            this.btnreadblock.TabIndex = 11;
            this.btnreadblock.Text = "read block";
            this.btnreadblock.UseVisualStyleBackColor = true;
            this.btnreadblock.Click += new System.EventHandler(this.btnreadblock_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(35, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "read all lines";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnreadline
            // 
            this.btnreadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadline.Location = new System.Drawing.Point(35, 52);
            this.btnreadline.Name = "btnreadline";
            this.btnreadline.Size = new System.Drawing.Size(126, 34);
            this.btnreadline.TabIndex = 9;
            this.btnreadline.Text = "readline";
            this.btnreadline.UseVisualStyleBackColor = true;
            this.btnreadline.Click += new System.EventHandler(this.btnreadline_Click);
            // 
            // btnWriteAsync
            // 
            this.btnWriteAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteAsync.Location = new System.Drawing.Point(275, 106);
            this.btnWriteAsync.Name = "btnWriteAsync";
            this.btnWriteAsync.Size = new System.Drawing.Size(167, 34);
            this.btnWriteAsync.TabIndex = 18;
            this.btnWriteAsync.Text = "WriteAsync";
            this.btnWriteAsync.UseVisualStyleBackColor = true;
            this.btnWriteAsync.Click += new System.EventHandler(this.btnWriteAsync_Click);
            // 
            // btnWriteAllText
            // 
            this.btnWriteAllText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteAllText.Location = new System.Drawing.Point(286, 165);
            this.btnWriteAllText.Name = "btnWriteAllText";
            this.btnWriteAllText.Size = new System.Drawing.Size(167, 34);
            this.btnWriteAllText.TabIndex = 19;
            this.btnWriteAllText.Text = "WriteAllText";
            this.btnWriteAllText.UseVisualStyleBackColor = true;
            this.btnWriteAllText.Click += new System.EventHandler(this.btnWriteAllText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 562);
            this.Controls.Add(this.btnWriteAllText);
            this.Controls.Add(this.btnWriteAsync);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnDeleteOneItem);
            this.Controls.Add(this.btnwriteline);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnreadblock);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnreadline);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnDeleteOneItem;
        private System.Windows.Forms.Button btnwriteline;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnreadblock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnreadline;
        private System.Windows.Forms.Button btnWriteAsync;
        private System.Windows.Forms.Button btnWriteAllText;
    }
}

