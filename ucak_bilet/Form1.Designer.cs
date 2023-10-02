namespace ucak_bilet
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
            this.ucusbilgi_groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nereye_comboBox2 = new System.Windows.Forms.ComboBox();
            this.nereden_comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.yolcubilgi_groupBox2 = new System.Windows.Forms.GroupBox();
            this.tarih_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saat_maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yolcuad_maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.tc_maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.tel_maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kaydet_button1 = new System.Windows.Forms.Button();
            this.kayıtliste_listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ucusbilgi_groupBox1.SuspendLayout();
            this.yolcubilgi_groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucusbilgi_groupBox1
            // 
            this.ucusbilgi_groupBox1.Controls.Add(this.saat_maskedTextBox1);
            this.ucusbilgi_groupBox1.Controls.Add(this.label4);
            this.ucusbilgi_groupBox1.Controls.Add(this.label3);
            this.ucusbilgi_groupBox1.Controls.Add(this.tarih_dateTimePicker1);
            this.ucusbilgi_groupBox1.Controls.Add(this.label2);
            this.ucusbilgi_groupBox1.Controls.Add(this.label1);
            this.ucusbilgi_groupBox1.Controls.Add(this.nereye_comboBox2);
            this.ucusbilgi_groupBox1.Controls.Add(this.nereden_comboBox1);
            this.ucusbilgi_groupBox1.Location = new System.Drawing.Point(23, 121);
            this.ucusbilgi_groupBox1.Name = "ucusbilgi_groupBox1";
            this.ucusbilgi_groupBox1.Size = new System.Drawing.Size(349, 186);
            this.ucusbilgi_groupBox1.TabIndex = 0;
            this.ucusbilgi_groupBox1.TabStop = false;
            this.ucusbilgi_groupBox1.Text = "Uçuş Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nereye:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nereden:";
            // 
            // nereye_comboBox2
            // 
            this.nereye_comboBox2.FormattingEnabled = true;
            this.nereye_comboBox2.Items.AddRange(new object[] {
            "Kocaeli",
            "Trabzon",
            "İstanbul",
            "Diyarbakır",
            "İzmir",
            "Hatay",
            "Manisa",
            "Mardin",
            "Ordu",
            "Samsun"});
            this.nereye_comboBox2.Location = new System.Drawing.Point(116, 120);
            this.nereye_comboBox2.Name = "nereye_comboBox2";
            this.nereye_comboBox2.Size = new System.Drawing.Size(121, 21);
            this.nereye_comboBox2.TabIndex = 3;
            // 
            // nereden_comboBox1
            // 
            this.nereden_comboBox1.FormattingEnabled = true;
            this.nereden_comboBox1.Items.AddRange(new object[] {
            "Kocaeli",
            "Trabzon",
            "İstanbul",
            "Diyarbakır",
            "İzmir",
            "Hatay",
            "Manisa",
            "Mardin",
            "Ordu",
            "Samsun"});
            this.nereden_comboBox1.Location = new System.Drawing.Point(116, 93);
            this.nereden_comboBox1.Name = "nereden_comboBox1";
            this.nereden_comboBox1.Size = new System.Drawing.Size(121, 21);
            this.nereden_comboBox1.TabIndex = 2;
            // 
            // yolcubilgi_groupBox2
            // 
            this.yolcubilgi_groupBox2.Controls.Add(this.kaydet_button1);
            this.yolcubilgi_groupBox2.Controls.Add(this.label7);
            this.yolcubilgi_groupBox2.Controls.Add(this.label6);
            this.yolcubilgi_groupBox2.Controls.Add(this.tel_maskedTextBox4);
            this.yolcubilgi_groupBox2.Controls.Add(this.tc_maskedTextBox3);
            this.yolcubilgi_groupBox2.Controls.Add(this.yolcuad_maskedTextBox2);
            this.yolcubilgi_groupBox2.Controls.Add(this.label5);
            this.yolcubilgi_groupBox2.Location = new System.Drawing.Point(378, 121);
            this.yolcubilgi_groupBox2.Name = "yolcubilgi_groupBox2";
            this.yolcubilgi_groupBox2.Size = new System.Drawing.Size(334, 186);
            this.yolcubilgi_groupBox2.TabIndex = 1;
            this.yolcubilgi_groupBox2.TabStop = false;
            this.yolcubilgi_groupBox2.Text = "Yolcu Bilgileri";
            // 
            // tarih_dateTimePicker1
            // 
            this.tarih_dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih_dateTimePicker1.Location = new System.Drawing.Point(116, 35);
            this.tarih_dateTimePicker1.Name = "tarih_dateTimePicker1";
            this.tarih_dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.tarih_dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saat:";
            // 
            // saat_maskedTextBox1
            // 
            this.saat_maskedTextBox1.Location = new System.Drawing.Point(116, 66);
            this.saat_maskedTextBox1.Mask = "00:00";
            this.saat_maskedTextBox1.Name = "saat_maskedTextBox1";
            this.saat_maskedTextBox1.Size = new System.Drawing.Size(38, 20);
            this.saat_maskedTextBox1.TabIndex = 2;
            this.saat_maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yolcu Ad Soyad:";
            // 
            // yolcuad_maskedTextBox2
            // 
            this.yolcuad_maskedTextBox2.Location = new System.Drawing.Point(176, 37);
            this.yolcuad_maskedTextBox2.Name = "yolcuad_maskedTextBox2";
            this.yolcuad_maskedTextBox2.Size = new System.Drawing.Size(130, 20);
            this.yolcuad_maskedTextBox2.TabIndex = 7;
            // 
            // tc_maskedTextBox3
            // 
            this.tc_maskedTextBox3.Location = new System.Drawing.Point(176, 67);
            this.tc_maskedTextBox3.Mask = "00000000000";
            this.tc_maskedTextBox3.Name = "tc_maskedTextBox3";
            this.tc_maskedTextBox3.Size = new System.Drawing.Size(130, 20);
            this.tc_maskedTextBox3.TabIndex = 8;
            // 
            // tel_maskedTextBox4
            // 
            this.tel_maskedTextBox4.Location = new System.Drawing.Point(176, 93);
            this.tel_maskedTextBox4.Mask = "(999) 000-0000";
            this.tel_maskedTextBox4.Name = "tel_maskedTextBox4";
            this.tel_maskedTextBox4.Size = new System.Drawing.Size(130, 20);
            this.tel_maskedTextBox4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(133, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(60, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefon No:";
            // 
            // kaydet_button1
            // 
            this.kaydet_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kaydet_button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kaydet_button1.Location = new System.Drawing.Point(176, 120);
            this.kaydet_button1.Name = "kaydet_button1";
            this.kaydet_button1.Size = new System.Drawing.Size(130, 39);
            this.kaydet_button1.TabIndex = 9;
            this.kaydet_button1.Text = "Kaydet";
            this.kaydet_button1.UseVisualStyleBackColor = false;
            this.kaydet_button1.Click += new System.EventHandler(this.kaydet_button1_Click);
            // 
            // kayıtliste_listBox1
            // 
            this.kayıtliste_listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtliste_listBox1.FormattingEnabled = true;
            this.kayıtliste_listBox1.HorizontalScrollbar = true;
            this.kayıtliste_listBox1.ItemHeight = 16;
            this.kayıtliste_listBox1.Location = new System.Drawing.Point(23, 313);
            this.kayıtliste_listBox1.Name = "kayıtliste_listBox1";
            this.kayıtliste_listBox1.Size = new System.Drawing.Size(689, 132);
            this.kayıtliste_listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 100);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(533, 56);
            this.label8.TabIndex = 0;
            this.label8.Text = "Hava Yolları Bilet Satış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(751, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kayıtliste_listBox1);
            this.Controls.Add(this.yolcubilgi_groupBox2);
            this.Controls.Add(this.ucusbilgi_groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ucusbilgi_groupBox1.ResumeLayout(false);
            this.ucusbilgi_groupBox1.PerformLayout();
            this.yolcubilgi_groupBox2.ResumeLayout(false);
            this.yolcubilgi_groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ucusbilgi_groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nereye_comboBox2;
        private System.Windows.Forms.ComboBox nereden_comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox yolcubilgi_groupBox2;
        private System.Windows.Forms.MaskedTextBox saat_maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tarih_dateTimePicker1;
        private System.Windows.Forms.Button kaydet_button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tel_maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox tc_maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox yolcuad_maskedTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox kayıtliste_listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}

