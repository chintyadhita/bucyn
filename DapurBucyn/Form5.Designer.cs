namespace DapurBucyn
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label nama_bahanLabel;
            System.Windows.Forms.Label harga_bahanLabel;
            System.Windows.Forms.Label stock_bahanLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bucynDataSet = new DapurBucyn.bucynDataSet();
            this.bahanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bahanTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.bahanTableAdapter();
            this.tableAdapterManager = new DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager();
            this.bahanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bahanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bahanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_bahanTextBox = new System.Windows.Forms.TextBox();
            this.harga_bahanTextBox = new System.Windows.Forms.TextBox();
            this.stock_bahanTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            nama_bahanLabel = new System.Windows.Forms.Label();
            harga_bahanLabel = new System.Windows.Forms.Label();
            stock_bahanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingNavigator)).BeginInit();
            this.bahanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bahanDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bucynDataSet
            // 
            this.bucynDataSet.DataSetName = "bucynDataSet";
            this.bucynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bahan_nasiTableAdapter = null;
            this.tableAdapterManager.bahanTableAdapter = this.bahanTableAdapter;
            this.tableAdapterManager.detail_penggunaanTableAdapter = null;
            this.tableAdapterManager.detail_penjualanTableAdapter = null;
            this.tableAdapterManager.nasiTableAdapter = null;
            this.tableAdapterManager.pembelian_bahanTableAdapter = null;
            this.tableAdapterManager.penggunaanTableAdapter = null;
            this.tableAdapterManager.penjualanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bahanBindingNavigator
            // 
            this.bahanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bahanBindingNavigator.BindingSource = this.bahanBindingSource;
            this.bahanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bahanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bahanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bahanBindingNavigatorSaveItem});
            this.bahanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bahanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bahanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bahanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bahanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bahanBindingNavigator.Name = "bahanBindingNavigator";
            this.bahanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bahanBindingNavigator.Size = new System.Drawing.Size(846, 25);
            this.bahanBindingNavigator.TabIndex = 15;
            this.bahanBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bahanBindingNavigatorSaveItem
            // 
            this.bahanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bahanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bahanBindingNavigatorSaveItem.Image")));
            this.bahanBindingNavigatorSaveItem.Name = "bahanBindingNavigatorSaveItem";
            this.bahanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.bahanBindingNavigatorSaveItem.Text = "Save Data";
            this.bahanBindingNavigatorSaveItem.Click += new System.EventHandler(this.bahanBindingNavigatorSaveItem_Click);
            // 
            // bahanDataGridView
            // 
            this.bahanDataGridView.AutoGenerateColumns = false;
            this.bahanDataGridView.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.bahanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bahanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bahanDataGridView.DataSource = this.bahanBindingSource;
            this.bahanDataGridView.Location = new System.Drawing.Point(12, 200);
            this.bahanDataGridView.Name = "bahanDataGridView";
            this.bahanDataGridView.Size = new System.Drawing.Size(448, 220);
            this.bahanDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_bahan";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_bahan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama_bahan";
            this.dataGridViewTextBoxColumn2.HeaderText = "nama_bahan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "harga_bahan";
            this.dataGridViewTextBoxColumn3.HeaderText = "harga_bahan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stock_bahan";
            this.dataGridViewTextBoxColumn4.HeaderText = "stock_bahan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // nama_bahanLabel
            // 
            nama_bahanLabel.AutoSize = true;
            nama_bahanLabel.Location = new System.Drawing.Point(10, 16);
            nama_bahanLabel.Name = "nama_bahanLabel";
            nama_bahanLabel.Size = new System.Drawing.Size(86, 17);
            nama_bahanLabel.TabIndex = 15;
            nama_bahanLabel.Text = "nama bahan:";
            // 
            // nama_bahanTextBox
            // 
            this.nama_bahanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bahanBindingSource, "nama_bahan", true));
            this.nama_bahanTextBox.Location = new System.Drawing.Point(103, 11);
            this.nama_bahanTextBox.Name = "nama_bahanTextBox";
            this.nama_bahanTextBox.Size = new System.Drawing.Size(213, 22);
            this.nama_bahanTextBox.TabIndex = 16;
            // 
            // harga_bahanLabel
            // 
            harga_bahanLabel.AutoSize = true;
            harga_bahanLabel.Location = new System.Drawing.Point(10, 42);
            harga_bahanLabel.Name = "harga_bahanLabel";
            harga_bahanLabel.Size = new System.Drawing.Size(87, 17);
            harga_bahanLabel.TabIndex = 17;
            harga_bahanLabel.Text = "harga bahan:";
            // 
            // harga_bahanTextBox
            // 
            this.harga_bahanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bahanBindingSource, "harga_bahan", true));
            this.harga_bahanTextBox.Location = new System.Drawing.Point(103, 37);
            this.harga_bahanTextBox.Name = "harga_bahanTextBox";
            this.harga_bahanTextBox.Size = new System.Drawing.Size(213, 22);
            this.harga_bahanTextBox.TabIndex = 18;
            // 
            // stock_bahanLabel
            // 
            stock_bahanLabel.AutoSize = true;
            stock_bahanLabel.Location = new System.Drawing.Point(10, 68);
            stock_bahanLabel.Name = "stock_bahanLabel";
            stock_bahanLabel.Size = new System.Drawing.Size(84, 17);
            stock_bahanLabel.TabIndex = 19;
            stock_bahanLabel.Text = "stock bahan:";
            // 
            // stock_bahanTextBox
            // 
            this.stock_bahanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bahanBindingSource, "stock_bahan", true));
            this.stock_bahanTextBox.Location = new System.Drawing.Point(103, 63);
            this.stock_bahanTextBox.Name = "stock_bahanTextBox";
            this.stock_bahanTextBox.Size = new System.Drawing.Size(213, 22);
            this.stock_bahanTextBox.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stock_bahanTextBox);
            this.panel1.Controls.Add(nama_bahanLabel);
            this.panel1.Controls.Add(stock_bahanLabel);
            this.panel1.Controls.Add(this.nama_bahanTextBox);
            this.panel1.Controls.Add(this.harga_bahanTextBox);
            this.panel1.Controls.Add(harga_bahanLabel);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 100);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nama Bahan : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(846, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bahanDataGridView);
            this.Controls.Add(this.bahanBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingNavigator)).EndInit();
            this.bahanBindingNavigator.ResumeLayout(false);
            this.bahanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bahanDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private bucynDataSet bucynDataSet;
        private System.Windows.Forms.BindingSource bahanBindingSource;
        private bucynDataSetTableAdapters.bahanTableAdapter bahanTableAdapter;
        private bucynDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bahanBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bahanBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bahanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox nama_bahanTextBox;
        private System.Windows.Forms.TextBox harga_bahanTextBox;
        private System.Windows.Forms.TextBox stock_bahanTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}