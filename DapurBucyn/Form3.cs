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
    public partial class Form3 : Form
    {
        bucynEntities db = new bucynEntities();
        public static Form3 _instance;
        public Form3()
        {
            InitializeComponent();
        }

        public static Form3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form3();
                return _instance;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bucynDataSet.penjualan' table. You can move, or remove it, as needed.
            this.penjualanTableAdapter.Fill(this.bucynDataSet.penjualan);

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void penjualanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.penjualanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bucynDataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string tgl = dt.ToString("dd-MM-yyyy");
            penjualan tbl_penjualan = new penjualan();
            tbl_penjualan.tanggal = tgl;
            tbl_penjualan.total_penjualan = 0;
            db.penjualans.Add(tbl_penjualan);
            db.SaveChanges();

            MessageBox.Show("Data Berhasil Tersimpan");
            displayData();
        }

        private void displayData()
        {
            penjualanDataGridView.DataSource = db.penjualans.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 formdetailPenjualan = new Form4();
            formdetailPenjualan.Show();
        }
    }
}
