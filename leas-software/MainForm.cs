using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leas_software
{
    public partial class MainForm : Form
    {

        private List<Situation> sList;
        private int currentSituation;
        private int nbSituations;

        public MainForm()
        {
            InitializeComponent();
            InitializePanels();
            LoadSituations();
        }

        /* Init */
        private void InitializePanels()
        {
            panelSaisie.Controls.Add(situationLabel);
        }

        private void LoadSituations()
        {
            sList = new List<Situation>();
            sList.Add(new Situation(0, "Vous vous tapez le doigt devant votre voisin."));
            sList.Add(new Situation(1, "Vous êtes dans le désert mais vous n'avez plus d'eau dans votre gourde."));
            sList.Add(new Situation(2, "Vous avez oublié l'anniversaire de votre conjoint(e)."));

            nbSituations = sList.Count;
            goToSituation(0);
        }

        private void refreshUI()
        {
            if (currentSituation == 0)
                prevButton.Enabled = false;
            else
                prevButton.Enabled = true;

            if (currentSituation == nbSituations - 1)
                nextButton.Enabled = false;
            else
                nextButton.Enabled = true;

            situationLabel.Text = sList[currentSituation].Text;
        }

        private bool goToSituation(int id)
        {
            if (nbSituations > 0 && id < nbSituations && id >= 0)
            {
                currentSituation = id;

                refreshUI();
                
                return true;
            }
            
            Console.WriteLine("Error : unable to change current situation.");
            return false;
        }

        /* Events handling */
        private void onNextButtonClick(object sender, EventArgs e)
        {
            goToSituation(currentSituation + 1);
        }

        private void onPrevButtonClick(object sender, EventArgs e)
        {
            goToSituation(currentSituation - 1);
        }
    }
}
