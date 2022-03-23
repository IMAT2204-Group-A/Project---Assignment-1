using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public partial class DVDReportForm : Form
    {
        public DVDReportForm()
        {
            InitializeComponent();
        }

        private void DVDReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DVDBookDataSet.tblDVD' table. You can move, or remove it, as needed.
            this.tblDVDTableAdapter.Fill(this.DVDBookDataSet.tblDVD);

            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
