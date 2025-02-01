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
    public partial class DmandeInscriptionTpConstitution : Form
    {
        public DmandeInscriptionTpConstitution()
        {
            InitializeComponent();
        }

        private void vider()
        {
            villeDTP.Text = "";
            dateTP.Text = "";
            iceTP.Text = "";
            cnTP.Text = "";
            denTP.Text = "";
            forTP.Text = "";
            actiTP.Text = "";
            capTP.Text = "";
            siegTP.Text = "";
            villeDTP.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DEMANDE D'INSCRIPTION TP");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "DEMANDE D'INSCRIPTION TP Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\DEMANDE D'INSCRIPTION TP.docx");

            doc.Bookmarks["steTpOne"].Range.Text = denTP.Text.Trim();
            doc.Bookmarks["steTpTow"].Range.Text = denTP.Text.Trim();
            doc.Bookmarks["forTpOne"].Range.Text = forTP.Text.Trim();
            doc.Bookmarks["forTpTow"].Range.Text = forTP.Text.Trim();
            doc.Bookmarks["VilTpOne"].Range.Text = villeDTP.Text.Trim();
            doc.Bookmarks["VilTpTow"].Range.Text = villeDTP.Text.Trim();
            doc.Bookmarks["VilTpTree"].Range.Text = villeDTP.Text.Trim();
            doc.Bookmarks["VilTpQuatre"].Range.Text = villeDTP.Text.Trim();
            doc.Bookmarks["dateTpOne"].Range.Text = dateTP.Text.Trim();
            doc.Bookmarks["iceTpOne"].Range.Text = iceTP.Text.Trim();
            doc.Bookmarks["cnTpOne"].Range.Text = cnTP.Text.Trim();
            doc.Bookmarks["actiTpOne"].Range.Text = actiTP.Text.Trim();
            doc.Bookmarks["CapTpOne"].Range.Text = capTP.Text.Trim();
            doc.Bookmarks["siegTpOne"].Range.Text = siegTP.Text.Trim();
            doc.Bookmarks["siegTpTow"].Range.Text = siegTP.Text.Trim();



            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "DEMANDE D'INSCRIPTION TP " + denTP.Text + ".pdf");
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

        private void DmandeInscriptionTpConstitution_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
