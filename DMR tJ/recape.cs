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
using System.IO;
using System.Xml.Linq;

namespace DMR_tJ
{
    public partial class recape : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public recape()
        {
            InitializeComponent();
        }

        private float HtCalute(float amount,string type)
        {

            return amount;
        }
        private void ExportToXml(string filePath)
        {
            string identifiantFiscal = "";
            string regime = "";
            string annee = "";
            string periode = "";
            bd.Open();
            // First, get the company data from the 'societee' table.
            string societeQuery = "SELECT nIf, regimeTva FROM societee WHERE idSte = @idSte";
            using (SqlCommand cmd = new SqlCommand(societeQuery, bd))
            {
                // Replace this with your actual idSte (this should come from your selection)
                cmd.Parameters.AddWithValue("@idSte", nDem.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    identifiantFiscal = reader["nIf"].ToString().Trim() ;   // Extract identifiantFiscal from nIce
                    regime = reader["regimeTva"].ToString().Trim();         // Extract regime from regimeTva
                }
                reader.Close();
            }
            bd.Close();
            // Now, create the XML structure
            XElement rootElement = new XElement("DeclarationReleveDeduction");

            // Extract annee and periode from the 'periodeA' field of the first row in your DataGridView.
           
                string periodeA = mois.Text ?? "";

            // Split periodeA into month (or quarter) and year
            if (periodeA.Contains("/") && periodeA.Contains("trimestre"))
            {
                var parts = periodeA.Split(' ');
                periode = parts[0]; // Month or quarter
                annee = parts[3];   // Year
            }
            else if (periodeA.Contains("/") && !(periodeA.Contains("trimestre")))
            {
                var parts = periodeA.Split(' ');
                periode = parts[0]; // Month or quarter
                annee = parts[2];   // Year
            }


            MessageBox.Show(periode + " trim " + annee);
            // Append elements to the root element
            rootElement.Add(
                new XElement("identifiantFiscal", identifiantFiscal),  // Add fetched identifiantFiscal
                new XElement("annee", annee),                          // Extracted year from periodeA
                new XElement("periode", periode),                      // Extracted period (month/quarter)
                new XElement("regime", regime)                         // Add fetched regime
            );

            // Create "releveDeductions" element
            XElement releveDeductions = new XElement("releveDeductions");

            // Iterate through DataGridView rows and add them to the XML
            foreach (DataGridViewRow row in tableau.Rows)
            {
                if (!row.IsNewRow)
                {
                    //string dateDePayment = Convert.ToDateTime(row.Cells[15].Value).ToString("yyyy-MM-dd");
                    //string dateFacture = Convert.ToDateTime(row.Cells[3].Value).ToString("yyyy-MM-dd");
                    //MessageBox.Show(dateDePayment + dateFacture);
                    XElement rdElement = new XElement("rd",
                        new XElement("ord", row.Cells[1].Value?.ToString()),  // nOrder
                        new XElement("num", row.Cells[2].Value?.ToString()),  // nfA
                        new XElement("des", row.Cells[7].Value?.ToString()),  // DESIG
                        new XElement("mht", row.Cells[8].Value?.ToString()),  // mhtA
                        new XElement("tva", row.Cells[10].Value?.ToString()),  // mtvaA
                        new XElement("ttc", row.Cells[13].Value?.ToString()),  // mttcA
                        new XElement("refF",
                            new XElement("if", row.Cells[5].Value?.ToString()),  // ifFouA
                            new XElement("nom", row.Cells[4].Value?.ToString()), // raisonSocial
                            new XElement("ice", row.Cells[6].Value?.ToString())  // iceFouA
                        ),
                        new XElement("tx", row.Cells[9].Value?.ToString()),    // ttvaA
                        new XElement("mp", new XElement("id", row.Cells[16].Value?.ToString())),  // modePayment
                        new XElement("dpai", Convert.ToDateTime(row.Cells[15].Value).ToString("yyyy-MM-dd")), //  ddpA
                        new XElement("dfac", Convert.ToDateTime(row.Cells[3].Value).ToString("yyyy-MM-dd"))  // ddfA
                    );
                    
                    // Add the rdElement to releveDeductions
                    releveDeductions.Add(rdElement);
                }
            }

            // Add releveDeductions to the root element
            rootElement.Add(releveDeductions);

            // Save the XML to the file
            XDocument xmlDocument = new XDocument(rootElement);
            xmlDocument.Save(filePath);

            MessageBox.Show("XML file exported successfully!");
        }




