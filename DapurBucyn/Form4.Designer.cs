namespace DapurBucyn
{
    partial class Form4
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
            System.Windows.Forms.Label id_nasiLabel;
            System.Windows.Forms.Label jumlah_nasiLabel;
            System.Windows.Forms.Label id_penjualanLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bucynDataSet = new DapurBucyn.bucynDataSet();
            this.detail_penjualanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detail_penjualanTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.detail_penjualanTableAdapter();
            this.tableAdapterManager = new DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager();
            this.nasiTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.nasiTableAdapter();
            this.penjualanTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.penjualanTableAdapter();
            this.detail_penjualanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.detail_penjualanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_nasiComboBox = new System.Windows.Forms.ComboBox();
            this.nasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jumlah_nasiTextBox = new System.Windows.Forms.TextBox();
            this.id_penjualanComboBox = new System.Windows.Forms.ComboBox();
            this.penjualanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.detail_penjualanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            id_nasiLabel = new System.Windows.Forms.Label();
            jumlah_nasiLabel = new System.Windows.Forms.Label();
            id_penjualanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penjualanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penjualanBindingNavigator)).BeginInit();
            this.detail_penjualanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penjualanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_nasiLabel
            // 
            id_nasiLabel.AutoSize = true;
            id_nasiLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_nasiLabel.ForeColor = System.Drawing.Color.DarkOrange;
            id_nasiLabel.Location = new System.Drawing.Point(7, 12);
            id_nasiLabel.Name = "id_nasiLabel";
            id_nasiLabel.Size = new System.Drawing.Size(48, 17);
            id_nasiLabel.TabIndex = 14;
            id_nasiLabel.Text = "id nasi:";
            // 
            // jumlah_nasiLabel
            // 
            jumlah_nasiLabel.AutoSize = true;
            jumlah_nasiLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jumlah_nasiLabel.ForeColor = System.Drawing.Color.DarkOrange;
            jumlah_nasiLabel.Location = new System.Drawing.Point(7, 74);
            jumlah_nasiLabel.Name = "jumlah_nasiLabel";
            jumlah_nasiLabel.Size = new System.Drawing.Size(76, 17);
            jumlah_nasiLabel.TabIndex = 16;
            jumlah_nasiLabel.Text = "jumlah nasi:";
            // 
            // id_penjualanLabel
            // 
            id_penjualanLabel.AutoSize = true;
            id_penjualanLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_penjualanLabel.ForeColor = System.Drawing.Color.DarkOrange;
            id_penjualanLabel.Location = new System.Drawing.Point(7, 43);
            id_penjualanLabel.Name = "id_penjualanLabel";
            id_penjualanLabel.Size = new System.Drawing.Size(84, 17);
            id_penjualanLabel.TabIndex = 18;
            id_penjualanLabel.Text = "id penjualan:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bucynDataSet
            // 
            this.bucynDataSet.DataSetName = "bucynDataSet";
            this.bucynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detail_penjualanBindingSource
            // 
            this.detail_penjualanBindingSource.DataMember = "detail_penjualan";
            this.detail_penjualanBindingSource.DataSource = this.bucynDataSet;
            // 
            // detail_penjualanTableAdapter
            // 
            this.detail_penjualanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bahan_nasiTableAdapter = null;
            this.tableAdapterManager.bahanTableAdapter = null;
            this.tableAdapterManager.detail_penggunaanTableAdapter = null;
            this.tableAdapterManager.detail_penjualanTableAdapter = this.detail_penjualanTableAdapter;
            this.tableAdapterManager.nasiTableAdapter = this.nasiTableAdapter;
            this.tableAdapterManager.pembelian_bahanTableAdapter = null;
            this.tableAdapterManager.penggunaanTableAdapter = null;
            this.tableAdapterManager.penjualanTableAdapter = this.penjualanTableAdapter;
            this.tableAdapterManager.UpdateOrder = DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nasiTableAdapter
            // 
            this.nasiTableAdapter.ClearBeforeFill = true;
            // 
            // penjualanTableAdapter
            // 
            this.penjualanTableAdapter.ClearBeforeFill = true;
            // 
            // detail_penjualanBindingNavigator
            // 
            this.detail_penjualanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.detail_penjualanBindingNavigator.BindingSource = this.detail_penjualanBindingSource;
            this.detail_penjualanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.detail_penjualanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.detail_penjualanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.detail_penjualanBindingNavigatorSaveItem});
            this.detail_penjualanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.detail_penjualanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.detail_penjualanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.detail_penjualanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.detail_penjualanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.detail_penjualanBindingNavigator.Name = "detail_penjualanBindingNavigator";
            this.detail_penjualanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.detail_penjualanBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.detail_penjualanBindingNavigator.TabIndex = 14;
            this.detail_penjualanBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // detail_penjualanBindingNavigatorSaveItem
            // 
            this.detail_penjualanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.detail_penjualanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("detail_penjualanBindingNavigatorSaveItem.Image")));
            this.detail_penjualanBindingNavigatorSaveItem.Name = "detail_penjualanBindingNavigatorSaveItem";
            this.detail_penjualanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.detail_penjualanBindingNavigatorSaveItem.Text = "Save Data";
            this.detail_penjualanBindingNavigatorSaveItem.Click += new System.EventHandler(this.detail_penjualanBindingNavigatorSaveItem_Click);
            // 
            // id_nasiComboBox
            // 
            this.id_nasiComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detail_penjualanBindingSource, "id_nasi", true));
            this.id_nasiComboBox.DataSource = this.nasiBindingSource;
            this.id_nasiComboBox.DisplayMember = "nama_nasi";
            this.id_nasiComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_nasiComboBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.id_nasiComboBox.FormattingEnabled = true;
            this.id_nasiComboBox.Location = new System.Drawing.Point(93, 9);
            this.id_nasiComboBox.Name = "id_nasiComboBox";
            this.id_nasiComboBox.Size = new System.Drawing.Size(320, 25);
            this.id_nasiComboBox.TabIndex = 15;
            this.id_nasiComboBox.ValueMember = "id_nasi";
            // 
            // nasiBindingSource
            // 
            this.nasiBindingSource.DataMember = "nasi";
            this.nasiBindingSource.DataSource = this.bucynDataSet;
            // 
            // jumlah_nasiTextBox
            // 
            this.jumlah_nasiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detail_penjualanBindingSource, "jumlah_nasi", true));
            this.jumlah_nasiTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah_nasiTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.jumlah_nasiTextBox.Location = new System.Drawing.Point(93, 71);
            this.jumlah_nasiTextBox.Name = "jumlah_nasiTextBox";
            this.jumlah_nasiTextBox.Size = new System.Drawing.Size(320, 22);
            this.jumlah_nasiTextBox.TabIndex = 17;
            // 
            // id_penjualanComboBox
            // 
            this.id_penjualanComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detail_penjualanBindingSource, "id_penjualan", true));
            this.id_penjualanComboBox.DataSource = this.penjualanBindingSource;
            this.id_penjualanComboBox.DisplayMember = "id_penjualan";
            this.id_penjualanComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_penjualanComboBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.id_penjualanComboBox.FormattingEnabled = true;
            this.id_penjualanComboBox.Location = new System.Drawing.Point(93, 40);
            this.id_penjualanComboBox.Name = "id_penjualanComboBox";
            this.id_penjualanComboBox.Size = new System.Drawing.Size(320, 25);
            this.id_penjualanComboBox.TabIndex = 19;
            this.id_penjualanComboBox.ValueMember = "id_penjualan";
            // 
            // penjualanBindingSource
            // 
            this.penjualanBindingSource.DataMember = "penjualan";
            this.penjualanBindingSource.DataSource = this.bucynDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.jumlah_nasiTextBox);
            this.panel1.Controls.Add(id_nasiLabel);
            this.panel1.Controls.Add(this.id_penjualanComboBox);
            this.panel1.Controls.Add(this.id_nasiComboBox);
            this.panel1.Controls.Add(id_penjualanLabel);
            this.panel1.Controls.Add(jumlah_nasiLabel);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 100);
            this.panel1.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 48);
            this.button2.TabIndex = 20;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // detail_penjualanDataGridView
            // 
            this.detail_penjualanDataGridView.AutoGenerateColumns = false;
            this.detail_penjualanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detail_penjualanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.detail_penjualanDataGridView.DataSource = this.detail_penjualanBindingSource;
            this.detail_penjualanDataGridView.Location = new System.Drawing.Point(12, 174);
            this.detail_penjualanDataGridView.Name = "detail_penjualanDataGridView";
            this.detail_penjualanDataGridView.Size = new System.Drawing.Size(555, 220);
            this.detail_penjualanDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_detail_pembelian";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_detail_pembelian";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_nasi";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_nasi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "jumlah_nasi";
            this.dataGridViewTextBoxColumn3.HeaderText = "jumlah_nasi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn4.HeaderText = "total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_penjualan";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_penjualan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "id_penjualan : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.detail_penjualanDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detail_penjualanBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penjualanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penjualanBindingNavigator)).EndInit();
            this.detail_penjualanBindingNavigator.ResumeLayout(false);
            this.detail_penjualanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualanBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penjualanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private bucynDataSet bucynDataSet;
        private System.Windows.Forms.BindingSource detail_penjualanBindingSource;
        private bucynDataSetTableAdapters.detail_penjualanTableAdapter detail_penjualanTableAdapter;
        private bucynDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator detail_penjualanBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton detail_penjualanBindingNavigatorSaveItem;
        private bucynDataSetTableAdapters.nasiTableAdapter nasiTableAdapter;
        private System.Windows.Forms.ComboBox id_nasiComboBox;
        private System.Windows.Forms.TextBox jumlah_nasiTextBox;
        private System.Windows.Forms.ComboBox id_penjualanComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView detail_penjualanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource nasiBindingSource;
        private bucynDataSetTableAdapters.penjualanTableAdapter penjualanTableAdapter;
        private System.Windows.Forms.BindingSource penjualanBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}