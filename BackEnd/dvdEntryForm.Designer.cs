
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
            System.Windows.Forms.Label dVDIDLabel;
            System.Windows.Forms.Label dVDNameLabel;
            System.Windows.Forms.Label dVDDescriptionLabel;
            System.Windows.Forms.Label dVDDateOfReleaseLabel;
            System.Windows.Forms.Label dVDLengthLabel;
            System.Windows.Forms.Label dVDPriceLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label dVDImageLabel;
            this.txtDVDID = new System.Windows.Forms.TextBox();
            this.txtDVDName = new System.Windows.Forms.TextBox();
            this.txtDVDDescription = new System.Windows.Forms.TextBox();
            this.DTPDVDDateOfRelease = new System.Windows.Forms.DateTimePicker();
            this.txtDVDLenght = new System.Windows.Forms.TextBox();
            this.txtDVDPrice = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtDVDImage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            dVDIDLabel = new System.Windows.Forms.Label();
            dVDNameLabel = new System.Windows.Forms.Label();
            dVDDescriptionLabel = new System.Windows.Forms.Label();
            dVDDateOfReleaseLabel = new System.Windows.Forms.Label();
            dVDLengthLabel = new System.Windows.Forms.Label();
            dVDPriceLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            dVDImageLabel = new System.Windows.Forms.Label();
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
            dVDDateOfReleaseLabel.Location = new System.Drawing.Point(29, 237);
            dVDDateOfReleaseLabel.Name = "dVDDateOfReleaseLabel";
            dVDDateOfReleaseLabel.Size = new System.Drawing.Size(112, 13);
            dVDDateOfReleaseLabel.TabIndex = 7;
            dVDDateOfReleaseLabel.Text = "DVDDate Of Release:";
            // 
            // dVDLengthLabel
            // 
            dVDLengthLabel.AutoSize = true;
            dVDLengthLabel.Location = new System.Drawing.Point(29, 269);
            dVDLengthLabel.Name = "dVDLengthLabel";
            dVDLengthLabel.Size = new System.Drawing.Size(66, 13);
            dVDLengthLabel.TabIndex = 9;
            dVDLengthLabel.Text = "DVDLength:";
            // 
            // dVDPriceLabel
            // 
            dVDPriceLabel.AutoSize = true;
            dVDPriceLabel.Location = new System.Drawing.Point(29, 299);
            dVDPriceLabel.Name = "dVDPriceLabel";
            dVDPriceLabel.Size = new System.Drawing.Size(57, 13);
            dVDPriceLabel.TabIndex = 11;
            dVDPriceLabel.Text = "DVDPrice:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(29, 329);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(62, 13);
            supplierIDLabel.TabIndex = 13;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // dVDImageLabel
            // 
            dVDImageLabel.AutoSize = true;
            dVDImageLabel.Location = new System.Drawing.Point(29, 365);
            dVDImageLabel.Name = "dVDImageLabel";
            dVDImageLabel.Size = new System.Drawing.Size(62, 13);
            dVDImageLabel.TabIndex = 15;
            dVDImageLabel.Text = "DVDImage:";
            // 
            // txtDVDID
            // 
            this.txtDVDID.Location = new System.Drawing.Point(147, 74);
            this.txtDVDID.Name = "txtDVDID";
            this.txtDVDID.Size = new System.Drawing.Size(100, 20);
            this.txtDVDID.TabIndex = 2;
            // 
            // txtDVDName
            // 
            this.txtDVDName.Location = new System.Drawing.Point(147, 108);
            this.txtDVDName.Name = "txtDVDName";
            this.txtDVDName.Size = new System.Drawing.Size(100, 20);
            this.txtDVDName.TabIndex = 4;
            // 
            // txtDVDDescription
            // 
            this.txtDVDDescription.Location = new System.Drawing.Point(147, 137);
            this.txtDVDDescription.Multiline = true;
            this.txtDVDDescription.Name = "txtDVDDescription";
            this.txtDVDDescription.Size = new System.Drawing.Size(275, 76);
            this.txtDVDDescription.TabIndex = 6;
            // 
            // DTPDVDDateOfRelease
            // 
            this.DTPDVDDateOfRelease.Location = new System.Drawing.Point(147, 230);
            this.DTPDVDDateOfRelease.Name = "DTPDVDDateOfRelease";
            this.DTPDVDDateOfRelease.Size = new System.Drawing.Size(200, 20);
            this.DTPDVDDateOfRelease.TabIndex = 8;
            // 
            // txtDVDLenght
            // 
            this.txtDVDLenght.Location = new System.Drawing.Point(147, 266);
            this.txtDVDLenght.Name = "txtDVDLenght";
            this.txtDVDLenght.Size = new System.Drawing.Size(100, 20);
            this.txtDVDLenght.TabIndex = 10;
            // 
            // txtDVDPrice
            // 
            this.txtDVDPrice.Location = new System.Drawing.Point(147, 296);
            this.txtDVDPrice.Name = "txtDVDPrice";
            this.txtDVDPrice.Size = new System.Drawing.Size(100, 20);
            this.txtDVDPrice.TabIndex = 12;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(147, 326);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierID.TabIndex = 14;
            // 
            // txtDVDImage
            // 
            this.txtDVDImage.Location = new System.Drawing.Point(147, 362);
            this.txtDVDImage.Name = "txtDVDImage";
            this.txtDVDImage.Size = new System.Drawing.Size(100, 20);
            this.txtDVDImage.TabIndex = 16;
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
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(387, 369);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 20;
            // 
            // dvdEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 471);
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
            this.Controls.Add(this.DTPDVDDateOfRelease);
            this.Controls.Add(dVDDescriptionLabel);
            this.Controls.Add(this.txtDVDDescription);
            this.Controls.Add(dVDNameLabel);
            this.Controls.Add(this.txtDVDName);
            this.Controls.Add(dVDIDLabel);
            this.Controls.Add(this.txtDVDID);
            this.Name = "dvdEntryForm";
            this.Text = "dvdEntryForm";
            this.Load += new System.EventHandler(this.dvdEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDVDID;
        private System.Windows.Forms.TextBox txtDVDName;
        private System.Windows.Forms.TextBox txtDVDDescription;
        private System.Windows.Forms.DateTimePicker DTPDVDDateOfRelease;
        private System.Windows.Forms.TextBox txtDVDLenght;
        private System.Windows.Forms.TextBox txtDVDPrice;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDVDImage;
        private System.Windows.Forms.Label lblError;
    }
}