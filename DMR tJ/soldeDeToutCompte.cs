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
    public partial class soldeDeToutCompte : Form
    {
        public soldeDeToutCompte()
        {
            InitializeComponent();
        }

        private void vider()
        {
            villeAttestaion.Text = "";
            dateAttestaion.Text = "";
            denAttestaion.Text = "";
            forAttestaion.Text = "";
            sigAttestaion.Text = "";
            siegAttestaion.Text = "";
            iceAttestaion.Text = "";
            tpAttestaion.Text = "";
            ifAttestaion.Text = "";
            rcAttestaion.Text = "";
            cnssAttestaion.Text = "";
            genAttestaion.Text = "";
            nomAttestaion.Text = "";
            cinAttestaion.Text = "";
            immatriculationAttestaion.Text = "";
            nombrejtAttestation.Text = "";
            nombrejcAttestation.Text = "";
            salairejcAttestation.Text = "";
            salairejtAttestation.Text = "";
            montantcAttestaion.Text = "";
            montantlAttestaion.Text = "";
            totalAttestation.Text = "";
            villeAttestaion.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {

            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SOLDE DE TOUT COMPTE");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "SOLDE DE TOUT COMPTE Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\SOLDE DE TOUS COMPTE.docx");

            //doc.Bookmarks["villeAttestation"].Range.Text = villeAttestaion.Text.Trim();



            doc.Bookmarks["villeAttestation"].Range.Text = villeAttestaion.Text.Trim();
            doc.Bookmarks["dateAttestation"].Range.Text = dateAttestaion.Text.Trim();
            doc.Bookmarks["denAttestation"].Range.Text = denAttestaion.Text.Trim();
            doc.Bookmarks["forAttestation"].Range.Text = forAttestaion.Text.Trim();
            doc.Bookmarks["sigAttestation"].Range.Text = sigAttestaion.Text.Trim();
            doc.Bookmarks["siegAttestationOne"].Range.Text = siegAttestaion.Text.Trim();

            doc.Bookmarks["iceAttestationOne"].Range.Text = iceAttestaion.Text.Trim();
            doc.Bookmarks["ifAttestationOne"].Range.Text = ifAttestaion.Text.Trim();
            doc.Bookmarks["tpAttestationOne"].Range.Text = tpAttestaion.Text.Trim();
            doc.Bookmarks["rcAttestationOne"].Range.Text = rcAttestaion.Text.Trim();
            doc.Bookmarks["cnssAttestationOne"].Range.Text = cnssAttestaion.Text.Trim();

            doc.Bookmarks["genAttestationOne"].Range.Text = genAttestaion.Text.Trim();
            doc.Bookmarks["nomAttestationOne"].Range.Text = nomAttestaion.Text.Trim();
            doc.Bookmarks["tpidentite"].Range.Text = tpidentite.Text.Trim();
            doc.Bookmarks["cinAttestationOne"].Range.Text = cinAttestaion.Text.Trim();
            doc.Bookmarks["immatriculationAttestation"].Range.Text = immatriculationAttestaion.Text.Trim();

            doc.Bookmarks["nombrejtAttestation"].Range.Text = nombrejtAttestation.Text.Trim();
            doc.Bookmarks["nombrejcAttestation"].Range.Text = nombrejcAttestation.Text.Trim();
            doc.Bookmarks["salairejcAttestation"].Range.Text = salairejcAttestation.Text.Trim();
            doc.Bookmarks["salairejtAttestation"].Range.Text = salairejtAttestation.Text.Trim();
            doc.Bookmarks["montantcAttestation"].Range.Text = montantcAttestaion.Text.Trim();
            doc.Bookmarks["montantlAttestation"].Range.Text = montantlAttestaion.Text.Trim();
            doc.Bookmarks["totalAttestation"].Range.Text = totalAttestation.Text.Trim();



            //doc.Bookmarks["iceAttestationTow"].Range.Text = iceAttestaion.Text.Trim();
            //doc.Bookmarks["ifAttestationTow"].Range.Text = ifAttestaion.Text.Trim();
            //doc.Bookmarks["tpAttestationTow"].Range.Text = tpAttestaion.Text.Trim();
            //doc.Bookmarks["rcAttestationTow"].Range.Text = rcAttestaion.Text.Trim();
            //doc.Bookmarks["cnssAttestationTow"].Range.Text = cnssAttestaion.Text.Trim();
            //doc.Bookmarks["denAttestationTow"].Range.Text = denAttestaion.Text.Trim();
            //doc.Bookmarks["forAttestationOne"].Range.Text = forAttestaion.Text.Trim();
            //doc.Bookmarks["forAttestationTow"].Range.Text = forAttestaion.Text.Trim();
            //doc.Bookmarks["sigAttestation"].Range.Text = sigAttestaion.Text.Trim();
            //doc.Bookmarks["siegAttestationOne"].Range.Text = siegAttestaion.Text.Trim();
            //doc.Bookmarks["siegAttestationTow"].Range.Text = siegAttestaion.Text.Trim();
            //doc.Bookmarks["nomAttestationTow"].Range.Text = nomAttestaion.Text.Trim();
            //doc.Bookmarks["cinAttestationOne"].Range.Text = cinAttestaion.Text.Trim();
            //doc.Bookmarks["cinAttestationTow"].Range.Text = cinAttestaion.Text.Trim();


 

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "SOLDE DE TOUT COMPTE " + denAttestaion.Text + ".pdf");
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dateAttestaion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void denAttestaion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
