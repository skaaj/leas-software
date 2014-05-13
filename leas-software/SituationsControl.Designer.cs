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
            this.wordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelOther = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewOther = new System.Windows.Forms.DataGridView();
            this.wordColOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreColOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonResult = new System.Windows.Forms.Button();
            this.labelTotalUser = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalOther = new System.Windows.Forms.Label();
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
            this.labelSituation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSituation.Location = new System.Drawing.Point(3, 0);
            this.labelSituation.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labelSituation.Name = "labelSituation";
            this.labelSituation.Size = new System.Drawing.Size(642, 15);
            this.labelSituation.TabIndex = 0;
            this.labelSituation.Text = "labelSituation";
            // 
            // buttonNext
            // 
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonNext.Location = new System.Drawing.Point(528, 385);
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
            this.labelNbSituations.Location = new System.Drawing.Point(339, 390);
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
            this.boxCurrentSituation.Location = new System.Drawing.Point(299, 387);
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
            this.labelUserName.Location = new System.Drawing.Point(3, 35);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(333, 13);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "username";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordCol,
            this.scoreCol});
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewUser, 2);
            this.dataGridViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUser.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewUser.Location = new System.Drawing.Point(3, 51);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersVisible = false;
            this.dataGridViewUser.Size = new System.Drawing.Size(333, 300);
            this.dataGridViewUser.TabIndex = 6;
            this.dataGridViewUser.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellEnterUser);
            this.dataGridViewUser.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellValueChanged);
            this.dataGridViewUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            // 
            // wordCol
            // 
            this.wordCol.HeaderText = "Mots";
            this.wordCol.Name = "wordCol";
            // 
            // scoreCol
            // 
            this.scoreCol.FillWeight = 25F;
            this.scoreCol.HeaderText = "Scores";
            this.scoreCol.Name = "scoreCol";
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelOther, 3);
            this.labelOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOther.Location = new System.Drawing.Point(342, 35);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(303, 13);
            this.labelOther.TabIndex = 7;
            this.labelOther.Text = "Entourage";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel.Controls.Add(this.labelSituation, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelUserName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewUser, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelOther, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewOther, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonResult, 4, 4);
            this.tableLayoutPanel.Controls.Add(this.buttonNext, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.labelNbSituations, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.buttonPrevious, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelTotal, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.labelTotalUser, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.labelTotalOther, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.boxCurrentSituation, 1, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.MinimumSize = new System.Drawing.Size(0, 200);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
            this.dataGridViewOther.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordColOther,
            this.scoreColOther});
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewOther, 3);
            this.dataGridViewOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOther.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewOther.Location = new System.Drawing.Point(342, 51);
            this.dataGridViewOther.Name = "dataGridViewOther";
            this.dataGridViewOther.RowHeadersVisible = false;
            this.dataGridViewOther.Size = new System.Drawing.Size(303, 300);
            this.dataGridViewOther.TabIndex = 9;
            this.dataGridViewOther.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellEnterOther);
            this.dataGridViewOther.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellValueChangedOther);
            this.dataGridViewOther.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUpOther);
            // 
            // wordColOther
            // 
            this.wordColOther.HeaderText = "Mots";
            this.wordColOther.Name = "wordColOther";
            // 
            // scoreColOther
            // 
            this.scoreColOther.FillWeight = 25F;
            this.scoreColOther.HeaderText = "Scores";
            this.scoreColOther.Name = "scoreColOther";
            // 
            // buttonResult
            // 
            this.buttonResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonResult.Location = new System.Drawing.Point(588, 385);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(57, 25);
            this.buttonResult.TabIndex = 10;
            this.buttonResult.Text = "Résumé";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.onClickEnd);
            // 
            // labelTotalUser
            // 
            this.labelTotalUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotalUser.AutoSize = true;
            this.labelTotalUser.Location = new System.Drawing.Point(342, 361);
            this.labelTotalUser.Name = "labelTotalUser";
            this.labelTotalUser.Size = new System.Drawing.Size(84, 13);
            this.labelTotalUser.TabIndex = 11;
            this.labelTotalUser.Text = "Total utilisateur :";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(63, 359);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(3, 5, 5, 10);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(79, 13);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total situation :";
            // 
            // labelTotalOther
            // 
            this.labelTotalOther.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotalOther.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelTotalOther, 2);
            this.labelTotalOther.Location = new System.Drawing.Point(528, 361);
            this.labelTotalOther.Name = "labelTotalOther";
            this.labelTotalOther.Size = new System.Drawing.Size(88, 13);
            this.labelTotalOther.TabIndex = 13;
            this.labelTotalOther.Text = "Total entourage :";
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
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalUser;
        private System.Windows.Forms.Label labelTotalOther;

    }
}
