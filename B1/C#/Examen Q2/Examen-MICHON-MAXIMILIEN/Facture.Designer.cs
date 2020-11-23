namespace Examen_MICHON_MAXIMILIEN
{
    partial class Facture
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpérationListBox = new System.Windows.Forms.ListBox();
            this.TotalLB = new System.Windows.Forms.Label();
            this.TotalVLB = new System.Windows.Forms.Label();
            this.AjouterRéparationBTN = new System.Windows.Forms.Button();
            this.AjouterUnePièceBTN = new System.Windows.Forms.Button();
            this.SupprimerLaSélectionBTN = new System.Windows.Forms.Button();
            this.ViderLaListeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpérationListBox
            // 
            this.OpérationListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpérationListBox.FormattingEnabled = true;
            this.OpérationListBox.Location = new System.Drawing.Point(26, 12);
            this.OpérationListBox.Name = "OpérationListBox";
            this.OpérationListBox.Size = new System.Drawing.Size(323, 316);
            this.OpérationListBox.TabIndex = 0;
            // 
            // TotalLB
            // 
            this.TotalLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalLB.AutoSize = true;
            this.TotalLB.Location = new System.Drawing.Point(23, 355);
            this.TotalLB.Name = "TotalLB";
            this.TotalLB.Size = new System.Drawing.Size(43, 13);
            this.TotalLB.TabIndex = 1;
            this.TotalLB.Text = "Totale :";
            // 
            // TotalVLB
            // 
            this.TotalVLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalVLB.AutoSize = true;
            this.TotalVLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVLB.Location = new System.Drawing.Point(300, 355);
            this.TotalVLB.Name = "TotalVLB";
            this.TotalVLB.Size = new System.Drawing.Size(49, 13);
            this.TotalVLB.TabIndex = 1;
            this.TotalVLB.Text = "0 euros";
            // 
            // AjouterRéparationBTN
            // 
            this.AjouterRéparationBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AjouterRéparationBTN.Location = new System.Drawing.Point(374, 28);
            this.AjouterRéparationBTN.Name = "AjouterRéparationBTN";
            this.AjouterRéparationBTN.Size = new System.Drawing.Size(193, 42);
            this.AjouterRéparationBTN.TabIndex = 2;
            this.AjouterRéparationBTN.Text = "Ajouter une réparation";
            this.AjouterRéparationBTN.UseVisualStyleBackColor = true;
            this.AjouterRéparationBTN.Click += new System.EventHandler(this.AjouterRéparationBTN_Click);
            // 
            // AjouterUnePièceBTN
            // 
            this.AjouterUnePièceBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AjouterUnePièceBTN.Location = new System.Drawing.Point(374, 76);
            this.AjouterUnePièceBTN.Name = "AjouterUnePièceBTN";
            this.AjouterUnePièceBTN.Size = new System.Drawing.Size(193, 42);
            this.AjouterUnePièceBTN.TabIndex = 2;
            this.AjouterUnePièceBTN.Text = "Ajouter une pièce";
            this.AjouterUnePièceBTN.UseVisualStyleBackColor = true;
            this.AjouterUnePièceBTN.Click += new System.EventHandler(this.AjouterUnePièceBTN_Click);
            // 
            // SupprimerLaSélectionBTN
            // 
            this.SupprimerLaSélectionBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SupprimerLaSélectionBTN.Location = new System.Drawing.Point(374, 209);
            this.SupprimerLaSélectionBTN.Name = "SupprimerLaSélectionBTN";
            this.SupprimerLaSélectionBTN.Size = new System.Drawing.Size(193, 42);
            this.SupprimerLaSélectionBTN.TabIndex = 2;
            this.SupprimerLaSélectionBTN.Text = "Supprimer la sélection";
            this.SupprimerLaSélectionBTN.UseVisualStyleBackColor = true;
            this.SupprimerLaSélectionBTN.Click += new System.EventHandler(this.SupprimerLaSélectionBTN_Click);
            // 
            // ViderLaListeBTN
            // 
            this.ViderLaListeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViderLaListeBTN.Location = new System.Drawing.Point(374, 259);
            this.ViderLaListeBTN.Name = "ViderLaListeBTN";
            this.ViderLaListeBTN.Size = new System.Drawing.Size(193, 42);
            this.ViderLaListeBTN.TabIndex = 2;
            this.ViderLaListeBTN.Text = "Vider la liste";
            this.ViderLaListeBTN.UseVisualStyleBackColor = true;
            this.ViderLaListeBTN.Click += new System.EventHandler(this.ViderLaListeBTN_Click);
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 391);
            this.Controls.Add(this.ViderLaListeBTN);
            this.Controls.Add(this.SupprimerLaSélectionBTN);
            this.Controls.Add(this.AjouterUnePièceBTN);
            this.Controls.Add(this.AjouterRéparationBTN);
            this.Controls.Add(this.TotalVLB);
            this.Controls.Add(this.TotalLB);
            this.Controls.Add(this.OpérationListBox);
            this.Name = "Facture";
            this.Text = "Facture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OpérationListBox;
        private System.Windows.Forms.Label TotalLB;
        private System.Windows.Forms.Label TotalVLB;
        private System.Windows.Forms.Button AjouterRéparationBTN;
        private System.Windows.Forms.Button AjouterUnePièceBTN;
        private System.Windows.Forms.Button SupprimerLaSélectionBTN;
        private System.Windows.Forms.Button ViderLaListeBTN;
    }
}
