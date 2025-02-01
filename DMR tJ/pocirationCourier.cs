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
    public partial class pocirationCourier : Form
    {
        public pocirationCourier()
        {
            InitializeComponent();
        }

        private void vider()
        {
            ville.Text = "";
            date.Text = "";
            denominationM.Text = "";
            formeM.Text = "";
            genreM.Text = "";
            nomM.Text = "";
            typIdenM.Text = "";
            cinM.Text = "";
            denominationMn.Text = "";
            formeMn.Text = "";
            rcMn.Text = "";
            villeMn.Text = "";
            siegeMn.Text = "";
            genreMn.Text = "";
            nomMn.Text = "";
            ville.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PROCURATION COURIER");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "PROCURATION COURIER Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\PROCURATION COURIER.docx");

            doc.Bookmarks["denominationM"].Range.Text = denominationM.Text.Trim();
            doc.Bookmarks["denominationMOne"].Range.Text = denominationM.Text.Trim();
            doc.Bookmarks["denominationMTwo"].Range.Text = denominationM.Text.Trim();
            doc.Bookmarks["formeM"].Range.Text = formeM.Text.Trim();
            doc.Bookmarks["formeMOne"].Range.Text = formeM.Text.Trim();
            doc.Bookmarks["formeMTwo"].Range.Text = formeM.Text.Trim();
            doc.Bookmarks["genreM"].Range.Text = genreM.Text.Trim();
            doc.Bookmarks["genreMOne"].Range.Text = genreM.Text.Trim();
            doc.Bookmarks["nomM"].Range.Text = nomM.Text.Trim();
            doc.Bookmarks["nomMOne"].Range.Text = nomM.Text.Trim();
            doc.Bookmarks["typIdenM"].Range.Text = typIdenM.Text.Trim();
            doc.Bookmarks["cinM"].Range.Text = cinM.Text.Trim();

            doc.Bookmarks["denominationMn"].Range.Text = denominationMn.Text.Trim();
            doc.Bookmarks["formeMn"].Range.Text = formeMn.Text.Trim();
            doc.Bookmarks["rcMn"].Range.Text = rcMn.Text.Trim();
            doc.Bookmarks["villeMn"].Range.Text = villeMn.Text.Trim();
            doc.Bookmarks["siegeMn"].Range.Text = siegeMn.Text.Trim();
            doc.Bookmarks["genreMn"].Range.Text = genreMn.Text.Trim();
            doc.Bookmarks["nomMn"].Range.Text = nomMn.Text.Trim();

            doc.Bookmarks["ville"].Range.Text = ville.Text.Trim();
            doc.Bookmarks["date"].Range.Text = date.Text.Trim();

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "PROCURATION COURIER " + denominationM.Text + ".pdf");
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
