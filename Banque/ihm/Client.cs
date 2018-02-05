using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.ihm
{
    public class Client
    {
        private int num;
        private string nom, prenom;
        private string adresse;
        private List<Compte> comptes = new List<Compte>();

        public Client(int num, string nom, string prenom, string ad)
        {
            this.num = num;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = ad;
        }

        public int Numero
        {
            get { return num; }
        }

        public string Nom
        {
            get { return nom; }
        }

        public string Prénom
        {
            get { return prenom; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public void ajouterCompte(Compte c)
        {
            this.comptes.Add(c);
        }

        public override string ToString()
        {
          /*  string recap = "", cpts = "", client = "";
            foreach (Compte c in comptes)
            {
                client = "Comptes du client " + this.nom + " :";
                cpts += " -Num : " + c.Numero;
            }
            recap = client + " " + cpts;*/
            return this.nom;
        }

        public string description()
        {
            string recap = "", cpts = "", client = "";
            foreach (Compte c in comptes)
            {
                client = "Comptes du client " + this.nom + " :";
                cpts += " -Num : " + c.Numero;
            }
            recap = client + " " + cpts; 
            return recap;
        }

        public string afficherCompte()
        {
            string recap = "", cpts = "", client = "";
            foreach (Compte c in comptes)
            {
                client = "Comptes du client " + this.nom + " :";
                cpts += " -Num : " + c.Numero;
            }
            recap = client + " " + cpts;
            return recap;
        }
    }
}
