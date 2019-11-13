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
    public partial class Form6 : Form
    {
        bucynEntities db = new bucynEntities();
        public static Form6 _instance;
        public static Form6 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form6();
                return _instance;
            }
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bucynDataSet.bahan' table. You can move, or remove it, as needed.
            this.bahanTableAdapter.Fill(this.bucynDataSet.bahan);
            // TODO: This line of code loads data into the 'bucynDataSet.pembelian_bahan' table. You can move, or remove it, as needed.
            this.pembelian_bahanTableAdapter.Fill(this.bucynDataSet.pembelian_bahan);

        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void pembelian_bahanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pembelian_bahanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bucynDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = pembelian_bahanDataGridView.DataSource;
            bs.Filter = "id_pembelian like '%" + textBox1.Text + "%'";
            pembelian_bahanDataGridView.DataSource = bs;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_bahanComboBox.SelectedValue);
            DateTime dt = DateTime.Now;
            string tgl = dt.ToString("dd-MM-yyyy");
            pembelian_bahan tbl_pembelian_bahan = new pembelian_bahan();
            tbl_pembelian_bahan.id_bahan = id;
            tbl_pembelian_bahan.jumlah_bahan = Convert.ToInt32(jumlah_bahanTextBox.Text);
            tbl_pembelian_bahan.tanggal = tgl;
            db.pembelian_bahan.Add(tbl_pembelian_bahan);
            db.SaveChanges();

            bahan tbl_bahan = (from a in db.bahans where a.id_bahan == id select a).SingleOrDefault();
            tbl_bahan.stock_bahan += tbl_pembelian_bahan.jumlah_bahan;
            db.SaveChanges();

            MessageBox.Show("Data Berhasil Tersimpan");
            displayData();
        }

        private void displayData()
        {
            pembelian_bahanDataGridView.DataSource = db.pembelian_bahan.ToList();
        }
    }
}
