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
    public partial class demandeMotDePasse : Form
    {
        public demandeMotDePasse()
        {
            InitializeComponent();
        }

        private void vider()
        {
            villeDM.Text = "";
            dateDM.Text = "";
            denominationDM.Text = "";
            formeDM.Text = "";
            siegeDM.Text = "";
            iceDM.Text = "";
            tpDM.Text = "";
            ifDM.Text = "";
            rcDM.Text = "";
            cnssDM.Text = "";
            villeDM.Select();
        }

        private void demandeMotDePasse_Load(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DDE DE MOT DE PASSE");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "DDE DE MOT DE PASSE Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\DDE DE MOT DE PASSE.docx");

            doc.Bookmarks["steOne"].Range.Text = denominationDM.Text.Trim();
            doc.Bookmarks["steTow"].Range.Text = denominationDM.Text.Trim();
            doc.Bookmarks["formeOne"].Range.Text = formeDM.Text.Trim();
            doc.Bookmarks["formeTow"].Range.Text = formeDM.Text.Trim();
            doc.Bookmarks["villeOne"].Range.Text = villeDM.Text.Trim();
            doc.Bookmarks["villeTow"].Range.Text = villeDM.Text.Trim();
            doc.Bookmarks["dateOne"].Range.Text = dateDM.Text.Trim();
            // doc.Bookmarks["destinataireOne"].Range.Text = destinataireDM.Text.Trim();
            doc.Bookmarks["siegeOne"].Range.Text = siegeDM.Text.Trim();
            doc.Bookmarks["tpOne"].Range.Text = tpDM.Text.Trim();
            doc.Bookmarks["tpTow"].Range.Text = tpDM.Text.Trim();
            doc.Bookmarks["ifOne"].Range.Text = ifDM.Text.Trim();
            doc.Bookmarks["ifTow"].Range.Text = ifDM.Text.Trim();
            doc.Bookmarks["rcOne"].Range.Text = rcDM.Text.Trim();
            doc.Bookmarks["iceOne"].Range.Text = iceDM.Text.Trim();
            doc.Bookmarks["cnssOne"].Range.Text = cnssDM.Text.Trim();



            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "DDE DE MOT DE PASSE " + denominationDM.Text + ".pdf");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
