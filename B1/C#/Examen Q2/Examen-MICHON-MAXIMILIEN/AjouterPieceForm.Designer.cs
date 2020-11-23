namespace Examen_MICHON_MAXIMILIEN
{
    partial class AjouterPieceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomLB = new System.Windows.Forms.Label();
            this.QuantitéLB = new System.Windows.Forms.Label();
            this.PrixALaPièceLB = new System.Windows.Forms.Label();
            this.NomTB = new System.Windows.Forms.TextBox();
            this.QuantitéTB = new System.Windows.Forms.TextBox();
            this.PrixALaPièceTB = new System.Windows.Forms.TextBox();
            this.AjouterBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomLB
            // 
            this.NomLB.AutoSize = true;
            this.NomLB.Location = new System.Drawing.Point(35, 39);
            this.NomLB.Name = "NomLB";
            this.NomLB.Size = new System.Drawing.Size(29, 13);
            this.NomLB.TabIndex = 0;
            this.NomLB.Text = "Nom";
            // 
            // QuantitéLB
            // 
            this.QuantitéLB.AutoSize = true;
            this.QuantitéLB.Location = new System.Drawing.Point(35, 79);
            this.QuantitéLB.Name = "QuantitéLB";
            this.QuantitéLB.Size = new System.Drawing.Size(47, 13);
            this.QuantitéLB.TabIndex = 0;
            this.QuantitéLB.Text = "Quantité";
            // 
            // PrixALaPièceLB
            // 
            this.PrixALaPièceLB.AutoSize = true;
            this.PrixALaPièceLB.Location = new System.Drawing.Point(35, 119);
            this.PrixALaPièceLB.Name = "PrixALaPièceLB";
            this.PrixALaPièceLB.Size = new System.Drawing.Size(73, 13);
            this.PrixALaPièceLB.TabIndex = 0;
            this.PrixALaPièceLB.Text = "Prix à la pièce";
            // 
            // NomTB
            // 
            this.NomTB.Location = new System.Drawing.Point(145, 39);
            this.NomTB.Name = "NomTB";
            this.NomTB.Size = new System.Drawing.Size(361, 20);
            this.NomTB.TabIndex = 1;
            // 
            // QuantitéTB
            // 
            this.QuantitéTB.Location = new System.Drawing.Point(145, 76);
            this.QuantitéTB.Name = "QuantitéTB";
            this.QuantitéTB.Size = new System.Drawing.Size(105, 20);
            this.QuantitéTB.TabIndex = 2;
            // 
            // PrixALaPièceTB
            // 
            this.PrixALaPièceTB.Location = new System.Drawing.Point(145, 116);
            this.PrixALaPièceTB.Name = "PrixALaPièceTB";
            this.PrixALaPièceTB.Size = new System.Drawing.Size(105, 20);
            this.PrixALaPièceTB.TabIndex = 3;
            // 
            // AjouterBTN
            // 
            this.AjouterBTN.Location = new System.Drawing.Point(388, 139);
            this.AjouterBTN.Name = "AjouterBTN";
            this.AjouterBTN.Size = new System.Drawing.Size(133, 45);
            this.AjouterBTN.TabIndex = 4;
            this.AjouterBTN.Text = "Ajouter";
            this.AjouterBTN.UseVisualStyleBackColor = true;
            this.AjouterBTN.Click += new System.EventHandler(this.AjouterBTN_Click);
            // 
            // AjouterPieceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 196);
            this.Controls.Add(this.AjouterBTN);
            this.Controls.Add(this.PrixALaPièceTB);
            this.Controls.Add(this.QuantitéTB);
            this.Controls.Add(this.NomTB);
            this.Controls.Add(this.PrixALaPièceLB);
            this.Controls.Add(this.QuantitéLB);
            this.Controls.Add(this.NomLB);
            this.MaximumSize = new System.Drawing.Size(549, 235);
            this.MinimumSize = new System.Drawing.Size(549, 235);
            this.Name = "AjouterPieceForm";
            this.Text = "Ajout d\'une pièce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomLB;
        private System.Windows.Forms.Label QuantitéLB;
        private System.Windows.Forms.Label PrixALaPièceLB;
        private System.Windows.Forms.TextBox NomTB;
        private System.Windows.Forms.TextBox QuantitéTB;
        private System.Windows.Forms.TextBox PrixALaPièceTB;
        private System.Windows.Forms.Button AjouterBTN;
    }
}