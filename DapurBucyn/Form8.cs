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
    public partial class Form8 : Form
    {

        bucynEntities db = new bucynEntities();
        public static Form8 _instance;
        public static Form8 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form8();
                return _instance;
            }
        }

        public Form8()
        {
            InitializeComponent();
        }

        private void detail_penggunaanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detail_penggunaanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bucynDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bucynDataSet.bahan' table. You can move, or remove it, as needed.
            this.bahanTableAdapter.Fill(this.bucynDataSet.bahan);
            // TODO: This line of code loads data into the 'bucynDataSet.penggunaan' table. You can move, or remove it, as needed.
            this.penggunaanTableAdapter.Fill(this.bucynDataSet.penggunaan);
            // TODO: This line of code loads data into the 'bucynDataSet.detail_penggunaan' table. You can move, or remove it, as needed.
            this.detail_penggunaanTableAdapter.Fill(this.bucynDataSet.detail_penggunaan);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id_penggunaan = Convert.ToInt32(id_penggunaanComboBox.SelectedValue);
            int id_bahan = Convert.ToInt32(id_bahanComboBox.SelectedValue);
            DateTime dt = DateTime.Now;
            string tgl = dt.ToString("dd-MM-yyyy");
            detail_penggunaan tbl_detail_penggunaan = new detail_penggunaan();
            tbl_detail_penggunaan.id_penggunaan = id_penggunaan;
            tbl_detail_penggunaan.id_bahan = id_bahan;
            tbl_detail_penggunaan.jumlah_bahan = Convert.ToInt32(jumlah_bahanTextBox.Text);
            bahan tbl_bahan = (from a in db.bahans where a.id_bahan == id_bahan select a).SingleOrDefault();
            tbl_detail_penggunaan.total_bahan = tbl_bahan.harga_bahan * tbl_detail_penggunaan.jumlah_bahan;
            penggunaan tbl_penggunaan = (from a in db.penggunaans where a.id_penggunaan == id_penggunaan select a).SingleOrDefault();
            tbl_penggunaan.total_penggunaan += tbl_detail_penggunaan.total_bahan;
            tbl_bahan.stock_bahan -= tbl_detail_penggunaan.jumlah_bahan;
            db.detail_penggunaan.Add(tbl_detail_penggunaan);
            db.SaveChanges();
            MessageBox.Show("Data Berhasil Tersimpan");
            displayData();
        }

        private void displayData()
        {
            detail_penggunaanDataGridView.DataSource = db.detail_penggunaan.ToList();
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
