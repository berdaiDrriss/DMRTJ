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
    public partial class abandonDePoste : Form
    {
        public abandonDePoste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abandonDePoste_Load(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ABANDON DE POSTE");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "ABANDON DE POSTE Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\ABANDON DE POSTE.docx");

            doc.Bookmarks["ville"].Range.Text = ville.Text.Trim();
            doc.Bookmarks["date"].Range.Text = date.Text.Trim();
            
            doc.Bookmarks["dem"].Range.Text = dem.Text.Trim();
            doc.Bookmarks["form"].Range.Text = form.Text.Trim();
            doc.Bookmarks["sieg"].Range.Text = sieg.Text.Trim();
            
            doc.Bookmarks["ice"].Range.Text = ice.Text.Trim();
            doc.Bookmarks["ifn"].Range.Text = ifn.Text.Trim();
            doc.Bookmarks["tp"].Range.Text = tp.Text.Trim();
            doc.Bookmarks["rc"].Range.Text = rc.Text.Trim();
            doc.Bookmarks["cnss"].Range.Text = cnss.Text.Trim();

            doc.Bookmarks["dateS"].Range.Text = dateS.Text.Trim();
            doc.Bookmarks["periode"].Range.Text = periode.Text.Trim();
            doc.Bookmarks["gen"].Range.Text = gen.Text.Trim();
            doc.Bookmarks["genOne"].Range.Text = gen.Text.Trim();
            doc.Bookmarks["genTow"].Range.Text = gen.Text.Trim();
            doc.Bookmarks["type"].Range.Text = type.Text.Trim();
            doc.Bookmarks["cin"].Range.Text = cin.Text.Trim();
            doc.Bookmarks["nom"].Range.Text = nom.Text.Trim();
            doc.Bookmarks["villeS"].Range.Text = villeS.Text.Trim();
            doc.Bookmarks["adresseP"].Range.Text = adresse.Text.Trim();




            // Save the document as PDF in the specified directories
            // string pdfOutputPath = Path.Combine(outputDirectory, "ABANDON DE POSTE" + dem.Text + ".pdf");
            //doc.ExportAsFixedFormat(pdfOutputPath, Word.WdExportFormat.wdExportFormatPDF);

            // Save the document as PDF in the specified directories
            //string pdfOutputPath = Path.Combine(outputDirectory, "ABANDON DE POSTE " + dem.Text + ".pdf");
            //doc.ExportAsFixedFormat(pdfOutputPath, Word.WdExportFormat.wdExportFormatPDF);

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "ABANDON DE POSTE" + dem.Text + ".pdf");
            doc.ExportAsFixedFormat(pdfOutputPath, Word.WdExportFormat.wdExportFormatPDF);

            // Open the saved PDF document
            System.Diagnostics.Process.Start(pdfOutputPath);

            // Close the Word document without saving changes
            doc.Close(false);
            Marshal.ReleaseComObject(doc);

            // Quit Word Application
            app.Quit();
            Marshal.ReleaseComObject(app);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
