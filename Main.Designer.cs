namespace Zadatak5
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodavanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmjenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.štampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postanskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIVrijemeUpisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataDataSet = new Zadatak5.MyDataDataSet();
            this.pretrazi = new System.Windows.Forms.Button();
            this.textBoxPretrazi = new System.Windows.Forms.TextBox();
            this.gradoviTableAdapter = new Zadatak5.MyDataDataSetTableAdapters.GradoviTableAdapter();
            this.buttonOsvjezi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeToolStripMenuItem,
            this.izmjenaToolStripMenuItem,
            this.brisanjeToolStripMenuItem,
            this.štampaToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.menuStrip1.Size = new System.Drawing.Size(764, 53);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodavanjeToolStripMenuItem
            // 
            this.dodavanjeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.dodavanjeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.dodavanjeToolStripMenuItem.Name = "dodavanjeToolStripMenuItem";
            this.dodavanjeToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.dodavanjeToolStripMenuItem.Text = "Dodavanje";
            this.dodavanjeToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeToolStripMenuItem_Click);
            // 
            // izmjenaToolStripMenuItem
            // 
            this.izmjenaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.izmjenaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.izmjenaToolStripMenuItem.Name = "izmjenaToolStripMenuItem";
            this.izmjenaToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.izmjenaToolStripMenuItem.Text = "Izmjena";
            this.izmjenaToolStripMenuItem.Click += new System.EventHandler(this.izmjenaToolStripMenuItem_Click);
            // 
            // brisanjeToolStripMenuItem
            // 
            this.brisanjeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.brisanjeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.brisanjeToolStripMenuItem.Name = "brisanjeToolStripMenuItem";
            this.brisanjeToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.brisanjeToolStripMenuItem.Text = "Brisanje";
            this.brisanjeToolStripMenuItem.Click += new System.EventHandler(this.brisanjeToolStripMenuItem_Click);
            // 
            // štampaToolStripMenuItem
            // 
            this.štampaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.štampaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.štampaToolStripMenuItem.Name = "štampaToolStripMenuItem";
            this.štampaToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.štampaToolStripMenuItem.Text = "Štampa";
            this.štampaToolStripMenuItem.Click += new System.EventHandler(this.štampaToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.izlazToolStripMenuItem.Margin = new System.Windows.Forms.Padding(210, 10, 10, 10);
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.postanskiBrojDataGridViewTextBoxColumn,
            this.datumIVrijemeUpisaDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.gradoviBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(289, 105);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(429, 300);
            this.dataGridView1.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // postanskiBrojDataGridViewTextBoxColumn
            // 
            this.postanskiBrojDataGridViewTextBoxColumn.DataPropertyName = "PostanskiBroj";
            this.postanskiBrojDataGridViewTextBoxColumn.HeaderText = "PostanskiBroj";
            this.postanskiBrojDataGridViewTextBoxColumn.Name = "postanskiBrojDataGridViewTextBoxColumn";
            this.postanskiBrojDataGridViewTextBoxColumn.ReadOnly = true;
            this.postanskiBrojDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // datumIVrijemeUpisaDataGridViewTextBoxColumn
            // 
            this.datumIVrijemeUpisaDataGridViewTextBoxColumn.DataPropertyName = "DatumIVrijemeUpisa";
            this.datumIVrijemeUpisaDataGridViewTextBoxColumn.HeaderText = "DatumIVrijemeUpisa";
            this.datumIVrijemeUpisaDataGridViewTextBoxColumn.Name = "datumIVrijemeUpisaDataGridViewTextBoxColumn";
            this.datumIVrijemeUpisaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumIVrijemeUpisaDataGridViewTextBoxColumn.Visible = false;
            // 
            // gradoviBindingSource
            // 
            this.gradoviBindingSource.DataMember = "Gradovi";
            this.gradoviBindingSource.DataSource = this.myDataDataSet;
            // 
            // myDataDataSet
            // 
            this.myDataDataSet.DataSetName = "MyDataDataSet";
            this.myDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pretrazi
            // 
            this.pretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.pretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pretrazi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretrazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pretrazi.Location = new System.Drawing.Point(34, 370);
            this.pretrazi.Name = "pretrazi";
            this.pretrazi.Size = new System.Drawing.Size(90, 35);
            this.pretrazi.TabIndex = 6;
            this.pretrazi.Text = "Pretraži";
            this.pretrazi.UseVisualStyleBackColor = false;
            this.pretrazi.Click += new System.EventHandler(this.pretrazi_Click);
            // 
            // textBoxPretrazi
            // 
            this.textBoxPretrazi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPretrazi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPretrazi.Location = new System.Drawing.Point(34, 227);
            this.textBoxPretrazi.Name = "textBoxPretrazi";
            this.textBoxPretrazi.Size = new System.Drawing.Size(213, 22);
            this.textBoxPretrazi.TabIndex = 5;
            // 
            // gradoviTableAdapter
            // 
            this.gradoviTableAdapter.ClearBeforeFill = true;
            // 
            // buttonOsvjezi
            // 
            this.buttonOsvjezi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.buttonOsvjezi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOsvjezi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOsvjezi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOsvjezi.Location = new System.Drawing.Point(157, 370);
            this.buttonOsvjezi.Name = "buttonOsvjezi";
            this.buttonOsvjezi.Size = new System.Drawing.Size(90, 35);
            this.buttonOsvjezi.TabIndex = 8;
            this.buttonOsvjezi.Text = "Osvježi";
            this.buttonOsvjezi.UseVisualStyleBackColor = false;
            this.buttonOsvjezi.Click += new System.EventHandler(this.buttonOsvjezi_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(764, 449);
            this.Controls.Add(this.buttonOsvjezi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pretrazi);
            this.Controls.Add(this.textBoxPretrazi);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Evidencija Gradova";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripMenuItem izmjenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pretrazi;
        private MyDataDataSet myDataDataSet;
        private System.Windows.Forms.BindingSource gradoviBindingSource;
        private MyDataDataSetTableAdapters.GradoviTableAdapter gradoviTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postanskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIVrijemeUpisaDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox textBoxPretrazi;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem dodavanjeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem brisanjeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem štampaToolStripMenuItem;
        private System.Windows.Forms.Button buttonOsvjezi;
    }
}

