using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10_GestionCabinet
{
    public class Cabinet
    {
        //Attributs
        private string nom;
        private string adresse;
        private List<Patient> patients;
        private List<String> specialites;

        //Modificateurs et accesseurs
        public string getNom()
        {
            return nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public string getAdresse()
        {
            return adresse;
        }

        public void setAdresse(string adresse)
        {
            this.adresse = adresse;
        }

        public List<Patient> getPatients()
        {
            return patients;
        }

        public List<String> getSpecialites()
        {
            return specialites;
        }

        public void setSpecialites(List<String> specialites)
        {
            this.specialites = specialites;
        }

         //Constructeur par defaut
        public Cabinet() 
        {
            this.specialites = new List<string>();
            this.patients = new List<Patient>();
        }

        //Constructeur avec quelques parametre
        public Cabinet(string nom, string adresse)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.specialites = new List<string>();
            this.patients = new List<Patient>();
        }

        //Constructeur avec parametre
        public Cabinet(string nom, string adresse,List<Patient> patients, List<String> specialites)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.patients = patients;
            this.specialites = specialites;
        }

        //Methode chercher par id
        public int ChercherPatient(int id)
        {
            foreach (Patient p in patients)
            {
                if(p.getId() == id)
                {
                    return id;
                }
            
            }
            return -1;
        }

        //Methode chercher par patient
        public int ChercherPatient(Patient p)
        {
            int pos = patients.IndexOf(p);
            return pos;
        }

        //Methode Ajouter
        public void ajouterPatient(Patient p)
        {
            if (ChercherPatient(p.getId()) != -1)
     
            {
                throw new Exception("Ce Patient existe deja");
            }
            else
            {
                patients.Add(p);
            }

        }

        //Methode Supprimer
        public void supprimerPatient(int id)
        {
            int pos = ChercherPatient(id);
            if (pos >= 0)
            {
                patients.RemoveAt(pos);
            }
            else
            {
                throw new Exception("Ce Patient a supprimer n'existe pas");
            }

        }

        public string supprimerPatient(string nom)
        {
            foreach (Patient p in patients)
            {
                if (p.getNom() == nom)
                {
                    return nom;
                }

            }
            return null;
        }
       
        //Methode listePatient par sexe
        public List<Patient> listePatient(bool sexe)
        {
            List<Patient> pats = new List<Patient>();
            foreach (Patient p in patients)
            {
                if (p.getSexe() == sexe)
                {
                    pats.Add(p);
                }
            }
            return pats;

        }

        //Methode listePatient par specialite
        public List<Patient> listePatient(String specialite)
        {
            List<Patient> pats = new List<Patient>();
            foreach (Patient p in patients)
            {
                if (p.getSpecialiteDemandee() == specialite)
                {
                    pats.Add(p);
                }
            }
            return pats;

        }

         //Patient Prioritaire
        public Patient prioritaire()
        {
           
            return patients.Count> 0 ? patients[0] : null; 

        }

       
        public Patient prioritaire(List<string> specialites)
        {

            return patients.Count > 0 ? patients[0] : null;

        }

        //Calculer age
        public int Age(DateTime dateN)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - dateN.Year;
            if (dateN > now.AddYears(-age))
            {
                age--;

            }
            return age;
        }



    }
}
