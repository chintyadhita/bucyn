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
    public partial class Form5 : Form
    {

        bucynEntities db = new bucynEntities();
        public static Form5 _instance;
        public static Form5 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form5();
                return _instance;
            }
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bucynDataSet.bahan' table. You can move, or remove it, as needed.
            this.bahanTableAdapter.Fill(this.bucynDataSet.bahan);

        }

        private void bahanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bahanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bucynDataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bahanDataGridView.DataSource;
            bs.Filter = "nama_bahan like '%" + textBox1.Text + "%'";
            bahanDataGridView.DataSource = bs;
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
