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
    public partial class Form2 : Form
    {
        bucynEntities db = new bucynEntities();
        public static Form2 _instance;
        public static Form2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form2();
                return _instance;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bucynDataSet.nasi' table. You can move, or remove it, as needed.
            this.nasiTableAdapter.Fill(this.bucynDataSet.nasi);

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void nasiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nasiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bucynDataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = nasiDataGridView.DataSource;
            bs.Filter = "nama_nasi like '%" + textBox1.Text + "%'";
            nasiDataGridView.DataSource = bs;
        }
    }
}
