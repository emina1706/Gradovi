using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace Zadatak5
{

    class CRUD 
    {
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

        public DataTable Dt1 { get; set; }

        SqlDataAdapter adapt1;
        public DataTable dt { set; get; }
        public DataTable Dt { set; get; }
        public String Name { set; get; }
        public string Number { set; get; }
        public string Time { set; get; }
        public int Id { set; get; }
        public DataTable Dt2 { get; set; }

        public void dodavanje()           
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Gradovi(Naziv,PostanskiBroj,DatumIVrijemeUpisa) VALUES (@naziv,@broj,@vrijeme)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@naziv", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.Add("@broj", SqlDbType.NVarChar).Value = Number;
            cmd.Parameters.Add("@vrijeme", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void izmjena()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Gradovi SET Naziv = @naziv,PostanskiBroj = @broj,DatumIVrijemeUpisa = @vrijeme WHERE Id=@id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@naziv", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.Add("@broj", SqlDbType.NVarChar).Value = Number;
            cmd.Parameters.Add("@vrijeme", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.ExecuteNonQuery();            
            con.Close();
        }

        public void brisanje()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Gradovi WHERE Id=@id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id; 
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void pretrazivanje() {
            /*con.Open();
            string query = "SELECT * FROM Gradovi WHERE 1=1";
            String Str = " ";           
            char[] splitChar = { ' ' };
            String[] strArr = Str.Split(splitChar);
            foreach (string rijec in strArr)
            {
                query += string.Format("AND Naziv LIKE '%{0}%' OR PostanskiBroj LIKE '%{0}%'", rijec,Str);
            }
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapt = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                }
            }
            con.Close();*/
        }

        public void osvjezi() {
            con.Open();
            adapt1 = new SqlDataAdapter("SELECT * FROM GradOvi", con);
            Dt1 = new DataTable();
            adapt1.Fill(Dt1);
            con.Close();
        }
        /* Podaci za Štamppu :
         * Username : Admin,
         * Password : Admin-----------------------------------------------------------------------------*/
        
    }
}
    
    

