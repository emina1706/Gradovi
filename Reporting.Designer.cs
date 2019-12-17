namespace Zadatak5
{
    partial class Reporting
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Stampa22 = new Zadatak5.Stampa2();
            this.myDataDataSet = new Zadatak5.MyDataDataSet();
            this.gradoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradoviTableAdapter = new Zadatak5.MyDataDataSetTableAdapters.GradoviTableAdapter();
            this.Stampa21 = new Zadatak5.Stampa2();
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(150, 150);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.Stampa22;
            this.crystalReportViewer2.Size = new System.Drawing.Size(854, 506);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer2.Load += new System.EventHandler(this.crystalReportViewer2_Load);
            // 
            // myDataDataSet
            // 
            this.myDataDataSet.DataSetName = "MyDataDataSet";
            this.myDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradoviBindingSource
            // 
            this.gradoviBindingSource.DataMember = "Gradovi";
            this.gradoviBindingSource.DataSource = this.myDataDataSet;
            // 
            // gradoviTableAdapter
            // 
            this.gradoviTableAdapter.ClearBeforeFill = true;
            // 
            // Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 506);
            this.ControlBox = false;
            this.Controls.Add(this.crystalReportViewer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporting";
            this.ShowInTaskbar = false;
            this.Text = "Registar";
            this.Load += new System.EventHandler(this.Reporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoviBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private MyDataDataSet myDataDataSet;
        private System.Windows.Forms.BindingSource gradoviBindingSource;
        private MyDataDataSetTableAdapters.GradoviTableAdapter gradoviTableAdapter;
        private Stampa2 Stampa22;
        private Stampa2 Stampa21;
    }
}