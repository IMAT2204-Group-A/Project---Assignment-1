
namespace BackEnd
{
    partial class dvdStockForm
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
            this.lstDVDs = new System.Windows.Forms.ListBox();
            this.tblDVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVDBookDataSet = new BackEnd.DVDBookDataSet();
            this.tblDVDTableAdapter = new BackEnd.DVDBookDataSetTableAdapters.tblDVDTableAdapter();
            this.btnAddDVD = new System.Windows.Forms.Button();
            this.btnEditDVD = new System.Windows.Forms.Button();
            this.btnRemoveDVD = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDVDs
            // 
            this.lstDVDs.DataSource = this.tblDVDBindingSource;
            this.lstDVDs.DisplayMember = "DVDName";
            this.lstDVDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F);
            this.lstDVDs.FormattingEnabled = true;
            this.lstDVDs.ItemHeight = 24;
            this.lstDVDs.Location = new System.Drawing.Point(12, 82);
            this.lstDVDs.Name = "lstDVDs";
            this.lstDVDs.Size = new System.Drawing.Size(629, 316);
            this.lstDVDs.TabIndex = 0;
            this.lstDVDs.ValueMember = "DVDID";
            // 
            // tblDVDBindingSource
            // 
            this.tblDVDBindingSource.DataMember = "tblDVD";
            this.tblDVDBindingSource.DataSource = this.dVDBookDataSet;
            // 
            // dVDBookDataSet
            // 
            this.dVDBookDataSet.DataSetName = "DVDBookDataSet";
            this.dVDBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDVDTableAdapter
            // 
            this.tblDVDTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddDVD
            // 
            this.btnAddDVD.Location = new System.Drawing.Point(13, 404);
            this.btnAddDVD.Name = "btnAddDVD";
            this.btnAddDVD.Size = new System.Drawing.Size(110, 57);
            this.btnAddDVD.TabIndex = 1;
            this.btnAddDVD.Text = "Add DVD";
            this.btnAddDVD.UseVisualStyleBackColor = true;
            this.btnAddDVD.Click += new System.EventHandler(this.btnAddDVD_Click);
            // 
            // btnEditDVD
            // 
            this.btnEditDVD.Location = new System.Drawing.Point(139, 404);
            this.btnEditDVD.Name = "btnEditDVD";
            this.btnEditDVD.Size = new System.Drawing.Size(110, 57);
            this.btnEditDVD.TabIndex = 2;
            this.btnEditDVD.Text = "Edit DVD";
            this.btnEditDVD.UseVisualStyleBackColor = true;
            this.btnEditDVD.Click += new System.EventHandler(this.btnEditDVD_Click);
            // 
            // btnRemoveDVD
            // 
            this.btnRemoveDVD.Location = new System.Drawing.Point(269, 404);
            this.btnRemoveDVD.Name = "btnRemoveDVD";
            this.btnRemoveDVD.Size = new System.Drawing.Size(110, 57);
            this.btnRemoveDVD.TabIndex = 3;
            this.btnRemoveDVD.Text = "Remove DVD";
            this.btnRemoveDVD.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(661, 473);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 57);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of DVDs that are stored in the database:";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(37, 497);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 20);
            this.lblErrorMessage.TabIndex = 6;
            // 
            // dvdStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 542);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemoveDVD);
            this.Controls.Add(this.btnEditDVD);
            this.Controls.Add(this.btnAddDVD);
            this.Controls.Add(this.lstDVDs);
            this.Name = "dvdStockForm";
            this.Text = "Stock View";
            this.Load += new System.EventHandler(this.dvdStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDBookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDVDs;
        private DVDBookDataSet dVDBookDataSet;
        private System.Windows.Forms.BindingSource tblDVDBindingSource;
        private DVDBookDataSetTableAdapters.tblDVDTableAdapter tblDVDTableAdapter;
        private System.Windows.Forms.Button btnAddDVD;
        private System.Windows.Forms.Button btnEditDVD;
        private System.Windows.Forms.Button btnRemoveDVD;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}