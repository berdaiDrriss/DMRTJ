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
    public partial class decharge : Form
    {
        public decharge()
        {
            InitializeComponent();
        }

        private void vider()
        {
            villeDecharge.Text = "";
            dateDecharge.Text = "";
            denExpiditeur.Text = "";
            forExpiditeur.Text = "";
            siegExpiditeur.Text = "";
            iceExpiditeur.Text = "";
            tpExpiditeur.Text = "";
            ifExpiditeur.Text = "";
            rcExpiditeur.Text = "";
            cnssExpiditeur.Text = "";
            denDecharge.Text = "";
            forDecharge.Text = "";
            iceDecharge.Text = "";
            objDecharge.Text = "";
            designDecharge.Text = "";
            perioDecharge.Text = "";
            villeDecharge.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DECHARGE");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "DECHARGE Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\DECHARGE.docx");

            doc.Bookmarks["villeDechageOne"].Range.Text = villeDecharge.Text.Trim();
            doc.Bookmarks["villeDechageTow"].Range.Text = villeDecharge.Text.Trim();
            doc.Bookmarks["dateDechageOne"].Range.Text = dateDecharge.Text.Trim();
            doc.Bookmarks["steDechageOne"].Range.Text = denDecharge.Text.Trim();
            doc.Bookmarks["steDechageTow"].Range.Text = denDecharge.Text.Trim();
            doc.Bookmarks["forDechageOne"].Range.Text = forDecharge.Text.Trim();
            doc.Bookmarks["forDechageTow"].Range.Text = forDecharge.Text.Trim();
            doc.Bookmarks["iceDechageOne"].Range.Text = iceDecharge.Text.Trim();
            doc.Bookmarks["objetDechageOne"].Range.Text = objDecharge.Text.Trim();
            doc.Bookmarks["designationDechageOne"].Range.Text = designDecharge.Text.Trim();
            doc.Bookmarks["periodeDechageOne"].Range.Text = perioDecharge.Text.Trim();

            doc.Bookmarks["denExpiditeur"].Range.Text = denExpiditeur.Text.Trim();
            doc.Bookmarks["forExpiditeur"].Range.Text = forExpiditeur.Text.Trim();
            doc.Bookmarks["denExpiditeurOne"].Range.Text = denExpiditeur.Text.Trim();
            doc.Bookmarks["forExpiditeurOne"].Range.Text = forExpiditeur.Text.Trim();
            doc.Bookmarks["siegExpiditeur"].Range.Text = siegExpiditeur.Text.Trim();

            doc.Bookmarks["iceExpiditeur"].Range.Text = iceExpiditeur.Text.Trim();
            doc.Bookmarks["ifExpiditeur"].Range.Text = ifExpiditeur.Text.Trim();
            doc.Bookmarks["tpExpiditeur"].Range.Text = tpExpiditeur.Text.Trim();
            doc.Bookmarks["rcExpiditeur"].Range.Text = rcExpiditeur.Text.Trim();
            doc.Bookmarks["cnssExpiditeur"].Range.Text = cnssExpiditeur.Text.Trim();




            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "DECHARGE" + denDecharge.Text + ".pdf");
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void decharge_Load(object sender, EventArgs e)
        {

        }
    }
}
