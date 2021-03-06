﻿namespace leas_software
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.acceuilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleSaisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerUneSaisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.container = new System.Windows.Forms.Panel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripLabel();
            this.buttonHelp = new System.Windows.Forms.ToolStripButton();
            this.buttonSaisie = new System.Windows.Forms.ToolStripButton();
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
            this.buttonSaisie,
            this.toolStripLabel1,
            this.buttonHelp,
            this.toolStripButtonRefresh});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(2);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(65, 36);
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
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 40);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(584, 321);
            this.container.TabIndex = 1;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 36);
            this.toolStripLabel1.Text = "Glossaire";
            this.toolStripLabel1.Click += new System.EventHandler(this.onClickGlossary);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(0, 33);
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(35, 36);
            this.buttonHelp.Text = "Aide";
            // 
            // buttonSaisie
            // 
            this.buttonSaisie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonSaisie.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaisie.Image")));
            this.buttonSaisie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSaisie.Name = "buttonSaisie";
            this.buttonSaisie.Size = new System.Drawing.Size(40, 33);
            this.buttonSaisie.Text = "Saisie";
            this.buttonSaisie.ToolTipText = "Accéder à la saisie en cours.";
            this.buttonSaisie.Click += new System.EventHandler(this.onClickSaisie);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.container);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.Text = "LEAS Software ver 0.7";
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
        private System.Windows.Forms.ToolStripButton toolStripLabel1;
        private System.Windows.Forms.ToolStripButton buttonHelp;
        private System.Windows.Forms.ToolStripLabel toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripButton buttonSaisie;

    }
}

