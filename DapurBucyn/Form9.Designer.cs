namespace DapurBucyn
{
    partial class Form9
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
            System.Windows.Forms.Label id_penggunaanLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.bucynDataSet = new DapurBucyn.bucynDataSet();
            this.bahan_nasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bahan_nasiTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.bahan_nasiTableAdapter();
            this.tableAdapterManager = new DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager();
            this.bahan_nasiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bahan_nasiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bahan_nasiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_nasiComboBox = new System.Windows.Forms.ComboBox();
            this.jumlah_nasiTextBox = new System.Windows.Forms.TextBox();
            this.id_penggunaanComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.nasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nasiTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.nasiTableAdapter();
            this.penggunaanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penggunaanTableAdapter = new DapurBucyn.bucynDataSetTableAdapters.penggunaanTableAdapter();
            id_nasiLabel = new System.Windows.Forms.Label();
            jumlah_nasiLabel = new System.Windows.Forms.Label();
            id_penggunaanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahan_nasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahan_nasiBindingNavigator)).BeginInit();
            this.bahan_nasiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bahan_nasiDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_nasiLabel
            // 
            id_nasiLabel.AutoSize = true;
            id_nasiLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_nasiLabel.Location = new System.Drawing.Point(6, 15);
            id_nasiLabel.Name = "id_nasiLabel";
            id_nasiLabel.Size = new System.Drawing.Size(48, 17);
            id_nasiLabel.TabIndex = 2;
            id_nasiLabel.Text = "id nasi:";
            // 
            // jumlah_nasiLabel
            // 
            jumlah_nasiLabel.AutoSize = true;
            jumlah_nasiLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jumlah_nasiLabel.Location = new System.Drawing.Point(6, 42);
            jumlah_nasiLabel.Name = "jumlah_nasiLabel";
            jumlah_nasiLabel.Size = new System.Drawing.Size(76, 17);
            jumlah_nasiLabel.TabIndex = 4;
            jumlah_nasiLabel.Text = "jumlah nasi:";
            // 
            // id_penggunaanLabel
            // 
            id_penggunaanLabel.AutoSize = true;
            id_penggunaanLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_penggunaanLabel.Location = new System.Drawing.Point(6, 68);
            id_penggunaanLabel.Name = "id_penggunaanLabel";
            id_penggunaanLabel.Size = new System.Drawing.Size(101, 17);
            id_penggunaanLabel.TabIndex = 6;
            id_penggunaanLabel.Text = "id penggunaan:";
            // 
            // bucynDataSet
            // 
            this.bucynDataSet.DataSetName = "bucynDataSet";
            this.bucynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bahan_nasiBindingSource
            // 
            this.bahan_nasiBindingSource.DataMember = "bahan_nasi";
            this.bahan_nasiBindingSource.DataSource = this.bucynDataSet;
            // 
            // bahan_nasiTableAdapter
            // 
            this.bahan_nasiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bahan_nasiTableAdapter = this.bahan_nasiTableAdapter;
            this.tableAdapterManager.bahanTableAdapter = null;
            this.tableAdapterManager.detail_penggunaanTableAdapter = null;
            this.tableAdapterManager.detail_penjualanTableAdapter = null;
            this.tableAdapterManager.nasiTableAdapter = null;
            this.tableAdapterManager.pembelian_bahanTableAdapter = null;
            this.tableAdapterManager.penggunaanTableAdapter = null;
            this.tableAdapterManager.penjualanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DapurBucyn.bucynDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bahan_nasiBindingNavigator
            // 
            this.bahan_nasiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bahan_nasiBindingNavigator.BindingSource = this.bahan_nasiBindingSource;
            this.bahan_nasiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bahan_nasiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bahan_nasiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bahan_nasiBindingNavigatorSaveItem});
            this.bahan_nasiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bahan_nasiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bahan_nasiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bahan_nasiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bahan_nasiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bahan_nasiBindingNavigator.Name = "bahan_nasiBindingNavigator";
            this.bahan_nasiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bahan_nasiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.bahan_nasiBindingNavigator.TabIndex = 0;
            this.bahan_nasiBindingNavigator.Text = "bindingNavigator1";
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
            // bahan_nasiBindingNavigatorSaveItem
            // 
            this.bahan_nasiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bahan_nasiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bahan_nasiBindingNavigatorSaveItem.Image")));
            this.bahan_nasiBindingNavigatorSaveItem.Name = "bahan_nasiBindingNavigatorSaveItem";
            this.bahan_nasiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bahan_nasiBindingNavigatorSaveItem.Text = "Save Data";
            this.bahan_nasiBindingNavigatorSaveItem.Click += new System.EventHandler(this.bahan_nasiBindingNavigatorSaveItem_Click);
            // 
            // bahan_nasiDataGridView
            // 
            this.bahan_nasiDataGridView.AutoGenerateColumns = false;
            this.bahan_nasiDataGridView.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.bahan_nasiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bahan_nasiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bahan_nasiDataGridView.DataSource = this.bahan_nasiBindingSource;
            this.bahan_nasiDataGridView.Location = new System.Drawing.Point(12, 167);
            this.bahan_nasiDataGridView.Name = "bahan_nasiDataGridView";
            this.bahan_nasiDataGridView.Size = new System.Drawing.Size(548, 220);
            this.bahan_nasiDataGridView.TabIndex = 1;
            this.bahan_nasiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bahan_nasiDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_bahan_nasi";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_bahan_nasi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_penggunaan";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_penggunaan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "laba_rugi";
            this.dataGridViewTextBoxColumn5.HeaderText = "laba_rugi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // id_nasiComboBox
            // 
            this.id_nasiComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bahan_nasiBindingSource, "id_nasi", true));
            this.id_nasiComboBox.DataSource = this.nasiBindingSource;
            this.id_nasiComboBox.DisplayMember = "nama_nasi";
            this.id_nasiComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_nasiComboBox.FormattingEnabled = true;
            this.id_nasiComboBox.Location = new System.Drawing.Point(113, 12);
            this.id_nasiComboBox.Name = "id_nasiComboBox";
            this.id_nasiComboBox.Size = new System.Drawing.Size(244, 25);
            this.id_nasiComboBox.TabIndex = 3;
            this.id_nasiComboBox.ValueMember = "id_nasi";
            // 
            // jumlah_nasiTextBox
            // 
            this.jumlah_nasiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bahan_nasiBindingSource, "jumlah_nasi", true));
            this.jumlah_nasiTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah_nasiTextBox.Location = new System.Drawing.Point(113, 39);
            this.jumlah_nasiTextBox.Name = "jumlah_nasiTextBox";
            this.jumlah_nasiTextBox.Size = new System.Drawing.Size(244, 22);
            this.jumlah_nasiTextBox.TabIndex = 5;
            // 
            // id_penggunaanComboBox
            // 
            this.id_penggunaanComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bahan_nasiBindingSource, "id_penggunaan", true));
            this.id_penggunaanComboBox.DataSource = this.penggunaanBindingSource;
            this.id_penggunaanComboBox.DisplayMember = "id_penggunaan";
            this.id_penggunaanComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_penggunaanComboBox.FormattingEnabled = true;
            this.id_penggunaanComboBox.Location = new System.Drawing.Point(113, 65);
            this.id_penggunaanComboBox.Name = "id_penggunaanComboBox";
            this.id_penggunaanComboBox.Size = new System.Drawing.Size(244, 25);
            this.id_penggunaanComboBox.TabIndex = 7;
            this.id_penggunaanComboBox.ValueMember = "id_penggunaan";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(id_nasiLabel);
            this.panel1.Controls.Add(this.id_nasiComboBox);
            this.panel1.Controls.Add(jumlah_nasiLabel);
            this.panel1.Controls.Add(this.jumlah_nasiTextBox);
            this.panel1.Controls.Add(id_penggunaanLabel);
            this.panel1.Controls.Add(this.id_penggunaanComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 100);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 48);
            this.button2.TabIndex = 25;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // penggunaanBindingSource
            // 
            this.penggunaanBindingSource.DataMember = "penggunaan";
            this.penggunaanBindingSource.DataSource = this.bucynDataSet;
            // 
            // penggunaanTableAdapter
            // 
            this.penggunaanTableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bahan_nasiDataGridView);
            this.Controls.Add(this.bahan_nasiBindingNavigator);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Name = "Form9";
            this.Text = "Form9";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form9_FormClosed);
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bucynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahan_nasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahan_nasiBindingNavigator)).EndInit();
            this.bahan_nasiBindingNavigator.ResumeLayout(false);
            this.bahan_nasiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bahan_nasiDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bucynDataSet bucynDataSet;
        private System.Windows.Forms.BindingSource bahan_nasiBindingSource;
        private bucynDataSetTableAdapters.bahan_nasiTableAdapter bahan_nasiTableAdapter;
        private bucynDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bahan_nasiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bahan_nasiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bahan_nasiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox id_nasiComboBox;
        private System.Windows.Forms.TextBox jumlah_nasiTextBox;
        private System.Windows.Forms.ComboBox id_penggunaanComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource nasiBindingSource;
        private bucynDataSetTableAdapters.nasiTableAdapter nasiTableAdapter;
        private System.Windows.Forms.BindingSource penggunaanBindingSource;
        private bucynDataSetTableAdapters.penggunaanTableAdapter penggunaanTableAdapter;
    }
}