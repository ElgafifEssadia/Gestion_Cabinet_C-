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
    public partial class Form1 : Form
    {
        Cabinet c = new Cabinet();
        public static List<Patient> patients = new List<Patient>();
        public static string nom;
        public static string prenom;
        public static string spec;
        public static bool sexe;

        
        public Form1()
        {
            InitializeComponent();
        }


        public void Afficher()
        {
            //dataGridView1.Rows.Clear();
            foreach (Patient pa in patients)
            {

                dataGridView1.Rows.Add(pa.getId(),pa.getNom(),
                    pa.getPrenom(),pa.getSexe(),pa.getSpecialiteDemandee(),pa.getDateNaissance());
            }
        }

        private void button1_ajouter_Click(object sender, EventArgs e)
        {
            int id;
            int year = dateTimePicker1.Value.Year;
            int mois = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;
            DateTime date = new DateTime(year, mois, day);
            //bool sex;
            if (int.TryParse(textBox_Id.Text, out id))
                if (textBox_nom.Text.Trim() != "")
                    if (textBox_prenom.Text.Trim() != "")
                    {
                        //if(bool.TryParse(comboBox_Sexe.Text,out sex))
                        //{
                            Patient p1 = new Patient(int.Parse(textBox_Id.Text), textBox_nom.Text, textBox_prenom.Text, comboBox_specialite.Text, date);
                            c.ajouterPatient(p1);
                            listeAttente1.Items.Add(textBox_nom.Text);
                           
                       /* }
                        else
                        {
                            MessageBox.Show("Selectionner le sexe ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);*/

                        }
                        else
                        {
                            MessageBox.Show("Saisie obligatoire pour Prenom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    else
                    {
                        MessageBox.Show("Saisie obligatoire pour Nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
            else
            {
                MessageBox.Show("Saisir une valeur Entiere pour ID", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Id.Clear();
                textBox_Id.Focus();
            }

        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void button_afficher_Click(object sender, EventArgs e)
        {

            List<Patient> card = new List<Patient>();
            card = c.listePatient("Cardiologue");
            List<Patient> den = new List<Patient>();
            den = c.listePatient("Dentiste");
            List<Patient> gen = new List<Patient>();
            gen = c.listePatient("Géneraliste");
            Form3 f = new Form3(card,den,gen);
            f.ShowDialog();     
        }

        private void button_classerSexe_Click(object sender, EventArgs e)
        {
            
            List<Patient> hommes = new List<Patient>();
            hommes = c.listePatient(true);
            List<Patient> femmes = new List<Patient>();
            femmes = c.listePatient(false);
            Form5 f = new Form5(hommes,femmes);
            f.ShowDialog(); 
        }

        private void button_classeAge_Click(object sender, EventArgs e)
        {
            /*string nom = textBox_nom.Text;
            int year = dateTimePicker1.Value.Year;
            int mois = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;
            DateTime date = new DateTime(year, mois, day);
            int age = c.Age(date);*/
            Form4 f = new Form4(patients);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listeAttente1.Items.Clear();
        }

        private void button_renitialiserForm_Click(object sender, EventArgs e)
        {
            textBox_Id.Clear();
            textBox_nom.Clear();
            textBox_prenom.Clear();
            comboBox_Sexe.SelectedIndex = -1;
            comboBox_specialite.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listeAttente1.Items.RemoveAt(listeAttente1.SelectedIndex);
            //c.supprimerPatient(listeAttente1.SelectedIndex);     
        }

        private void button_prioritaire_Click(object sender, EventArgs e)
        {
            Patient pri = c.prioritaire();
            nom = pri.getNom();
            prenom = pri.getPrenom();
            sexe = pri.getSexe();
            spec = pri.getSpecialiteDemandee();
            
            Form2 form2 = new Form2(nom,prenom,sexe,spec);
            form2.ShowDialog();
            
            
            
        }

  
    }
}
