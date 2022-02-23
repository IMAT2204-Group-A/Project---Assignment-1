
namespace BackEnd
{
    partial class DVDList
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
            this.txtDVDList = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnFindDVD = new System.Windows.Forms.Button();
            this.btnAddNewDVD = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.BtnSaveToFile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDVDList
            // 
            this.txtDVDList.Enabled = false;
            this.txtDVDList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVDList.Location = new System.Drawing.Point(87, 75);
            this.txtDVDList.Multiline = true;
            this.txtDVDList.Name = "txtDVDList";
            this.txtDVDList.Size = new System.Drawing.Size(701, 226);
            this.txtDVDList.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(616, 394);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(83, 44);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(705, 394);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 44);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(26, 394);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(83, 44);
            this.btnDisplayAll.TabIndex = 3;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnFindDVD
            // 
            this.btnFindDVD.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFindDVD.Location = new System.Drawing.Point(130, 394);
            this.btnFindDVD.Name = "btnFindDVD";
            this.btnFindDVD.Size = new System.Drawing.Size(83, 44);
            this.btnFindDVD.TabIndex = 4;
            this.btnFindDVD.Text = "Find DVD";
            this.btnFindDVD.UseVisualStyleBackColor = true;
            this.btnFindDVD.Click += new System.EventHandler(this.btnFindDVD_Click);
            // 
            // btnAddNewDVD
            // 
            this.btnAddNewDVD.Location = new System.Drawing.Point(233, 394);
            this.btnAddNewDVD.Name = "btnAddNewDVD";
            this.btnAddNewDVD.Size = new System.Drawing.Size(83, 44);
            this.btnAddNewDVD.TabIndex = 5;
            this.btnAddNewDVD.Text = "Add New DVD";
            this.btnAddNewDVD.UseVisualStyleBackColor = true;
            this.btnAddNewDVD.Click += new System.EventHandler(this.btnAddNewDVD_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(6, 75);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 52);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Create Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // BtnSaveToFile
            // 
            this.BtnSaveToFile.Location = new System.Drawing.Point(6, 133);
            this.BtnSaveToFile.Name = "BtnSaveToFile";
            this.BtnSaveToFile.Size = new System.Drawing.Size(75, 51);
            this.BtnSaveToFile.TabIndex = 7;
            this.BtnSaveToFile.Text = "Save to text file.";
            this.BtnSaveToFile.UseVisualStyleBackColor = true;
            this.BtnSaveToFile.Click += new System.EventHandler(this.BtnSaveToFile_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(705, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 68);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DVDList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnSaveToFile);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnAddNewDVD);
            this.Controls.Add(this.btnFindDVD);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtDVDList);
            this.Name = "DVDList";
            this.Text = "List of DVDs";
            this.Load += new System.EventHandler(this.DVDList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDVDList;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnFindDVD;
        private System.Windows.Forms.Button btnAddNewDVD;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button BtnSaveToFile;
        private System.Windows.Forms.Button btnClose;
    }
}