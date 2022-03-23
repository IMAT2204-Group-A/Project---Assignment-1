
namespace BackEnd
{
    partial class DVDReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblDVDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DVDBookDataSet = new BackEnd.DVDBookDataSet();
            this.btnClose = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblDVDTableAdapter = new BackEnd.DVDBookDataSetTableAdapters.tblDVDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVDBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblDVDBindingSource
            // 
            this.tblDVDBindingSource.DataMember = "tblDVD";
            this.tblDVDBindingSource.DataSource = this.DVDBookDataSet;
            // 
            // DVDBookDataSet
            // 
            this.DVDBookDataSet.DataSetName = "DVDBookDataSet";
            this.DVDBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1113, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 43);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DVDTableStatus";
            reportDataSource2.Value = this.tblDVDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BackEnd.rptDVDDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1100, 600);
            this.reportViewer1.TabIndex = 2;
            // 
            // tblDVDTableAdapter
            // 
            this.tblDVDTableAdapter.ClearBeforeFill = true;
            // 
            // DVDReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 633);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnClose);
            this.Name = "DVDReportForm";
            this.Text = "DVDReportForm";
            this.Load += new System.EventHandler(this.DVDReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDVDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVDBookDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblDVDBindingSource;
        private DVDBookDataSet DVDBookDataSet;
        private DVDBookDataSetTableAdapters.tblDVDTableAdapter tblDVDTableAdapter;
    }
}