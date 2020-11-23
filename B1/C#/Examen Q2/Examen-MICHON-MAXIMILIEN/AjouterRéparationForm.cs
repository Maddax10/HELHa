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
    public partial class AjouterRéparationForm : Form
    {
        //Les fenêtre ne sont pas redimensionnable
        private Facture Facture;
        private Réparation réparation;

        private string Motif;
        private int NbHeures;
        private int NbMinutes;
        private double PrixALHeure;

        public AjouterRéparationForm()
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
            Motif = MotifTB?.Text.Trim();
            NbHeures = int.Parse(NbHeuresTB.Text);
            NbMinutes = int.Parse(NbMinutesTB.Text);
            PrixALHeure = double.Parse(PrixALHeureTB.Text);
            //int.TryParse(NbHeuresTB.Text, out NbHeures);
            //int.TryParse(NbMinutesTB.Text, out NbMinutes);
            //double.TryParse(PrixALHeureTB.Text, out PrixALHeure);

            if (Motif != String.Empty && ((NbHeures > 0 && NbMinutes >= 0) || (NbHeures == 0 && NbMinutes > 0)) && PrixALHeure > 0)
            {
                réparation = new Réparation(Motif, NbHeures, NbMinutes, PrixALHeure);

                Opération.ListeOpérations.Add(réparation);

                Facture.AjouterALaListeInformations(réparation.GetDétails());

                ResetFormulaire();

                this.Dispose();

            }
        }

        private void ResetFormulaire()
        {
            MotifTB.Text = String.Empty;
            NbHeuresTB.Text = String.Empty;
            NbMinutesTB.Text = String.Empty;
            PrixALHeureTB.Text = String.Empty;
        }
    }
}
