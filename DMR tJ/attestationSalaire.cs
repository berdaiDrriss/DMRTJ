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
    public partial class attestationSalaire : Form
    {
        public attestationSalaire()
        {
            InitializeComponent();
        }

        private void vider()
        {
            ville.Text = "";
            date.Text = "";
            denomination.Text = "";
            forme.Text = "";
            siege.Text = "";
            ice.Text = "";
            tp.Text = "";
            iif.Text = "";
            rc.Text = "";
            cnss.Text = "";
            genre.Text = "";
            nom.Text = "";
            tIdentite.Text = "";
            nIdentite.Text = "";
            immatriculation.Text = "";
            dateDebut.Text = "";
            salaire.Text = "";
            ville.Select();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {

            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ATTESTATION DE SALAIRE");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "ATTESTATION DE SALAIRE Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\ATTESTATION DE SALAIRE.docx");

            doc.Bookmarks["ville"].Range.Text = ville.Text.Trim();
            doc.Bookmarks["date"].Range.Text = date.Text.Trim();


            doc.Bookmarks["denomination"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["denominationOne"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["forme"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["formeOne"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["siege"].Range.Text = siege.Text.Trim();

            doc.Bookmarks["ice"].Range.Text = ice.Text.Trim();
            doc.Bookmarks["tp"].Range.Text = tp.Text.Trim();
            doc.Bookmarks["iif"].Range.Text = iif.Text.Trim();
            doc.Bookmarks["rc"].Range.Text = rc.Text.Trim();
            doc.Bookmarks["cnss"].Range.Text = cnss.Text.Trim();

            doc.Bookmarks["genre"].Range.Text = genre.Text.Trim();
            doc.Bookmarks["nom"].Range.Text = nom.Text.Trim();
            doc.Bookmarks["tIdentite"].Range.Text = tIdentite.Text.Trim();
            doc.Bookmarks["nIdentite"].Range.Text = nIdentite.Text.Trim();
            doc.Bookmarks["immatriculation"].Range.Text = immatriculation.Text.Trim();
            doc.Bookmarks["dateDebut"].Range.Text = dateDebut.Text.Trim();
            doc.Bookmarks["salaire"].Range.Text = salaire.Text.Trim();

            

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "ATTESTATION DE SALAIRE " + nom.Text + ".pdf");
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

        private void attestationSalaire_Load(object sender, EventArgs e)
        {

        }
    }
}
