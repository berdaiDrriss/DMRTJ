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
    public partial class procuration : Form
    {
        public procuration()
        {
            InitializeComponent();
        }

        private void vider()
        {
            genM.Text = "";
            nomM.Text = "";
            natIonaliteM.Text = "";
            typIdenM.Text = "";
            cinM.Text = "";
            villeNaissanceM.Text = "";
            dateM.Text = "";
            villeM.Text = "";
            adresseM.Text = "";
            genMT.Text = "";
            nomMT.Text = "";
            natIonaliteMT.Text = "";
            typIdenMT.Text = "";
            cinMT.Text = "";
            villeNaissanceMT.Text = "";
            dateMT.Text = "";
            villeMT.Text = "";
            adresseMT.Text = "";
            ville.Text = "";
            date.Text = "";
            denomination.Text = "";
            forme.Text = "";
            relatif.Text = "";
            designation.Text = "";
            genM.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PROCURATION  CONSTITUTION");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "PROCURATION  CONSTITUTION Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\PROCURATION  CONSTITUTION.docx");

            doc.Bookmarks["genM"].Range.Text = genM.Text.Trim();
            doc.Bookmarks["genMOne"].Range.Text = genM.Text.Trim();
            doc.Bookmarks["nomM"].Range.Text = nomM.Text.Trim();
            doc.Bookmarks["nomMOne"].Range.Text = nomM.Text.Trim();
            doc.Bookmarks["natIonaliteM"].Range.Text = natIonaliteM.Text.Trim();
            doc.Bookmarks["typIdenM"].Range.Text = typIdenM.Text.Trim();
            doc.Bookmarks["cinM"].Range.Text = cinM.Text.Trim();
            doc.Bookmarks["dateM"].Range.Text = dateM.Text.Trim();
            doc.Bookmarks["villeNaissanceM"].Range.Text = villeNaissanceM.Text.Trim();
            doc.Bookmarks["villeM"].Range.Text = villeM.Text.Trim();
            doc.Bookmarks["adresseM"].Range.Text = adresseM.Text.Trim();

            doc.Bookmarks["genMT"].Range.Text = genMT.Text.Trim();
            doc.Bookmarks["nomMT"].Range.Text = nomMT.Text.Trim();
            doc.Bookmarks["natIonaliteMT"].Range.Text = natIonaliteMT.Text.Trim();
            doc.Bookmarks["typIdenMT"].Range.Text = typIdenMT.Text.Trim();
            doc.Bookmarks["cinMT"].Range.Text = cinMT.Text.Trim();
            doc.Bookmarks["dateMT"].Range.Text = dateMT.Text.Trim();
            doc.Bookmarks["villeNaissanceMT"].Range.Text = villeNaissanceMT.Text.Trim();
            doc.Bookmarks["villeMT"].Range.Text = villeMT.Text.Trim();
            doc.Bookmarks["adresseMT"].Range.Text = adresseMT.Text.Trim();

            doc.Bookmarks["ville"].Range.Text = ville.Text.Trim();
            doc.Bookmarks["date"].Range.Text = date.Text.Trim();
            doc.Bookmarks["denomination"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["forme"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["relatif"].Range.Text = relatif.Text.Trim();
            doc.Bookmarks["designation"].Range.Text = designation.Text.Trim();


            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "PROCURATION  CONSTITUTION " + denomination.Text + ".pdf");
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

        private void procuration_Load(object sender, EventArgs e)
        {

        }
    }
}
