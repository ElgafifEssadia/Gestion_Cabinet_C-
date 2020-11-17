using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP10_GestionCabinet
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
            Application.Run(new Form1());

            /*Patient p = new Patient(1, "alami", "Sara", true, "cariologe", new DateTime(2019, 4, 23));
            Cabinet c = new Cabinet("hhh","hhh");
            c.ajouterPatient(p);
            c.ChercherPatient(1);
            //c.listePatient("cariologe");
            //Console.WriteLine(p);*/
            


        }
    }
}
