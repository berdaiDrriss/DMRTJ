using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace DMR_tJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gen.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vider()
        {
            gen.Text = "";
            genSin.Text="";
            nomp.Text = "";
            typIden.Text = "";
            sin.Text = "";
            nat.Text="";
            cin.Text="";
            reside.Text="";
            ville.Text="";
            reside.Text="";
            den.Text="";
            capC.Text="";
            capL.Text="";
            parC.Text="";
            parL.Text="";
            sie.Text="";
            ob.Text="";
            pub.Text="";
            gen.Select();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "statusSarlAu");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "statusSarlAuBackup");

            
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
            Word.Documents docs = app.Documents ;
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\STATUT APP.docx");

            doc.Bookmarks["typePerson"].Range.Text = gen.Text.Trim();
            doc.Bookmarks["nomPerson"].Range.Text = nomp.Text.Trim();
            doc.Bookmarks["typePersonCpS"].Range.Text = gen.Text.Trim();
            doc.Bookmarks["nomPersonCpS"].Range.Text = nomp.Text.Trim();
            doc.Bookmarks["typePersonAp"].Range.Text = gen.Text.Trim();
            doc.Bookmarks["typeIdent"].Range.Text = typIden.Text.Trim();
            doc.Bookmarks["typePersonSigne"].Range.Text = genSin.Text.Trim();
            doc.Bookmarks["typePersonAsso"].Range.Text = gen.Text.Trim();
            doc.Bookmarks["nomPersonAp"].Range.Text = nomp.Text.Trim();
            doc.Bookmarks["singnature"].Range.Text = sin.Text.Trim();
            doc.Bookmarks["nomPersonAsso"].Range.Text = nomp.Text.Trim();
            doc.Bookmarks["nationalite"].Range.Text = nat.Text.Trim();
            doc.Bookmarks["cin"].Range.Text = cin.Text.Trim();
            doc.Bookmarks["born"].Range.Text = ne.Text.Trim();
            doc.Bookmarks["bornIn"].Range.Text = ville.Text.Trim();
            doc.Bookmarks["resd"].Range.Text = reside.Text.Trim();
            doc.Bookmarks["steName"].Range.Text = den.Text.Trim();
            doc.Bookmarks["steNameArt"].Range.Text = den.Text.Trim();
            doc.Bookmarks["capital"].Range.Text = capC.Text.Trim();
            doc.Bookmarks["capitalCpS"].Range.Text = capC.Text.Trim();
            doc.Bookmarks["capitalApOne"].Range.Text = capC.Text.Trim();
            doc.Bookmarks["capitalApTwo"].Range.Text = capC.Text.Trim();
            doc.Bookmarks["capitalApThree"].Range.Text = capC.Text.Trim();
            doc.Bookmarks["capitalLettreOne"].Range.Text = capL.Text.Trim();
            doc.Bookmarks["capitalLettreTwo"].Range.Text = capL.Text.Trim();
            doc.Bookmarks["parOneC"].Range.Text = parC.Text.Trim();
            doc.Bookmarks["parTwoC"].Range.Text = parC.Text.Trim();
            doc.Bookmarks["parThreeC"].Range.Text = parC.Text.Trim();
            doc.Bookmarks["parQuatreC"].Range.Text = parC.Text.Trim();
            doc.Bookmarks["parOneL"].Range.Text = parL.Text.Trim();
            doc.Bookmarks["parTwoL"].Range.Text = parL.Text.Trim();
            doc.Bookmarks["adresse"].Range.Text = sie.Text.Trim();
            doc.Bookmarks["adresseSeg"].Range.Text = sie.Text.Trim();
            doc.Bookmarks["obj"].Range.Text = ob.Text.Trim();
            doc.Bookmarks["publicite"].Range.Text = pub.Text.Trim();


            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "Status " + den.Text + ".pdf");
            doc.ExportAsFixedFormat(pdfOutputPath, Word.WdExportFormat.wdExportFormatPDF);

            string pdfbackupDirectory = Path.Combine(backupDirectory, "Status " + den.Text + ".pdf");
            doc.ExportAsFixedFormat(pdfbackupDirectory, Word.WdExportFormat.wdExportFormatPDF);

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void capC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pub_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void typIden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
