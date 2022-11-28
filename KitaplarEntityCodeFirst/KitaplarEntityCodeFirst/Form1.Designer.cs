namespace KitaplarEntityCodeFirst
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnlisteleyazar = new System.Windows.Forms.Button();
            this.txtyazarid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtyazarad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtyazarsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsayfasayisi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtturekleid = new System.Windows.Forms.TextBox();
            this.txtyazarekleid = new System.Windows.Forms.TextBox();
            this.cbtur = new System.Windows.Forms.ComboBox();
            this.cbyazar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkitapad = new System.Windows.Forms.TextBox();
            this.mtxtbyili = new System.Windows.Forms.MaskedTextBox();
            this.btnara = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnlistelekitap = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtturid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtturad = new System.Windows.Forms.TextBox();
            this.btnlisteletur = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblsecim = new System.Windows.Forms.Label();
            this.btnyenile = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlisteleyazar
            // 
            this.btnlisteleyazar.BackColor = System.Drawing.Color.SeaShell;
            this.btnlisteleyazar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlisteleyazar.Location = new System.Drawing.Point(345, 262);
            this.btnlisteleyazar.Name = "btnlisteleyazar";
            this.btnlisteleyazar.Size = new System.Drawing.Size(118, 36);
            this.btnlisteleyazar.TabIndex = 25;
            this.btnlisteleyazar.Text = "Yazarlar";
            this.btnlisteleyazar.UseVisualStyleBackColor = false;
            this.btnlisteleyazar.Click += new System.EventHandler(this.btnlisteleyazar_Click);
            // 
            // txtyazarid
            // 
            this.txtyazarid.Location = new System.Drawing.Point(124, 19);
            this.txtyazarid.Name = "txtyazarid";
            this.txtyazarid.Size = new System.Drawing.Size(100, 20);
            this.txtyazarid.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(90, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Id :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(35, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Yazar Adı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(13, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Yazar Soyad :";
            // 
            // txtyazarad
            // 
            this.txtyazarad.Location = new System.Drawing.Point(124, 56);
            this.txtyazarad.Name = "txtyazarad";
            this.txtyazarad.Size = new System.Drawing.Size(100, 20);
            this.txtyazarad.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox2.Controls.Add(this.txtyazarsoyad);
            this.groupBox2.Controls.Add(this.txtyazarid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtyazarad);
            this.groupBox2.Location = new System.Drawing.Point(276, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 122);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yazar Bilgi";
            // 
            // txtyazarsoyad
            // 
            this.txtyazarsoyad.Location = new System.Drawing.Point(124, 86);
            this.txtyazarsoyad.Name = "txtyazarsoyad";
            this.txtyazarsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtyazarsoyad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sayfa Sayısı :";
            // 
            // txtsayfasayisi
            // 
            this.txtsayfasayisi.Location = new System.Drawing.Point(120, 104);
            this.txtsayfasayisi.Name = "txtsayfasayisi";
            this.txtsayfasayisi.Size = new System.Drawing.Size(100, 20);
            this.txtsayfasayisi.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.txtturekleid);
            this.groupBox1.Controls.Add(this.txtyazarekleid);
            this.groupBox1.Controls.Add(this.cbtur);
            this.groupBox1.Controls.Add(this.cbyazar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsayfasayisi);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtkitapad);
            this.groupBox1.Controls.Add(this.mtxtbyili);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 212);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgi";
            // 
            // txtturekleid
            // 
            this.txtturekleid.Location = new System.Drawing.Point(223, 164);
            this.txtturekleid.Name = "txtturekleid";
            this.txtturekleid.Size = new System.Drawing.Size(21, 20);
            this.txtturekleid.TabIndex = 17;
            // 
            // txtyazarekleid
            // 
            this.txtyazarekleid.Location = new System.Drawing.Point(223, 139);
            this.txtyazarekleid.Name = "txtyazarekleid";
            this.txtyazarekleid.Size = new System.Drawing.Size(21, 20);
            this.txtyazarekleid.TabIndex = 16;
            // 
            // cbtur
            // 
            this.cbtur.FormattingEnabled = true;
            this.cbtur.Location = new System.Drawing.Point(120, 163);
            this.cbtur.Name = "cbtur";
            this.cbtur.Size = new System.Drawing.Size(100, 21);
            this.cbtur.TabIndex = 15;
            // 
            // cbyazar
            // 
            this.cbyazar.FormattingEnabled = true;
            this.cbyazar.Location = new System.Drawing.Point(120, 139);
            this.cbyazar.Name = "cbyazar";
            this.cbyazar.Size = new System.Drawing.Size(100, 21);
            this.cbyazar.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(14, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Kitabın Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yazar :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(120, 21);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Basım Yılı :";
            // 
            // txtkitapad
            // 
            this.txtkitapad.Location = new System.Drawing.Point(120, 45);
            this.txtkitapad.Name = "txtkitapad";
            this.txtkitapad.Size = new System.Drawing.Size(100, 20);
            this.txtkitapad.TabIndex = 6;
            // 
            // mtxtbyili
            // 
            this.mtxtbyili.Location = new System.Drawing.Point(120, 71);
            this.mtxtbyili.Mask = "00/00/0000";
            this.mtxtbyili.Name = "mtxtbyili";
            this.mtxtbyili.Size = new System.Drawing.Size(100, 20);
            this.mtxtbyili.TabIndex = 8;
            this.mtxtbyili.ValidatingType = typeof(System.DateTime);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.SeaShell;
            this.btnara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnara.Location = new System.Drawing.Point(283, 304);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 21;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.SeaShell;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguncelle.Location = new System.Drawing.Point(388, 304);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 20;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.SeaShell;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsil.Location = new System.Drawing.Point(184, 304);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 19;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SeaShell;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnekle.Location = new System.Drawing.Point(82, 304);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 18;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnlistelekitap
            // 
            this.btnlistelekitap.BackColor = System.Drawing.Color.SeaShell;
            this.btnlistelekitap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlistelekitap.Location = new System.Drawing.Point(82, 262);
            this.btnlistelekitap.Name = "btnlistelekitap";
            this.btnlistelekitap.Size = new System.Drawing.Size(118, 36);
            this.btnlistelekitap.TabIndex = 22;
            this.btnlistelekitap.Text = "Kitaplar";
            this.btnlistelekitap.UseVisualStyleBackColor = false;
            this.btnlistelekitap.Click += new System.EventHandler(this.btnlistelekitap_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid.Location = new System.Drawing.Point(0, 347);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(542, 140);
            this.dataGrid.TabIndex = 17;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox3.Controls.Add(this.txtturid);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtturad);
            this.groupBox3.Location = new System.Drawing.Point(276, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 75);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tür Bilgi";
            // 
            // txtturid
            // 
            this.txtturid.Location = new System.Drawing.Point(124, 18);
            this.txtturid.Name = "txtturid";
            this.txtturid.Size = new System.Drawing.Size(100, 20);
            this.txtturid.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(87, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Id :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(51, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tür Adı :";
            // 
            // txtturad
            // 
            this.txtturad.Location = new System.Drawing.Point(124, 40);
            this.txtturad.Name = "txtturad";
            this.txtturad.Size = new System.Drawing.Size(100, 20);
            this.txtturad.TabIndex = 6;
            // 
            // btnlisteletur
            // 
            this.btnlisteletur.BackColor = System.Drawing.Color.SeaShell;
            this.btnlisteletur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlisteletur.Location = new System.Drawing.Point(220, 262);
            this.btnlisteletur.Name = "btnlisteletur";
            this.btnlisteletur.Size = new System.Drawing.Size(104, 36);
            this.btnlisteletur.TabIndex = 26;
            this.btnlisteletur.Text = "Kitap Türleri";
            this.btnlisteletur.UseVisualStyleBackColor = false;
            this.btnlisteletur.Click += new System.EventHandler(this.btnlisteletur_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Seçim :";
            // 
            // lblsecim
            // 
            this.lblsecim.AutoSize = true;
            this.lblsecim.Location = new System.Drawing.Point(469, 331);
            this.lblsecim.Name = "lblsecim";
            this.lblsecim.Size = new System.Drawing.Size(19, 13);
            this.lblsecim.TabIndex = 28;
            this.lblsecim.Text = "....";
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SeaShell;
            this.btnyenile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnyenile.Location = new System.Drawing.Point(489, 8);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(41, 23);
            this.btnyenile.TabIndex = 29;
            this.btnyenile.Text = "f5";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(169, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 19);
            this.label13.TabIndex = 30;
            this.label13.Text = "Kitap Bilgi Sistemi ( CRUD )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(542, 487);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnyenile);
            this.Controls.Add(this.lblsecim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnlisteletur);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnlisteleyazar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnlistelekitap);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlisteleyazar;
        private System.Windows.Forms.TextBox txtyazarid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtyazarad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtyazarsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsayfasayisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkitapad;
        private System.Windows.Forms.MaskedTextBox mtxtbyili;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnlistelekitap;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtturid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtturad;
        private System.Windows.Forms.Button btnlisteletur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblsecim;
        private System.Windows.Forms.ComboBox cbtur;
        private System.Windows.Forms.ComboBox cbyazar;
        private System.Windows.Forms.TextBox txtturekleid;
        private System.Windows.Forms.TextBox txtyazarekleid;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Label label13;
    }
}

