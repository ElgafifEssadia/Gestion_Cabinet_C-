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
    public partial class Form5 : Form
    {
        public Form5(List<Patient> hommes, List<Patient> femmes)
        {
            InitializeComponent();
            foreach (Patient pa in hommes)
            {
                homme.Items.Add(pa.getNom());
            }
            
            foreach (Patient pa in femmes)
            {
                femme.Items.Add(pa.getNom());
            }
        }
    }
}
