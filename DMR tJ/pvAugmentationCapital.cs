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
    public partial class pvAugmentationCapital : Form
    {
        public pvAugmentationCapital()
        {
            InitializeComponent();
        }

        private void pvAugmentationCapital_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PV AUGMENTATION CAPITAL");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "PV AUGMENTATION CAPITAL Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\PV AUGMENTATION CAPITAL.docx");

            doc.Bookmarks["den"].Range.Text = den.Text.Trim();
            doc.Bookmarks["fj"].Range.Text = fj.Text.Trim();

            doc.Bookmarks["aca"].Range.Text = aca.Text.Trim();

            doc.Bookmarks["vs"].Range.Text = vs.Text.Trim();
            doc.Bookmarks["sie"].Range.Text = sie.Text.Trim();

            doc.Bookmarks["rc"].Range.Text = rc.Text.Trim();
            doc.Bookmarks["iif"].Range.Text = iif.Text.Trim();

            doc.Bookmarks["ap"].Range.Text = ap.Text.Trim();
            doc.Bookmarks["dp"].Range.Text = dp.Text.Trim();



            doc.Bookmarks["denOne"].Range.Text = den.Text.Trim();
            doc.Bookmarks["fjOne"].Range.Text = fj.Text.Trim();

            doc.Bookmarks["acaOne"].Range.Text = aca.Text.Trim();

            doc.Bookmarks["vsOne"].Range.Text = vs.Text.Trim();
            doc.Bookmarks["sieOne"].Range.Text = sie.Text.Trim();

            doc.Bookmarks["ma"].Range.Text = ma.Text.Trim();

            doc.Bookmarks["acaTow"].Range.Text = aca.Text.Trim();

            doc.Bookmarks["ncac"].Range.Text = ncac.Text.Trim();

            doc.Bookmarks["acaTree"].Range.Text = aca.Text.Trim();

            doc.Bookmarks["maOne"].Range.Text = ma.Text.Trim();

            doc.Bookmarks["ncacOne"].Range.Text = ncac.Text.Trim();

            doc.Bookmarks["ge"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pn"].Range.Text = pn.Text.Trim();
            doc.Bookmarks["npsc"].Range.Text = npsc.Text.Trim();
            doc.Bookmarks["npsl"].Range.Text = npsl.Text.Trim();
            doc.Bookmarks["npscOne"].Range.Text = npsc.Text.Trim();
            doc.Bookmarks["acaQuatre"].Range.Text = aca.Text.Trim();
            doc.Bookmarks["ncacTow"].Range.Text = ncac.Text.Trim();

            doc.Bookmarks["geOne"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pnOne"].Range.Text = pn.Text.Trim();
            doc.Bookmarks["ncacTree"].Range.Text = ncac.Text.Trim();
            doc.Bookmarks["ncal"].Range.Text = ncal.Text.Trim();
            doc.Bookmarks["ncacQuatre"].Range.Text = ncac.Text.Trim();
            doc.Bookmarks["ncalOne"].Range.Text = ncal.Text.Trim();
            doc.Bookmarks["ncacCinq"].Range.Text = ncac.Text.Trim();
            doc.Bookmarks["npscTow"].Range.Text = npsc.Text.Trim();

            doc.Bookmarks["geTow"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pnTow"].Range.Text = pn.Text.Trim();
            doc.Bookmarks["npscTree"].Range.Text = npsc.Text.Trim();
            doc.Bookmarks["npslOne"].Range.Text = npsl.Text.Trim();
            doc.Bookmarks["npscQuatre"].Range.Text = npsc.Text.Trim();

            doc.Bookmarks["geTree"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pnTree"].Range.Text = pn.Text.Trim();

            doc.Bookmarks["aps"].Range.Text = aps.Text.Trim();
            doc.Bookmarks["apsOne"].Range.Text = aps.Text.Trim();
            doc.Bookmarks["pa"].Range.Text = pa.Text.Trim();



            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "PV AUGMENTATION CAPITAL " + den.Text + ".pdf");
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
