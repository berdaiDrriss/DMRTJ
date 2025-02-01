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
    public partial class listeSocietee : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public listeSocietee()
        {
            InitializeComponent();
        }

        private void remplir()
        {
            //conxChecker();
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from societee ", bd);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[0],
                    rd[1],
                    rd[2],
                    rd[5],
                    rd[3],
                    rd[9],
                    rd[10],
                    rd[11],
                    rd[12],
                    rd[13]
                    );
            }
            rd.Close();
        }

        private void listeSocietee_Load(object sender, EventArgs e)
        {
            remplir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
