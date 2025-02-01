using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMR_tJ
{
    public partial class menuJuridique : Form
    {
        public menuJuridique()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {

            panelStatut.Visible = false;
            panelPv.Visible = false;
            panelDemande.Visible = false;
            panelContrat.Visible = false;
            panelSalarier.Visible = false;


        }
        private void hideSubMenu()
        {
            if (panelStatut.Visible == true)
                panelStatut.Visible = false;
            if (panelPv.Visible == true)
                panelPv.Visible = false;
            if (panelDemande.Visible == true)
                panelDemande.Visible = false;
            if (panelContrat.Visible == true)
                panelContrat.Visible = false;
            if (panelSalarier.Visible == true)
                panelSalarier.Visible = false;


        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuJuridique_Load(object sender, EventArgs e)
        {

        }

        private void btnStatut_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStatut);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPv);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDemande);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showSubMenu(panelContrat);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSalarier);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is Form1)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            Form1 a = new Form1();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void panelDemande_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is DmandeInscriptionTpConstitution)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            DmandeInscriptionTpConstitution a = new DmandeInscriptionTpConstitution();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is demande_extre_de_role)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            demande_extre_de_role a = new demande_extre_de_role();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is demandeMotDePasse)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            demandeMotDePasse a = new demandeMotDePasse();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is demandeMotPasseSimple)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            demandeMotPasseSimple a = new demandeMotPasseSimple();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is attestationContratDomiciliation)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            attestationContratDomiciliation a = new attestationContratDomiciliation();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is contratCdi)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            contratCdi a = new contratCdi();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is attestationDeTavail)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            attestationDeTavail a = new attestationDeTavail();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is soldeDeToutCompte)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            soldeDeToutCompte a = new soldeDeToutCompte();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is abandonDePoste)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            abandonDePoste a = new abandonDePoste();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is archiffage)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            archiffage a = new archiffage();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is decharge)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            decharge a = new decharge();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is journeauxLegeaux)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            journeauxLegeaux a = new journeauxLegeaux();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ficheComptable)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ficheComptable a = new ficheComptable();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is contratDeTravail)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            contratDeTravail a = new contratDeTravail();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is resiliationContratDomiciliation)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            resiliationContratDomiciliation a = new resiliationContratDomiciliation();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is depense)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            depense a = new depense();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ContratBail)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ContratBail a = new ContratBail();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is satutSarl)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            satutSarl a = new satutSarl();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is procuration)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            procuration a = new procuration();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is resiliationBail)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            resiliationBail a = new resiliationBail();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is miseAdisposition)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            miseAdisposition a = new miseAdisposition();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is societe)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            societe a = new societe();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is deduction)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            deduction a = new deduction();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is encaissement)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            encaissement a = new encaissement();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is depotLegal)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            depotLegal a = new depotLegal();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }
    }
}
