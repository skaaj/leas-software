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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordCol,
            this.levelCol,
            this.lexicalCol});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(397, 253);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.onRowLeave);
            this.dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.onAddedRow);
            // 
            // wordCol
            // 
            this.wordCol.HeaderText = "Mot";
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
            // GlossaryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Name = "GlossaryControl";
            this.Size = new System.Drawing.Size(397, 253);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexicalCol;

    }
}
