using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zadatak5
{
    public partial class Forma : Form
    {
        Main main = new Main();
        CRUD crud1 = new CRUD();

        public Forma()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

            crud1.Name = textBoxGrad.Text;
            crud1.Number = textBoxBroj.Text;
            crud1.brisanje();
            MessageBox.Show("Uspješno ste obrisali podatke !");
            Forma.ActiveForm.Close();
            
            crud1.osvjezi();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (btnDodaj.Text == "Dodaj")
            {
                if (String.IsNullOrEmpty(textBoxGrad.Text))
                {
                    MessageBox.Show("Upišite naziv grada !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(textBoxBroj.Text))
                {
                    MessageBox.Show("Upišite poštanski broj !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    crud1.Name = textBoxGrad.Text;
                    crud1.Number = textBoxBroj.Text;
                    crud1.dodavanje();
                    MessageBox.Show("Uspješno ste dodali podatke !");
                    textBoxGrad.Clear();
                    textBoxBroj.Clear();
                    crud1.osvjezi();
                }
            }
            else if (btnDodaj.Text == "Potvrdi") {
                
                crud1.Name = textBoxGrad.Text;
                crud1.Number = textBoxBroj.Text;
                crud1.izmjena();
                MessageBox.Show("Uspješno ste izvršili izmjenu podataka !");
                Forma.ActiveForm.Close();
                crud1.osvjezi();
            }
        }

        private void Forma_Load(object sender, EventArgs e)
        {

        }
    }
}
