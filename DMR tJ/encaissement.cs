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
    public partial class encaissement : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public encaissement()
        {
            InitializeComponent();
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
                nf.Text,
               // df.Value.ToString("YYYY/MM/DD"),
                df.Value.Date,
                rs.Text,
                des.Text,
                mht.Text,
                tau.Text,
                mtva.Text,
                mttc.Text,
               // dp.Value.ToString("YYYY/MM/DD"),
                dp.Value.Date,
                mp.Text
                ) ;
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            bd.Open();

            for (int i=0; i < tableau.Rows.Count -1; i++)
            {
                SqlCommand v = new SqlCommand("insert into encaissements (idSte,nfV,dfV,rscfV,ddfV,mhtV,ttvaV,mtvaV,mttcV,ddpV,mdpV,periodeV,typeV) values (@dem,@nf,@df,@rs,@des,@mht,@tau,@mtva,@mttc,@dp,@mp,@period,@tVen)", bd);
                v.Parameters.AddWithValue("@dem",nDem.Text);
                v.Parameters.AddWithValue("@nf", tableau.Rows[i].Cells[0].Value.ToString());
                v.Parameters.AddWithValue("@df", tableau.Rows[i].Cells[1].Value);
                v.Parameters.AddWithValue("@rs", tableau.Rows[i].Cells[2].Value.ToString());
                v.Parameters.AddWithValue("@des", tableau.Rows[i].Cells[3].Value.ToString());
                v.Parameters.AddWithValue("@mht", tableau.Rows[i].Cells[4].Value.ToString());
                v.Parameters.AddWithValue("@tau", tableau.Rows[i].Cells[5].Value.ToString());
                v.Parameters.AddWithValue("@mtva", tableau.Rows[i].Cells[6].Value.ToString());
                v.Parameters.AddWithValue("@mttc", tableau.Rows[i].Cells[7].Value.ToString());
                v.Parameters.AddWithValue("@dp", tableau.Rows[i].Cells[8].Value);
                v.Parameters.AddWithValue("@mp", idModePayment.Text);
                v.Parameters.AddWithValue("@tVen", tVen.Text);
                if (tupeD.SelectedIndex==0)
                {
                    v.Parameters.AddWithValue("@period", mois.Text + "/" + anne.Text);
                }
                else
                {
                    v.Parameters.AddWithValue("@period", trim.Text + "/" + anne.Text);
                }
                v.ExecuteNonQuery();
                
            };
            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES", "FIDUPLUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bd.Close();



            //bd.Open();
            //try
            //{
            //    for (int i = 0; i < tableau.Rows.Count - 1; i++)
            //    {
            //        SqlCommand v = new SqlCommand(
            //            "INSERT INTO encaissement (dem, nf, df, mht, mtva, tau, mp, des, dp, rs) VALUES (@dem, @nf, @df, @mht, @mtva, @tau, @mp, @des, @dp, @rs)", bd);

            //        v.Parameters.AddWithValue("@dem", nDem.Text);
            //        v.Parameters.AddWithValue("@nf", tableau.Rows[i].Cells[0].Value.ToString());

            //        // Handle @df parameter
            //        var dfValue = tableau.Rows[i].Cells[1].Value;
            //        if (dfValue == null || string.IsNullOrWhiteSpace(dfValue.ToString()))
            //        {
            //            v.Parameters.AddWithValue("@df", DBNull.Value);
            //        }
            //        else
            //        {
            //            v.Parameters.AddWithValue("@df", Convert.ToDateTime(dfValue).ToString("yyyy-MM-dd"));
            //        }

            //        v.Parameters.AddWithValue("@rs", tableau.Rows[i].Cells[2].Value.ToString());
            //        v.Parameters.AddWithValue("@des", tableau.Rows[i].Cells[3].Value.ToString());
            //        v.Parameters.AddWithValue("@mht", Convert.ToDouble(tableau.Rows[i].Cells[4].Value));
            //        v.Parameters.AddWithValue("@tau", Convert.ToDouble(tableau.Rows[i].Cells[5].Value));
            //        v.Parameters.AddWithValue("@mtva", Convert.ToDouble(tableau.Rows[i].Cells[6].Value));

            //        // Handle @dp parameter
            //        var dpValue = tableau.Rows[i].Cells[8].Value;
            //        if (dpValue == null || string.IsNullOrWhiteSpace(dpValue.ToString()))
            //        {
            //            v.Parameters.AddWithValue("@dp", DBNull.Value);
            //        }
            //        else
            //        {
            //            v.Parameters.AddWithValue("@dp", Convert.ToDateTime(dpValue).ToString("yyyy-MM-dd"));
            //        }

            //        v.Parameters.AddWithValue("@mp", tableau.Rows[i].Cells[9].Value.ToString());

            //        v.ExecuteNonQuery();
            //    }

            //    MessageBox.Show("ENREGISTREMENT EFFECTUER AVEC SUCCES", "FIDUPLUS FACTURATION",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Erreur: {ex.Message}", "FIDUPLUS FACTURATION",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    bd.Close();
            //}

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
            if (tupeD.SelectedIndex==0) 
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
