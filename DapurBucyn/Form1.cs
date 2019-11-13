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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        private void bahanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lABARUGIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void daftarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(Form2.Instance);
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(Form3.Instance);
        }

        private void nASIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jENISToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm(Form5.Instance);
        }

        private void pEMBELIANToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm(Form6.Instance);
        }

        private void pENGGUNAANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(Form7.Instance);
        }
    }
}
