using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak5
{ 

    public partial class Reporting : Form
{ 
        public Reporting()
        {
            InitializeComponent();
        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'myDataDataSet.Gradovi' table. You can move, or remove it, as needed.
            /*this.gradoviTableAdapter.Fill(this.myDataDataSet.Gradovi);
            crystalReportViewer1.ReportSource = report;
            
            report.SetDataSource(myDataDataSet);
            crud1.rep();*/
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
