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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxLexical = new System.Windows.Forms.ComboBox();
            this.textBoxAddLevel = new System.Windows.Forms.TextBox();
            this.textBoxAddWord = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelAddWord = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel.SetColumnSpan(this.dataGridView, 5);
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(592, 296);
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
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.00118F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.3969F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.12071F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.27589F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.20531F));
            this.tableLayoutPanel.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonAdd, 4, 3);
            this.tableLayoutPanel.Controls.Add(this.comboBoxLexical, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxAddLevel, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxAddWord, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxSearch, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelAddWord, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelSearch, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonSearch, 2, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(598, 360);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(526, 334);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(69, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.onAdd);
            // 
            // comboBoxLexical
            // 
            this.comboBoxLexical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLexical.FormattingEnabled = true;
            this.comboBoxLexical.Location = new System.Drawing.Point(411, 335);
            this.comboBoxLexical.Name = "comboBoxLexical";
            this.comboBoxLexical.Size = new System.Drawing.Size(109, 21);
            this.comboBoxLexical.TabIndex = 4;
            // 
            // textBoxAddLevel
            // 
            this.textBoxAddLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddLevel.Location = new System.Drawing.Point(333, 335);
            this.textBoxAddLevel.Name = "textBoxAddLevel";
            this.textBoxAddLevel.Size = new System.Drawing.Size(72, 20);
            this.textBoxAddLevel.TabIndex = 1;
            // 
            // textBoxAddWord
            // 
            this.textBoxAddWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddWord.Location = new System.Drawing.Point(170, 335);
            this.textBoxAddWord.MaxLength = 25;
            this.textBoxAddWord.Name = "textBoxAddWord";
            this.textBoxAddWord.Size = new System.Drawing.Size(157, 20);
            this.textBoxAddWord.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(170, 306);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(157, 20);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeySearch);
            // 
            // labelAddWord
            // 
            this.labelAddWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAddWord.AutoSize = true;
            this.labelAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddWord.Location = new System.Drawing.Point(3, 337);
            this.labelAddWord.Name = "labelAddWord";
            this.labelAddWord.Size = new System.Drawing.Size(124, 17);
            this.labelAddWord.TabIndex = 5;
            this.labelAddWord.Text = "Ajouter un mot :";
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(3, 308);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(161, 17);
            this.labelSearch.TabIndex = 6;
            this.labelSearch.Text = "Rechercher un mot : ";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(333, 305);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(72, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Chercher";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.onClickSearch);
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
        private System.Windows.Forms.Label labelAddWord;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;

    }
}
