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
    public partial class ficheComptable : Form
    {
        public ficheComptable()
        {
            InitializeComponent();
        }

        private void vider()
        {
            villeFC.Text = "";
            dateFC.Text = "";
            genFC.Text = "";
            denFC.Text = "";
            formeFC.Text = "";
            siegeFC.Text = "";
            iceFC.Text = "";
            tpFC.Text = "";
            ifFC.Text = "";
            rcFC.Text = "";
            cnssFC.Text = "";
            villeFC.Select();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {

            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FICHE COMPTABLE");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "FICHE COMPTABLE Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\FICHE COMPTABLE.docx");

            doc.Bookmarks["villeFC"].Range.Text = villeFC.Text.Trim();
            doc.Bookmarks["villeFCOne"].Range.Text = villeFC.Text.Trim();
            doc.Bookmarks["villeFCTow"].Range.Text = villeFC.Text.Trim();
           //doc.Bookmarks["villeFCTree"].Range.Text = villeFC.Text.Trim();


            doc.Bookmarks["dateFC"].Range.Text = dateFC.Text.Trim();


            doc.Bookmarks["denFC"].Range.Text = denFC.Text.Trim();
            doc.Bookmarks["denFCOne"].Range.Text = denFC.Text.Trim();


            doc.Bookmarks["formeFC"].Range.Text = formeFC.Text.Trim();
            doc.Bookmarks["formeFCOne"].Range.Text = formeFC.Text.Trim();



            doc.Bookmarks["iceFC"].Range.Text = iceFC.Text.Trim();
            //doc.Bookmarks["iceJLOne"].Range.Text = iceJL.Text.Trim();


            doc.Bookmarks["ifFC"].Range.Text = ifFC.Text.Trim();


            doc.Bookmarks["tpFC"].Range.Text = tpFC.Text.Trim();


            doc.Bookmarks["rcFC"].Range.Text = rcFC.Text.Trim();
           // doc.Bookmarks["rcJLOne"].Range.Text = rcFC.Text.Trim();


            doc.Bookmarks["cnssFC"].Range.Text = cnssFC.Text.Trim();
            doc.Bookmarks["cnssFCOne"].Range.Text = cnssFC.Text.Trim();
            doc.Bookmarks["cnssFCTow"].Range.Text = cnssFC.Text.Trim();
           //doc.Bookmarks["cnssFCQuatre"].Range.Text = cnssFC.Text.Trim();
            


            doc.Bookmarks["genFC"].Range.Text = genFC.Text.Trim();

            doc.Bookmarks["siegeFC"].Range.Text = siegeFC.Text.Trim();
            doc.Bookmarks["siegeFCOne"].Range.Text = siegeFC.Text.Trim();





            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "FICHE COMPTABLE " + denFC.Text + ".pdf");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
