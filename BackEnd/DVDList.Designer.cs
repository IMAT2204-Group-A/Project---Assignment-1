
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnFindDVD = new System.Windows.Forms.Button();
            this.btnAddNewDVD = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.BtnSaveToFile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstDVDs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(721, 455);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(83, 44);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(810, 455);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 44);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(22, 451);
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
            this.btnFindDVD.Location = new System.Drawing.Point(126, 451);
            this.btnFindDVD.Name = "btnFindDVD";
            this.btnFindDVD.Size = new System.Drawing.Size(83, 44);
            this.btnFindDVD.TabIndex = 4;
            this.btnFindDVD.Text = "Find DVD";
            this.btnFindDVD.UseVisualStyleBackColor = true;
            this.btnFindDVD.Click += new System.EventHandler(this.btnFindDVD_Click);
            // 
            // btnAddNewDVD
            // 
            this.btnAddNewDVD.Location = new System.Drawing.Point(229, 451);
            this.btnAddNewDVD.Name = "btnAddNewDVD";
            this.btnAddNewDVD.Size = new System.Drawing.Size(83, 44);
            this.btnAddNewDVD.TabIndex = 5;
            this.btnAddNewDVD.Text = "Add New DVD";
            this.btnAddNewDVD.UseVisualStyleBackColor = true;
            this.btnAddNewDVD.Click += new System.EventHandler(this.btnAddNewDVD_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(27, 373);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 52);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Create Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // BtnSaveToFile
            // 
            this.BtnSaveToFile.Location = new System.Drawing.Point(108, 373);
            this.BtnSaveToFile.Name = "BtnSaveToFile";
            this.BtnSaveToFile.Size = new System.Drawing.Size(75, 51);
            this.BtnSaveToFile.TabIndex = 7;
            this.BtnSaveToFile.Text = "Save to text file.";
            this.BtnSaveToFile.UseVisualStyleBackColor = true;
            this.BtnSaveToFile.Click += new System.EventHandler(this.BtnSaveToFile_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(824, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 67);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "The List of DVDs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BackEnd.Properties.Resources.Logo_Smaller;
            this.pictureBox1.Location = new System.Drawing.Point(238, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lstDVDs
            // 
            this.lstDVDs.FormattingEnabled = true;
            this.lstDVDs.Location = new System.Drawing.Point(18, 81);
            this.lstDVDs.Name = "lstDVDs";
            this.lstDVDs.Size = new System.Drawing.Size(769, 277);
            this.lstDVDs.TabIndex = 11;
            this.lstDVDs.SelectedIndexChanged += new System.EventHandler(this.lstDVDs_SelectedIndexChanged);
            // 
            // DVDList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 511);
            this.Controls.Add(this.lstDVDs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnSaveToFile);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnAddNewDVD);
            this.Controls.Add(this.btnFindDVD);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Name = "DVDList";
            this.Text = " ";
            this.Load += new System.EventHandler(this.DVDList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnFindDVD;
        private System.Windows.Forms.Button btnAddNewDVD;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button BtnSaveToFile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstDVDs;
    }
}