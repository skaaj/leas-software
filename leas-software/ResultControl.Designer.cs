namespace leas_software
{
    partial class ResultControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.situationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreUserCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreTotalOtherCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.situationCol,
            this.scoreTotalCol,
            this.scoreUserCol,
            this.scoreTotalOtherCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(494, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // situationCol
            // 
            this.situationCol.HeaderText = "Situation";
            this.situationCol.Name = "situationCol";
            this.situationCol.ReadOnly = true;
            // 
            // scoreTotalCol
            // 
            this.scoreTotalCol.HeaderText = "Score Total";
            this.scoreTotalCol.Name = "scoreTotalCol";
            this.scoreTotalCol.ReadOnly = true;
            // 
            // scoreUserCol
            // 
            this.scoreUserCol.HeaderText = "Score total utilisateur";
            this.scoreUserCol.Name = "scoreUserCol";
            this.scoreUserCol.ReadOnly = true;
            // 
            // scoreTotalOtherCol
            // 
            this.scoreTotalOtherCol.HeaderText = "Score total entourage";
            this.scoreTotalOtherCol.Name = "scoreTotalOtherCol";
            this.scoreTotalOtherCol.ReadOnly = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBack.Location = new System.Drawing.Point(3, 310);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(494, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Retourner à la saisie";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.onClickBack);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(3, 284);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(494, 17);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total : ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonBack, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTotal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 336);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ResultControl";
            this.Size = new System.Drawing.Size(500, 336);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn situationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreTotalCol;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreUserCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreTotalOtherCol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
