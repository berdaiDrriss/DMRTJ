using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMR_tJ
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new deduction());
            //Application.Run(new demande_extre_de_role());
            //Application.Run(new demandeMotDePasse());
            //Application.Run(new DmandeInscriptionTpConstitution());
            //Application.Run(new decharge());
            //Application.Run(new attestationDeTavail());
            //Application.Run(new soldeDeToutCompte());
            //Application.Run(new archiffage());
            //Application.Run(new demandeMotPasseSimple());
            //Application.Run(new attestationContratDomiciliation());
            //Application.Run(new abandonDePoste());
            //Application.Run(new journeauxLegeaux());
            //Application.Run(new ficheComptable());
            //Application.Run(new contratDeTravail());
            //Application.Run(new resiliationContratDomiciliation());
            //Application.Run(new depense());
            //Application.Run(new miseAdisposition());
            Application.Run(new encaissement());
            //Application.Run(new menuJuridiques());
            //Application.Run(new menuTva());
        }
    }
}
