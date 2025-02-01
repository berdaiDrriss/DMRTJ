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
    public partial class attestationDeTavail : Form
    {
        public attestationDeTavail()
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
            dateSalarierAttestaion.Text = "";
            periodeAttestaion.Text = "";
            posteAttestaion.Text = "";
            villeAttestaion.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ATTESTATION DE TRAVAIL");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "ATTESTATION DE TRAVAIL Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\ATTESTATION DE TRAVAIL.docx");

            doc.Bookmarks["villeAtesstationTravail"].Range.Text = villeAttestaion.Text.Trim();
            doc.Bookmarks["villeAtesstationTravailOne"].Range.Text = villeAttestaion.Text.Trim();
            doc.Bookmarks["dateAtesstationTravail"].Range.Text = dateAttestaion.Text.Trim();
            doc.Bookmarks["dateNaissanceAtesstationTravail"].Range.Text = dateSalarierAttestaion.Text.Trim();
            doc.Bookmarks["steAtesstationTravail"].Range.Text = denAttestaion.Text.Trim();
            doc.Bookmarks["steAtesstationTravailOne"].Range.Text = denAttestaion.Text.Trim();
            doc.Bookmarks["forAtesstationTravail"].Range.Text = forAttestaion.Text.Trim();
            doc.Bookmarks["forAtesstationTravailOne"].Range.Text = forAttestaion.Text.Trim();
            doc.Bookmarks["signatureAtesstationTravail"].Range.Text = sigAttestaion.Text.Trim();
            doc.Bookmarks["siegeAtesstationTravailOne"].Range.Text = siegAttestaion.Text.Trim();
            doc.Bookmarks["siegeAtesstationTravailTow"].Range.Text = siegAttestaion.Text.Trim();
            doc.Bookmarks["iceAtesstationTravailOne"].Range.Text = iceAttestaion.Text.Trim();
            doc.Bookmarks["iceAtesstationTravailTow"].Range.Text = iceAttestaion.Text.Trim();
            doc.Bookmarks["ifAtesstationTravailOne"].Range.Text = ifAttestaion.Text.Trim();
            doc.Bookmarks["ifAtesstationTravailTow"].Range.Text = ifAttestaion.Text.Trim();
            doc.Bookmarks["tpAtesstationTravailOne"].Range.Text = tpAttestaion.Text.Trim();
            doc.Bookmarks["tpAtesstationTravailTow"].Range.Text = tpAttestaion.Text.Trim();
            doc.Bookmarks["rcAtesstationTravailOne"].Range.Text = rcAttestaion.Text.Trim();
            doc.Bookmarks["rcAtesstationTravailTow"].Range.Text = rcAttestaion.Text.Trim();
            doc.Bookmarks["cnssAtesstationTravailOne"].Range.Text = cnssAttestaion.Text.Trim();
            doc.Bookmarks["cnssAtesstationTravailTow"].Range.Text = cnssAttestaion.Text.Trim();
            doc.Bookmarks["genreAtesstationTravail"].Range.Text = genAttestaion.Text.Trim();
            doc.Bookmarks["nomAtesstationTravail"].Range.Text = nomAttestaion.Text.Trim();

           // doc.Bookmarks["dateNaissanceAtesstationTravail"].Range.Text = dateSalarierAttestaion.Text.Trim();

            doc.Bookmarks["cinNaissanceAtesstationTravail"].Range.Text = cinAttestaion.Text.Trim();
            doc.Bookmarks["immatriNaissanceAtesstationTravail"].Range.Text = immatriculationAttestaion.Text.Trim();
            doc.Bookmarks["posteAtesstationTravail"].Range.Text = posteAttestaion.Text.Trim();
            doc.Bookmarks["periodeAtesstationTravail"].Range.Text = periodeAttestaion.Text.Trim();

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "ATTESTATION DE TRAVAIL " + denAttestaion.Text + ".pdf");
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

        private void attestationDeTavail_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
