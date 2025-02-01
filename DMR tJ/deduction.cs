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
    public partial class deduction : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public deduction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < tableau.Rows.Count - 1; x++)
            {
                if (tableau.Rows[x].Cells[0].Value.ToString() == nf.Text)
                {
                    MessageBox.Show("SERVICE DEJA  AJOUTÉ", "FIDUPLUS FACTURATION",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            tableau.Rows.Add(
                tAch.Text,
                no.Text,
                nf.Text,
                df.Value.Date,
                rs.Text,
                iff.Text,
                icef.Text,
                des.Text,
                mht.Text,
                tau.Text,
                mtva.Text,
                pro.Text,
                mapro.Text,
                mam.Text,
                mttc.Text,
                dp.Value.Date,
                idModePayment.Text

                // df.Value.ToString("YYYY/MM/DD"),
                // dp.Value.ToString("YYYY/MM/DD"),
                //dp.Value.Date,

                );
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            bd.Open();
            for (int i = 0; i < tableau.Rows.Count - 1; i++)
            {
                SqlCommand v = new SqlCommand("insert into deduction (idSte,typeA,nOrder,nfA,dfA,rscfA,ifFouA,iceFouA,ddfA,mhtA,ttvaA,mtvaA,prorata,mttcA,maProrata,amande,ddpA,mdpA,periodeA) values (@dem,@tAch,@no,@nf,@df,@rs,@iff,@icef,@des,@mht,@tau,@mtva,@pro,@mapro,@mam,@mttc,@dp,@mp,@period)", bd);
                v.Parameters.AddWithValue("@dem", nDem.Text);
                v.Parameters.AddWithValue("@tAch", tableau.Rows[i].Cells[0].Value.ToString());
                v.Parameters.AddWithValue("@no", tableau.Rows[i].Cells[1].Value.ToString());
                v.Parameters.AddWithValue("@nf", tableau.Rows[i].Cells[2].Value.ToString());
                v.Parameters.AddWithValue("@df", tableau.Rows[i].Cells[3].Value);
                v.Parameters.AddWithValue("@rs", tableau.Rows[i].Cells[4].Value.ToString());
                v.Parameters.AddWithValue("@iff", tableau.Rows[i].Cells[5].Value.ToString());
                v.Parameters.AddWithValue("@icef", tableau.Rows[i].Cells[6].Value.ToString());
                v.Parameters.AddWithValue("@des", tableau.Rows[i].Cells[7].Value.ToString());
                v.Parameters.AddWithValue("@mht", tableau.Rows[i].Cells[8].Value.ToString());
                v.Parameters.AddWithValue("@tau", tableau.Rows[i].Cells[9].Value.ToString());
                v.Parameters.AddWithValue("@mtva", tableau.Rows[i].Cells[10].Value.ToString());
                v.Parameters.AddWithValue("@pro", tableau.Rows[i].Cells[11].Value.ToString());
                v.Parameters.AddWithValue("@mapro", tableau.Rows[i].Cells[12].Value.ToString());
                v.Parameters.AddWithValue("@mam", tableau.Rows[i].Cells[13].Value.ToString());
                v.Parameters.AddWithValue("@mttc", tableau.Rows[i].Cells[14].Value.ToString());
                v.Parameters.AddWithValue("@dp", tableau.Rows[i].Cells[15].Value);
                v.Parameters.AddWithValue("@mp", tableau.Rows[i].Cells[16].Value.ToString());


                if (tupeD.SelectedIndex == 0)
                {
                    v.Parameters.AddWithValue("@period", mois.Text + " / " + anne.Text);
                }
                else
                {
                    v.Parameters.AddWithValue("@period", trim.Text + " / " + anne.Text);
                }

                v.ExecuteNonQuery();

            };
            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES", "FIDUPLUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bd.Close();
        }

        private void Choisir_Click(object sender, EventArgs e)
        {
            listeSocietee ls = new listeSocietee();
            ls.ShowDialog();
            int i = ls.tableau.CurrentRow.Index;
            nDem.Text = ls.tableau.Rows[i].Cells[0].Value.ToString();
            dem.Text = ls.tableau.Rows[i].Cells[1].Value.ToString();
        }

        private void tupeD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tupeD.SelectedIndex == 0)
            {
                mois.Visible = true;
                mo.Visible = true;
                anne.Visible = true;
                an.Visible = true;
                trim.Visible = false;
                tri.Visible = false;

            }
            else
            {
                mois.Visible = false;
                mo.Visible = false;
                anne.Visible = true;
                an.Visible = true;
                trim.Visible = true;
                tri.Visible = true;
            }
        }

        private void deduction_Load(object sender, EventArgs e)
        {

        }

        private void nDem_TextChanged(object sender, EventArgs e)
        {

        }

        private void mp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mp.SelectedIndex)
            {
                case 0:
                    idModePayment.Text = "1";
                    break;
                case 1:
                    idModePayment.Text = "2";
                    break;
                case 2:
                    idModePayment.Text = "3";
                    break;
                case 3:
                    idModePayment.Text = "4";
                    break;
                case 4:
                    idModePayment.Text = "5";
                    break;
                case 5:
                    idModePayment.Text = "6";
                    break;
                case 6:
                    idModePayment.Text = "7";
                    break;
                default:
                    // Optional: Handle other cases if needed
                    break;
            }

        }
    }
}
