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
using static Zadatak5.Forma;

namespace Zadatak5
{   
    public partial class Main : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);
        CRUD crud1 = new CRUD();
        Reporting reporting = new Reporting();

        public Main()
        {
            InitializeComponent();           
        }
        
        public void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataDataSet.Gradovi' table. You can move, or remove it, as needed.
            this.gradoviTableAdapter.Fill(this.myDataDataSet.Gradovi);
            dataGridView1.DataSource = crud1.Dt1;
        }
        //Dodavanje podataka
        public void dodavanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma dodati = new Forma();
            dodati.btnDodaj.Text = "Dodaj";                       
            dodati.Show();
            dodati.btnObrisi.Enabled = false;
        }

        //Izmjena podataka
        public void izmjenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma izmijeniti = new Forma();
            
            if (dataGridView1.CurrentRow != null)
            {
                izmijeniti.Show();               
                izmijeniti.btnDodaj.Text = "Potvrdi";
                izmijeniti.btnObrisi.Enabled = false;
                crud1.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);               
                izmijeniti.textBoxGrad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                izmijeniti.textBoxBroj.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati grad, kako biste izvršili izmjenu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);          
            }                       
        }

        //Brisanje podataka
        private void brisanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Forma obrisati = new Forma();
            if (dataGridView1.CurrentRow != null)
            {
                obrisati.Show();
                obrisati.btnDodaj.Enabled = false;
                crud1.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                obrisati.textBoxGrad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                obrisati.textBoxGrad.ReadOnly = true;
                obrisati.textBoxBroj.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                obrisati.textBoxBroj.ReadOnly = true;
                crud1.brisanje();
            }
            else if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati grad, kako biste obrisali podatke !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveForm.Close();
            }
        }

        //pretrazivanje podataka
        private void pretrazi_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Gradovi WHERE 1=1";
            String str = null;
            String[] strArr = null;
            str = textBoxPretrazi.Text;
            char[] splitChar = { ' ' };
            strArr = str.Split(splitChar);
            foreach (string rijec in strArr)
            {
                query += string.Format("AND Naziv LIKE '%{0}%' OR PostanskiBroj LIKE '%{0}%'", rijec,textBoxPretrazi);
            }
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapt = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }con.Close();          
        }
     
            private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOsvjezi_Click(object sender, EventArgs e)
        {
            crud1.osvjezi();
            dataGridView1.DataSource = crud1.Dt1;
            dataGridView1.Rows[0].Selected = false;
        }

        private void štampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting re = new Reporting();
            re.Show();                      
        }

        private void Main_Load_1(object sender, EventArgs e)
        {

        }
    }
}
