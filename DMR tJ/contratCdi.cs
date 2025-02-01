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
    public partial class contratCdi : Form
    {
        public contratCdi()
        {
            InitializeComponent();
        }

        private void vider()
        {
            ville.Text = "";
            date.Text = "";
            denomination.Text = "";
            forme.Text = "";
            villeSiege.Text = "";
            siege.Text = "";
            capital.Text = "";
            genreGerant.Text = "";
            nomGerant.Text = "";
            qualiteGerant.Text = "";
            genreSalarier.Text = "";
            nomSalarier.Text = "";
            nationaliteSalarier.Text = "";
            typeIdentite.Text = "";
            identite.Text = "";
            villeSalarier.Text = "";
            adresseSalarier.Text = "";
            dateDebutContrat.Text = "";
            villeLieuTravail.Text = "";
            lieuTravail.Text = "";
            posteOccupe.Text = "";
            montantC.Text = "";
            montantL.Text = "";
            preavi.Text = "";
            periodeEssaie.Text = "";
            ville.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CONTRAT CDI");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "CONTRAT CDI Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\CONTRAT CDI.docx");

            doc.Bookmarks["ville"].Range.Text = ville.Text.Trim();
            doc.Bookmarks["villeSiege"].Range.Text = villeSiege.Text.Trim();
            doc.Bookmarks["date"].Range.Text = date.Text.Trim();

            doc.Bookmarks["denomination"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["denominationOne"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["forme"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["formeOne"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["capital"].Range.Text = capital.Text.Trim();
            doc.Bookmarks["siege"].Range.Text = siege.Text.Trim();
            doc.Bookmarks["genreGerant"].Range.Text = genreGerant.Text.Trim();
            doc.Bookmarks["genreGerantOne"].Range.Text = genreGerant.Text.Trim();
            doc.Bookmarks["nomGerant"].Range.Text = nomGerant.Text.Trim();
            doc.Bookmarks["nomGerantOne"].Range.Text = nomGerant.Text.Trim();
            doc.Bookmarks["qualiteGerant"].Range.Text = qualiteGerant.Text.Trim();

            doc.Bookmarks["genreSalarier"].Range.Text = genreSalarier.Text.Trim();
            doc.Bookmarks["genreSalarierOne"].Range.Text = genreSalarier.Text.Trim();
            doc.Bookmarks["nomSalarier"].Range.Text = nomSalarier.Text.Trim();
            doc.Bookmarks["nomSalarierOne"].Range.Text = nomSalarier.Text.Trim();
            doc.Bookmarks["nationaliteSalarier"].Range.Text = nationaliteSalarier.Text.Trim();
            doc.Bookmarks["typeIdentite"].Range.Text = typeIdentite.Text.Trim();
            doc.Bookmarks["identite"].Range.Text = identite.Text.Trim();
            doc.Bookmarks["villeSalarier"].Range.Text = villeSalarier.Text.Trim();
            doc.Bookmarks["adresseSalarier"].Range.Text = adresseSalarier.Text.Trim();

            doc.Bookmarks["dateDebutContrat"].Range.Text = dateDebutContrat.Text.Trim();
            doc.Bookmarks["preavi"].Range.Text = preavi.Text.Trim();
            doc.Bookmarks["periodeEssaie"].Range.Text = periodeEssaie.Text.Trim();
            doc.Bookmarks["posteOccupe"].Range.Text = posteOccupe.Text.Trim();
            doc.Bookmarks["villeLieuTravail"].Range.Text = villeLieuTravail.Text.Trim();
            doc.Bookmarks["lieuTravail"].Range.Text = lieuTravail.Text.Trim();
            doc.Bookmarks["montantC"].Range.Text = montantC.Text.Trim();
            doc.Bookmarks["montantL"].Range.Text = montantL.Text.Trim();


            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "CONTRAT CDI" + denomination.Text + ".pdf");
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
    }
}
