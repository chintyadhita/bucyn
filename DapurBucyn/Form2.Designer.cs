namespace DapurBucyn
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label nama_nasiLabel;
            System.Windows.Forms.Label harga_nasiLabel;
            System.Windows.Forms.Label stock_nasiLabel;
            this.bucynDataSet = new DapurBucyn.bucynDataSet();
            this.nasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nasiTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.nasiTableAdapter();
            this.tableAdapterManager = new DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager();
            this.nasiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nasiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nasiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_nasiTextBox = new System.Windows.Forms.TextBox();
            this.harga_nasiTextBox = new System.Windows.Forms.TextBox();
            this.stock_nasiTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            nama_nasiLabel = new System.Windows.Forms.Label();
            harga_nasiLabel = new System.Windows.Forms.Label();
            stock_nasiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiBindingNavigator)).BeginInit();
            this.nasiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nasiDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bucynDataSet
            // 
            this.bucynDataSet.DataSetName = "bucynDataSet";
            this.bucynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nasiBindingSource
            // 
            this.nasiBindingSource.DataMember = "nasi";
            this.nasiBindingSource.DataSource = this.bucynDataSet;
            // 
            // nasiTableAdapter
            // 
            this.nasiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bahan_nasiTableAdapter = null;
            this.tableAdapterManager.bahanTableAdapter = null;
            this.tableAdapterManager.detail_penggunaanTableAdapter = null;
            this.tableAdapterManager.nasiTableAdapter = this.nasiTableAdapter;
            this.tableAdapterManager.pembelian_bahanTableAdapter = null;
            this.tableAdapterManager.penggunaanTableAdapter = null;
            this.tableAdapterManager.penjualanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nasiBindingNavigator
            // 
            this.nasiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nasiBindingNavigator.BindingSource = this.nasiBindingSource;
            this.nasiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nasiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nasiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nasiBindingNavigatorSaveItem});
            this.nasiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nasiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nasiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nasiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nasiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nasiBindingNavigator.Name = "nasiBindingNavigator";
            this.nasiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nasiBindingNavigator.Size = new System.Drawing.Size(505, 25);
            this.nasiBindingNavigator.TabIndex = 0;
            this.nasiBindingNavigator.Text = "bindingNavigator1";
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
            // nasiBindingNavigatorSaveItem
            // 
            this.nasiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nasiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nasiBindingNavigatorSaveItem.Image")));
            this.nasiBindingNavigatorSaveItem.Name = "nasiBindingNavigatorSaveItem";
            this.nasiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nasiBindingNavigatorSaveItem.Text = "Save Data";
            this.nasiBindingNavigatorSaveItem.Click += new System.EventHandler(this.nasiBindingNavigatorSaveItem_Click);
            // 
            // nasiDataGridView
            // 
            this.nasiDataGridView.AutoGenerateColumns = false;
            this.nasiDataGridView.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.nasiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nasiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.nasiDataGridView.DataSource = this.nasiBindingSource;
            this.nasiDataGridView.GridColor = System.Drawing.Color.SaddleBrown;
            this.nasiDataGridView.Location = new System.Drawing.Point(12, 189);
            this.nasiDataGridView.Name = "nasiDataGridView";
            this.nasiDataGridView.Size = new System.Drawing.Size(451, 151);
            this.nasiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_nasi";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_nasi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama_nasi";
            this.dataGridViewTextBoxColumn2.HeaderText = "nama_nasi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "harga_nasi";
            this.dataGridViewTextBoxColumn3.HeaderText = "harga_nasi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stock_nasi";
            this.dataGridViewTextBoxColumn4.HeaderText = "stock_nasi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // nama_nasiLabel
            // 
            nama_nasiLabel.AutoSize = true;
            nama_nasiLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nama_nasiLabel.ForeColor = System.Drawing.Color.DarkOrange;
            nama_nasiLabel.Location = new System.Drawing.Point(12, 17);
            nama_nasiLabel.Name = "nama_nasiLabel";
            nama_nasiLabel.Size = new System.Drawing.Size(71, 17);
            nama_nasiLabel.TabIndex = 2;
            nama_nasiLabel.Text = "nama nasi:";
            // 
            // nama_nasiTextBox
            // 
            this.nama_nasiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nasiBindingSource, "nama_nasi", true));
            this.nama_nasiTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_nasiTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.nama_nasiTextBox.Location = new System.Drawing.Point(89, 12);
            this.nama_nasiTextBox.Name = "nama_nasiTextBox";
            this.nama_nasiTextBox.Size = new System.Drawing.Size(346, 22);
            this.nama_nasiTextBox.TabIndex = 3;
            // 
            // harga_nasiLabel
            // 
            harga_nasiLabel.AutoSize = true;
            harga_nasiLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            harga_nasiLabel.ForeColor = System.Drawing.Color.DarkOrange;
            harga_nasiLabel.Location = new System.Drawing.Point(12, 43);
            harga_nasiLabel.Name = "harga_nasiLabel";
            harga_nasiLabel.Size = new System.Drawing.Size(72, 17);
            harga_nasiLabel.TabIndex = 4;
            harga_nasiLabel.Text = "harga nasi:";
            // 
            // harga_nasiTextBox
            // 
            this.harga_nasiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nasiBindingSource, "harga_nasi", true));
            this.harga_nasiTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga_nasiTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.harga_nasiTextBox.Location = new System.Drawing.Point(89, 38);
            this.harga_nasiTextBox.Name = "harga_nasiTextBox";
            this.harga_nasiTextBox.Size = new System.Drawing.Size(346, 22);
            this.harga_nasiTextBox.TabIndex = 5;
            // 
            // stock_nasiLabel
            // 
            stock_nasiLabel.AutoSize = true;
            stock_nasiLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stock_nasiLabel.ForeColor = System.Drawing.Color.DarkOrange;
            stock_nasiLabel.Location = new System.Drawing.Point(12, 69);
            stock_nasiLabel.Name = "stock_nasiLabel";
            stock_nasiLabel.Size = new System.Drawing.Size(69, 17);
            stock_nasiLabel.TabIndex = 6;
            stock_nasiLabel.Text = "stock nasi:";
            // 
            // stock_nasiTextBox
            // 
            this.stock_nasiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nasiBindingSource, "stock_nasi", true));
            this.stock_nasiTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_nasiTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.stock_nasiTextBox.Location = new System.Drawing.Point(89, 64);
            this.stock_nasiTextBox.Name = "stock_nasiTextBox";
            this.stock_nasiTextBox.Size = new System.Drawing.Size(346, 22);
            this.stock_nasiTextBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stock_nasiTextBox);
            this.panel1.Controls.Add(nama_nasiLabel);
            this.panel1.Controls.Add(stock_nasiLabel);
            this.panel1.Controls.Add(this.nama_nasiTextBox);
            this.panel1.Controls.Add(this.harga_nasiTextBox);
            this.panel1.Controls.Add(harga_nasiLabel);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 100);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nama Nasi :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(146, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 38);
            this.panel2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox1.Location = new System.Drawing.Point(85, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 22);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(237, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(505, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nasiDataGridView);
            this.Controls.Add(this.nasiBindingNavigator);
            this.Name = "Form2";
            this.Text = "Daftar Nasi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiBindingNavigator)).EndInit();
            this.nasiBindingNavigator.ResumeLayout(false);
            this.nasiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nasiDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bucynDataSet bucynDataSet;
        private System.Windows.Forms.BindingSource nasiBindingSource;
        private bucynDataSetTableAdapters.nasiTableAdapter nasiTableAdapter;
        private bucynDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nasiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nasiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nasiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox nama_nasiTextBox;
        private System.Windows.Forms.TextBox harga_nasiTextBox;
        private System.Windows.Forms.TextBox stock_nasiTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}