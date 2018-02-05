using Banque.metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banque.ihm
{
    public class Compte
    {
        private int num;
        private Client proprio;
        private double solde;
        private double decouvert;


        public Compte()
        {

        }

        public Compte(int n, Client c)
        {
            num = n;
            Solde = 0;
            proprio = c;
            this.proprio.ajouterCompte(this);
        }


        public int Numero
        {
            get
            {
                return num;
            }
        }

        public string Description
        {
            get
            {
                return num + " " + proprio.Nom + " " + Solde + "euro";
            }
        }

        public Client Propriétaire
        {
            get
            {
                return proprio;
            }
        }

        public double Decouvert
        {
            get
            {
                return decouvert;
            }
        }

        public double Solde
        {
            get
            {
                return solde;
            }

            set
            {
                solde = value;
            }
        }

        public void crediter(double mont)
        {
            Solde = Solde + mont;
        }

        public bool debiter(double mont)
        {
                try
                {

                    if (Solde - mont < -Decouvert)
                    {
                        throw new LessException("Attention, découvert non autorisé");
                        
                    }

                    else
                    {
                        Solde = Solde - mont;
                        return true;
                    }
                }
                catch (LessException ex)
            {
                MessageBox.Show("erreur : " + ex.Message);
                return false;
            }

        }

        public bool setDecouvert(double value)
        {
            bool res = false;
            try
            {
            
            if (this.Solde < -value)
            {
                    throw new LessException("Attention, modification du découvert non autorisé");
                    

                }else {
                    decouvert = value;
                    res = true;
                }
            }
            catch (LessException ex)
            {
                MessageBox.Show("erreur : " + ex.Message);
                return res;
            }
            return res;
        }

        public override string ToString()
        {
            string recap = "- Numero : "+this.num+" - Propriétaire : "+this.proprio+" - Solde : "+this.solde;

            return recap;
        }
    }
}
