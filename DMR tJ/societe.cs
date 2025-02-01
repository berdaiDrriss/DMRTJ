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
    public partial class societe : Form
    {
        int npr;
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        //static string cons = @"server=DESKTOP-3RISC0T\SQLEXPRESS;database=fiduciare;Integrated security=True";
        //SqlConnection bd = new SqlConnection(cons);
        //SqlConnection bd = new SqlConnection(@"data source=DESKTOP-3RISC0T\SQLEXPRESS;inital catalog=fiduciare;Integrated security=True");
        public societe()
        {
            InitializeComponent();
            remplir();
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
            SqlCommand cmd = new SqlCommand("select * from societee ", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            
            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[1],
                    rd[2],
                    rd[5],
                    rd[3],
                    rd[9],
                    rd[10],
                    rd[11],
                    rd[12],
                    rd[13]
                    ) ;
            }
            rd.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void clear()
        {
            denomination.Text = ""; 
            forme.Text = ""; 
            capital.Text = ""; 
            regimeTva.Text = ""; 
            activite.Text = ""; 
            ville.Text = ""; 
            siege.Text = ""; 
            ice.Text = ""; 
            tp.Text = ""; 
            iif.Text = ""; 
            rc.Text = "";
            cnss.Text = "";
            nRTVA.Text = "";
            denomination.Select();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            conxChecker();
            if (denomination.Text!="" && forme.Text!="" && capital.Text!="" && regimeTva.Text!="" && activite.Text!="" && ville.Text!="" && siege.Text!="" && ice.Text!="" && tp.Text!="" && iif.Text!="" && rc.Text!="" && cnss.Text!="")
            {
                bd.Open();
                SqlCommand cmd1 = new SqlCommand("Select denomination From societee where denomination=@denomination", bd);
                cmd1.Parameters.AddWithValue("@denomination", denomination.Text);
                SqlDataReader rd = cmd1.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    MessageBox.Show("DENOMINATION DEJA EXISTE", "FIDUPLUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rd.Close();
                    return;
                }
                rd.Close();
                SqlCommand cmd = new SqlCommand("insert into societee values (@denomination,@forme,@capital,@regimeTva,@dateDebut,@activite,@ville,@siege,@ice,@tp,@iif,@rc,@cnss )",bd);
                cmd.Parameters.AddWithValue("@denomination", denomination.Text);
                cmd.Parameters.AddWithValue("@forme", forme.Text);
                cmd.Parameters.AddWithValue("@capital", capital.Text);
                cmd.Parameters.AddWithValue("@regimeTva", nRTVA.Text);
                cmd.Parameters.AddWithValue("@dateDebut", dateDebut.Value);
                cmd.Parameters.AddWithValue("@activite", activite.Text);
                cmd.Parameters.AddWithValue("@ville", ville.Text);
                cmd.Parameters.AddWithValue("@siege", siege.Text);
                cmd.Parameters.AddWithValue("@ice", ice.Text);
                cmd.Parameters.AddWithValue("@tp", tp.Text);
                cmd.Parameters.AddWithValue("@iif", iif.Text);
                cmd.Parameters.AddWithValue("@rc", rc.Text);
                cmd.Parameters.AddWithValue("@cnss", cnss.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ENREGISTREMENT EFFECTUER AVEC SUCCEE ", "FIDUPLUS", MessageBoxButtons.OK,MessageBoxIcon.Information) ;
                bd.Close();
                clear();
                remplir();
            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "FIDUCIARE", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            conxChecker();
            bd.Open();
            npr = int.Parse(Interaction.InputBox("RECHERCHER N° SOCIETE", "FIDUPLUS "));
            SqlCommand cmd = new SqlCommand("select * from societee where [idSte]=@nSte", bd);
           // SqlCommand cmd = new SqlCommand("select denomination from societee where [idSte]=@nSte", bd);
            cmd.Parameters.AddWithValue("@nSte", npr);
            SqlDataReader rd = cmd.ExecuteReader();
           
            if (rd.HasRows == false)
            {
                MessageBox.Show("N° SOCIETE " + npr.ToString() + "  N'EXISTE PAS ", "FIDUPLUS ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rd.Read();
                denomination.Text = rd[1].ToString();
                forme.Text = rd[2].ToString();
                capital.Text = rd[3].ToString();
                nRTVA.Text = rd[4].ToString();
                dateDebut.Text = rd[5].ToString();
                activite.Text = rd[6].ToString();
                ville.Text = rd[7].ToString();
                siege.Text = rd[8].ToString();
                ice.Text = rd[9].ToString();
                tp.Text = rd[10].ToString();
                iif.Text = rd[11].ToString();
                rc.Text = rd[12].ToString();
                cnss.Text = rd[13].ToString();
                if(nRTVA.Text == "1")
                {
                    regimeTva.SelectedIndex = 0;
                }
                else
                {
                    regimeTva.SelectedIndex = 1;
                }
                //Modifier.Enabled = true;
               // Supprimer.Enabled = true;
               // Enregistrer.Enabled = false;

            }
            rd.Close();
            bd.Close();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            conxChecker();
            bd.Open();
            if (MessageBox.Show("VOULEZ-VOUS APPORTER DES MODIFICATIONS", "FIDUPLUS FACTURATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update societee set[denomination]=@denomination," +
                    "[formeJuridique]=@forme,[capital]=@capital, " +
                    "[regimeTva]=@regimeTva , [dateDebutActivite]=@dateDebut, [activitee]=@activite, [ville]=@ville, [siege]=@siege, [nIce]=@ice, [nTp]=@tp, [nIf]=@iif, [nRc]=@rc, [nCnss]=@cnss where[idSte]='" + npr + "'", bd);
                cmd.Parameters.AddWithValue("@denomination", denomination.Text);
                cmd.Parameters.AddWithValue("@forme", forme.Text);
                cmd.Parameters.AddWithValue("@capital", capital.Text);
                cmd.Parameters.AddWithValue("@regimeTva", nRTVA.Text);
                cmd.Parameters.AddWithValue("@dateDebut", dateDebut.Value);
                cmd.Parameters.AddWithValue("@activite", activite.Text);
                cmd.Parameters.AddWithValue("@ville", ville.Text);
                cmd.Parameters.AddWithValue("@siege", siege.Text);
                cmd.Parameters.AddWithValue("@ice", ice.Text);
                cmd.Parameters.AddWithValue("@tp", tp.Text);
                cmd.Parameters.AddWithValue("@iif", iif.Text);
                cmd.Parameters.AddWithValue("@rc", rc.Text);
                cmd.Parameters.AddWithValue("@cnss", cnss.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES", "FIDUPLUS FACTURATION",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Nouveau_Click(sender, e);
                remplir();
                clear();
            }
        }

        private void societe_Load(object sender, EventArgs e)
        {

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            conxChecker();

            if (MessageBox.Show("VOULEZ-VOUS SUPPRIMER CE CLIENT", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            bd.Open();
            {
                SqlCommand x = new SqlCommand(" delete from societee where idSte = @idSte",bd);
                x.Parameters.AddWithValue("@idSte", npr);
                x.ExecuteNonQuery();
            }
            bd.Close();
            remplir();
           
        }

        private void dem_TextChanged(object sender, EventArgs e)
        {
            conxChecker();
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand x = new SqlCommand("select s.denomination,s.formeJuridique,s.dateDebutActivite,s.capital,s.nIce,s.nTp,s.nIf,s.nRc,s.nCnss from societee s  where s.denomination like @dem", bd);
            x.Parameters.AddWithValue("@dem", dem.Text + "%");
            SqlDataReader rd = x.ExecuteReader();
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
            bd.Close();
        }

        private void regimeTva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regimeTva.SelectedIndex==0)
            {
                nRTVA.Text = "1";
            }
            else
            {
                nRTVA.Text = "2";
            }
        }
    }
}
