using Banque.ihm;
using Banque.metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banque
{
    public partial class Form1 : Form
    {

        List<Compte> lstcpt = new List<Compte>();
        List<Client> lstclt = new List<Client>();

        public Form1()
        {
            InitializeComponent();
        }

        private void créditerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Créditer : ";
            bt.Text = "Valider le crédit";
        }

        private void débiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Débiter : ";
            bt.Text = "Valider le débit";
        }

        private void découvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label.Text = "Découvert autorisé : ";
            bt.Text = "Valider le découvert";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label.Text = "Créditer : ";
            bt.Text = "Valider le crédit";

            //création des Clients
            Client clt1 = new Client(1, "Derieu", "Vincent", "3 rue des grands champs");
            Client clt2 = new Client(2, "Leponge", "Bob", "rue de l'ocean ");
            //création des comptes
            Compte c1 = new Compte(100, clt1);
            Compte c2 = new Compte(101, clt1);
            Compte c3 = new Compte(102, clt2);
            
            Compte c4 = new Compte(200, clt1);
            Compte c5 = new Compte(201, clt1);
            Compte c6 = new Compte(202, clt2);
            
            clt1.ajouterCompte(c1);
            clt1.ajouterCompte(c2);
            clt1.ajouterCompte(c3);

            clt2.ajouterCompte(c4);
            clt2.ajouterCompte(c5);
            clt2.ajouterCompte(c6);

            lstcpt.Add(c1);
            lstcpt.Add(c2);
            lstcpt.Add(c3);
            lstcpt.Add(c4);
            lstcpt.Add(c5);
            lstcpt.Add(c6);

            lb.DataSource = lstcpt;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            try {

                if (tb.Text.Length == 0)//gestion de l'exception empty
                {
                    throw new EmptyException("attention, votre textbox est vide !");
                }

                double nombre;
                if (!double.TryParse(tb.Text,out nombre))//gestion de l'exception type
                {
                    throw new  TypeException("attention, mauvais type !");
                }

                //

                if (bt.Text.Equals("Valider le crédit"))
                {

                    Compte cpt = lb.SelectedItem as Compte;

                    cpt.crediter(Double.Parse(tb.Text));
                    lb.DataSource = null;
                    lb.DataSource = lstcpt;

                }
                if (bt.Text == "Valider le débit")
                {

                    Compte cpt = lb.SelectedItem as Compte;

                    cpt.debiter(Double.Parse(tb.Text));
                    lb.DataSource = null;
                    lb.DataSource = lstcpt;
                }


                /* catch (FormatException ex)
                 {
                     MessageBox.Show("erreur:" + ex.Message);
                 }*/

            
                if (bt.Text == "Valider le découvert")
                {
                    Compte cpt = lb.SelectedItem as Compte;

                    cpt.setDecouvert(Double.Parse(tb.Text));
                    lb.DataSource = null;
                    lb.DataSource = lstcpt;
                
                }


        }

            catch (EmptyException ex)
            {
                MessageBox.Show("erreur : " + ex.Message);
            }

            catch (TypeException ex)
            {
                MessageBox.Show("erreur : " + ex.Message);
            }
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nom, prenom, adresse;
            Compte cpt = lb.SelectedItem as Compte;
            Client proprio = cpt.Propriétaire;
            nom = proprio.Nom;
            prenom = proprio.Prénom;
            adresse = proprio.Adresse;
            FormulaireClient formulaire = new FormulaireClient(nom,prenom,adresse);
            formulaire.Show();
            this.Visible = false;
            
            
        }
    }
}
