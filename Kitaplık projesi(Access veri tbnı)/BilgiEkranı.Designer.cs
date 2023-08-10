
namespace Kitaplık_projesi_Access_veri_tbnı_
{
    partial class BilgiEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilgiEkranı));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.rdsıfır = new System.Windows.Forms.RadioButton();
            this.rdikinciel = new System.Windows.Forms.RadioButton();
            this.cmbtur = new System.Windows.Forms.ComboBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnçıkış = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbul = new System.Windows.Forms.TextBox();
            this.btnbul = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.btnsıfırla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(5, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tür:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sayfa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Durum:";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(164, 51);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(256, 37);
            this.txtid.TabIndex = 7;
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(164, 94);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(256, 37);
            this.txtad.TabIndex = 8;
            // 
            // txtyazar
            // 
            this.txtyazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyazar.Location = new System.Drawing.Point(164, 140);
            this.txtyazar.Multiline = true;
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(256, 37);
            this.txtyazar.TabIndex = 9;
            // 
            // txtsayfa
            // 
            this.txtsayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsayfa.Location = new System.Drawing.Point(164, 184);
            this.txtsayfa.Multiline = true;
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(256, 37);
            this.txtsayfa.TabIndex = 10;
            // 
            // rdsıfır
            // 
            this.rdsıfır.AutoSize = true;
            this.rdsıfır.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdsıfır.Location = new System.Drawing.Point(164, 276);
            this.rdsıfır.Name = "rdsıfır";
            this.rdsıfır.Size = new System.Drawing.Size(75, 30);
            this.rdsıfır.TabIndex = 12;
            this.rdsıfır.TabStop = true;
            this.rdsıfır.Text = "Sıfır";
            this.rdsıfır.UseVisualStyleBackColor = true;
            this.rdsıfır.CheckedChanged += new System.EventHandler(this.rdsıfır_CheckedChanged);
            // 
            // rdikinciel
            // 
            this.rdikinciel.AutoSize = true;
            this.rdikinciel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdikinciel.Location = new System.Drawing.Point(284, 277);
            this.rdikinciel.Name = "rdikinciel";
            this.rdikinciel.Size = new System.Drawing.Size(114, 30);
            this.rdikinciel.TabIndex = 13;
            this.rdikinciel.TabStop = true;
            this.rdikinciel.Text = "İkinci El";
            this.rdikinciel.UseVisualStyleBackColor = true;
            this.rdikinciel.CheckedChanged += new System.EventHandler(this.rdikinciel_CheckedChanged);
            // 
            // cmbtur
            // 
            this.cmbtur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbtur.FormattingEnabled = true;
            this.cmbtur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Tiyatro",
            "Deneme"});
            this.cmbtur.Location = new System.Drawing.Point(164, 228);
            this.cmbtur.Name = "cmbtur";
            this.cmbtur.Size = new System.Drawing.Size(256, 37);
            this.cmbtur.TabIndex = 14;
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.SystemColors.Menu;
            this.btnlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistele.Location = new System.Drawing.Point(442, 47);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(151, 38);
            this.btnlistele.TabIndex = 15;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.SystemColors.Menu;
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(442, 92);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(151, 39);
            this.btnkaydet.TabIndex = 16;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.Menu;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(442, 140);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(151, 39);
            this.btnsil.TabIndex = 18;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.SystemColors.Menu;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(442, 188);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(151, 38);
            this.btnguncelle.TabIndex = 17;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(728, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnçıkış
            // 
            this.btnçıkış.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnçıkış.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnçıkış.Location = new System.Drawing.Point(442, 259);
            this.btnçıkış.Name = "btnçıkış";
            this.btnçıkış.Size = new System.Drawing.Size(151, 38);
            this.btnçıkış.TabIndex = 20;
            this.btnçıkış.Text = "Çıkış";
            this.btnçıkış.UseVisualStyleBackColor = false;
            this.btnçıkış.Click += new System.EventHandler(this.btnçıkış_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(666, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kitap Adı:";
            // 
            // txtbul
            // 
            this.txtbul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbul.Location = new System.Drawing.Point(801, 213);
            this.txtbul.Name = "txtbul";
            this.txtbul.Size = new System.Drawing.Size(192, 34);
            this.txtbul.TabIndex = 22;
            // 
            // btnbul
            // 
            this.btnbul.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbul.Location = new System.Drawing.Point(823, 260);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(82, 48);
            this.btnbul.TabIndex = 23;
            this.btnbul.Text = "Bul";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.MistyRose;
            this.btnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnara.Location = new System.Drawing.Point(911, 260);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(82, 48);
            this.btnara.TabIndex = 24;
            this.btnara.Text = "Harfe göre ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnsıfırla
            // 
            this.btnsıfırla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsıfırla.Location = new System.Drawing.Point(735, 261);
            this.btnsıfırla.Name = "btnsıfırla";
            this.btnsıfırla.Size = new System.Drawing.Size(82, 48);
            this.btnsıfırla.TabIndex = 25;
            this.btnsıfırla.Text = "Sıfırla";
            this.btnsıfırla.UseVisualStyleBackColor = false;
            this.btnsıfırla.Click += new System.EventHandler(this.btnsıfırla_Click);
            // 
            // BilgiEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 527);
            this.Controls.Add(this.btnsıfırla);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.txtbul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnçıkış);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.cmbtur);
            this.Controls.Add(this.rdikinciel);
            this.Controls.Add(this.rdsıfır);
            this.Controls.Add(this.txtsayfa);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "BilgiEkranı";
            this.Text = "Bilgi Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.RadioButton rdsıfır;
        private System.Windows.Forms.RadioButton rdikinciel;
        private System.Windows.Forms.ComboBox cmbtur;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnçıkış;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbul;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnsıfırla;
    }
}

