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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserControl));
            this.labelUserName = new System.Windows.Forms.Label();
            this.boxUserName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.labelSex = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Location = new System.Drawing.Point(3, 32);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(35, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Nom :";
            // 
            // boxUserName
            // 
            this.boxUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxUserName.Location = new System.Drawing.Point(120, 29);
            this.boxUserName.MaxLength = 24;
            this.boxUserName.Name = "boxUserName";
            this.boxUserName.Size = new System.Drawing.Size(163, 20);
            this.boxUserName.TabIndex = 1;
            this.boxUserName.Click += new System.EventHandler(this.onClickName);
            this.boxUserName.Enter += new System.EventHandler(this.onEnter);
            this.boxUserName.Leave += new System.EventHandler(this.onLeave);
            // 
            // labelAge
            // 
            this.labelAge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.Color.Transparent;
            this.labelAge.Location = new System.Drawing.Point(3, 110);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age :";
            // 
            // numericAge
            // 
            this.numericAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(185)))), ((int)(((byte)(249)))));
            this.numericAge.Location = new System.Drawing.Point(120, 107);
            this.numericAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericAge.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
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
            this.labelSex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSex.AutoSize = true;
            this.labelSex.BackColor = System.Drawing.Color.Transparent;
            this.labelSex.Location = new System.Drawing.Point(3, 188);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(37, 13);
            this.labelSex.TabIndex = 4;
            this.labelSex.Text = "Sexe :";
            this.labelSex.Leave += new System.EventHandler(this.onLeave);
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSex.AutoCompleteCustomSource.AddRange(new string[] {
            "Homme",
            "Femme"});
            this.comboBoxSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxSex.BackColor = System.Drawing.Color.White;
            this.comboBoxSex.DropDownHeight = 60;
            this.comboBoxSex.DropDownWidth = 120;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.IntegralHeight = false;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.comboBoxSex.Location = new System.Drawing.Point(120, 184);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(163, 21);
            this.comboBoxSex.TabIndex = 5;
            this.comboBoxSex.Text = "Homme";
            this.comboBoxSex.Validated += new System.EventHandler(this.onValidated);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSubmit.Location = new System.Drawing.Point(103, 262);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(198, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Commencer la saisie";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.onSubmit);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonSubmit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.boxUserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAge, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericAge, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSex, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(361, 313);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // NewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewUserControl";
            this.Size = new System.Drawing.Size(361, 313);
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox boxUserName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
