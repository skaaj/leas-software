namespace leas_software
{
    partial class SituationsControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSituation = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelNbSituations = new System.Windows.Forms.Label();
            this.boxCurrentSituation = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSituation
            // 
            this.labelSituation.AutoSize = true;
            this.labelSituation.Location = new System.Drawing.Point(4, 4);
            this.labelSituation.Name = "labelSituation";
            this.labelSituation.Size = new System.Drawing.Size(70, 13);
            this.labelSituation.TabIndex = 0;
            this.labelSituation.Text = "labelSituation";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(326, 170);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.onClickNext);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrevious.Location = new System.Drawing.Point(3, 170);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.onClickPrevious);
            // 
            // labelNbSituations
            // 
            this.labelNbSituations.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelNbSituations.AutoSize = true;
            this.labelNbSituations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbSituations.Location = new System.Drawing.Point(200, 176);
            this.labelNbSituations.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelNbSituations.Name = "labelNbSituations";
            this.labelNbSituations.Size = new System.Drawing.Size(37, 13);
            this.labelNbSituations.TabIndex = 3;
            this.labelNbSituations.Text = "/ NaN";
            // 
            // boxCurrentSituation
            // 
            this.boxCurrentSituation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.boxCurrentSituation.Location = new System.Drawing.Point(174, 173);
            this.boxCurrentSituation.Margin = new System.Windows.Forms.Padding(0);
            this.boxCurrentSituation.MaxLength = 2;
            this.boxCurrentSituation.Name = "boxCurrentSituation";
            this.boxCurrentSituation.Size = new System.Drawing.Size(26, 20);
            this.boxCurrentSituation.TabIndex = 4;
            this.boxCurrentSituation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxCurrentSituation.Click += new System.EventHandler(this.onClickBoxNbPage);
            this.boxCurrentSituation.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(348, 4);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(53, 13);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "username";
            // 
            // SituationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.boxCurrentSituation);
            this.Controls.Add(this.labelNbSituations);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelSituation);
            this.Name = "SituationsControl";
            this.Size = new System.Drawing.Size(404, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSituation;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label labelNbSituations;
        private System.Windows.Forms.TextBox boxCurrentSituation;
        private System.Windows.Forms.Label labelUserName;

    }
}
