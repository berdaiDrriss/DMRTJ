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
    public partial class miseAdisposition : Form
    {
        public miseAdisposition()
        {
            InitializeComponent();
        }

        private void vider()
        {
            ville.Text = "";
            date.Text = "";
            banque.Text = "";
            agence.Text = "";
            denomination.Text = "";
            forme.Text = "";
            siege.Text = "";
            compte.Text = "";
            montantC.Text = "";
            montantL.Text = "";
            ice.Text = "";
            tp.Text = "";
            iif.Text = "";
            rc.Text = "";
            cnss.Text = "";
            genre.Text = "";
            nom.Text = "";
            type.Text = "";
            identite.Text = "";
            ville.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MISE A DISPOSITION");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "MISE A DISPOSITION Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\MISE A DISPOSITION.docx");

            doc.Bookmarks["ville"].Range.Text = ville.Text.Trim();
            doc.Bookmarks["villeOne"].Range.Text = ville.Text.Trim();
            doc.Bookmarks["date"].Range.Text = date.Text.Trim();
            doc.Bookmarks["banque"].Range.Text = banque.Text.Trim();
            doc.Bookmarks["agence"].Range.Text = agence.Text.Trim();

            doc.Bookmarks["denomination"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["denominationOne"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["forme"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["formeOne"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["siege"].Range.Text = siege.Text.Trim();
            doc.Bookmarks["compte"].Range.Text = compte.Text.Trim();
            doc.Bookmarks["compteOne"].Range.Text = compte.Text.Trim();
            doc.Bookmarks["montantC"].Range.Text = montantC.Text.Trim();
            doc.Bookmarks["montantL"].Range.Text = montantL.Text.Trim();

            doc.Bookmarks["genre"].Range.Text = genre.Text.Trim();
            doc.Bookmarks["nom"].Range.Text = nom.Text.Trim();
            doc.Bookmarks["type"].Range.Text = type.Text.Trim();
            doc.Bookmarks["identite"].Range.Text = identite.Text.Trim();

            doc.Bookmarks["ice"].Range.Text = ice.Text.Trim();
            doc.Bookmarks["tp"].Range.Text = tp.Text.Trim();
            doc.Bookmarks["iif"].Range.Text = iif.Text.Trim();
            doc.Bookmarks["rc"].Range.Text = rc.Text.Trim();
            doc.Bookmarks["cnss"].Range.Text = cnss.Text.Trim();

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "MISE A DISPOSITION " + nom.Text + ".pdf");
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

        private void miseAdisposition_Load(object sender, EventArgs e)
        {

        }
    }
}
