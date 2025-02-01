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
    public partial class raportLiquidation : Form
    {
        public raportLiquidation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RAPPORT DE LIQUIDATION");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "RAPPORT DE LIQUIDATION Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\RAPPORT DE LIQUIDATION.docx");

            doc.Bookmarks["dd"].Range.Text = dd.Text.Trim();
            doc.Bookmarks["ddOne"].Range.Text = dd.Text.Trim();
            doc.Bookmarks["ge"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pn"].Range.Text = pn.Text.Trim();
            //doc.Bookmarks["qu"].Range.Text = qu.Text.Trim();

            doc.Bookmarks["rc"].Range.Text = rc.Text.Trim();
            doc.Bookmarks["iif"].Range.Text = iif.Text.Trim();

            doc.Bookmarks["den"].Range.Text = den.Text.Trim();
            doc.Bookmarks["fj"].Range.Text = fj.Text.Trim();
            doc.Bookmarks["ca"].Range.Text = ca.Text.Trim();
            doc.Bookmarks["vs"].Range.Text = vs.Text.Trim();
            doc.Bookmarks["sie"].Range.Text = sie.Text.Trim();

            doc.Bookmarks["ts"].Range.Text = ts.Text.Trim();
            doc.Bookmarks["tsOne"].Range.Text = ts.Text.Trim();
            doc.Bookmarks["so"].Range.Text = so.Text.Trim();

            

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "RAPPORT DE LIQUIDATION " + den.Text + ".pdf");
            doc.ExportAsFixedFormat(pdfOutputPath, Word.WdExportFormat.wdExportFormatPDF);

            // Open the saved PDF document
            System.Diagnostics.Process.Start(pdfOutputPath);

            // Close the Word document without saving changes
            doc.Close(false);
            Marshal.ReleaseComObject(doc);

            // Quit Word Application
            app.Quit();
            Marshal.ReleaseComObject(app);
            //vider();
        }
    }
}
