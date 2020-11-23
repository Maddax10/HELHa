using Examen_MICHON_MAXIMILIEN.Models;
using Examen_MICHON_MAXIMILIEN.Models.Parents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_MICHON_MAXIMILIEN
{
    public partial class AjouterPieceForm : Form
    {
        private Facture Facture;

        private Pièce pièce;

        private string Nom;
        private double Quantité;
        private double PrixALaPièce;

        public AjouterPieceForm()
        {
            InitializeComponent();
        }

        public void SetFactureInstance(Facture facture)
        {
            if (Facture != facture)
            {
                Facture = facture;
            }
        }

        private void AjouterBTN_Click(object sender, EventArgs e)
        {
            Nom = NomTB?.Text.Trim();
            Quantité = double.Parse(QuantitéTB.Text);
            PrixALaPièce = double.Parse(PrixALaPièceTB.Text);
            //double.TryParse(QuantitéTB.Text, out Quantité);
            //double.TryParse(PrixALaPièceTB.Text, out PrixALaPièce);

            if (Nom != String.Empty && Quantité > 0 && PrixALaPièce > 0)
            {
                pièce = new Pièce(Nom, Quantité, PrixALaPièce);

                Opération.ListeOpérations.Add(pièce);

                Facture.AjouterALaListeInformations(pièce.GetDétails());

                ResetFormulaire();

                this.Dispose();

            }
        }

        private void ResetFormulaire()
        {
            NomTB.Text = String.Empty;
            QuantitéTB.Text = String.Empty;
            PrixALaPièceTB.Text = String.Empty;
        }
    }
}
