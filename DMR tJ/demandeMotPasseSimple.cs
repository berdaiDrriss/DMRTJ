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
    public partial class demandeMotPasseSimple : Form
    {
        public demandeMotPasseSimple()
        {
            InitializeComponent();
        }

        private void vider()
        {
            villeSimpl.Text = "";
            dateSimpl.Text = "";
            denSimpl.Text = "";
            forSimpl.Text = "";
            objSimpl.Text = "";
            motifiSimpl.Text = "";
            emailSimpl.Text = "";
            siegSimpl.Text = "";
            iceSimpl.Text = "";
            tpSimpl.Text = "";
            ifSimpl.Text = "";
            rcSimpl.Text = "";
            cnssSimpl.Text = "";
            villeSimpl.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demandeMotPasseSimple_Load(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {

            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DDE DE MOT DE PASSE SIMPLE");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "DDE DE MOT DE PASSE SIMPLE Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\DDE DE MOT DE PASSE SIMPLE.docx");

            doc.Bookmarks["denSimpl"].Range.Text = denSimpl.Text.Trim();
            
            doc.Bookmarks["forSimpl"].Range.Text = forSimpl.Text.Trim();
            
            doc.Bookmarks["villeSimpl"].Range.Text = villeSimpl.Text.Trim();
            doc.Bookmarks["villeSimplOne"].Range.Text = villeSimpl.Text.Trim();

            doc.Bookmarks["dateSimpl"].Range.Text = dateSimpl.Text.Trim();

           // doc.Bookmarks["destinataieSimpl"].Range.Text = destinataireSimpl.Text.Trim();
            doc.Bookmarks["emailSimpl"].Range.Text = emailSimpl.Text.Trim();

            doc.Bookmarks["siegSimpl"].Range.Text = siegSimpl.Text.Trim();

            doc.Bookmarks["tpSimpl"].Range.Text = tpSimpl.Text.Trim();

            doc.Bookmarks["tpSimplOne"].Range.Text = tpSimpl.Text.Trim();

            doc.Bookmarks["ifSimpl"].Range.Text = ifSimpl.Text.Trim();

            doc.Bookmarks["ifSimplOne"].Range.Text = ifSimpl.Text.Trim();

            doc.Bookmarks["rcSimpl"].Range.Text = rcSimpl.Text.Trim();
            doc.Bookmarks["iceSimpl"].Range.Text = iceSimpl.Text.Trim();
            doc.Bookmarks["cnssSimpl"].Range.Text = cnssSimpl.Text.Trim();

            doc.Bookmarks["motifiSimpl"].Range.Text = motifiSimpl.Text.Trim();
            doc.Bookmarks["objSimpl"].Range.Text = objSimpl.Text.Trim();



            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "DDE DE MOT DE PASSE SIMPLE " + denSimpl.Text + ".pdf");
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
