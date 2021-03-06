
namespace BackEnd
{
    partial class DVDEntryForm
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
            System.Windows.Forms.Label dVDNameLabel;
            System.Windows.Forms.Label dVDDescriptionLabel;
            System.Windows.Forms.Label dVDDateOfReleaseLabel;
            System.Windows.Forms.Label dVDLengthLabel;
            System.Windows.Forms.Label dVDPriceLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label dVDImageLabel;
            System.Windows.Forms.Label label2;
            this.txtDVDName = new System.Windows.Forms.TextBox();
            this.txtDVDDescription = new System.Windows.Forms.TextBox();
            this.txtDVDLenght = new System.Windows.Forms.TextBox();
            this.txtDVDPrice = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtDVDImage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtDVDDateOfRelease = new System.Windows.Forms.TextBox();
            this.lstGenreList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblGenreTableAdapter = new BackEnd.DVDBookDataSetTableAdapters.tblGenreTableAdapter();
            this.dVDBookDataSet = new BackEnd.DVDBookDataSet();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            dVDNameLabel = new System.Windows.Forms.Label();
            dVDDescriptionLabel = new System.Windows.Forms.Label();
            dVDDateOfReleaseLabel = new System.Windows.Forms.Label();
            dVDLengthLabel = new System.Windows.Forms.Label();
            dVDPriceLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            dVDImageLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dVDNameLabel
            // 
            dVDNameLabel.AutoSize = true;
            dVDNameLabel.Location = new System.Drawing.Point(17, 77);
            dVDNameLabel.Name = "dVDNameLabel";
            dVDNameLabel.Size = new System.Drawing.Size(38, 13);
            dVDNameLabel.TabIndex = 3;
            dVDNameLabel.Text = "Name:";
            // 
            // dVDDescriptionLabel
            // 
            dVDDescriptionLabel.AutoSize = true;
            dVDDescriptionLabel.Location = new System.Drawing.Point(17, 109);
            dVDDescriptionLabel.Name = "dVDDescriptionLabel";
            dVDDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            dVDDescriptionLabel.TabIndex = 5;
            dVDDescriptionLabel.Text = "Description:";
            // 
            // dVDDateOfReleaseLabel
            // 
            dVDDateOfReleaseLabel.AutoSize = true;
            dVDDateOfReleaseLabel.Location = new System.Drawing.Point(17, 276);
            dVDDateOfReleaseLabel.Name = "dVDDateOfReleaseLabel";
            dVDDateOfReleaseLabel.Size = new System.Drawing.Size(89, 13);
            dVDDateOfReleaseLabel.TabIndex = 7;
            dVDDateOfReleaseLabel.Text = "Date Of Release:";
            // 
            // dVDLengthLabel
            // 
            dVDLengthLabel.AutoSize = true;
            dVDLengthLabel.Location = new System.Drawing.Point(17, 308);
            dVDLengthLabel.Name = "dVDLengthLabel";
            dVDLengthLabel.Size = new System.Drawing.Size(43, 13);
            dVDLengthLabel.TabIndex = 9;
            dVDLengthLabel.Text = "Length:";
            // 
            // dVDPriceLabel
            // 
            dVDPriceLabel.AutoSize = true;
            dVDPriceLabel.Location = new System.Drawing.Point(17, 338);
            dVDPriceLabel.Name = "dVDPriceLabel";
            dVDPriceLabel.Size = new System.Drawing.Size(34, 13);
            dVDPriceLabel.TabIndex = 11;
            dVDPriceLabel.Text = "Price:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(17, 368);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(62, 13);
            supplierIDLabel.TabIndex = 13;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // dVDImageLabel
            // 
            dVDImageLabel.AutoSize = true;
            dVDImageLabel.Location = new System.Drawing.Point(17, 404);
            dVDImageLabel.Name = "dVDImageLabel";
            dVDImageLabel.Size = new System.Drawing.Size(39, 13);
            dVDImageLabel.TabIndex = 15;
            dVDImageLabel.Text = "Image:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(17, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(232, 36);
            label2.TabIndex = 24;
            label2.Text = "DVD Entry Form";
            // 
            // txtDVDName
            // 
            this.txtDVDName.Location = new System.Drawing.Point(135, 77);
            this.txtDVDName.Name = "txtDVDName";
            this.txtDVDName.Size = new System.Drawing.Size(100, 20);
            this.txtDVDName.TabIndex = 4;
            // 
            // txtDVDDescription
            // 
            this.txtDVDDescription.Location = new System.Drawing.Point(135, 106);
            this.txtDVDDescription.Multiline = true;
            this.txtDVDDescription.Name = "txtDVDDescription";
            this.txtDVDDescription.Size = new System.Drawing.Size(275, 76);
            this.txtDVDDescription.TabIndex = 6;
            // 
            // txtDVDLenght
            // 
            this.txtDVDLenght.Location = new System.Drawing.Point(135, 305);
            this.txtDVDLenght.Name = "txtDVDLenght";
            this.txtDVDLenght.Size = new System.Drawing.Size(100, 20);
            this.txtDVDLenght.TabIndex = 10;
            // 
            // txtDVDPrice
            // 
            this.txtDVDPrice.Location = new System.Drawing.Point(135, 335);
            this.txtDVDPrice.Name = "txtDVDPrice";
            this.txtDVDPrice.Size = new System.Drawing.Size(100, 20);
            this.txtDVDPrice.TabIndex = 12;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(135, 365);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierID.TabIndex = 14;
            // 
            // txtDVDImage
            // 
            this.txtDVDImage.Location = new System.Drawing.Point(135, 401);
            this.txtDVDImage.Name = "txtDVDImage";
            this.txtDVDImage.Size = new System.Drawing.Size(100, 20);
            this.txtDVDImage.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 475);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 51);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(135, 475);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 51);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(387, 369);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 20;
            // 
            // txtDVDDateOfRelease
            // 
            this.txtDVDDateOfRelease.Location = new System.Drawing.Point(135, 269);
            this.txtDVDDateOfRelease.Name = "txtDVDDateOfRelease";
            this.txtDVDDateOfRelease.Size = new System.Drawing.Size(177, 20);
            this.txtDVDDateOfRelease.TabIndex = 21;
            // 
            // lstGenreList
            // 
            this.lstGenreList.FormattingEnabled = true;
            this.lstGenreList.Location = new System.Drawing.Point(135, 188);
            this.lstGenreList.Name = "lstGenreList";
            this.lstGenreList.Size = new System.Drawing.Size(162, 69);
            this.lstGenreList.TabIndex = 22;
            this.lstGenreList.SelectedIndexChanged += new System.EventHandler(this.lstGenreList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Genres";
            // 
            // tblGenreTableAdapter
            // 
            this.tblGenreTableAdapter.ClearBeforeFill = true;
            // 
            // dVDBookDataSet
            // 
            this.dVDBookDataSet.DataSetName = "DVDBookDataSet";
            this.dVDBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(241, 399);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DVDEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 538);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGenreList);
            this.Controls.Add(this.txtDVDDateOfRelease);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(dVDImageLabel);
            this.Controls.Add(this.txtDVDImage);
            this.Controls.Add(supplierIDLabel);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(dVDPriceLabel);
            this.Controls.Add(this.txtDVDPrice);
            this.Controls.Add(dVDLengthLabel);
            this.Controls.Add(this.txtDVDLenght);
            this.Controls.Add(dVDDateOfReleaseLabel);
            this.Controls.Add(dVDDescriptionLabel);
            this.Controls.Add(this.txtDVDDescription);
            this.Controls.Add(dVDNameLabel);
            this.Controls.Add(this.txtDVDName);
            this.Name = "DVDEntryForm";
            this.Text = "DVD Entry Form";
            this.Load += new System.EventHandler(this.dvdEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dVDBookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDVDName;
        private System.Windows.Forms.TextBox txtDVDDescription;
        private System.Windows.Forms.TextBox txtDVDLenght;
        private System.Windows.Forms.TextBox txtDVDPrice;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDVDImage;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtDVDDateOfRelease;
        private System.Windows.Forms.ListBox lstGenreList;
        private System.Windows.Forms.Label label1;
        private DVDBookDataSetTableAdapters.tblGenreTableAdapter tblGenreTableAdapter;
        private DVDBookDataSet dVDBookDataSet;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}