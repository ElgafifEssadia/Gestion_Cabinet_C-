using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10_GestionCabinet
{
    public class Patient
    {
        //Attributs
        private int id;
        private string nom;
        private string prenom;
        private bool sexe;
        private string specialiteDemandee;
        private DateTime dateNaissance;

        //Modificateurs et accesseurs
        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getNom()
        {
            return nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public string getPrenom()
        {
            return prenom;
        }

        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public bool getSexe()
        {
            return sexe;
        }

        public void setSexe(bool sexe)
        {
            this.sexe = sexe;
        }

        public string getSpecialiteDemandee()
        {
            return specialiteDemandee;
        }

        public void setSpecialiteDemandee(string specialiteDemandee)
        {
            this.specialiteDemandee = specialiteDemandee;
        }

        public DateTime getDateNaissance()
        {
            return dateNaissance;
        }

        public void setDateNaissance(DateTime dateNaissance)
        {
            this.dateNaissance = dateNaissance;
        }

        //Constructeur par defaut
        public Patient() 
        {
            this.id = 0;
            this.nom = "alami";
            this.specialiteDemandee = "Cardiologue";
            this.sexe = true;
            this.dateNaissance=new DateTime(2019,4,23);
        }

        //Constructeur avec un seul parametre
        public Patient(int id, string nom) 
        {
            this.id = id;
            this.nom = nom;
        }

        //Constructeur avec parametre
        public Patient(int id, string nom, string prenom, bool sexe, string specialiteDemandee,DateTime dateNaissance)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.specialiteDemandee = specialiteDemandee;
            this.dateNaissance = dateNaissance;
        }

        public Patient(int id, string nom, string prenom, string specialiteDemandee, DateTime dateNaissance)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.specialiteDemandee = specialiteDemandee;
            this.dateNaissance = dateNaissance;
        }

        //Mthode toString()
        public override string ToString()
        {

            return "Patient N° " + id + " Nom : " + nom + " Prenom : " + prenom + " Sexe : " + sexe + " Spécialite Demandée : " + specialiteDemandee+" Date Naissance : "+dateNaissance;
        }



        // Age
        public int age(DateTime DateNaissance)
        {
            DateTime n = DateTime.Now;
            int age = n.Year - DateNaissance.Year;

            if (n.Month < DateNaissance.Month || (n.Month == DateNaissance.Month && n.Day < DateNaissance.Day))
                age--;

            return age;
        }

    }
}
