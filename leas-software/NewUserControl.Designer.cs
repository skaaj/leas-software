namespace leas_software
{
    partial class NewUserControl
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.boxUserName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.labelSex = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(5, 7);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(35, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Nom :";
            // 
            // boxUserName
            // 
            this.boxUserName.Location = new System.Drawing.Point(46, 4);
            this.boxUserName.Name = "boxUserName";
            this.boxUserName.Size = new System.Drawing.Size(163, 20);
            this.boxUserName.TabIndex = 1;
            this.boxUserName.Leave += new System.EventHandler(this.onLeave);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(8, 32);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age :";
            // 
            // numericAge
            // 
            this.numericAge.Location = new System.Drawing.Point(46, 30);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(163, 20);
            this.numericAge.TabIndex = 3;
            this.numericAge.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericAge.Click += new System.EventHandler(this.onClickAge);
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(8, 59);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(37, 13);
            this.labelSex.TabIndex = 4;
            this.labelSex.Text = "Sexe :";
            this.labelSex.Leave += new System.EventHandler(this.onLeave);
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.comboBoxSex.Location = new System.Drawing.Point(46, 56);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(163, 21);
            this.comboBoxSex.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(11, 96);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(198, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Commencer la saisie";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.onSubmit);
            // 
            // NewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.numericAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.boxUserName);
            this.Controls.Add(this.labelUserName);
            this.Name = "NewUserControl";
            this.Size = new System.Drawing.Size(361, 313);
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox boxUserName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Button buttonSubmit;
    }
}
