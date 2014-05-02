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
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.labelOther = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewOther = new System.Windows.Forms.DataGridView();
            this.buttonResult = new System.Windows.Forms.Button();
            this.wordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordColOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreColOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOther)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSituation
            // 
            this.labelSituation.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelSituation, 5);
            this.labelSituation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSituation.Location = new System.Drawing.Point(3, 0);
            this.labelSituation.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labelSituation.Name = "labelSituation";
            this.labelSituation.Size = new System.Drawing.Size(642, 13);
            this.labelSituation.TabIndex = 0;
            this.labelSituation.Text = "labelSituation";
            // 
            // buttonNext
            // 
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonNext.Location = new System.Drawing.Point(529, 385);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(54, 25);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.onClickNext);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPrevious.Location = new System.Drawing.Point(3, 385);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(54, 25);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.onClickPrevious);
            // 
            // labelNbSituations
            // 
            this.labelNbSituations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNbSituations.AutoSize = true;
            this.labelNbSituations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbSituations.Location = new System.Drawing.Point(340, 390);
            this.labelNbSituations.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelNbSituations.Name = "labelNbSituations";
            this.labelNbSituations.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.labelNbSituations.Size = new System.Drawing.Size(37, 15);
            this.labelNbSituations.TabIndex = 3;
            this.labelNbSituations.Text = "/ NaN";
            // 
            // boxCurrentSituation
            // 
            this.boxCurrentSituation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.boxCurrentSituation.Location = new System.Drawing.Point(300, 387);
            this.boxCurrentSituation.Margin = new System.Windows.Forms.Padding(0);
            this.boxCurrentSituation.MaxLength = 2;
            this.boxCurrentSituation.Name = "boxCurrentSituation";
            this.boxCurrentSituation.Size = new System.Drawing.Size(40, 20);
            this.boxCurrentSituation.TabIndex = 4;
            this.boxCurrentSituation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxCurrentSituation.Click += new System.EventHandler(this.onClickBoxNbPage);
            this.boxCurrentSituation.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelUserName, 2);
            this.labelUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(3, 33);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(334, 13);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "username";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.ColumnHeadersVisible = false;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordCol,
            this.scoreCol});
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewUser, 2);
            this.dataGridViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUser.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewUser.Location = new System.Drawing.Point(3, 49);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersVisible = false;
            this.dataGridViewUser.Size = new System.Drawing.Size(334, 330);
            this.dataGridViewUser.TabIndex = 6;
            this.dataGridViewUser.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellEnterUser);
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelOther, 3);
            this.labelOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOther.Location = new System.Drawing.Point(343, 33);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(302, 13);
            this.labelOther.TabIndex = 7;
            this.labelOther.Text = "Autre";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel.Controls.Add(this.labelSituation, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonNext, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.labelNbSituations, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.boxCurrentSituation, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.labelUserName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonPrevious, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewUser, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelOther, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewOther, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonResult, 4, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.MinimumSize = new System.Drawing.Size(0, 200);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(648, 413);
            this.tableLayoutPanel.TabIndex = 9;
            // 
            // dataGridViewOther
            // 
            this.dataGridViewOther.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOther.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOther.ColumnHeadersVisible = false;
            this.dataGridViewOther.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordColOther,
            this.scoreColOther});
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewOther, 3);
            this.dataGridViewOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOther.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewOther.Location = new System.Drawing.Point(343, 49);
            this.dataGridViewOther.Name = "dataGridViewOther";
            this.dataGridViewOther.RowHeadersVisible = false;
            this.dataGridViewOther.Size = new System.Drawing.Size(302, 330);
            this.dataGridViewOther.TabIndex = 9;
            // 
            // buttonResult
            // 
            this.buttonResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResult.Location = new System.Drawing.Point(589, 385);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(56, 25);
            this.buttonResult.TabIndex = 10;
            this.buttonResult.Text = "Fin";
            this.buttonResult.UseVisualStyleBackColor = true;
            // 
            // wordCol
            // 
            this.wordCol.HeaderText = "";
            this.wordCol.Name = "wordCol";
            // 
            // scoreCol
            // 
            this.scoreCol.FillWeight = 25F;
            this.scoreCol.HeaderText = "";
            this.scoreCol.Name = "scoreCol";
            // 
            // wordColOther
            // 
            this.wordColOther.HeaderText = "";
            this.wordColOther.Name = "wordColOther";
            // 
            // scoreColOther
            // 
            this.scoreColOther.FillWeight = 25F;
            this.scoreColOther.HeaderText = "";
            this.scoreColOther.Name = "scoreColOther";
            // 
            // SituationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "SituationsControl";
            this.Size = new System.Drawing.Size(648, 413);
            this.Resize += new System.EventHandler(this.onResize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOther)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSituation;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label labelNbSituations;
        private System.Windows.Forms.TextBox boxCurrentSituation;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridView dataGridViewOther;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordColOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreColOther;

    }
}
