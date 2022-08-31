namespace LengthConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LenghtTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.inchesCheckBox = new System.Windows.Forms.CheckBox();
            this.feetCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length Converter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(308, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Convert (Inches -  Feets)";
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.AccessibleName = "LengthTextBox";
            this.LenghtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LenghtTextBox.Location = new System.Drawing.Point(149, 195);
            this.LenghtTextBox.MaxLength = 100;
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(336, 26);
            this.LenghtTextBox.TabIndex = 3;
            this.LenghtTextBox.Text = "Enter Length here...";
            this.LenghtTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.LenghtTextBox.Enter += new System.EventHandler(this.onFocusTextBox);
            this.LenghtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Length";
            // 
            // calculateBtn
            // 
            this.calculateBtn.AccessibleName = "calculationButton";
            this.calculateBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.calculateBtn.Location = new System.Drawing.Point(514, 191);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(109, 35);
            this.calculateBtn.TabIndex = 5;
            this.calculateBtn.Text = "Calculate\r\n";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // inchesCheckBox
            // 
            this.inchesCheckBox.AccessibleName = "inchesCheckBox";
            this.inchesCheckBox.AutoSize = true;
            this.inchesCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.inchesCheckBox.Checked = true;
            this.inchesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inchesCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inchesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesCheckBox.Location = new System.Drawing.Point(149, 254);
            this.inchesCheckBox.Name = "inchesCheckBox";
            this.inchesCheckBox.Size = new System.Drawing.Size(76, 24);
            this.inchesCheckBox.TabIndex = 6;
            this.inchesCheckBox.Text = "Inches";
            this.inchesCheckBox.UseVisualStyleBackColor = false;
            this.inchesCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // feetCheckBox
            // 
            this.feetCheckBox.AccessibleName = "FeetCheckBox";
            this.feetCheckBox.AutoSize = true;
            this.feetCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feetCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetCheckBox.Location = new System.Drawing.Point(149, 285);
            this.feetCheckBox.Name = "feetCheckBox";
            this.feetCheckBox.Size = new System.Drawing.Size(61, 24);
            this.feetCheckBox.TabIndex = 7;
            this.feetCheckBox.Text = "Feet";
            this.feetCheckBox.UseVisualStyleBackColor = true;
            this.feetCheckBox.CheckedChanged += new System.EventHandler(this.feetCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Conversion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.AutoSize = true;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.ForeColor = System.Drawing.Color.Black;
            this.resultTextBox.Location = new System.Drawing.Point(377, 289);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(141, 20);
            this.resultTextBox.TabIndex = 8;
            this.resultTextBox.Text = "No Conversion Yet";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.feetCheckBox);
            this.Controls.Add(this.inchesCheckBox);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LenghtTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LengthConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LenghtTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.CheckBox inchesCheckBox;
        private System.Windows.Forms.CheckBox feetCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultTextBox;
    }
}

