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
    public partial class Form7 : Form
    {
        bucynEntities db = new bucynEntities();
        public static Form7 _instance;
        public static Form7 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form7();
                return _instance;
            }
        }
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bucynDataSet.penggunaan' table. You can move, or remove it, as needed.
            this.penggunaanTableAdapter.Fill(this.bucynDataSet.penggunaan);

        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void penggunaanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.penggunaanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bucynDataSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string tgl = dt.ToString("dd-MM-yyyy");
            penggunaan tbl_penggunaan = new penggunaan();
            tbl_penggunaan.tanggal = tgl;
            tbl_penggunaan.total_penggunaan = 0;
            db.penggunaans.Add(tbl_penggunaan);
            db.SaveChanges();

            MessageBox.Show("Data Berhasil Tersimpan");
            displayData();
        }

        private void displayData()
        {
            penggunaanDataGridView.DataSource = db.penggunaans.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 formdetailPenggunaan = new Form8();
            formdetailPenggunaan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 formHasilNasi = new Form9();
            formHasilNasi.Show();
        }
    }
}
