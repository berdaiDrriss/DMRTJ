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
    public partial class immatriculationRc : Form
    {
        public immatriculationRc()
        {
            InitializeComponent();
        }

        private void vider()
        {
            ville.Text = "";
            date.Text = "";
            denomination.Text = "";
            forme.Text = "";
            enseigne.Text = "";
            sigle.Text = "";
            dateNegatif.Text = "";
            activite.Text = "";
            nTp.Text = "";
            villeSte.Text = "";
            siege.Text = "";
            capital.Text = "";
            nom.Text = "";
            villen.Text = "";
            daten.Text = "";
            nationalilte.Text = "";
            qualite.Text = "";
            typeIdentite.Text = "";
            nIdentite.Text = "";
            villeResidence.Text = "";
            adresseResidence.Text = "";
            ville.Select();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RC IMMATRICULATION");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "RC IMMATRICULATION Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\RC IMMATRICULATION.docx");

            doc.Bookmarks["ville"].Range.Text = ville.Text.Trim();
            doc.Bookmarks["date"].Range.Text = date.Text.Trim();

            doc.Bookmarks["denomination"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["denominationOne"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["forme"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["formeOne"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["formeTow"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["enseigne"].Range.Text = enseigne.Text.Trim();
            doc.Bookmarks["sigle"].Range.Text = sigle.Text.Trim();
            doc.Bookmarks["dateNegatif"].Range.Text = dateNegatif.Text.Trim();
            doc.Bookmarks["activite"].Range.Text = activite.Text.Trim();
            doc.Bookmarks["nTp"].Range.Text = nTp.Text.Trim();
            doc.Bookmarks["villeSte"].Range.Text = villeSte.Text.Trim();
            doc.Bookmarks["siege"].Range.Text = siege.Text.Trim();
            doc.Bookmarks["capital"].Range.Text = capital.Text.Trim();

            doc.Bookmarks["nom"].Range.Text = nom.Text.Trim();
            doc.Bookmarks["nomOne"].Range.Text = nom.Text.Trim();
            doc.Bookmarks["villen"].Range.Text = villen.Text.Trim();
            doc.Bookmarks["daten"].Range.Text = daten.Text.Trim();
            doc.Bookmarks["nationalilte"].Range.Text = nationalilte.Text.Trim();
            doc.Bookmarks["qualite"].Range.Text = qualite.Text.Trim();
            doc.Bookmarks["qualiteOne"].Range.Text = qualite.Text.Trim();
            doc.Bookmarks["typeIdentite"].Range.Text = typeIdentite.Text.Trim();
            doc.Bookmarks["nIdentite"].Range.Text = nIdentite.Text.Trim();
            doc.Bookmarks["villeResidence"].Range.Text = villeResidence.Text.Trim();
            doc.Bookmarks["villeResidenceOne"].Range.Text = villeResidence.Text.Trim();
            doc.Bookmarks["adresseResidence"].Range.Text = adresseResidence.Text.Trim();
            doc.Bookmarks["adresseResidenceOne"].Range.Text = adresseResidence.Text.Trim();




            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "RC IMMATRICULATION" + denomination.Text + ".pdf");
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
