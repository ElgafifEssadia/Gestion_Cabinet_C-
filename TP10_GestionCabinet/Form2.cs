using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP10_GestionCabinet
{
    public partial class Form2 : Form
    {
        public Form2(string nom,string prenom,bool sexe,string spec)
        {
            InitializeComponent();
            prio_nom.Text = nom;
            prio_prenom.Text = prenom;
            if (sexe == false) prio_sexe.Text = "Femme";
            if (sexe == true) prio_sexe.Text = "Homme";
            prio_specialite.Text = spec;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }
    }
}
