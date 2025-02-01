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
    public partial class depotLegal : Form
    {
        public depotLegal()
        {
            InitializeComponent();
        }

        private void vider()
        {
            rc.Text = "";
            denomination.Text = "";
            forme.Text = "";
            sigle.Text = "";
            capital.Text = "";
            ville.Text = "";
            siege.Text = "";
            nom1.Text = "";
            nom2.Text = "";
            nom3.Text = "";
            nom4.Text = "";
            nom5.Text = "";
            nom6.Text = "";
            depotC.Text = "";
            depotM.Text = "";
            etatSynthese.Text = "";
            decision.Text = "";
            o1.Text = "";
            o2.Text = "";
            o3.Text = "";
            o4.Text = "";
            o5.Text = "";
            o6.Text = "";
            o7.Text = "";
            o8.Text = "";
            o9.Text = "";
            o10.Text = "";
            o11.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
            c4.Text = "";
            c5.Text = "";
            c6.Text = "";
            c7.Text = "";
            c8.Text = "";
            c9.Text = "";
            c10.Text = "";
            c11.Text = "";
            e1.Text = "";
            e2.Text = "";
            e3.Text = "";
            e4.Text = "";
            e5.Text = "";
            e6.Text = "";
            e7.Text = "";
            e8.Text = "";
            e9.Text = "";
            e10.Text = "";
            e11.Text = "";
            date1.Text = "";
            date2.Text = "";
            date3.Text = "";
            date4.Text = "";
            date5.Text = "";
            date6.Text = "";
            date7.Text = "";
            date8.Text = "";
            date9.Text = "";
            date10.Text = "";
            date11.Text = "";
            autre.Text = "";
            rc.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Specify the desired directory paths
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DEPOT LEGAL");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "DEPOT LEGAL Backup");


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
            Word.Document doc = docs.Open(Environment.CurrentDirectory + "\\DEPOT LEGAL.docx");

            doc.Bookmarks["rc"].Range.Text = rc.Text.Trim();
            doc.Bookmarks["denomination"].Range.Text = denomination.Text.Trim();
            doc.Bookmarks["forme"].Range.Text = forme.Text.Trim();
            doc.Bookmarks["sigle"].Range.Text = sigle.Text.Trim();
            doc.Bookmarks["capital"].Range.Text = capital.Text.Trim();
            doc.Bookmarks["ville"].Range.Text = ville.Text.Trim();
            doc.Bookmarks["siege"].Range.Text = siege.Text.Trim();

            doc.Bookmarks["nom1"].Range.Text = nom1.Text.Trim();
            doc.Bookmarks["nom7"].Range.Text = nom1.Text.Trim();
            doc.Bookmarks["nom2"].Range.Text = nom2.Text.Trim();
            doc.Bookmarks["nom3"].Range.Text = nom3.Text.Trim();
            doc.Bookmarks["nom4"].Range.Text = nom4.Text.Trim();
            doc.Bookmarks["nom5"].Range.Text = nom5.Text.Trim();
            doc.Bookmarks["nom6"].Range.Text = nom6.Text.Trim();

            doc.Bookmarks["depotC"].Range.Text = depotC.Text.Trim();
            doc.Bookmarks["depotM"].Range.Text = depotM.Text.Trim();
            doc.Bookmarks["etatSynthese"].Range.Text = etatSynthese.Text.Trim();
            doc.Bookmarks["decision"].Range.Text = decision.Text.Trim();

            doc.Bookmarks["o1"].Range.Text = o1.Text.Trim();
            doc.Bookmarks["o2"].Range.Text = o2.Text.Trim();
            doc.Bookmarks["o3"].Range.Text = o3.Text.Trim();
            doc.Bookmarks["o4"].Range.Text = o4.Text.Trim();
            doc.Bookmarks["o5"].Range.Text = o5.Text.Trim();
            doc.Bookmarks["o6"].Range.Text = o6.Text.Trim();
            doc.Bookmarks["o7"].Range.Text = o7.Text.Trim();
            doc.Bookmarks["o8"].Range.Text = o8.Text.Trim();
            doc.Bookmarks["o9"].Range.Text = o9.Text.Trim();
            doc.Bookmarks["o10"].Range.Text = o10.Text.Trim();
            doc.Bookmarks["o11"].Range.Text = o11.Text.Trim();

            doc.Bookmarks["c1"].Range.Text = c1.Text.Trim();
            doc.Bookmarks["c2"].Range.Text = c2.Text.Trim();
            doc.Bookmarks["c3"].Range.Text = c3.Text.Trim();
            doc.Bookmarks["c4"].Range.Text = c4.Text.Trim();
            doc.Bookmarks["c5"].Range.Text = c5.Text.Trim();
            doc.Bookmarks["c6"].Range.Text = c6.Text.Trim();
            doc.Bookmarks["c7"].Range.Text = c7.Text.Trim();
            doc.Bookmarks["c8"].Range.Text = c8.Text.Trim();
            doc.Bookmarks["c9"].Range.Text = c9.Text.Trim();
            doc.Bookmarks["c10"].Range.Text = c10.Text.Trim();
            doc.Bookmarks["c11"].Range.Text = c11.Text.Trim();

            doc.Bookmarks["e1"].Range.Text = e1.Text.Trim();
            doc.Bookmarks["e2"].Range.Text = e2.Text.Trim();
            doc.Bookmarks["e3"].Range.Text = e3.Text.Trim();
            doc.Bookmarks["e4"].Range.Text = e4.Text.Trim();
            doc.Bookmarks["e5"].Range.Text = e5.Text.Trim();
            doc.Bookmarks["e6"].Range.Text = e6.Text.Trim();
            doc.Bookmarks["e7"].Range.Text = e7.Text.Trim();
            doc.Bookmarks["e8"].Range.Text = e8.Text.Trim();
            doc.Bookmarks["e9"].Range.Text = e9.Text.Trim();
            doc.Bookmarks["e10"].Range.Text = e10.Text.Trim();
            doc.Bookmarks["e11"].Range.Text = e11.Text.Trim();

            doc.Bookmarks["date1"].Range.Text = date1.Text.Trim();
            doc.Bookmarks["date2"].Range.Text = date2.Text.Trim();
            doc.Bookmarks["date3"].Range.Text = date3.Text.Trim();
            doc.Bookmarks["date4"].Range.Text = date4.Text.Trim();
            doc.Bookmarks["date5"].Range.Text = date5.Text.Trim();
            doc.Bookmarks["date6"].Range.Text = date6.Text.Trim();
            doc.Bookmarks["date7"].Range.Text = date7.Text.Trim();
            doc.Bookmarks["date8"].Range.Text = date8.Text.Trim();
            doc.Bookmarks["date9"].Range.Text = date9.Text.Trim();
            doc.Bookmarks["date10"].Range.Text = date10.Text.Trim();
            doc.Bookmarks["date11"].Range.Text = date11.Text.Trim();

            doc.Bookmarks["autre"].Range.Text = autre.Text.Trim();


            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "DEPOT LEGAL" + denomination.Text + ".pdf");
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
