
namespace BackEnd
{
    partial class dvdEntryForm
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
            System.Windows.Forms.Label dVDIDLabel;
            System.Windows.Forms.Label dVDNameLabel;
            System.Windows.Forms.Label dVDDescriptionLabel;
            System.Windows.Forms.Label dVDDateOfReleaseLabel;
            System.Windows.Forms.Label dVDLengthLabel;
            System.Windows.Forms.Label dVDPriceLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label dVDImageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dvdEntryForm));
            this.dVDBookDataSet = new BackEnd.DVDBookDataSet();
            this.tblDVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDVDTableAdapter = new BackEnd.DVDBookDataSetTableAdapters.tblDVDTableAdapter();
            this.tableAdapterManager = new BackEnd.DVDBookDataSetTableAdapters.TableAdapterManager();
            this.tblDVDGenreTableAdapter = new BackEnd.DVDBookDataSetTableAdapters.tblDVDGenreTableAdapter();
            this.dVDIDTextBox = new System.Windows.Forms.TextBox();
            this.dVDNameTextBox = new System.Windows.Forms.TextBox();
            this.dVDDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.dVDDateOfReleaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dVDLengthTextBox = new System.Windows.Forms.TextBox();
            this.dVDPriceTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.dVDImageTextBox = new System.Windows.Forms.TextBox();
            this.tblDVDGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDVDGenreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.tblDVDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblDVDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            dVDIDLabel = new System.Windows.Forms.Label();
            dVDNameLabel = new System.Windows.Forms.Label();
            dVDDescriptionLabel = new System.Windows.Forms.Label();
            dVDDateOfReleaseLabel = new System.Windows.Forms.Label();
            dVDLengthLabel = new System.Windows.Forms.Label();
            dVDPriceLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            dVDImageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDGenreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDGenreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDBindingNavigator)).BeginInit();
            this.tblDVDBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dVDIDLabel
            // 
            dVDIDLabel.AutoSize = true;
            dVDIDLabel.Location = new System.Drawing.Point(29, 77);
            dVDIDLabel.Name = "dVDIDLabel";
            dVDIDLabel.Size = new System.Drawing.Size(44, 13);
            dVDIDLabel.TabIndex = 1;
            dVDIDLabel.Text = "DVDID:";
            // 
            // dVDNameLabel
            // 
            dVDNameLabel.AutoSize = true;
            dVDNameLabel.Location = new System.Drawing.Point(29, 108);
            dVDNameLabel.Name = "dVDNameLabel";
            dVDNameLabel.Size = new System.Drawing.Size(61, 13);
            dVDNameLabel.TabIndex = 3;
            dVDNameLabel.Text = "DVDName:";
            // 
            // dVDDescriptionLabel
            // 
            dVDDescriptionLabel.AutoSize = true;
            dVDDescriptionLabel.Location = new System.Drawing.Point(29, 140);
            dVDDescriptionLabel.Name = "dVDDescriptionLabel";
            dVDDescriptionLabel.Size = new System.Drawing.Size(86, 13);
            dVDDescriptionLabel.TabIndex = 5;
            dVDDescriptionLabel.Text = "DVDDescription:";
            // 
            // dVDDateOfReleaseLabel
            // 
            dVDDateOfReleaseLabel.AutoSize = true;
            dVDDateOfReleaseLabel.Location = new System.Drawing.Point(29, 174);
            dVDDateOfReleaseLabel.Name = "dVDDateOfReleaseLabel";
            dVDDateOfReleaseLabel.Size = new System.Drawing.Size(112, 13);
            dVDDateOfReleaseLabel.TabIndex = 7;
            dVDDateOfReleaseLabel.Text = "DVDDate Of Release:";
            // 
            // dVDLengthLabel
            // 
            dVDLengthLabel.AutoSize = true;
            dVDLengthLabel.Location = new System.Drawing.Point(29, 206);
            dVDLengthLabel.Name = "dVDLengthLabel";
            dVDLengthLabel.Size = new System.Drawing.Size(66, 13);
            dVDLengthLabel.TabIndex = 9;
            dVDLengthLabel.Text = "DVDLength:";
            // 
            // dVDPriceLabel
            // 
            dVDPriceLabel.AutoSize = true;
            dVDPriceLabel.Location = new System.Drawing.Point(29, 236);
            dVDPriceLabel.Name = "dVDPriceLabel";
            dVDPriceLabel.Size = new System.Drawing.Size(57, 13);
            dVDPriceLabel.TabIndex = 11;
            dVDPriceLabel.Text = "DVDPrice:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(29, 266);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(62, 13);
            supplierIDLabel.TabIndex = 13;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // dVDImageLabel
            // 
            dVDImageLabel.AutoSize = true;
            dVDImageLabel.Location = new System.Drawing.Point(29, 302);
            dVDImageLabel.Name = "dVDImageLabel";
            dVDImageLabel.Size = new System.Drawing.Size(62, 13);
            dVDImageLabel.TabIndex = 15;
            dVDImageLabel.Text = "DVDImage:";
            // 
            // dVDBookDataSet
            // 
            this.dVDBookDataSet.DataSetName = "DVDBookDataSet";
            this.dVDBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDVDBindingSource
            // 
            this.tblDVDBindingSource.DataMember = "tblDVD";
            this.tblDVDBindingSource.DataSource = this.dVDBookDataSet;
            // 
            // tblDVDTableAdapter
            // 
            this.tblDVDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblDVDCopyTableAdapter = null;
            this.tableAdapterManager.tblDVDGenreTableAdapter = this.tblDVDGenreTableAdapter;
            this.tableAdapterManager.tblDVDTableAdapter = this.tblDVDTableAdapter;
            this.tableAdapterManager.tblGenreTableAdapter = null;
            this.tableAdapterManager.tblLoginTableAdapter = null;
            this.tableAdapterManager.tblOrderLineTableAdapter = null;
            this.tableAdapterManager.tblOrderTableAdapter = null;
            this.tableAdapterManager.tblSupplierTableAdapter = null;
            this.tableAdapterManager.tblUserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BackEnd.DVDBookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblDVDGenreTableAdapter
            // 
            this.tblDVDGenreTableAdapter.ClearBeforeFill = true;
            // 
            // dVDIDTextBox
            // 
            this.dVDIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDVDBindingSource, "DVDID", true));
            this.dVDIDTextBox.Location = new System.Drawing.Point(147, 74);
            this.dVDIDTextBox.Name = "dVDIDTextBox";
            this.dVDIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.dVDIDTextBox.TabIndex = 2;
            // 
            // dVDNameTextBox
            // 
            this.dVDNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDVDBindingSource, "DVDName", true));
            this.dVDNameTextBox.Location = new System.Drawing.Point(147, 108);
            this.dVDNameTextBox.Name = "dVDNameTextBox";
            this.dVDNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.dVDNameTextBox.TabIndex = 4;
            // 
            // dVDDescriptionTextBox
            // 
            this.dVDDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDVDBindingSource, "DVDDescription", true));
            this.dVDDescriptionTextBox.Location = new System.Drawing.Point(147, 137);
            this.dVDDescriptionTextBox.Name = "dVDDescriptionTextBox";
            this.dVDDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.dVDDescriptionTextBox.TabIndex = 6;
            // 
            // dVDDateOfReleaseDateTimePicker
            // 
            this.dVDDateOfReleaseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblDVDBindingSource, "DVDDateOfRelease", true));
            this.dVDDateOfReleaseDateTimePicker.Location = new System.Drawing.Point(147, 167);
            this.dVDDateOfReleaseDateTimePicker.Name = "dVDDateOfReleaseDateTimePicker";
            this.dVDDateOfReleaseDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dVDDateOfReleaseDateTimePicker.TabIndex = 8;
            // 
            // dVDLengthTextBox
            // 
            this.dVDLengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDVDBindingSource, "DVDLength", true));
            this.dVDLengthTextBox.Location = new System.Drawing.Point(147, 203);
            this.dVDLengthTextBox.Name = "dVDLengthTextBox";
            this.dVDLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.dVDLengthTextBox.TabIndex = 10;
            // 
            // dVDPriceTextBox
            // 
            this.dVDPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDVDBindingSource, "DVDPrice", true));
            this.dVDPriceTextBox.Location = new System.Drawing.Point(147, 233);
            this.dVDPriceTextBox.Name = "dVDPriceTextBox";
            this.dVDPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.dVDPriceTextBox.TabIndex = 12;
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDVDBindingSource, "SupplierID", true));
            this.supplierIDTextBox.Location = new System.Drawing.Point(147, 263);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplierIDTextBox.TabIndex = 14;
            // 
            // dVDImageTextBox
            // 
            this.dVDImageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDVDBindingSource, "DVDImage", true));
            this.dVDImageTextBox.Location = new System.Drawing.Point(147, 299);
            this.dVDImageTextBox.Name = "dVDImageTextBox";
            this.dVDImageTextBox.Size = new System.Drawing.Size(100, 20);
            this.dVDImageTextBox.TabIndex = 16;
            // 
            // tblDVDGenreBindingSource
            // 
            this.tblDVDGenreBindingSource.DataMember = "FK_tblDVDGenre_tblDVD";
            this.tblDVDGenreBindingSource.DataSource = this.tblDVDBindingSource;
            // 
            // tblDVDGenreDataGridView
            // 
            this.tblDVDGenreDataGridView.AutoGenerateColumns = false;
            this.tblDVDGenreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDVDGenreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tblDVDGenreDataGridView.DataSource = this.tblDVDGenreBindingSource;
            this.tblDVDGenreDataGridView.Location = new System.Drawing.Point(521, 74);
            this.tblDVDGenreDataGridView.Name = "tblDVDGenreDataGridView";
            this.tblDVDGenreDataGridView.Size = new System.Drawing.Size(298, 216);
            this.tblDVDGenreDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DVDID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DVDID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GenreID";
            this.dataGridViewTextBoxColumn2.HeaderText = "GenreID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(111, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 51);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 51);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // tblDVDBindingNavigatorSaveItem
            // 
            this.tblDVDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblDVDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblDVDBindingNavigatorSaveItem.Image")));
            this.tblDVDBindingNavigatorSaveItem.Name = "tblDVDBindingNavigatorSaveItem";
            this.tblDVDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblDVDBindingNavigatorSaveItem.Text = "Save Data";
            this.tblDVDBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblDVDBindingNavigatorSaveItem_Click);
            // 
            // tblDVDBindingNavigator
            // 
            this.tblDVDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblDVDBindingNavigator.BindingSource = this.tblDVDBindingSource;
            this.tblDVDBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblDVDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblDVDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblDVDBindingNavigatorSaveItem});
            this.tblDVDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblDVDBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblDVDBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblDVDBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblDVDBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblDVDBindingNavigator.Name = "tblDVDBindingNavigator";
            this.tblDVDBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblDVDBindingNavigator.Size = new System.Drawing.Size(819, 25);
            this.tblDVDBindingNavigator.TabIndex = 0;
            this.tblDVDBindingNavigator.Text = "bindingNavigator1";
            // 
            // dvdEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 471);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tblDVDGenreDataGridView);
            this.Controls.Add(dVDImageLabel);
            this.Controls.Add(this.dVDImageTextBox);
            this.Controls.Add(supplierIDLabel);
            this.Controls.Add(this.supplierIDTextBox);
            this.Controls.Add(dVDPriceLabel);
            this.Controls.Add(this.dVDPriceTextBox);
            this.Controls.Add(dVDLengthLabel);
            this.Controls.Add(this.dVDLengthTextBox);
            this.Controls.Add(dVDDateOfReleaseLabel);
            this.Controls.Add(this.dVDDateOfReleaseDateTimePicker);
            this.Controls.Add(dVDDescriptionLabel);
            this.Controls.Add(this.dVDDescriptionTextBox);
            this.Controls.Add(dVDNameLabel);
            this.Controls.Add(this.dVDNameTextBox);
            this.Controls.Add(dVDIDLabel);
            this.Controls.Add(this.dVDIDTextBox);
            this.Controls.Add(this.tblDVDBindingNavigator);
            this.Name = "dvdEntryForm";
            this.Text = "dvdEntryForm";
            this.Load += new System.EventHandler(this.dvdEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dVDBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDGenreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDGenreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDBindingNavigator)).EndInit();
            this.tblDVDBindingNavigator.ResumeLayout(false);
            this.tblDVDBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DVDBookDataSet dVDBookDataSet;
        private System.Windows.Forms.BindingSource tblDVDBindingSource;
        private DVDBookDataSetTableAdapters.tblDVDTableAdapter tblDVDTableAdapter;
        private DVDBookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox dVDIDTextBox;
        private System.Windows.Forms.TextBox dVDNameTextBox;
        private System.Windows.Forms.TextBox dVDDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker dVDDateOfReleaseDateTimePicker;
        private System.Windows.Forms.TextBox dVDLengthTextBox;
        private System.Windows.Forms.TextBox dVDPriceTextBox;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.TextBox dVDImageTextBox;
        private DVDBookDataSetTableAdapters.tblDVDGenreTableAdapter tblDVDGenreTableAdapter;
        private System.Windows.Forms.BindingSource tblDVDGenreBindingSource;
        private System.Windows.Forms.DataGridView tblDVDGenreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton tblDVDBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator tblDVDBindingNavigator;
    }
}