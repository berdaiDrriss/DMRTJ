using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Configuration;

namespace DMR_tJ
{
    public partial class listeRepresantant : Form
    {
        int npr;
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public listeRepresantant()
        {
            InitializeComponent();
        }

        public void conxChecker()
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }

        }

        private void remplir()
        {
            conxChecker();
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select R.idRepresentant,s.denomination,R.nom,R.typeIdentite,R.identite,R.tel,R.email,R.ville,R.adresse from representant R join societee s on s.idSte = R.idSte ", bd);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[0],
                    rd[1],
                    rd[2],
                    rd[3],
                    rd[4],
                    rd[5],
                    rd[6],
                    rd[7],
                    rd[8]

                    );
            }
            rd.Close();
        }


        private void listeRepresantant_Load(object sender, EventArgs e)
        {
            remplir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
