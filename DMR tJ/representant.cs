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
    public partial class representant : Form
    {
        int npr;
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public representant()
        {
            InitializeComponent();
        }

        private void vider()
        {
            denomination.Text = "";
            nom.Text = "";
            typeIdentite.Text = "";
            identite.Text = "";
            tel.Text = "";
            mail.Text = "";
            ville.Text = "";
            adresse.Text = "";
            denomination.Select();
        }

        public void conxChecker()
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }

        }

        private void remplir()
        {
            conxChecker();
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select R.idRepresentant,s.denomination,R.nom,R.typeIdentite,R.identite,R.tel,R.email,R.ville,R.adresse from representant R join societee s on s.idSte = R.idSte ", bd);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[0],
                    rd[1],
                    rd[2],
                    rd[3],
                    rd[4],
                    rd[5],
                    rd[6],
                    rd[7],
                    rd[8]

                    );
            }
            rd.Close();
        }


        private void Enregistrer_Click(object sender, EventArgs e)
        {
             conxChecker();
            if (nom.Text != "" && typeIdentite.Text != "" && identite.Text != "" && tel.Text != "" && mail.Text != "" && ville.Text != "" && adresse.Text != "")
            {
                bd.Open();


                SqlCommand cmd = new SqlCommand("insert into representant values (@idSte,@nom,@typeIdentite,@identite,@tel,@email,@ville,@adresse)", bd);
                cmd.Parameters.AddWithValue("@idSte", ids.Text);
                cmd.Parameters.AddWithValue("@nom", nom.Text);
                cmd.Parameters.AddWithValue("@typeIdentite", typeIdentite.Text);
                cmd.Parameters.AddWithValue("@identite", identite.Text);
                cmd.Parameters.AddWithValue("@tel", tel.Text);
                cmd.Parameters.AddWithValue("@email", mail.Text);
                cmd.Parameters.AddWithValue("@ville", ville.Text);
                cmd.Parameters.AddWithValue("@adresse", adresse.Text);
                


                cmd.ExecuteNonQuery();
                MessageBox.Show("ENREGISTREMENT EFFECTUER AVEC SUCCEE ", "FIDUPLUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.Close();
                //clear();
                remplir();
                vider();
            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "FIDUCIARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //remplir();
        }

        private void Choisir_Click(object sender, EventArgs e)
        {
            listeSocietee ls = new listeSocietee();
            ls.ShowDialog();
            int i = ls.tableau.CurrentRow.Index;
            ids.Text = ls.tableau.Rows[i].Cells[0].Value.ToString();
            denomination.Text = ls.tableau.Rows[i].Cells[1].Value.ToString();
        }

        private void representant_Load(object sender, EventArgs e)
        {
            remplir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            conxChecker();
            bd.Open();
            try
            {
                npr = int.Parse(Interaction.InputBox("RECHERCHER N° SOCIETE", "FIDUPLUS "));
                SqlCommand cmd = new SqlCommand("select s.denomination,R.nom,R.typeIdentite,R.identite,R.tel,R.email,R.ville,R.adresse from representant R join societee s on s.idSte = R.idSte where [idRepresentant]=@X", bd);
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
                    nom.Text = rd[1].ToString();
                    typeIdentite.Text = rd[2].ToString();
                    identite.Text = rd[3].ToString();
                    tel.Text = rd[4].ToString();
                    mail.Text = rd[5].ToString();
                    ville.Text = rd[6].ToString();
                    adresse.Text = rd[7].ToString();


                    //Modifier.Enabled = true;
                    // Supprimer.Enabled = true;
                    // Enregistrer.Enabled = false;

                }
                rd.Close();
                bd.Close();
            }
            catch
            {
                MessageBox.Show(" SAISIE INCORRECTE ", "FIDUPLUS",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    string query = "UPDATE representant SET [nom] = @nom, [typeIdentite] = @typeIdentite, [identite] = @identite, [tel] = @tel , [email] = @email , [ville] = @ville , [adresse] = @adresse WHERE [idRepresentant] = @idRepresentant";

                    SqlCommand cmd = new SqlCommand(query, bd);

                    // Ajout des paramètres
                    cmd.Parameters.AddWithValue("@nom", nom.Text); // Nom corrigé
                    cmd.Parameters.AddWithValue("@typeIdentite", typeIdentite.Text); // Nom corrigé
                    cmd.Parameters.AddWithValue("@identite", identite.Text);
                    cmd.Parameters.AddWithValue("@tel", tel.Text);
                    cmd.Parameters.AddWithValue("@email", mail.Text);
                    cmd.Parameters.AddWithValue("@ville", ville.Text);
                    cmd.Parameters.AddWithValue("@adresse", adresse.Text);
                    cmd.Parameters.AddWithValue("@idRepresentant", npr); // Paramètre pour l'ID

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
    }
}
