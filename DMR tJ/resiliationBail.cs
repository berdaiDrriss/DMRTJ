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
    public partial class resiliationBail : Form
    {
        public resiliationBail()
        {
            InitializeComponent();
        }

        private void vider()
        {
            gen.Text = "";
            nom.Text = "";
            nat.Text = "";
            typIden.Text = "";
            cin.Text = "";
            ville.Text = "";
            adresse.Text = "";
            dem.Text = "";
            forme.Text = "";
            villeRc.Text = "";
            rc.Text = "";
            genB.Text = "";
            nomR.Text = "";
            villeR.Text = "";
            dateB.Text = "";
            dateRe.Text = "";
            titreF.Text = "";
            villeL.Text = "";
            adresseR.Text = "";
            gen.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RESILIATION CONTRAT DE BAIL");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "RESILIATION CONTRAT DE BAIL Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\RESILIATION CONTRAT DE BAIL.docx");

            doc.Bookmarks["gen"].Range.Text = gen.Text.Trim();
            doc.Bookmarks["genOne"].Range.Text = gen.Text.Trim();
            doc.Bookmarks["nom"].Range.Text = nom.Text.Trim();
            doc.Bookmarks["nomOne"].Range.Text = nom.Text.Trim();
            doc.Bookmarks["nat"].Range.Text = nat.Text.Trim();
            doc.Bookmarks["typIden"].Range.Text = typIden.Text.Trim();
            doc.Bookmarks["cin"].Range.Text = cin.Text.Trim();
            doc.Bookmarks["ville"].Range.Text = ville.Text.Trim();
            doc.Bookmarks["adresse"].Range.Text = adresse.Text.Trim();

            doc.Bookmarks["dem"].Range.Text = dem.Text.Trim();
            doc.Bookmarks["demOne"].Range.Text = dem.Text.Trim();
            doc.Bookmarks["forme"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["formeOne"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["villeRc"].Range.Text = villeRc.Text.Trim();
            doc.Bookmarks["rc"].Range.Text = rc.Text.Trim();
            doc.Bookmarks["genB"].Range.Text = genB.Text.Trim();
            doc.Bookmarks["nomR"].Range.Text = nomR.Text.Trim();

            doc.Bookmarks["dateB"].Range.Text = dateB.Text.Trim();
            doc.Bookmarks["dateRe"].Range.Text = dateRe.Text.Trim();
            doc.Bookmarks["villeR"].Range.Text = villeR.Text.Trim();
            doc.Bookmarks["villeL"].Range.Text = villeL.Text.Trim();
            doc.Bookmarks["adresseR"].Range.Text = adresseR.Text.Trim();
            doc.Bookmarks["titreF"].Range.Text = titreF.Text.Trim();

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "RESILIATION CONTRAT DE BAIL " + dem.Text + ".pdf");
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
