using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace DMR_tJ
{
    class Class1
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);

        private string msg;
        private string name;

        public Class1()
        {
            msg = "";
        }

        public void conxChecker()
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }

        }

        

        public void msgSucces(string name)
        {
            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEE", name, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
