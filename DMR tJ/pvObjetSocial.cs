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
    public partial class pvObjetSocial : Form
    {
        public pvObjetSocial()
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
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PV CHANGEMANT D'OBJET SOCIAL");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "PV CHANGEMANT D'OBJET SOCIAL Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\PV CHANGEMANT D'OBJET SOCIAL.docx");

            doc.Bookmarks["den"].Range.Text = den.Text.Trim();
            doc.Bookmarks["fj"].Range.Text = fj.Text.Trim();
            doc.Bookmarks["denOne"].Range.Text = den.Text.Trim();
            doc.Bookmarks["fjOne"].Range.Text = fj.Text.Trim();
            doc.Bookmarks["denTow"].Range.Text = den.Text.Trim();
            doc.Bookmarks["fjTow"].Range.Text = fj.Text.Trim();
            doc.Bookmarks["mos"].Range.Text = mos.Text.Trim();
            doc.Bookmarks["mosOne"].Range.Text = mos.Text.Trim();

            doc.Bookmarks["rc"].Range.Text = rc.Text.Trim();
            doc.Bookmarks["iif"].Range.Text = iif.Text.Trim();

            doc.Bookmarks["ap"].Range.Text = ap.Text.Trim();
            doc.Bookmarks["dp"].Range.Text = dp.Text.Trim();

            doc.Bookmarks["ca"].Range.Text = ca.Text.Trim();
            doc.Bookmarks["ps"].Range.Text = ps.Text.Trim();
            doc.Bookmarks["caOne"].Range.Text = ca.Text.Trim();
            doc.Bookmarks["psOne"].Range.Text = ps.Text.Trim();

            doc.Bookmarks["vs"].Range.Text = vs.Text.Trim();
            doc.Bookmarks["sie"].Range.Text = sie.Text.Trim();

            doc.Bookmarks["ge"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pn"].Range.Text = pn.Text.Trim();
            doc.Bookmarks["geOne"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pnOne"].Range.Text = pn.Text.Trim();

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "PV CHANGEMANT D'OBJET SOCIAL " + den.Text + ".pdf");
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
