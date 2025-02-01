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
    public partial class menuTva : Form
    {
        public menuTva()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSociete.Visible = false;
        }

        private void hideSubMenu() 
        {
            if (panelSociete.Visible == true)
                panelSociete.Visible = false;
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

        private void button34_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSociete);
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void btnStatut_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is representant)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            representant a = new representant();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is listeRepresantant)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            listeRepresantant a = new listeRepresantant();

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
            if (currentForm is loginMotPasse)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            loginMotPasse a = new loginMotPasse();

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
            if (currentForm is listeSocietee)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            listeSocietee a = new listeSocietee();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is recape)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            recape a = new recape();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }
    }
}
