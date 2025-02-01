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
    public partial class pvDissolution : Form
    {
        public pvDissolution()
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
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PV DE DISSOLUTION");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "PV DE DISSOLUTION Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\PV DE DISSOLUTION.docx");

            doc.Bookmarks["den"].Range.Text = den.Text.Trim();
            doc.Bookmarks["fj"].Range.Text = fj.Text.Trim();
            doc.Bookmarks["denOne"].Range.Text = den.Text.Trim();
            doc.Bookmarks["fjOne"].Range.Text = fj.Text.Trim();
            doc.Bookmarks["denTow"].Range.Text = den.Text.Trim();
            doc.Bookmarks["fjTow"].Range.Text = fj.Text.Trim();

            doc.Bookmarks["rc"].Range.Text = rc.Text.Trim();
            doc.Bookmarks["iif"].Range.Text = iif.Text.Trim();

            doc.Bookmarks["ap"].Range.Text = ap.Text.Trim();
            doc.Bookmarks["dp"].Range.Text = dp.Text.Trim();

            doc.Bookmarks["ca"].Range.Text = ca.Text.Trim();
            doc.Bookmarks["ps"].Range.Text = ps.Text.Trim();
            doc.Bookmarks["caOne"].Range.Text = ca.Text.Trim();
            doc.Bookmarks["psOne"].Range.Text = ps.Text.Trim();
            doc.Bookmarks["caTow"].Range.Text = ca.Text.Trim();

            doc.Bookmarks["vs"].Range.Text = vs.Text.Trim();
            doc.Bookmarks["sie"].Range.Text = sie.Text.Trim();
            doc.Bookmarks["vsOne"].Range.Text = vs.Text.Trim();
            doc.Bookmarks["sieOne"].Range.Text = sie.Text.Trim();
            doc.Bookmarks["vsTow"].Range.Text = vs.Text.Trim();
            doc.Bookmarks["sieTow"].Range.Text = sie.Text.Trim();
            doc.Bookmarks["vsTree"].Range.Text = vs.Text.Trim();
            doc.Bookmarks["sieTree"].Range.Text = sie.Text.Trim();

            doc.Bookmarks["vc"].Range.Text = vc.Text.Trim();
            doc.Bookmarks["de"].Range.Text = de.Text.Trim();

            doc.Bookmarks["nRe"].Range.Text = nRe.Text.Trim();
            doc.Bookmarks["nOr"].Range.Text = nOr.Text.Trim();

            doc.Bookmarks["ge"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pn"].Range.Text = pn.Text.Trim();
            doc.Bookmarks["geOne"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pnOne"].Range.Text = pn.Text.Trim();
            doc.Bookmarks["geTow"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pnTow"].Range.Text = pn.Text.Trim();
            doc.Bookmarks["geTree"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pnTree"].Range.Text = pn.Text.Trim();

            doc.Bookmarks["na"].Range.Text = na.Text.Trim();
            doc.Bookmarks["ti"].Range.Text = ti.Text.Trim();
            doc.Bookmarks["ni"].Range.Text = ni.Text.Trim();
            doc.Bookmarks["vn"].Range.Text = vn.Text.Trim();
            doc.Bookmarks["dn"].Range.Text = dn.Text.Trim();

            //doc.Bookmarks["qu"].Range.Text = qu.Text.Trim();
            doc.Bookmarks["vr"].Range.Text = vr.Text.Trim();
            doc.Bookmarks["ar"].Range.Text = ar.Text.Trim();

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "PV DE DISSOLUTION " + den.Text + ".pdf");
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
