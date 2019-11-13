namespace DapurBucyn
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            System.Windows.Forms.Label id_penggunaanLabel;
            System.Windows.Forms.Label id_bahanLabel;
            System.Windows.Forms.Label jumlah_bahanLabel;
            this.bucynDataSet = new DapurBucyn.bucynDataSet();
            this.detail_penggunaanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detail_penggunaanTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.detail_penggunaanTableAdapter();
            this.tableAdapterManager = new DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager();
            this.detail_penggunaanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.detail_penggunaanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_penggunaanComboBox = new System.Windows.Forms.ComboBox();
            this.id_bahanComboBox = new System.Windows.Forms.ComboBox();
            this.jumlah_bahanTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.detail_penggunaanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.penggunaanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penggunaanTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.penggunaanTableAdapter();
            this.bahanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bahanTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.bahanTableAdapter();
            id_penggunaanLabel = new System.Windows.Forms.Label();
            id_bahanLabel = new System.Windows.Forms.Label();
            jumlah_bahanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penggunaanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penggunaanBindingNavigator)).BeginInit();
            this.detail_penggunaanBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penggunaanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bucynDataSet
            // 
            this.bucynDataSet.DataSetName = "bucynDataSet";
            this.bucynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detail_penggunaanBindingSource
            // 
            this.detail_penggunaanBindingSource.DataMember = "detail_penggunaan";
            this.detail_penggunaanBindingSource.DataSource = this.bucynDataSet;
            // 
            // detail_penggunaanTableAdapter
            // 
            this.detail_penggunaanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bahan_nasiTableAdapter = null;
            this.tableAdapterManager.bahanTableAdapter = this.bahanTableAdapter;
            this.tableAdapterManager.detail_penggunaanTableAdapter = this.detail_penggunaanTableAdapter;
            this.tableAdapterManager.detail_penjualanTableAdapter = null;
            this.tableAdapterManager.nasiTableAdapter = null;
            this.tableAdapterManager.pembelian_bahanTableAdapter = null;
            this.tableAdapterManager.penggunaanTableAdapter = this.penggunaanTableAdapter;
            this.tableAdapterManager.penjualanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detail_penggunaanBindingNavigator
            // 
            this.detail_penggunaanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.detail_penggunaanBindingNavigator.BindingSource = this.detail_penggunaanBindingSource;
            this.detail_penggunaanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.detail_penggunaanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.detail_penggunaanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.detail_penggunaanBindingNavigatorSaveItem});
            this.detail_penggunaanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.detail_penggunaanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.detail_penggunaanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.detail_penggunaanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.detail_penggunaanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.detail_penggunaanBindingNavigator.Name = "detail_penggunaanBindingNavigator";
            this.detail_penggunaanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.detail_penggunaanBindingNavigator.Size = new System.Drawing.Size(933, 25);
            this.detail_penggunaanBindingNavigator.TabIndex = 0;
            this.detail_penggunaanBindingNavigator.Text = "bindingNavigator1";
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
            // detail_penggunaanBindingNavigatorSaveItem
            // 
            this.detail_penggunaanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.detail_penggunaanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("detail_penggunaanBindingNavigatorSaveItem.Image")));
            this.detail_penggunaanBindingNavigatorSaveItem.Name = "detail_penggunaanBindingNavigatorSaveItem";
            this.detail_penggunaanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.detail_penggunaanBindingNavigatorSaveItem.Text = "Save Data";
            this.detail_penggunaanBindingNavigatorSaveItem.Click += new System.EventHandler(this.detail_penggunaanBindingNavigatorSaveItem_Click);
            // 
            // id_penggunaanLabel
            // 
            id_penggunaanLabel.AutoSize = true;
            id_penggunaanLabel.Location = new System.Drawing.Point(6, 11);
            id_penggunaanLabel.Name = "id_penggunaanLabel";
            id_penggunaanLabel.Size = new System.Drawing.Size(101, 17);
            id_penggunaanLabel.TabIndex = 1;
            id_penggunaanLabel.Text = "id penggunaan:";
            // 
            // id_penggunaanComboBox
            // 
            this.id_penggunaanComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detail_penggunaanBindingSource, "id_penggunaan", true));
            this.id_penggunaanComboBox.DataSource = this.penggunaanBindingSource;
            this.id_penggunaanComboBox.DisplayMember = "id_penggunaan";
            this.id_penggunaanComboBox.FormattingEnabled = true;
            this.id_penggunaanComboBox.Location = new System.Drawing.Point(113, 8);
            this.id_penggunaanComboBox.Name = "id_penggunaanComboBox";
            this.id_penggunaanComboBox.Size = new System.Drawing.Size(277, 25);
            this.id_penggunaanComboBox.TabIndex = 2;
            this.id_penggunaanComboBox.ValueMember = "id_penggunaan";
            // 
            // id_bahanLabel
            // 
            id_bahanLabel.AutoSize = true;
            id_bahanLabel.Location = new System.Drawing.Point(6, 42);
            id_bahanLabel.Name = "id_bahanLabel";
            id_bahanLabel.Size = new System.Drawing.Size(63, 17);
            id_bahanLabel.TabIndex = 3;
            id_bahanLabel.Text = "id bahan:";
            // 
            // id_bahanComboBox
            // 
            this.id_bahanComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detail_penggunaanBindingSource, "id_bahan", true));
            this.id_bahanComboBox.DataSource = this.bahanBindingSource;
            this.id_bahanComboBox.DisplayMember = "nama_bahan";
            this.id_bahanComboBox.FormattingEnabled = true;
            this.id_bahanComboBox.Location = new System.Drawing.Point(113, 39);
            this.id_bahanComboBox.Name = "id_bahanComboBox";
            this.id_bahanComboBox.Size = new System.Drawing.Size(277, 25);
            this.id_bahanComboBox.TabIndex = 4;
            this.id_bahanComboBox.ValueMember = "id_bahan";
            // 
            // jumlah_bahanLabel
            // 
            jumlah_bahanLabel.AutoSize = true;
            jumlah_bahanLabel.Location = new System.Drawing.Point(6, 73);
            jumlah_bahanLabel.Name = "jumlah_bahanLabel";
            jumlah_bahanLabel.Size = new System.Drawing.Size(91, 17);
            jumlah_bahanLabel.TabIndex = 5;
            jumlah_bahanLabel.Text = "jumlah bahan:";
            // 
            // jumlah_bahanTextBox
            // 
            this.jumlah_bahanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detail_penggunaanBindingSource, "jumlah_bahan", true));
            this.jumlah_bahanTextBox.Location = new System.Drawing.Point(113, 70);
            this.jumlah_bahanTextBox.Name = "jumlah_bahanTextBox";
            this.jumlah_bahanTextBox.Size = new System.Drawing.Size(277, 22);
            this.jumlah_bahanTextBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(id_penggunaanLabel);
            this.panel1.Controls.Add(this.id_penggunaanComboBox);
            this.panel1.Controls.Add(id_bahanLabel);
            this.panel1.Controls.Add(this.id_bahanComboBox);
            this.panel1.Controls.Add(jumlah_bahanLabel);
            this.panel1.Controls.Add(this.jumlah_bahanTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 100);
            this.panel1.TabIndex = 7;
            // 
            // detail_penggunaanDataGridView
            // 
            this.detail_penggunaanDataGridView.AutoGenerateColumns = false;
            this.detail_penggunaanDataGridView.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.detail_penggunaanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detail_penggunaanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.detail_penggunaanDataGridView.DataSource = this.detail_penggunaanBindingSource;
            this.detail_penggunaanDataGridView.GridColor = System.Drawing.Color.SaddleBrown;
            this.detail_penggunaanDataGridView.Location = new System.Drawing.Point(12, 184);
            this.detail_penggunaanDataGridView.Name = "detail_penggunaanDataGridView";
            this.detail_penggunaanDataGridView.Size = new System.Drawing.Size(555, 220);
            this.detail_penggunaanDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_detail";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_detail";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_penggunaan";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_penggunaan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_bahan";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_bahan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "jumlah_bahan";
            this.dataGridViewTextBoxColumn4.HeaderText = "jumlah_bahan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total_bahan";
            this.dataGridViewTextBoxColumn5.HeaderText = "total_bahan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 48);
            this.button2.TabIndex = 24;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "id_penggunaan : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // penggunaanBindingSource
            // 
            this.penggunaanBindingSource.DataMember = "penggunaan";
            this.penggunaanBindingSource.DataSource = this.bucynDataSet;
            // 
            // penggunaanTableAdapter
            // 
            this.penggunaanTableAdapter.ClearBeforeFill = true;
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
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.detail_penggunaanDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detail_penggunaanBindingNavigator);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form8";
            this.Text = "Form8";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form8_FormClosed);
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penggunaanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penggunaanBindingNavigator)).EndInit();
            this.detail_penggunaanBindingNavigator.ResumeLayout(false);
            this.detail_penggunaanBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detail_penggunaanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bucynDataSet bucynDataSet;
        private System.Windows.Forms.BindingSource detail_penggunaanBindingSource;
        private bucynDataSetTableAdapters.detail_penggunaanTableAdapter detail_penggunaanTableAdapter;
        private bucynDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator detail_penggunaanBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton detail_penggunaanBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox id_penggunaanComboBox;
        private System.Windows.Forms.ComboBox id_bahanComboBox;
        private System.Windows.Forms.TextBox jumlah_bahanTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView detail_penggunaanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private bucynDataSetTableAdapters.penggunaanTableAdapter penggunaanTableAdapter;
        private System.Windows.Forms.BindingSource penggunaanBindingSource;
        private bucynDataSetTableAdapters.bahanTableAdapter bahanTableAdapter;
        private System.Windows.Forms.BindingSource bahanBindingSource;
    }
}