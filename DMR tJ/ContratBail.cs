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
    public partial class ContratBail : Form
    {
        public ContratBail()
        {
            InitializeComponent();
        }

        private void vider()
        {
            genre.Text = "";
            nom.Text = "";
            nationalite.Text = "";
            tpidentite.Text = "";
            nidentite.Text = "";
            villen.Text = "";
            daten.Text = "";
            adressen.Text = "";
            denomination.Text = "";
            forme.Text = "";
            genrer.Text = "";
            nomr.Text = "";
            qualite.Text = "";
            nationaliter.Text = "";
            tpidentiter.Text = "";
            nidentiter.Text = "";
            villenr.Text = "";
            datenr.Text = "";
            adressenr.Text = "";
            villec.Text = "";
            datec.Text = "";
            adressec.Text = "";
            duree.Text = "";
            dateDebut.Text = "";
            designation.Text = "";
            montantc.Text = "";
            montantl.Text = "";
            genre.Select();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CONTRAT DE BAIL");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "CONTRAT DE BAIL Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\CONTRAT DE BAIL.docx");

            doc.Bookmarks["genre"].Range.Text = genre.Text.Trim();
            doc.Bookmarks["genreOne"].Range.Text = genre.Text.Trim();
            doc.Bookmarks["nom"].Range.Text = nom.Text.Trim();
            doc.Bookmarks["nomOne"].Range.Text = nom.Text.Trim();
            doc.Bookmarks["nationalite"].Range.Text = nationalite.Text.Trim();
            doc.Bookmarks["tpidentite"].Range.Text = tpidentite.Text.Trim();
            doc.Bookmarks["nidentite"].Range.Text = nidentite.Text.Trim();
            doc.Bookmarks["villen"].Range.Text = villen.Text.Trim();
            doc.Bookmarks["daten"].Range.Text = daten.Text.Trim();
            doc.Bookmarks["adressen"].Range.Text = adressen.Text.Trim();

            doc.Bookmarks["denomination"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["denominationOne"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["denominationTow"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["forme"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["formeOne"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["formeTow"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["genrer"].Range.Text = genrer.Text.Trim();
            doc.Bookmarks["genrerOne"].Range.Text = genrer.Text.Trim();
            doc.Bookmarks["genrerTow"].Range.Text = genrer.Text.Trim();
            doc.Bookmarks["nomr"].Range.Text = nomr.Text.Trim();
            doc.Bookmarks["nomrOne"].Range.Text = nomr.Text.Trim();
            doc.Bookmarks["nomrTow"].Range.Text = nomr.Text.Trim();
            doc.Bookmarks["qualite"].Range.Text = qualite.Text.Trim();
            doc.Bookmarks["nationaliter"].Range.Text = nationaliter.Text.Trim();
            doc.Bookmarks["tpidentiter"].Range.Text = tpidentiter.Text.Trim();
            doc.Bookmarks["nidentiter"].Range.Text = nidentiter.Text.Trim();
            doc.Bookmarks["villenr"].Range.Text = villenr.Text.Trim();
            doc.Bookmarks["datenr"].Range.Text = datenr.Text.Trim();
            doc.Bookmarks["adressenr"].Range.Text = adressenr.Text.Trim();

            doc.Bookmarks["villec"].Range.Text = villec.Text.Trim();
            doc.Bookmarks["villecOne"].Range.Text = villec.Text.Trim();
            doc.Bookmarks["datec"].Range.Text = datec.Text.Trim();
            doc.Bookmarks["adressec"].Range.Text = adressec.Text.Trim();
            doc.Bookmarks["duree"].Range.Text = duree.Text.Trim();
            doc.Bookmarks["dateDebut"].Range.Text = dateDebut.Text.Trim();
            doc.Bookmarks["designation"].Range.Text = designation.Text.Trim();
            doc.Bookmarks["montantc"].Range.Text = montantc.Text.Trim();
            doc.Bookmarks["montantl"].Range.Text = montantl.Text.Trim();

            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "CONTRAT DE BAIL " + denomination.Text + ".pdf");
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
