namespace kitesurf
{
    partial class Frm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            this.tbxPoid = new System.Windows.Forms.TextBox();
            this.lblTxtPoids = new System.Windows.Forms.Label();
            this.lblTxtAile = new System.Windows.Forms.Label();
            this.tbxAiles = new System.Windows.Forms.TextBox();
            this.lblTxtVent = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.tmrResertDonnee = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nudPoids = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoids)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxPoid
            // 
            this.tbxPoid.Location = new System.Drawing.Point(12, 290);
            this.tbxPoid.Name = "tbxPoid";
            this.tbxPoid.ReadOnly = true;
            this.tbxPoid.Size = new System.Drawing.Size(75, 20);
            this.tbxPoid.TabIndex = 0;
            // 
            // lblTxtPoids
            // 
            this.lblTxtPoids.AutoSize = true;
            this.lblTxtPoids.Location = new System.Drawing.Point(12, 19);
            this.lblTxtPoids.Name = "lblTxtPoids";
            this.lblTxtPoids.Size = new System.Drawing.Size(66, 13);
            this.lblTxtPoids.TabIndex = 1;
            this.lblTxtPoids.Text = "Votre poids :";
            // 
            // lblTxtAile
            // 
            this.lblTxtAile.AutoSize = true;
            this.lblTxtAile.Location = new System.Drawing.Point(33, 114);
            this.lblTxtAile.Name = "lblTxtAile";
            this.lblTxtAile.Size = new System.Drawing.Size(150, 13);
            this.lblTxtAile.TabIndex = 2;
            this.lblTxtAile.Text = "Tailles d\'ailes recommandées :";
            // 
            // tbxAiles
            // 
            this.tbxAiles.Location = new System.Drawing.Point(426, 85);
            this.tbxAiles.Multiline = true;
            this.tbxAiles.Name = "tbxAiles";
            this.tbxAiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxAiles.Size = new System.Drawing.Size(362, 59);
            this.tbxAiles.TabIndex = 3;
            // 
            // lblTxtVent
            // 
            this.lblTxtVent.Location = new System.Drawing.Point(12, 263);
            this.lblTxtVent.Name = "lblTxtVent";
            this.lblTxtVent.Size = new System.Drawing.Size(100, 14);
            this.lblTxtVent.TabIndex = 6;
            this.lblTxtVent.Text = "Vitesse Vent :";
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualiser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualiser.BackgroundImage")));
            this.btnActualiser.ForeColor = System.Drawing.Color.White;
            this.btnActualiser.Location = new System.Drawing.Point(659, 45);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(129, 34);
            this.btnActualiser.TabIndex = 7;
            this.btnActualiser.Text = "Actualiser les données";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // tmrResertDonnee
            // 
            this.tmrResertDonnee.Enabled = true;
            this.tmrResertDonnee.Interval = 600000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // nudPoids
            // 
            this.nudPoids.Location = new System.Drawing.Point(84, 19);
            this.nudPoids.Name = "nudPoids";
            this.nudPoids.Size = new System.Drawing.Size(120, 20);
            this.nudPoids.TabIndex = 9;
            this.nudPoids.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.nudPoids.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPoids_KeyPress);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudPoids);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.lblTxtVent);
            this.Controls.Add(this.tbxAiles);
            this.Controls.Add(this.lblTxtAile);
            this.Controls.Add(this.lblTxtPoids);
            this.Controls.Add(this.tbxPoid);
            this.Name = "Frm1";
            this.Text = "KiteSurf";
            this.Load += new System.EventHandler(this.Frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPoids)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPoid;
        private System.Windows.Forms.Label lblTxtPoids;
        private System.Windows.Forms.Label lblTxtAile;
        private System.Windows.Forms.TextBox tbxAiles;
        private System.Windows.Forms.Label lblTxtVent;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Timer tmrResertDonnee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPoids;
    }
}

