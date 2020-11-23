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
    public partial class Facture : Form
    {
        //Je vais utiliser une liste de string que je vais manipuler et affecter à ma listeOpérationListBox
        List<string> ListeInformations = new List<string>();

        private AjouterPieceForm AjouterPieceForm;
        private AjouterRéparationForm AjouterRéparationForm;

        //Variable qui va être utilisé pour afficher le montant total des pièces dans la listeInformations
        private double Total = 0;
        private int SelectedIndex;

        public Facture()
        {
            InitializeComponent();

        }

        private void AjouterRéparationBTN_Click(object sender, EventArgs e)
        {
            //Quand on ferme/ouvre trop vite pour ajouter quelque chose, le garbage collector à pas le temps de venir détruire l'instance donc je regarde si elle est diposed
            if (AjouterRéparationForm == null || AjouterRéparationForm.IsDisposed)
            {
                AjouterRéparationForm = new AjouterRéparationForm();
                //J'envoie l'instance de la Facture pour pouvoir utiliser la méthode "AjouterALaListeInformations()" dans "AjouterPieceForm.cs" et "AjouterRéparationForm.cs"
                AjouterRéparationForm.SetFactureInstance(this);
                AjouterRéparationForm.ShowDialog();
            }
            else
            {
                AjouterRéparationForm.ShowDialog();
            }
        }
        private void AjouterUnePièceBTN_Click(object sender, EventArgs e)
        {
            if (AjouterPieceForm == null || AjouterPieceForm.IsDisposed)
            {
                AjouterPieceForm = new AjouterPieceForm();
                AjouterPieceForm.SetFactureInstance(this);
                AjouterPieceForm.ShowDialog();
            }
            else
            {
                AjouterPieceForm.ShowDialog();
            }
        }
        private void ViderLaListeBTN_Click(object sender, EventArgs e)
        {
            ListeInformations.Clear();
            Opération.ListeOpérations.Clear();

            RefreshListe();

            RefreshTotal();
        }

        private void SupprimerLaSélectionBTN_Click(object sender, EventArgs e)
        {
            SelectedIndex = OpérationListBox.SelectedIndex;

            if (SelectedIndex >= 0)
            {

                Opération.ListeOpérations.RemoveAt(SelectedIndex);

                ListeInformations.RemoveAt(SelectedIndex);

                RefreshListe();

                RefreshTotal();
            }
        }
        private void RefreshListe()
        {
            OpérationListBox.DataSource = null;
            OpérationListBox.DataSource = ListeInformations;
        }
        private void RefreshTotal()
        {
            Total = 0;
            foreach (Opération Opération in Opération.ListeOpérations)
            {
                Total += Opération.GetPrix();
            }

            TotalVLB.Text = Total.ToString() + " euros";
        }
        public void AjouterALaListeInformations(string information)
        {
            ListeInformations.Add(information);

            RefreshListe();
            RefreshTotal();

        }

    }
}
