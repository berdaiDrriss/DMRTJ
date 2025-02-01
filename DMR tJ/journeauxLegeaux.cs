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
    public partial class journeauxLegeaux : Form
    {
        public journeauxLegeaux()
        {
            InitializeComponent();
        }

        private void vider()
        {
            villeJL.Text = "";
            dateJL.Text = "";
            genJL.Text = "";
            denJL.Text = "";
            formeJL.Text = "";
            siegeJL.Text = "";
            iceJL.Text = "";
            tpJL.Text = "";
            ifJL.Text = "";
            rcJL.Text = "";
            cnssJL.Text = "";
            villeJL.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void journeauxLegeaux_Load(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "JOURANUX LEGAUX");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "JOURANUX LEGAUX Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\JOURANUX LEGAUX.docx");

            doc.Bookmarks["villeJL"].Range.Text = villeJL.Text.Trim();
            doc.Bookmarks["villeJLOne"].Range.Text = villeJL.Text.Trim();
            doc.Bookmarks["villeJLTow"].Range.Text = villeJL.Text.Trim();
            doc.Bookmarks["villeJLTree"].Range.Text = villeJL.Text.Trim();
            doc.Bookmarks["dateJL"].Range.Text = dateJL.Text.Trim();
            doc.Bookmarks["denJL"].Range.Text = denJL.Text.Trim();
            doc.Bookmarks["denJLOne"].Range.Text = denJL.Text.Trim();
            doc.Bookmarks["formeJL"].Range.Text = formeJL.Text.Trim();
            doc.Bookmarks["formeJLOne"].Range.Text = formeJL.Text.Trim();
            doc.Bookmarks["iceJL"].Range.Text = iceJL.Text.Trim();
           //doc.Bookmarks["iceJLOne"].Range.Text = iceJL.Text.Trim();
            doc.Bookmarks["ifJL"].Range.Text = ifJL.Text.Trim();
            doc.Bookmarks["tpJL"].Range.Text = tpJL.Text.Trim();
            doc.Bookmarks["rcJL"].Range.Text = rcJL.Text.Trim();
            doc.Bookmarks["rcJLOne"].Range.Text = rcJL.Text.Trim();
            doc.Bookmarks["cnssJL"].Range.Text = cnssJL.Text.Trim();
            doc.Bookmarks["genJL"].Range.Text = genJL.Text.Trim();
            doc.Bookmarks["siegeJL"].Range.Text = siegeJL.Text.Trim();
            doc.Bookmarks["siegeJLOne"].Range.Text = siegeJL.Text.Trim();

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "JOURANUX LEGAUX " + denJL.Text + ".pdf");
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
