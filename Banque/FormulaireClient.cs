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
    public partial class FormulaireClient : Form
    {
        public FormulaireClient(string nom, string prenom, string adresse)
        {
            InitializeComponent();
            tb1.Text = nom;
            tb2.Text = prenom;
            tb3.Text = adresse;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1
            FormulaireClient.ActiveForm.Close();
        }
    }
}
