using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DMR_tJ
{
    public partial class ordreDeVirement : Form
    {
        public ordreDeVirement()
        {
            InitializeComponent();
        }

        private void vider()
        {
            ville.Text = "";
            date.Text = "";
            banque.Text = "";
            agence.Text = "";
            denomination.Text = "";
            forme.Text = "";
            siege.Text = "";
            compte.Text = "";
            ice.Text = "";
            tp.Text = "";
            iif.Text = "";
            rc.Text = "";
            cnss.Text = "";
            genre.Text = "";
            nom.Text = "";
            nCompteS.Text = "";
            salaire.Text = "";
            ville.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            
                for (int x = 0; x < tableau.Rows.Count - 1; x++)
                {
                    if (tableau.Rows[x].Cells[1].Value.ToString() == nom.Text)
                    {
                        MessageBox.Show("SERVICE DEJA  AJOUTÉ", "FIDUPLUS FACTURATION",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            tableau.Rows.Add(
                genre.Text,
                nom.Text,
                nCompteS.Text,
                salaire.Text
                );

            genre.Text = "";
            nom.Text = "";
            nCompteS.Text = "";
            salaire.Text = "";
            genre.Select();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            string outputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Ordre de virement");
            string backupDirectory = Path.Combine(Environment.CurrentDirectory, "Ordre de virement");

            // Create the directories if they don't exist
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }
            if (!Directory.Exists(backupDirectory))
            {
                Directory.CreateDirectory(backupDirectory);
            }
            int nl = 21;
            Ex.Application app = new Ex.Application();
            Ex.Workbooks books;
            books = app.Workbooks;
            Ex.Workbook book;
            book = books.Open(Environment.CurrentDirectory + "\\Ordre de virement.xlsx");
            Ex._Worksheet ws = book.ActiveSheet;

            ws.Cells[8, 7] = ville.Text;
            ws.Cells[5, 3] = date.Value.Date;
            ws.Cells[6, 7] = banque.Text;
            ws.Cells[7, 8] = agence.Text;
            ws.Cells[14, 3] = compte.Text;
            ws.Cells[16, 7] = compte.Text;
            ws.Cells[18, 6] = date.Value.Month;
            for (int i = 0; i < tableau.Rows.Count - 1; i++)
            {

                ws.Cells[nl, 1] = tableau.Rows[i].Cells[1].Value.ToString();
                ws.Cells[nl, 5] = tableau.Rows[i].Cells[2].Value.ToString();
                ws.Cells[nl, 9] = tableau.Rows[i].Cells[3].Value.ToString();
                nl++;

            }
            string virDate = date.Text;
            // Save the document as PDF in the specified directories
            string pdfOutputPath = Path.Combine(outputDirectory, "Ordre de virement " + denomination.Text +" "+virDate+".pdf");
            book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdfOutputPath);

            string pdfbackupDirectory = Path.Combine(backupDirectory, "Ordre de virement " + denomination.Text + " " + virDate + ".pdf");
            book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdfbackupDirectory);

            // Open the saved PDF document
            System.Diagnostics.Process.Start(pdfOutputPath);

            // Close the Word document without saving changes
            book.Close(false);
            Marshal.ReleaseComObject(book);

            // Quit Word Application
            app.Quit();
            Marshal.ReleaseComObject(app);
            vider();
        }
    }
}
