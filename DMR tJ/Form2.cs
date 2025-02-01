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
    public partial class resiliationContratDomiciliation : Form
    {
        public resiliationContratDomiciliation()
        {
            InitializeComponent();
        }

        private void vider()
        {
            villeRD.Text = "";
            dateRD.Text = "";
            denRD.Text = "";
            formeRD.Text = "";
            siegeRD.Text = "";
            genRD.Text = "";
            nomRD.Text = "";
            iceRD.Text = "";
            tpRD.Text = "";
            ifRD.Text = "";
            rcRD.Text = "";
            cnssRD.Text = "";
            denRDD.Text = "";
            formeRDD.Text = "";
            genRDD.Text = "";
            nomRDD.Text = "";
            villeRD.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RESILIATION DE CONTRAT DE DOMICILIATION SOCIETE");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "RESILIATION DE CONTRAT DE DOMICILIATION SOCIETE Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\RESILIATION DE CONTRAT DE DOMICILIATION SOCIETE.docx");

            doc.Bookmarks["villeRD"].Range.Text = villeRD.Text.Trim();
            doc.Bookmarks["villeRDOne"].Range.Text = villeRD.Text.Trim();
            doc.Bookmarks["villeRDTow"].Range.Text = villeRD.Text.Trim();
            doc.Bookmarks["villeRDQuatre"].Range.Text = villeRD.Text.Trim();
            doc.Bookmarks["dateRD"].Range.Text = dateRD.Text.Trim();
            doc.Bookmarks["denRD"].Range.Text = denRD.Text.Trim();
            doc.Bookmarks["denRDOne"].Range.Text = denRD.Text.Trim();
            doc.Bookmarks["denRDTow"].Range.Text = denRD.Text.Trim();
            doc.Bookmarks["formeRD"].Range.Text = formeRD.Text.Trim();
            doc.Bookmarks["formeRDOne"].Range.Text = formeRD.Text.Trim();
            doc.Bookmarks["formeRDTow"].Range.Text = formeRD.Text.Trim();
            doc.Bookmarks["siegeRD"].Range.Text = siegeRD.Text.Trim();
            doc.Bookmarks["siegeRDOne"].Range.Text = siegeRD.Text.Trim();
            doc.Bookmarks["siegeRDTow"].Range.Text = siegeRD.Text.Trim();

            doc.Bookmarks["genRD"].Range.Text = genRD.Text.Trim();
            doc.Bookmarks["nomRD"].Range.Text = nomRD.Text.Trim();

            doc.Bookmarks["iceRD"].Range.Text = iceRD.Text.Trim();
            doc.Bookmarks["iceRDOne"].Range.Text = iceRD.Text.Trim();
            doc.Bookmarks["tpRD"].Range.Text = tpRD.Text.Trim();
            doc.Bookmarks["tpRDOne"].Range.Text = tpRD.Text.Trim();
            doc.Bookmarks["ifRD"].Range.Text = ifRD.Text.Trim();
            doc.Bookmarks["ifRDOne"].Range.Text = ifRD.Text.Trim();
            doc.Bookmarks["rcRD"].Range.Text = rcRD.Text.Trim();
            doc.Bookmarks["rcRDOne"].Range.Text = rcRD.Text.Trim();
            doc.Bookmarks["cnssRD"].Range.Text = cnssRD.Text.Trim();
            doc.Bookmarks["cnssRDOne"].Range.Text = cnssRD.Text.Trim();

            doc.Bookmarks["denRDD"].Range.Text = denRDD.Text.Trim();
            doc.Bookmarks["denRDDOne"].Range.Text = denRDD.Text.Trim();
            doc.Bookmarks["formeRDD"].Range.Text = formeRDD.Text.Trim();
            doc.Bookmarks["formeRDDOne"].Range.Text = formeRDD.Text.Trim();
            doc.Bookmarks["genRDD"].Range.Text = genRDD.Text.Trim();
            doc.Bookmarks["nomRDD"].Range.Text = nomRDD.Text.Trim();


            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "RESILIATION DE CONTRAT DE DOMICILIATION SOCIETE " + denRD.Text + ".pdf");
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
