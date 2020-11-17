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
    public partial class Form3 : Form
    {
        public Form3(List<Patient> card, List<Patient> den, List<Patient> gen)
        {
            InitializeComponent();
            
            foreach (Patient pa in card)
            {
                Cardiologue.Items.Add(pa.getNom());
            }
            foreach (Patient pa in den)
            {
                Dentiste.Items.Add(pa.getNom());
            }
            foreach (Patient pa in gen)
            {
                Generaliste.Items.Add(pa.getNom());
            }
    
        }
    }
}
