namespace FIS
{
    partial class FormPay
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblCash = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCardName = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalitatea de plată";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(130, 150);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Numerar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(129, 207);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Card bancar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(311, 135);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(282, 60);
            this.lblCash.TabIndex = 3;
            this.lblCash.Text = "* Puteți alege modalitatea de plată,\r\nfie în numerar la livrare, fie acum, cu\r\nca" +
    "rdul bancar. \r\n";
            this.lblCash.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(622, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmă";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.Location = new System.Drawing.Point(297, 100);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(123, 40);
            this.lblCardName.TabIndex = 7;
            this.lblCardName.Text = "Nume deținător\r\n(Ion Popescu)";
            // 
            // txtCardName
            // 
            this.txtCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardName.Location = new System.Drawing.Point(500, 100);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(194, 27);
            this.txtCardName.TabIndex = 8;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(500, 149);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(194, 27);
            this.txtCardNumber.TabIndex = 10;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(297, 149);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(183, 40);
            this.lblCardNumber.TabIndex = 9;
            this.lblCardNumber.Text = "Număr card\r\n(1298-1234-5678-9012)";
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVV.Location = new System.Drawing.Point(500, 198);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(194, 27);
            this.txtCVV.TabIndex = 12;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.Location = new System.Drawing.Point(297, 198);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(91, 40);
            this.lblCVV.TabIndex = 11;
            this.lblCVV.Text = "CVV/CVV2\r\n(990)";
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpirationDate.Location = new System.Drawing.Point(500, 250);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(194, 27);
            this.txtExpirationDate.TabIndex = 14;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(297, 248);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(109, 40);
            this.lblExpirationDate.TabIndex = 13;
            this.lblExpirationDate.Text = "Data expirării\r\n(11/2024)";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(59, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Înapoi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(165, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 16;
            this.button3.Text = "Ieșire";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 18;
            // 
            // FormPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtExpirationDate);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "FormPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtExpirationDate;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}

