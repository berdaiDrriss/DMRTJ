using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DMR_tJ
{
    public partial class depense : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public depense()
        {
            InitializeComponent();
            remplir();
        }

        private void remplir()
        {
            if(tabControl1.SelectedTab == entrees)
            {
                conxChecker();
                bd.Open();
                tableau.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select dateEntree,libelleEntree,montantEntree from entree  ", bd);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    tableau.Rows.Add(
                        rd[0],
                        rd[1],
                        rd[2]
                        );
                }
                rd.Close();
            }
            else
            {
                conxChecker();
                bd.Open();
                tableau1.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select dateSortie,libelleSortie,montantSortie from sortie  ", bd);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    tableau1.Rows.Add(
                        rd[0],
                        rd[1],
                        rd[2]
                        );
                }
                rd.Close();
            }
            
        }

        private void remplire()
        {
            conxChecker();
            bd.Open();
            tableau1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select dateSortie,libelleSortie,montantSortie from sortie  ", bd);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                tableau1.Rows.Add(
                    rd[0],
                    rd[1],
                    rd[2]
                    );
            }
            rd.Close();
        }

        private void vider()
        {
            date.Text = "";
            libelle.Text = "";
            montant.Text = "";
   
        }

        private void vider1()
        {
            dateS.Text = "";
            libelleS.Text = "";
            montantS.Text = "";

        }

        public void conxChecker()
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
           conxChecker();
            if (date.Text != "" && libelle.Text != "" && montant.Text != "")
            {
                bd.Open();

                SqlCommand cmd = new SqlCommand("insert into entree values (@dateEntree,@libelleEntree,@montantEntree )", bd);
                cmd.Parameters.AddWithValue("@dateEntree", date.Value);
                cmd.Parameters.AddWithValue("@libelleEntree", libelle.Text);
                cmd.Parameters.AddWithValue("@montantEntree", montant.Text) ;
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("ENREGISTREMENT EFFECTUER AVEC SUCCEE ", "FIDUPLUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.Close();
                vider();
                remplir();
            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "FIDUCIARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void depense_Load(object sender, EventArgs e)
        {
            remplir();
            //remplire();
        }

        private void EnregistrerS_Click(object sender, EventArgs e)
        {
            conxChecker();
            if (dateS.Text != "" && libelleS.Text != "" && montantS.Text != "")
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("insert into sortie values (@dateSortie,@libelleSortie,@montantSortie )", bd);
            cmd.Parameters.AddWithValue("@dateSortie", dateS.Value);
            cmd.Parameters.AddWithValue("@libelleSortie", libelleS.Text);
            cmd.Parameters.AddWithValue("@montantSortie", montantS.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("ENREGISTREMENT EFFECTUER AVEC SUCCEE ", "FIDUPLUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bd.Close();
            vider1();
            remplire();
        }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "FIDUCIARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void libilleRentree_TextChanged(object sender, EventArgs e)
        {
            conxChecker();
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select dateEntree,libelleEntree,montantEntree from entree where libelleEntree like @dem", bd);
            cmd.Parameters.AddWithValue("@dem", libilleRentree.Text + "%");
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[0],
                    rd[1],
                    rd[2]

                    );
            }
            bd.Close();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            remplir();
        }
    }

}
