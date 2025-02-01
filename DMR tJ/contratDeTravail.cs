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
    public partial class contratDeTravail : Form
    {
        public contratDeTravail()
        {
            InitializeComponent();
        }

        private void vider()
        {
            villeCdd.Text = "";
            dateCdd.Text = "";
            denCdd.Text = "";
            formeCdd.Text = "";
            siegeCdd.Text = "";
            genRCdd.Text = "";
            nomRCdd.Text = "";
            qualiteRCdd.Text = "";
            genSCdd.Text = "";
            nomSCdd.Text = "";
            nationalSCdd.Text = "";
            identiteSCdd.Text = "";
            nidentiteSCdd.Text = "";
            villeSCdd.Text = "";
            adresseSCdd.Text = "";
            datedebutCdd.Text = "";
            datefinCdd.Text = "";
            dureeCdd.Text = "";
            posteCdd.Text = "";
            montantcCdd.Text = "";
            montantlCdd.Text = "";
            villeCdd.Select();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CONTRAT TRAVAIL CDD");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "CONTRAT TRAVAIL CDD Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\CONTRAT TRAVAIL CDD.docx");

            doc.Bookmarks["villeCdd"].Range.Text = villeCdd.Text.Trim();
            doc.Bookmarks["villeCddOne"].Range.Text = villeCdd.Text.Trim();
            doc.Bookmarks["dateCdd"].Range.Text = dateCdd.Text.Trim();
            doc.Bookmarks["denCdd"].Range.Text = denCdd.Text.Trim();
            doc.Bookmarks["denCddOne"].Range.Text = denCdd.Text.Trim();
            doc.Bookmarks["denCddTow"].Range.Text = denCdd.Text.Trim();
            doc.Bookmarks["formeCdd"].Range.Text = formeCdd.Text.Trim();
            doc.Bookmarks["formeCddOne"].Range.Text = formeCdd.Text.Trim();
            doc.Bookmarks["siegeCdd"].Range.Text = siegeCdd.Text.Trim();

            doc.Bookmarks["genRCdd"].Range.Text = genRCdd.Text.Trim();
            doc.Bookmarks["nomRCdd"].Range.Text = nomRCdd.Text.Trim();
            doc.Bookmarks["qualiteRCdd"].Range.Text = qualiteRCdd.Text.Trim();

            doc.Bookmarks["genSCdd"].Range.Text = genSCdd.Text.Trim();
            doc.Bookmarks["nomSCdd"].Range.Text = nomSCdd.Text.Trim();
            doc.Bookmarks["nomSCddOne"].Range.Text = nomSCdd.Text.Trim();
            doc.Bookmarks["nationalSCdd"].Range.Text = nationalSCdd.Text.Trim();
            doc.Bookmarks["identiteSCdd"].Range.Text = identiteSCdd.Text.Trim();
            doc.Bookmarks["nidentiteSCdd"].Range.Text = nidentiteSCdd.Text.Trim();
            doc.Bookmarks["villeSCdd"].Range.Text = villeSCdd.Text.Trim();
            doc.Bookmarks["adresseSCdd"].Range.Text = adresseSCdd.Text.Trim();

            doc.Bookmarks["datedebutCdd"].Range.Text = datedebutCdd.Text.Trim();
            doc.Bookmarks["datedebutCddOne"].Range.Text = datedebutCdd.Text.Trim();
            doc.Bookmarks["datefinCdd"].Range.Text = datefinCdd.Text.Trim();
            doc.Bookmarks["datefinCddOne"].Range.Text = datefinCdd.Text.Trim();
            doc.Bookmarks["dureeCdd"].Range.Text = dureeCdd.Text.Trim();
            doc.Bookmarks["posteCdd"].Range.Text = posteCdd.Text.Trim();
            doc.Bookmarks["montantcCdd"].Range.Text = montantcCdd.Text.Trim();
            doc.Bookmarks["montantlCdd"].Range.Text = montantlCdd.Text.Trim();
            


            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "CONTRAT TRAVAIL CDD " + denCdd.Text + ".pdf");
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
