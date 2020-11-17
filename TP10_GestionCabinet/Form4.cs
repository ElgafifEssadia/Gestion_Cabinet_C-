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
    public partial class Form4 : Form
    {
        public Form4(List<Patient> patients)
        {
            InitializeComponent();
            Cabinet c = new Cabinet();
            foreach(Patient pa in patients)
            {
                DateTime date = pa.getDateNaissance();
                int year = date.Year;
                int mois = date.Month;
                int day = date.Day;
                DateTime date1 = new DateTime(year, mois, day);
                int age = c.Age(date1);
                if (age < 18)
                {
                    enfant.Items.Add(pa.getNom());
                }
                else
                {
                    adulte.Items.Add(pa.getNom());
                }

            }
            
        }
    }
}
