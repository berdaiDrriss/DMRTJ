using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Runtime.InteropServices;

namespace DMR_tJ
{
    public partial class attestationContratDomiciliation : Form
    {
        public attestationContratDomiciliation()
        {
            InitializeComponent();
        }

        private void vider()
        {
            villeCa.Text = "";
            dateCa.Text = "";
            denominationCa.Text = "";
            formeCa.Text = "";
            siegeCa.Text = "";
            genCaD.Text = "";
            nomCaD.Text = "";
            identiteCaD.Text = "";
            nidentiteCaD.Text = "";
            villeNCaD.Text = "";
            dateNCaD.Text = "";
            adresseCaD.Text = "";
            iceCaD.Text = "";
            tpCaD.Text = "";
            ifCaD.Text = "";
            rcCaD.Text = "";
            cnssCaD.Text = "";
            iceGCa.Text = "";
            denGCa.Text = "";
            formeGCa.Text = "";
            dateDebutCa.Text = "";
            dateFinGCa.Text = "";
            dureeGCa.Text = "";
            montantGCa.Text = "";
            genGCa.Text = "";
            nomGCa.Text = "";
            qualiteGCa.Text = "";
            identiteGCa.Text = "";
            nidentiteGCa.Text = "";
            villeNGCa.Text = "";
            dateNGCa.Text = "";
            adresseNGCa.Text = "";
            villeCa.Select();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void attestationContratDomiciliation_Load(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ATTESTATION ET CONTRAT DE DOMICILIATION");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "ATTESTATION ET CONTRAT DE DOMICILIATION Backup");


            // Create the directories if they don't exist
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }
            if (!Directory.Exists(backupDirectory))
            {
                Directory.CreateDirectory(backupDirectory);
            }

            Word.Application app = new Word.Application();
            Word.Documents docs = app.Documents;
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\ATTESTATION ET CONTRAT DE DOMICILIATION.docx");

            doc.Bookmarks["villeCa"].Range.Text = villeCa.Text.Trim();
            doc.Bookmarks["villeCaOne"].Range.Text = villeCa.Text.Trim();
            doc.Bookmarks["villeCaTow"].Range.Text = villeCa.Text.Trim();
            doc.Bookmarks["villeCaTree"].Range.Text = villeCa.Text.Trim();
            doc.Bookmarks["villeCaquatre"].Range.Text = villeCa.Text.Trim();
            doc.Bookmarks["villeCinq"].Range.Text = villeCa.Text.Trim();

            doc.Bookmarks["dateCa"].Range.Text = dateCa.Text.Trim();
            doc.Bookmarks["dateCinq"].Range.Text = dateCa.Text.Trim();

            doc.Bookmarks["denominationCa"].Range.Text = denominationCa.Text.Trim();
            doc.Bookmarks["denominationCaOne"].Range.Text = denominationCa.Text.Trim();
            doc.Bookmarks["denominationCaTow"].Range.Text = denominationCa.Text.Trim();
            doc.Bookmarks["denominationCaTree"].Range.Text = denominationCa.Text.Trim();
            doc.Bookmarks["denominationCaQuatre"].Range.Text = denominationCa.Text.Trim();

            doc.Bookmarks["formeCa"].Range.Text = formeCa.Text.Trim();
            doc.Bookmarks["formeCaOne"].Range.Text = formeCa.Text.Trim();
            doc.Bookmarks["formeCaTow"].Range.Text = formeCa.Text.Trim();
            doc.Bookmarks["formeCaTree"].Range.Text = formeCa.Text.Trim();
            doc.Bookmarks["formeCaQuatre"].Range.Text = formeCa.Text.Trim();

            doc.Bookmarks["siegeCa"].Range.Text = siegeCa.Text.Trim();
            doc.Bookmarks["siegeCaOne"].Range.Text = siegeCa.Text.Trim();
            doc.Bookmarks["siegeCaTow"].Range.Text = siegeCa.Text.Trim();
            doc.Bookmarks["siegeCaTree"].Range.Text = siegeCa.Text.Trim();

            doc.Bookmarks["genCaD"].Range.Text = genCaD.Text.Trim();
            doc.Bookmarks["genCaDOne"].Range.Text = genCaD.Text.Trim();

            doc.Bookmarks["nomCaD"].Range.Text = nomCaD.Text.Trim();
            doc.Bookmarks["nomCaDOne"].Range.Text = nomCaD.Text.Trim();

            doc.Bookmarks["identiteCaD"].Range.Text = identiteCaD.Text.Trim();

            doc.Bookmarks["nidentiteCaD"].Range.Text = nidentiteCaD.Text.Trim();

            doc.Bookmarks["villeNCaD"].Range.Text = villeNCaD.Text.Trim();

            doc.Bookmarks["dateNCaD"].Range.Text = dateNCaD.Text.Trim();

            doc.Bookmarks["adresseCaD"].Range.Text = adresseCaD.Text.Trim();

            doc.Bookmarks["iceCaD"].Range.Text = iceCaD.Text.Trim();
            doc.Bookmarks["iceCaDOne"].Range.Text = iceCaD.Text.Trim();
            doc.Bookmarks["iceCaDTow"].Range.Text = iceCaD.Text.Trim();

            doc.Bookmarks["tpCaD"].Range.Text = tpCaD.Text.Trim();
            doc.Bookmarks["tpCaDOne"].Range.Text = tpCaD.Text.Trim();
            doc.Bookmarks["tpCaDTow"].Range.Text = tpCaD.Text.Trim();

            doc.Bookmarks["ifCaD"].Range.Text = ifCaD.Text.Trim();
            doc.Bookmarks["ifCaDOne"].Range.Text = ifCaD.Text.Trim();
            doc.Bookmarks["ifCaDTow"].Range.Text = ifCaD.Text.Trim();

            doc.Bookmarks["rcCaD"].Range.Text = rcCaD.Text.Trim();
            doc.Bookmarks["rcCaDOne"].Range.Text = rcCaD.Text.Trim();
            doc.Bookmarks["rcCaDTow"].Range.Text = rcCaD.Text.Trim();

            doc.Bookmarks["cnssCaD"].Range.Text = cnssCaD.Text.Trim();
            doc.Bookmarks["cnssCaDOne"].Range.Text = cnssCaD.Text.Trim();
            doc.Bookmarks["cnssCaDTow"].Range.Text = cnssCaD.Text.Trim();

            doc.Bookmarks["iceGCa"].Range.Text = iceGCa.Text.Trim();
            doc.Bookmarks["iceGCaOne"].Range.Text = iceGCa.Text.Trim();
            doc.Bookmarks["iceGCaTow"].Range.Text = iceGCa.Text.Trim();
           // doc.Bookmarks["iceGCaTree"].Range.Text = iceGCa.Text.Trim();
           // doc.Bookmarks["iceGCaQuatre"].Range.Text = iceGCa.Text.Trim();

            doc.Bookmarks["denGCa"].Range.Text = denGCa.Text.Trim();
            doc.Bookmarks["denGCaOne"].Range.Text = denGCa.Text.Trim();
            doc.Bookmarks["denGCaTow"].Range.Text = denGCa.Text.Trim();
            doc.Bookmarks["denGCaTree"].Range.Text = denGCa.Text.Trim();
            doc.Bookmarks["denGCaQuatre"].Range.Text = denGCa.Text.Trim();

            doc.Bookmarks["formeGCa"].Range.Text = formeGCa.Text.Trim();
            doc.Bookmarks["formeGCaOne"].Range.Text = formeGCa.Text.Trim();
            doc.Bookmarks["formeGCaTow"].Range.Text = formeGCa.Text.Trim();
            doc.Bookmarks["formeGCaTree"].Range.Text = formeGCa.Text.Trim();
            doc.Bookmarks["formeGCaQuatre"].Range.Text = formeGCa.Text.Trim();

            doc.Bookmarks["dateDebutCa"].Range.Text = dateDebutCa.Text.Trim();

            doc.Bookmarks["dateFinGCa"].Range.Text = dateFinGCa.Text.Trim();

            doc.Bookmarks["dureeGCa"].Range.Text = dureeGCa.Text.Trim();

            doc.Bookmarks["montantGCa"].Range.Text = montantGCa.Text.Trim();

            doc.Bookmarks["genGCa"].Range.Text = genGCa.Text.Trim();
            doc.Bookmarks["genGCaOne"].Range.Text = genGCa.Text.Trim();


            doc.Bookmarks["nomGCa"].Range.Text = nomGCa.Text.Trim();
            doc.Bookmarks["nomGCaOne"].Range.Text = nomGCa.Text.Trim();


            doc.Bookmarks["qualiteGCa"].Range.Text = qualiteGCa.Text.Trim();

            doc.Bookmarks["identiteGCa"].Range.Text = identiteGCa.Text.Trim();
            doc.Bookmarks["identiteGCaOne"].Range.Text = identiteGCa.Text.Trim();

            doc.Bookmarks["nidentiteGCa"].Range.Text = nidentiteGCa.Text.Trim();
            doc.Bookmarks["nidentiteGCaOne"].Range.Text = nidentiteGCa.Text.Trim();

            doc.Bookmarks["villeNGCa"].Range.Text = villeNGCa.Text.Trim();

            doc.Bookmarks["dateNGCa"].Range.Text = dateNGCa.Text.Trim();

            doc.Bookmarks["adresseNGCa"].Range.Text = adresseNGCa.Text.Trim();




            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "ATTESTATION ET CONTRAT DE DOMICILIATION" + denGCa.Text + ".pdf");
            doc.ExportAsFixedFormat(pdfOutputPath, Word.WdExportFormat.wdExportFormatPDF);

            // Open the saved PDF document
            System.Diagnostics.Process.Start(pdfOutputPath);

            // Close the Word document without saving changes
            doc.Close(false);
            Marshal.ReleaseComObject(doc);

            // Quit Word Application
            app.Quit();
            Marshal.ReleaseComObject(app);
            vider();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
