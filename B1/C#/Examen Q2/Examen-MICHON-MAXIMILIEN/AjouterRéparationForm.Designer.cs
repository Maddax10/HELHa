namespace Examen_MICHON_MAXIMILIEN
{
    partial class AjouterRéparationForm
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
            this.MotifLB = new System.Windows.Forms.Label();
            this.NbHeureLB = new System.Windows.Forms.Label();
            this.NbMinutesLB = new System.Windows.Forms.Label();
            this.PrixALHeureLB = new System.Windows.Forms.Label();
            this.MotifTB = new System.Windows.Forms.TextBox();
            this.NbHeuresTB = new System.Windows.Forms.TextBox();
            this.NbMinutesTB = new System.Windows.Forms.TextBox();
            this.PrixALHeureTB = new System.Windows.Forms.TextBox();
            this.AjouterBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MotifLB
            // 
            this.MotifLB.AutoSize = true;
            this.MotifLB.Location = new System.Drawing.Point(46, 47);
            this.MotifLB.Name = "MotifLB";
            this.MotifLB.Size = new System.Drawing.Size(30, 13);
            this.MotifLB.TabIndex = 0;
            this.MotifLB.Text = "Motif";
            // 
            // NbHeureLB
            // 
            this.NbHeureLB.AutoSize = true;
            this.NbHeureLB.Location = new System.Drawing.Point(46, 87);
            this.NbHeureLB.Name = "NbHeureLB";
            this.NbHeureLB.Size = new System.Drawing.Size(87, 13);
            this.NbHeureLB.TabIndex = 0;
            this.NbHeureLB.Text = "Nombre d\'heures";
            // 
            // NbMinutesLB
            // 
            this.NbMinutesLB.AutoSize = true;
            this.NbMinutesLB.Location = new System.Drawing.Point(46, 127);
            this.NbMinutesLB.Name = "NbMinutesLB";
            this.NbMinutesLB.Size = new System.Drawing.Size(98, 13);
            this.NbMinutesLB.TabIndex = 0;
            this.NbMinutesLB.Text = "Nombre de minutes";
            // 
            // PrixALHeureLB
            // 
            this.PrixALHeureLB.AutoSize = true;
            this.PrixALHeureLB.Location = new System.Drawing.Point(46, 167);
            this.PrixALHeureLB.Name = "PrixALHeureLB";
            this.PrixALHeureLB.Size = new System.Drawing.Size(67, 13);
            this.PrixALHeureLB.TabIndex = 0;
            this.PrixALHeureLB.Text = "Prix à l\'heure";
            // 
            // MotifTB
            // 
            this.MotifTB.Location = new System.Drawing.Point(189, 44);
            this.MotifTB.Name = "MotifTB";
            this.MotifTB.Size = new System.Drawing.Size(366, 20);
            this.MotifTB.TabIndex = 1;
            // 
            // NbHeuresTB
            // 
            this.NbHeuresTB.Location = new System.Drawing.Point(189, 84);
            this.NbHeuresTB.Name = "NbHeuresTB";
            this.NbHeuresTB.Size = new System.Drawing.Size(106, 20);
            this.NbHeuresTB.TabIndex = 2;
            // 
            // NbMinutesTB
            // 
            this.NbMinutesTB.Location = new System.Drawing.Point(189, 124);
            this.NbMinutesTB.Name = "NbMinutesTB";
            this.NbMinutesTB.Size = new System.Drawing.Size(106, 20);
            this.NbMinutesTB.TabIndex = 3;
            // 
            // PrixALHeureTB
            // 
            this.PrixALHeureTB.Location = new System.Drawing.Point(189, 164);
            this.PrixALHeureTB.Name = "PrixALHeureTB";
            this.PrixALHeureTB.Size = new System.Drawing.Size(106, 20);
            this.PrixALHeureTB.TabIndex = 4;
            // 
            // AjouterBTN
            // 
            this.AjouterBTN.Location = new System.Drawing.Point(443, 193);
            this.AjouterBTN.Name = "AjouterBTN";
            this.AjouterBTN.Size = new System.Drawing.Size(112, 43);
            this.AjouterBTN.TabIndex = 5;
            this.AjouterBTN.Text = "Ajouter";
            this.AjouterBTN.UseVisualStyleBackColor = true;
            this.AjouterBTN.Click += new System.EventHandler(this.AjouterBTN_Click);
            // 
            // AjouterRéparationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 248);
            this.Controls.Add(this.AjouterBTN);
            this.Controls.Add(this.PrixALHeureTB);
            this.Controls.Add(this.NbMinutesTB);
            this.Controls.Add(this.NbHeuresTB);
            this.Controls.Add(this.MotifTB);
            this.Controls.Add(this.PrixALHeureLB);
            this.Controls.Add(this.NbMinutesLB);
            this.Controls.Add(this.NbHeureLB);
            this.Controls.Add(this.MotifLB);
            this.MaximumSize = new System.Drawing.Size(587, 287);
            this.MinimumSize = new System.Drawing.Size(587, 287);
            this.Name = "AjouterRéparationForm";
            this.Text = "Ajout d\'une réparation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MotifLB;
        private System.Windows.Forms.Label NbHeureLB;
        private System.Windows.Forms.Label NbMinutesLB;
        private System.Windows.Forms.Label PrixALHeureLB;
        private System.Windows.Forms.TextBox MotifTB;
        private System.Windows.Forms.TextBox NbHeuresTB;
        private System.Windows.Forms.TextBox NbMinutesTB;
        private System.Windows.Forms.TextBox PrixALHeureTB;
        private System.Windows.Forms.Button AjouterBTN;
    }
}