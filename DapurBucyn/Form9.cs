using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapurBucyn
{
    public partial class Form9 : Form
    {
        bucynEntities db = new bucynEntities();
        public static Form9 _instance;
        public static Form9 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form9();
                return _instance;
            }
        }

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bucynDataSet.penggunaan' table. You can move, or remove it, as needed.
            this.penggunaanTableAdapter.Fill(this.bucynDataSet.penggunaan);
            // TODO: This line of code loads data into the 'bucynDataSet.nasi' table. You can move, or remove it, as needed.
            this.nasiTableAdapter.Fill(this.bucynDataSet.nasi);
            // TODO: This line of code loads data into the 'bucynDataSet.bahan_nasi' table. You can move, or remove it, as needed.
            this.bahan_nasiTableAdapter.Fill(this.bucynDataSet.bahan_nasi);

        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void bahan_nasiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bahan_nasiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bucynDataSet);

        }

        private void bahan_nasiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id_nasi = Convert.ToInt32(id_nasiComboBox.SelectedValue);
            int id_penggunaan = Convert.ToInt32(id_penggunaanComboBox.SelectedValue);
            DateTime dt = DateTime.Now;
            string tgl = dt.ToString("dd-MM-yyyy");
            bahan_nasi tbl_bahan_nasi = new bahan_nasi();
            tbl_bahan_nasi.id_penggunaan = id_penggunaan;
            tbl_bahan_nasi.id_nasi = id_nasi;
            tbl_bahan_nasi.jumlah_nasi = Convert.ToInt32(jumlah_nasiTextBox.Text);
            nasi tbl_nasi = (from a in db.nasis where a.id_nasi == id_nasi select a).SingleOrDefault();
            penggunaan tbl_penggunaan = (from a in db.penggunaans where a.id_penggunaan == id_penggunaan select a).SingleOrDefault();
            tbl_bahan_nasi.laba_rugi = (tbl_nasi.harga_nasi * tbl_bahan_nasi.jumlah_nasi) - tbl_penggunaan.total_penggunaan;
            tbl_nasi.stock_nasi += tbl_bahan_nasi.jumlah_nasi;
            db.bahan_nasi.Add(tbl_bahan_nasi);
            db.SaveChanges();
            MessageBox.Show("Data Berhasil Tersimpan");
            displayData();
        }
        private void displayData()
        {
            bahan_nasiDataGridView.DataSource = db.bahan_nasi.ToList();
        }
    }
}
