using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplık_projesi_Access_veri_tbnı_
{
    public partial class BilgiEkranı : Form
    {
        string durum = "";
        public BilgiEkranı()
        {
            InitializeComponent();
        }

        OleDbConnection baglantı = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\fatih\OneDrive\Masaüstü\Bookshelf(2002-2003).mdb");

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Bookshelf", baglantı);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {      
            baglantı.Open();
            OleDbCommand kmt1 = new OleDbCommand("insert into Bookshelf (KitapAD, Yazar, Sayfa, Tür, Durum) values (@p1,@p2,@p3,@p4,@p5)", baglantı);
            kmt1.Parameters.AddWithValue("@p1", txtad.Text);
            kmt1.Parameters.AddWithValue("@p2", txtyazar.Text);
            kmt1.Parameters.AddWithValue("@p3", txtsayfa.Text);
            kmt1.Parameters.AddWithValue("@p4", cmbtur.Text);
            kmt1.Parameters.AddWithValue("@p5", durum);
            kmt1.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Bilgileriniz Kaydedilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdsıfır_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void rdikinciel_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            cmbtur.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            if (dataGridView1.Rows[sec].Cells[5].Value.ToString() == "True")
            {
                rdsıfır.Checked = true;
            }
            else
                rdikinciel.Checked = true;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand kmt2 = new OleDbCommand("Delete from Bookshelf where KitapID=@p1", baglantı);
            kmt2.Parameters.AddWithValue("@p1", txtid.Text);
            kmt2.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Bilgileriniz silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand kmt3 = new OleDbCommand("update Bookshelf set KitapAD=@p1, Yazar=@p2, Sayfa=@p3, Tür=@p4, Durum=@p5 where KitapID=@p6",baglantı);
            kmt3.Parameters.AddWithValue("@p1", txtad.Text);
            kmt3.Parameters.AddWithValue("@p2", txtyazar.Text);
            kmt3.Parameters.AddWithValue("@p3", txtsayfa.Text);
            kmt3.Parameters.AddWithValue("@p4", cmbtur.Text);
            if (rdsıfır.Checked == true)
            {
                kmt3.Parameters.AddWithValue("@p5", durum);
            }
            
            if (rdikinciel.Checked == true)
            {
                kmt3.Parameters.AddWithValue("@p5", durum);
            }
            kmt3.Parameters.AddWithValue("@p6", txtid.Text);
            kmt3.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Bilgileriniz güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            
            OleDbCommand kmt4 = new OleDbCommand("Select * from Bookshelf where KitapAD=@p1", baglantı);
            kmt4.Parameters.AddWithValue("@p1", txtbul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(kmt4);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }

        private void btnsıfırla_Click(object sender, EventArgs e)
        {
            txtbul.Text = " ";
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            OleDbCommand kmt4 = new OleDbCommand("Select * from Bookshelf where KitapAD like '%"+ txtbul.Text +"%'", baglantı);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(kmt4);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
