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
    public partial class Form4 : Form
    {
        bucynEntities db = new bucynEntities();
        public static Form4 _instance;
        public static Form4 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form4();
                return _instance;
            }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bucynDataSet.penjualan' table. You can move, or remove it, as needed.
            this.penjualanTableAdapter.Fill(this.bucynDataSet.penjualan);
            // TODO: This line of code loads data into the 'bucynDataSet.nasi' table. You can move, or remove it, as needed.
            this.nasiTableAdapter.Fill(this.bucynDataSet.nasi);
            // TODO: This line of code loads data into the 'bucynDataSet.detail_penjualan' table. You can move, or remove it, as needed.
            this.detail_penjualanTableAdapter.Fill(this.bucynDataSet.detail_penjualan);

        }

        private void detail_penjualanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detail_penjualanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bucynDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = detail_penjualanDataGridView.DataSource;
            bs.Filter = "id_penjualan like '%" + textBox1.Text + "%'";
            detail_penjualanDataGridView.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id_nasi = Convert.ToInt32(id_nasiComboBox.SelectedValue);
            int id_penjualan = Convert.ToInt32(id_penjualanComboBox.SelectedValue);
            DateTime dt = DateTime.Now;
            string tgl = dt.ToString("dd-MM-yyyy");
            detail_penjualan tbl_detail_penjualan = new detail_penjualan();
            tbl_detail_penjualan.id_nasi = id_nasi;
            tbl_detail_penjualan.id_penjualan = id_penjualan;
            tbl_detail_penjualan.jumlah_nasi = Convert.ToInt32(jumlah_nasiTextBox.Text);
            nasi tbl_nasi = (from a in db.nasis where a.id_nasi == id_nasi select a).SingleOrDefault();
            tbl_detail_penjualan.total = tbl_nasi.harga_nasi * tbl_detail_penjualan.jumlah_nasi;
            penjualan tbl_penjualan = (from a in db.penjualans where a.id_penjualan == id_penjualan select a).SingleOrDefault();
            if (tbl_detail_penjualan.jumlah_nasi > tbl_nasi.stock_nasi)
            {
                MessageBox.Show("Transaksi batal karena stok tidak mencukupi");
            }
            else
            {
                tbl_penjualan.total_penjualan += tbl_detail_penjualan.total;
                tbl_nasi.stock_nasi -= tbl_detail_penjualan.jumlah_nasi;
                db.detail_penjualan.Add(tbl_detail_penjualan);
                db.SaveChanges();
                displayData();
            }

            MessageBox.Show("Data Berhasil Tersimpan");
            displayData();
        }

        private void displayData()
        {
            detail_penjualanDataGridView.DataSource = db.detail_penjualan.ToList();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
