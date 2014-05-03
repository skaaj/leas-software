namespace leas_software
{
    partial class GlossaryControl
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.wordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexicalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxAddLevel = new System.Windows.Forms.TextBox();
            this.textBoxAddWord = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxLexical = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordCol,
            this.levelCol,
            this.lexicalCol});
            this.tableLayoutPanel.SetColumnSpan(this.dataGridView, 4);
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(592, 325);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellEnter);
            this.dataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellValidated);
            this.dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            // 
            // wordCol
            // 
            this.wordCol.HeaderText = "Mot";
            this.wordCol.MaxInputLength = 25;
            this.wordCol.Name = "wordCol";
            // 
            // levelCol
            // 
            this.levelCol.HeaderText = "Niveau";
            this.levelCol.Name = "levelCol";
            // 
            // lexicalCol
            // 
            this.lexicalCol.HeaderText = "Champs lexical";
            this.lexicalCol.Name = "lexicalCol";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Controls.Add(this.textBoxAddLevel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxAddWord, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonAdd, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.comboBoxLexical, 2, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(598, 360);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // textBoxAddLevel
            // 
            this.textBoxAddLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddLevel.Location = new System.Drawing.Point(182, 335);
            this.textBoxAddLevel.Name = "textBoxAddLevel";
            this.textBoxAddLevel.Size = new System.Drawing.Size(173, 20);
            this.textBoxAddLevel.TabIndex = 1;
            // 
            // textBoxAddWord
            // 
            this.textBoxAddWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddWord.Location = new System.Drawing.Point(3, 335);
            this.textBoxAddWord.MaxLength = 25;
            this.textBoxAddWord.Name = "textBoxAddWord";
            this.textBoxAddWord.Size = new System.Drawing.Size(173, 20);
            this.textBoxAddWord.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(540, 334);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(55, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.onAdd);
            // 
            // comboBoxLexical
            // 
            this.comboBoxLexical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLexical.FormattingEnabled = true;
            this.comboBoxLexical.Location = new System.Drawing.Point(361, 335);
            this.comboBoxLexical.Name = "comboBoxLexical";
            this.comboBoxLexical.Size = new System.Drawing.Size(173, 21);
            this.comboBoxLexical.TabIndex = 4;
            // 
            // GlossaryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "GlossaryControl";
            this.Size = new System.Drawing.Size(598, 360);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox textBoxAddLevel;
        private System.Windows.Forms.TextBox textBoxAddWord;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxLexical;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexicalCol;

    }
}
