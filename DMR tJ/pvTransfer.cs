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
    public partial class pvTransfer : Form
    {
        public pvTransfer()
        {
            InitializeComponent();
        }

        private void vider()
        {
            ap.Text = "";
            dp.Text = "";
            ge.Text = "";
            pn.Text = "";
            qu.Text = "";
            rc.Text = "";
            iif.Text = "";
            den.Text = "";
            fj.Text = "";
            ca.Text = "";
            ps.Text = "";
            va.Text = "";
            sa.Text = "";
            vn.Text = "";
            sn.Text = "";
            ap.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PV TRANSFERT DE SIEGE");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "PV TRANSFERT DE SIEGE Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\PV TRANSFERT DE SIEGE.docx");

            doc.Bookmarks["dem"].Range.Text = den.Text.Trim();
            doc.Bookmarks["fj"].Range.Text = fj.Text.Trim();
            doc.Bookmarks["ca"].Range.Text = ca.Text.Trim();
            doc.Bookmarks["va"].Range.Text = va.Text.Trim();
            doc.Bookmarks["sa"].Range.Text = sa.Text.Trim();
            doc.Bookmarks["rc"].Range.Text = rc.Text.Trim();
            doc.Bookmarks["iif"].Range.Text = iif.Text.Trim();
            doc.Bookmarks["ap"].Range.Text = ap.Text.Trim();
            doc.Bookmarks["dp"].Range.Text = dp.Text.Trim();

            doc.Bookmarks["demOne"].Range.Text = den.Text.Trim();
            doc.Bookmarks["fjOne"].Range.Text = fj.Text.Trim();
            doc.Bookmarks["caOne"].Range.Text = ca.Text.Trim();
            doc.Bookmarks["ps"].Range.Text = ps.Text.Trim();
            doc.Bookmarks["psOne"].Range.Text = ps.Text.Trim();
            doc.Bookmarks["vaOne"].Range.Text = va.Text.Trim();
            doc.Bookmarks["saOne"].Range.Text = sa.Text.Trim();

            doc.Bookmarks["ge"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pn"].Range.Text = pn.Text.Trim();

         
            doc.Bookmarks["vaTow"].Range.Text = va.Text.Trim();
            doc.Bookmarks["saTow"].Range.Text = sa.Text.Trim();

            doc.Bookmarks["vn"].Range.Text = vn.Text.Trim();
            doc.Bookmarks["sn"].Range.Text = sn.Text.Trim();
            doc.Bookmarks["vnOne"].Range.Text = vn.Text.Trim();
            doc.Bookmarks["snOne"].Range.Text = sn.Text.Trim();
            doc.Bookmarks["vnTow"].Range.Text = vn.Text.Trim();
            doc.Bookmarks["snTow"].Range.Text = sn.Text.Trim();


            doc.Bookmarks["geOne"].Range.Text = ge.Text.Trim();
            doc.Bookmarks["pnOne"].Range.Text = pn.Text.Trim();
            doc.Bookmarks["qu"].Range.Text = qu.Text.Trim();




            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "PV TRANSFERT DE SIEGE " + den.Text + ".pdf");
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
