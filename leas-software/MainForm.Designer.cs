namespace leas_software
{
    partial class MainForm
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.acceuilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleSaisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerUneSaisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.buttonHelp = new System.Windows.Forms.ToolStripLabel();
            this.container = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripLabel1,
            this.buttonHelp});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(584, 40);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceuilToolStripMenuItem,
            this.nouvelleSaisieToolStripMenuItem,
            this.chargerUneSaisieToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(65, 40);
            this.toolStripDropDownButton1.Text = "Fichier";
            // 
            // acceuilToolStripMenuItem
            // 
            this.acceuilToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.acceuilToolStripMenuItem.Name = "acceuilToolStripMenuItem";
            this.acceuilToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.acceuilToolStripMenuItem.Text = "Accueil";
            this.acceuilToolStripMenuItem.Click += new System.EventHandler(this.onClickHome);
            // 
            // nouvelleSaisieToolStripMenuItem
            // 
            this.nouvelleSaisieToolStripMenuItem.Name = "nouvelleSaisieToolStripMenuItem";
            this.nouvelleSaisieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouvelleSaisieToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.nouvelleSaisieToolStripMenuItem.Text = "Nouvelle saisie";
            this.nouvelleSaisieToolStripMenuItem.Click += new System.EventHandler(this.onClickNewUser);
            // 
            // chargerUneSaisieToolStripMenuItem
            // 
            this.chargerUneSaisieToolStripMenuItem.Name = "chargerUneSaisieToolStripMenuItem";
            this.chargerUneSaisieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.chargerUneSaisieToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.chargerUneSaisieToolStripMenuItem.Text = "Charger une saisie";
            this.chargerUneSaisieToolStripMenuItem.Click += new System.EventHandler(this.onClickLoadUser);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.onClickExit);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 40);
            this.toolStripLabel1.Text = "Glossaire";
            this.toolStripLabel1.Click += new System.EventHandler(this.onClickGlossary);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(31, 40);
            this.buttonHelp.Text = "Aide";
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 40);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(584, 321);
            this.container.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.container);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.Text = "LEAS Software ver 0.3";
            this.SizeChanged += new System.EventHandler(this.onSizeChanged);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem acceuilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleSaisieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerUneSaisieToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel buttonHelp;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;

    }
}

