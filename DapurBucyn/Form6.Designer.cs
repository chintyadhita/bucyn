namespace DapurBucyn
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            System.Windows.Forms.Label id_bahanLabel;
            System.Windows.Forms.Label jumlah_bahanLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bucynDataSet = new DapurBucyn.bucynDataSet();
            this.pembelian_bahanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pembelian_bahanTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.pembelian_bahanTableAdapter();
            this.tableAdapterManager = new DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager();
            this.pembelian_bahanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pembelian_bahanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pembelian_bahanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_bahanComboBox = new System.Windows.Forms.ComboBox();
            this.jumlah_bahanTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bahanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bahanTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.bahanTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            id_bahanLabel = new System.Windows.Forms.Label();
            jumlah_bahanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelian_bahanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelian_bahanBindingNavigator)).BeginInit();
            this.pembelian_bahanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pembelian_bahanDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // bucynDataSet
            // 
            this.bucynDataSet.DataSetName = "bucynDataSet";
            this.bucynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pembelian_bahanBindingSource
            // 
            this.pembelian_bahanBindingSource.DataMember = "pembelian_bahan";
            this.pembelian_bahanBindingSource.DataSource = this.bucynDataSet;
            // 
            // pembelian_bahanTableAdapter
            // 
            this.pembelian_bahanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bahan_nasiTableAdapter = null;
            this.tableAdapterManager.bahanTableAdapter = this.bahanTableAdapter;
            this.tableAdapterManager.detail_penggunaanTableAdapter = null;
            this.tableAdapterManager.detail_penjualanTableAdapter = null;
            this.tableAdapterManager.nasiTableAdapter = null;
            this.tableAdapterManager.pembelian_bahanTableAdapter = this.pembelian_bahanTableAdapter;
            this.tableAdapterManager.penggunaanTableAdapter = null;
            this.tableAdapterManager.penjualanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pembelian_bahanBindingNavigator
            // 
            this.pembelian_bahanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pembelian_bahanBindingNavigator.BindingSource = this.pembelian_bahanBindingSource;
            this.pembelian_bahanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pembelian_bahanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pembelian_bahanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pembelian_bahanBindingNavigatorSaveItem});
            this.pembelian_bahanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pembelian_bahanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pembelian_bahanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pembelian_bahanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pembelian_bahanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pembelian_bahanBindingNavigator.Name = "pembelian_bahanBindingNavigator";
            this.pembelian_bahanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pembelian_bahanBindingNavigator.Size = new System.Drawing.Size(477, 25);
            this.pembelian_bahanBindingNavigator.TabIndex = 16;
            this.pembelian_bahanBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pembelian_bahanBindingNavigatorSaveItem
            // 
            this.pembelian_bahanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pembelian_bahanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pembelian_bahanBindingNavigatorSaveItem.Image")));
            this.pembelian_bahanBindingNavigatorSaveItem.Name = "pembelian_bahanBindingNavigatorSaveItem";
            this.pembelian_bahanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pembelian_bahanBindingNavigatorSaveItem.Text = "Save Data";
            this.pembelian_bahanBindingNavigatorSaveItem.Click += new System.EventHandler(this.pembelian_bahanBindingNavigatorSaveItem_Click);
            // 
            // pembelian_bahanDataGridView
            // 
            this.pembelian_bahanDataGridView.AutoGenerateColumns = false;
            this.pembelian_bahanDataGridView.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.pembelian_bahanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pembelian_bahanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pembelian_bahanDataGridView.DataSource = this.pembelian_bahanBindingSource;
            this.pembelian_bahanDataGridView.Location = new System.Drawing.Point(12, 202);
            this.pembelian_bahanDataGridView.Name = "pembelian_bahanDataGridView";
            this.pembelian_bahanDataGridView.Size = new System.Drawing.Size(455, 220);
            this.pembelian_bahanDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pembelian_bahan";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_pembelian_bahan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_bahan";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_bahan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tanggal";
            this.dataGridViewTextBoxColumn3.HeaderText = "tanggal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "jumlah_bahan";
            this.dataGridViewTextBoxColumn4.HeaderText = "jumlah_bahan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // id_bahanLabel
            // 
            id_bahanLabel.AutoSize = true;
            id_bahanLabel.Location = new System.Drawing.Point(3, 22);
            id_bahanLabel.Name = "id_bahanLabel";
            id_bahanLabel.Size = new System.Drawing.Size(63, 17);
            id_bahanLabel.TabIndex = 16;
            id_bahanLabel.Text = "id bahan:";
            // 
            // id_bahanComboBox
            // 
            this.id_bahanComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pembelian_bahanBindingSource, "id_bahan", true));
            this.id_bahanComboBox.DataSource = this.bahanBindingSource;
            this.id_bahanComboBox.DisplayMember = "nama_bahan";
            this.id_bahanComboBox.FormattingEnabled = true;
            this.id_bahanComboBox.Location = new System.Drawing.Point(100, 19);
            this.id_bahanComboBox.Name = "id_bahanComboBox";
            this.id_bahanComboBox.Size = new System.Drawing.Size(238, 25);
            this.id_bahanComboBox.TabIndex = 17;
            this.id_bahanComboBox.ValueMember = "id_bahan";
            // 
            // jumlah_bahanLabel
            // 
            jumlah_bahanLabel.AutoSize = true;
            jumlah_bahanLabel.Location = new System.Drawing.Point(3, 53);
            jumlah_bahanLabel.Name = "jumlah_bahanLabel";
            jumlah_bahanLabel.Size = new System.Drawing.Size(91, 17);
            jumlah_bahanLabel.TabIndex = 18;
            jumlah_bahanLabel.Text = "jumlah bahan:";
            // 
            // jumlah_bahanTextBox
            // 
            this.jumlah_bahanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pembelian_bahanBindingSource, "jumlah_bahan", true));
            this.jumlah_bahanTextBox.Location = new System.Drawing.Point(100, 50);
            this.jumlah_bahanTextBox.Name = "jumlah_bahanTextBox";
            this.jumlah_bahanTextBox.Size = new System.Drawing.Size(238, 22);
            this.jumlah_bahanTextBox.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(jumlah_bahanLabel);
            this.panel1.Controls.Add(id_bahanLabel);
            this.panel1.Controls.Add(this.jumlah_bahanTextBox);
            this.panel1.Controls.Add(this.id_bahanComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 89);
            this.panel1.TabIndex = 20;
            // 
            // bahanBindingSource
            // 
            this.bahanBindingSource.DataMember = "bahan";
            this.bahanBindingSource.DataSource = this.bucynDataSet;
            // 
            // bahanTableAdapter
            // 
            this.bahanTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 54);
            this.button1.TabIndex = 20;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "id_pembelian : ";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(477, 440);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pembelian_bahanDataGridView);
            this.Controls.Add(this.pembelian_bahanBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form6";
            this.Text = "Form6";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelian_bahanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelian_bahanBindingNavigator)).EndInit();
            this.pembelian_bahanBindingNavigator.ResumeLayout(false);
            this.pembelian_bahanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pembelian_bahanDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private bucynDataSet bucynDataSet;
        private System.Windows.Forms.BindingSource pembelian_bahanBindingSource;
        private bucynDataSetTableAdapters.pembelian_bahanTableAdapter pembelian_bahanTableAdapter;
        private bucynDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pembelian_bahanBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pembelian_bahanBindingNavigatorSaveItem;
        private bucynDataSetTableAdapters.bahanTableAdapter bahanTableAdapter;
        private System.Windows.Forms.DataGridView pembelian_bahanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox id_bahanComboBox;
        private System.Windows.Forms.TextBox jumlah_bahanTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bahanBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}