        // Method to export DataGridView data to EDI
        private void ExportToEdi(string filePath)
        {
            // EDI file structure segments
            List<EdiSegment> ediSegments = new List<EdiSegment>
            {
                new EdiSegment("ISA", "00", "          ", "00", "          ", "ZZ", "SENDER", "ZZ", "RECEIVER", DateTime.Now.ToString("yyMMdd"), DateTime.Now.ToString("HHmm"), "U", "00401", "000000001", "0", "P", ">"),
                new EdiSegment("GS", "IN", "SENDER", "RECEIVER", DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("HHmm"), "1", "X", "004010"),
                new EdiSegment("ST", "850", "0001")
            };

            // Iterate through DataGridView and map rows to EDI segments
            foreach (DataGridViewRow row in tableau.Rows)
            {
                if (!row.IsNewRow)
                {
                    string typeA = row.Cells[0].Value?.ToString() ?? "";
                    string nOrder = row.Cells[1].Value?.ToString() ?? "";
                    string nfA = row.Cells[2].Value?.ToString() ?? "";
                    string dfA = row.Cells[3].Value?.ToString() ?? "";  // Date Facture
                    string rscfA = row.Cells[4].Value?.ToString() ?? ""; // Raison Sociale
                    string nIF = row.Cells[5].Value?.ToString() ?? "";   // N IF
                    string iceFouA = row.Cells[6].Value?.ToString() ?? ""; // N ICE
                    string designation = row.Cells[7].Value?.ToString() ?? ""; // Designation
                    string mhtA = row.Cells[8].Value?.ToString() ?? "";  // Montant HT
                    string taux = row.Cells[9].Value?.ToString() ?? "";  // Taux
                    string mtvaA = row.Cells[10].Value?.ToString() ?? ""; // Montant TVA
                    string prorata = row.Cells[11].Value?.ToString() ?? ""; // Prorata
                    string maProrata = row.Cells[12].Value?.ToString() ?? "";  // Montant Après Prorata
                    string amande = row.Cells[13].Value?.ToString() ?? "";  // Montant Amande de 15
                    string mttcA = row.Cells[14].Value?.ToString() ?? "";  // Montant TTC
                    string dppA = row.Cells[15].Value?.ToString() ?? "";   // Date Payment
                    string mdpA = row.Cells[16].Value?.ToString() ?? "";   // Mode Payment

                    // Create EDI segment for this row
                    ediSegments.Add(new EdiSegment("PO1", "1", nOrder, nfA, "EA", mhtA, taux, mtvaA, prorata, amande, maProrata));
                }
            }
            // Closing EDI segments
            ediSegments.Add(new EdiSegment("SE", ediSegments.Count.ToString(), "0001"));
            ediSegments.Add(new EdiSegment("GE", "1", "1"));
            ediSegments.Add(new EdiSegment("IEA", "1", "000000001"));

            // Write EDI segments to file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var segment in ediSegments)
                {
                    writer.WriteLine(segment.ToString());
                }
            }

            MessageBox.Show("EDI file exported successfully!");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {





        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void recape_Load(object sender, EventArgs e)
        {
            //bd.Open();
            //SqlCommand cmd = new SqlCommand("select distinct periodeA from deduction ", bd);
            //SqlDataReader rd = cmd.ExecuteReader();
            //while (rd.Read())
            //{
            //    mois.Items.Add(rd[0]);
            //}
            //bd.Close();
        }
        private void filtre()
        {
            bd.Open();
            SqlCommand cd = new SqlCommand("select typeA,nOrder,nfA,dfA,rscfA,ifFouA,iceFouA,ddfA,mhtA,ttvaA,mtvaA,prorata,maProrata,amande,mttcA,ddpA,mdpA from deduction where idSte like @denomination and periodeA like @periodeA order by nOrder", bd);
            cd.Parameters.AddWithValue("@denomination", nDem.Text);
            cd.Parameters.AddWithValue("@periodeA",mois.Text);
            SqlDataReader rd = cd.ExecuteReader();
            tableau.Rows.Clear();
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
                    rd[8],
                    rd[9],
                    rd[10],
                    rd[11],
                    rd[12],
                    rd[13],
                    rd[14],
                    rd[15],
                    rd[16]
                    );
            }
            rd.Close();
            SqlCommand cd2 = new SqlCommand("select * from encaissements where idSte like @denominationE and periodeV like @periodeV", bd);
            cd2.Parameters.AddWithValue("@denominationE", nDem.Text);
            cd2.Parameters.AddWithValue("@periodeV", mois.Text);
            SqlDataReader rd2 = cd2.ExecuteReader();
            tableauEn.Rows.Clear();
            while (rd2.Read())
            {
                tableauEn.Rows.Add(
                    rd2[2],
                    rd2[3],
                    rd2[13],
                    rd2[11],
                    rd2[4],
                    rd2[7],
                    rd2[6],
                    rd2[5],
                    rd2[12],
                    rd2[8]
                    
                    );
            }
            bd.Close();
        }
        private void tupeD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tupeD.SelectedIndex == 0)
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("select distinct periodeA from deduction WHERE periodeA NOT LIKE '%trimestre%' ", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                mois.Items.Clear();
                while (rd.Read())
                {
                    mois.Items.Add(rd[0]);
                }
                bd.Close();
            }
            else
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("select distinct periodeA from deduction WHERE periodeA LIKE '%trimestre%' ", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                mois.Items.Clear();
                while (rd.Read())
                {
                    mois.Items.Add(rd[0]);
                }
                bd.Close();

            }
            
        }

        private void Choisir_Click(object sender, EventArgs e)
        {
            listeSocietee ls = new listeSocietee();
            ls.ShowDialog();
            int i = ls.tableau.CurrentRow.Index;
            nDem.Text = ls.tableau.Rows[i].Cells[0].Value.ToString();
            dem.Text = ls.tableau.Rows[i].Cells[1].Value.ToString();
        }

        private void mois_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtre();
        }

        private void groupBox18_Enter(object sender, EventArgs e)
        {

        }

        private void nDem_TextChanged(object sender, EventArgs e)
        {
            filtre();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Choose file location
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "EDI Files|*.edi",
                Title = "Save EDI File"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToEdi(saveFileDialog.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Choose file location
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML Files|*.xml",
                Title = "Save XML File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToXml(saveFileDialog.FileName);
            }
        }

        
    }
}
