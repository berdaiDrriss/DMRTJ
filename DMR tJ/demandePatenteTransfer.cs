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
    public partial class demande_extre_de_role : Form
    {
        public demande_extre_de_role()
        {
            InitializeComponent();
        }

        private void vider()
        {
            villeD.Text = "";
            dateD.Text = "";
            denominationD.Text = "";
            formeD.Text = "";
            capitalD.Text = "";
            siegeD.Text = "";
            iceD.Text = "";
            tpD.Text = "";
            ifD.Text = "";
            rcD.Text = "";
            cnssD.Text = "";
            villeD.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DEMENDE TP TRANSFERT DU SIEGE");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "DEMENDE TP TRANSFERT DU SIEGE Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\DEMENDE TP TRANSFERT DU SIEGE.docx");

            doc.Bookmarks["steOne"].Range.Text = denominationD.Text.Trim();
            doc.Bookmarks["steTow"].Range.Text = denominationD.Text.Trim();
            doc.Bookmarks["formeOne"].Range.Text = formeD.Text.Trim();
            doc.Bookmarks["formeTow"].Range.Text = formeD.Text.Trim();
            doc.Bookmarks["villeOne"].Range.Text = villeD.Text.Trim();
            doc.Bookmarks["villeTow"].Range.Text = villeD.Text.Trim();
            doc.Bookmarks["villeTree"].Range.Text = villeD.Text.Trim();
            doc.Bookmarks["dateOne"].Range.Text = dateD.Text.Trim();
            // doc.Bookmarks["destinataireOne"].Range.Text = destinataireD.Text.Trim();
            doc.Bookmarks["tpOne"].Range.Text = tpD.Text.Trim();
            doc.Bookmarks["tpTow"].Range.Text = tpD.Text.Trim();
            doc.Bookmarks["tpTree"].Range.Text = tpD.Text.Trim();
            doc.Bookmarks["ifOne"].Range.Text = ifD.Text.Trim();
            doc.Bookmarks["rcOne"].Range.Text = rcD.Text.Trim();
            doc.Bookmarks["iceOne"].Range.Text = iceD.Text.Trim();
            doc.Bookmarks["cnssOne"].Range.Text = cnssD.Text.Trim();
            doc.Bookmarks["capitalOne"].Range.Text = capitalD.Text.Trim();
            doc.Bookmarks["siegeOne"].Range.Text = siegeD.Text.Trim();
            doc.Bookmarks["siegeTow"].Range.Text = siegeD.Text.Trim();



            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "DEMENDE TP TRANSFERT DU SIEGE " + denominationD.Text + ".pdf");
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void demande_extre_de_role_Load(object sender, EventArgs e)
        {

        }
    }
}
