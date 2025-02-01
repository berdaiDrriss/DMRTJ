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
    public partial class loginMotPasse : Form
    {
        int npr;
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public loginMotPasse()
        {
            InitializeComponent();
        }

        private void vider()
        {
            denomination.Text = "";
            login.Text = "";
            motPasee.Text = "";
            compte.Text = "";
            observation.Text = "";
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
            SqlCommand cmd = new SqlCommand("select lp.idlogin,s.denomination,lp.loginm,lp.motPasse,lp.compte,lp.observation from loginPasses lp join societee s on s.idSte = lp.idSte " , bd);
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

        private void Choisir_Click(object sender, EventArgs e)
        {
            listeSocietee ls = new listeSocietee();
            ls.ShowDialog();
            int i = ls.tableau.CurrentRow.Index;
            ids.Text = ls.tableau.Rows[i].Cells[0].Value.ToString();
            denomination.Text = ls.tableau.Rows[i].Cells[1].Value.ToString();


        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            conxChecker();
            if (login.Text != "" && motPasee.Text != "" && compte.Text != "" && observation.Text != "")
            {
                bd.Open();
             
              
                SqlCommand cmd = new SqlCommand("insert into loginPasses values (@idSte,@loginm,@motPasse,@compte,@observation)", bd);
                cmd.Parameters.AddWithValue("@idSte", ids.Text);
                cmd.Parameters.AddWithValue("@loginm", login.Text);
                cmd.Parameters.AddWithValue("@motPasse", motPasee.Text);
                cmd.Parameters.AddWithValue("@compte", compte.Text);
                cmd.Parameters.AddWithValue("@observation", observation.Text);
               

                cmd.ExecuteNonQuery();
                MessageBox.Show("ENREGISTREMENT EFFECTUER AVEC SUCCEE ", "FIDUPLUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.Close();
                //clear();
                //remplir();
            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "FIDUCIARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            remplir();
            vider();
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            conxChecker();
            bd.Open();
            try
            {
                npr = int.Parse(Interaction.InputBox("RECHERCHER N° SOCIETE", "FIDUPLUS "));
                SqlCommand cmd = new SqlCommand("select s.denomination,lp.loginm,lp.motPasse,lp.compte,lp.observation from loginPasses lp join societee s on s.idSte = lp.idSte where [idLogin]=@X", bd);
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
                    login.Text = rd[1].ToString();
                    motPasee.Text = rd[2].ToString();
                    compte.Text = rd[3].ToString();
                    observation.Text = rd[4].ToString();


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

        private void loginMotPasse_Load(object sender, EventArgs e)
        {
            remplir();
        }

        private void deleteT(int id)
        {
            conxChecker();
            bd.Open();
            //string com = "DELETE FROM loginPasses WHERE idLogin = @id";
            SqlCommand cmd = new SqlCommand("DELETE FROM loginPasses WHERE idLogin = @id", bd);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            bd.Close();
        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tableau.Columns["supprimer"].Index && e.RowIndex >= 0)
            {
                if (tableau.Rows[e.RowIndex].Cells["supprimer"].Value != null)
                {
                    // Get the ID of the row to delete
                    int rowId = Convert.ToInt32(tableau.Rows[e.RowIndex].Cells[0].Value);

                    // Delete the row from the database
                    deleteT(rowId);

                    remplir();

                    // Remove the row from the DataGridView
                    //tableau.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            //conxChecker();
            //bd.Open();
            //if (MessageBox.Show("VOULEZ-VOUS APPORTER DES MODIFICATIONS", "FIDUPLUS FACTURATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    SqlCommand cmd = new SqlCommand("update loginPasses set[loginm]=@loginm," +
            //        "[motPasse]=@motPasse,[compte]=@compte, " +
            //        "[observation]=@observation where[idLogin]='" + npr + "'", bd);
            //    cmd.Parameters.AddWithValue("@denomination", denomination.Text);
            //    cmd.Parameters.AddWithValue("@loginm", login.Text);
            //    cmd.Parameters.AddWithValue("@motPasse", motPasee.Text);
            //    cmd.Parameters.AddWithValue("@compte", compte.Text);
            //    cmd.Parameters.AddWithValue("@observation", observation.Text);

            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES", "FIDUPLUS FACTURATION",
            //       MessageBoxButtons.OK, MessageBoxIcon.Information);
            //   //Nouveau_Click(sender, e);
            //    remplir();
            //}

            conxChecker();
            bd.Open();

            if (MessageBox.Show("VOULEZ-VOUS APPORTER DES MODIFICATIONS", "FIDUPLUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Requête SQL corrigée et sécurisée
                    string query = "UPDATE loginPasses SET [loginm] = @loginm, [motPasse] = @motPasse, [compte] = @compte, [observation] = @observation WHERE [idLogin] = @idLogin";

                    SqlCommand cmd = new SqlCommand(query, bd);

                    // Ajout des paramètres
                    cmd.Parameters.AddWithValue("@loginm", login.Text); // Nom corrigé
                    cmd.Parameters.AddWithValue("@motPasse", motPasee.Text); // Nom corrigé
                    cmd.Parameters.AddWithValue("@compte", compte.Text);
                    cmd.Parameters.AddWithValue("@observation", observation.Text);
                    cmd.Parameters.AddWithValue("@idLogin", npr); // Paramètre pour l'ID

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            conxChecker();
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand x = new SqlCommand("select lp.idlogin,s.denomination,lp.loginm,lp.motPasse,lp.compte,lp.observation from loginPasses lp join societee s on s.idSte = lp.idSte where s.denomination like @dem", bd);
            x.Parameters.AddWithValue("@dem", textBox3.Text+"%");
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
