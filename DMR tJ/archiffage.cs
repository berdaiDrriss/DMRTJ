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
using Microsoft.VisualBasic;
using System.Configuration;

namespace DMR_tJ
{
    public partial class archiffage : Form
    {
        int npr;
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public archiffage()
        {
            InitializeComponent();
        }

        public void conxChecker()
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
        }

        private void vider()
        {
            denomination.Text = "";
            date.Text = "";
            typeDossier.Text = "";
            nDossier.Text = "";
            nBoite.Text = "";
            denomination.Select();
        }

        private void remplir()
        {
            conxChecker();
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select A.idArchifage,s.denomination,A.dateA,A.typeDossier,A.nDossier,A.nBoite from archifage A join societee s on s.idSte = A.idSte ", bd);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[0],
                    rd[1],
                    rd[2],
                    rd[3],
                    rd[4],
                    rd[5]

                    );
            }
            rd.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
             conxChecker();
            if (denomination.Text != "" && typeDossier.Text != "" && nDossier.Text != "" && nBoite.Text != "")
            {
                bd.Open();


                SqlCommand cmd = new SqlCommand("insert into archifage values (@idSte,@dateA,@typeDossier,@nDossier,@nBoite)", bd);
                cmd.Parameters.AddWithValue("@idSte", ids.Text);
                cmd.Parameters.AddWithValue("@dateA", date.Value);
                cmd.Parameters.AddWithValue("@typeDossier", typeDossier.Text);
                cmd.Parameters.AddWithValue("@nDossier", nDossier.Text);
                cmd.Parameters.AddWithValue("@nBoite", nBoite.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("ENREGISTREMENT EFFECTUER AVEC SUCCEE ", "FIDUPLUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.Close();
                //clear();
                remplir();
            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "FIDUCIARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            remplir();
            vider();
        }

        private void Choisir_Click(object sender, EventArgs e)
        {

            listeSocietee ls = new listeSocietee();
            ls.ShowDialog();
            int i = ls.tableau.CurrentRow.Index;
            ids.Text = ls.tableau.Rows[i].Cells[0].Value.ToString();
            denomination.Text = ls.tableau.Rows[i].Cells[1].Value.ToString();
        }

        private void archiffage_Load(object sender, EventArgs e)
        {
            remplir();
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            conxChecker();
            bd.Open();
            //try
            //{
                npr = int.Parse(Interaction.InputBox("RECHERCHER N° SOCIETE", "FIDUPLUS "));
                SqlCommand cmd = new SqlCommand("select s.denomination,A.dateA,A.typeDossier,A.nDossier,A.nBoite from archifage A join societee s on s.idSte = A.idSte where [idArchifage]=@X", bd);
                // SqlCommand cmd = new SqlCommand("select denomination from societee where [idSte]=@nSte", bd);
                cmd.Parameters.AddWithValue("@X", npr);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows == false)
                {
                    MessageBox.Show("N° SOCIETE " + npr.ToString() + "  N'EXISTE PAS ", "FIDUPLUS ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    rd.Read();
                    denomination.Text = rd[0].ToString();
                    date.Text = rd[1].ToString();
                    typeDossier.Text = rd[2].ToString();
                    nDossier.Text = rd[3].ToString();
                    nBoite.Text = rd[4].ToString();


                    //Modifier.Enabled = true;
                    // Supprimer.Enabled = true;
                    // Enregistrer.Enabled = false;

                }
                rd.Close();
                bd.Close();
            //}
            //catch
            //{
            //    MessageBox.Show(" SAISIE INCORRECTE ", "FIDUPLUS",
            //   MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            conxChecker();
            bd.Open();

            if (MessageBox.Show("VOULEZ-VOUS APPORTER DES MODIFICATIONS", "FIDUPLUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Requête SQL corrigée et sécurisée
                    string query = "UPDATE archifage SET [dateA] = @dateA, [typeDossier] = @typeDossier, [nDossier] = @nDossier, [nBoite] = @nBoite WHERE [idArchifage] = @idArchifage";

                    SqlCommand cmd = new SqlCommand(query, bd);

                    // Ajout des paramètres
                    cmd.Parameters.AddWithValue("@dateA", date.Value); // Nom corrigé
                    cmd.Parameters.AddWithValue("@typeDossier", typeDossier.Text); // Nom corrigé
                    cmd.Parameters.AddWithValue("@nDossier", nDossier.Text);
                    cmd.Parameters.AddWithValue("@nBoite", nBoite.Text);
                    cmd.Parameters.AddWithValue("@idArchifage", npr); // Paramètre pour l'ID

                    // Exécution de la commande
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("MODIFICATION EFFECTUÉE AVEC SUCCÈS", "FIDUPLUS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Rechargement des données
                    remplir();
                    vider();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Fermeture de la connexion
                    bd.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conxChecker();
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand x = new SqlCommand("select lp.idArchifage,s.denomination,lp.dateA,lp.typeDossier,lp.nDossier,lp.nBoite from archifage lp join societee s on s.idSte = lp.idSte where s.denomination like @dem", bd);
            x.Parameters.AddWithValue("@dem", textBox1.Text + "%");
            SqlDataReader rd = x.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[0],
                    rd[1],
                    rd[2],
                    rd[3],
                    rd[4],
                    rd[5]
                    );
            }
            bd.Close();
        }
    }
}
