using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leas_software
{
    public partial class SituationsControl : UserControl
    {
        private Model model;

        private int currentSituation;
        private bool fireEvent;
        public SituationsControl(MainForm context)
        {
            InitializeComponent();

            this.model = context.Model;
            this.currentSituation = 0;
            switchSituation(currentSituation);
            this.labelUserName.Text = model.CurrentUser.Name;
        }

        private void switchSituation(int index){
            Situation s = model.getSituation(index);

            if (s != null)
            {
                this.labelSituation.Text = s.Text;
                currentSituation = index;

                refreshUI();
            }
        }

        private void refreshUI()
        {
            int nbSituation = currentSituation + 1;
            fireEvent = false;
            this.boxCurrentSituation.Text = nbSituation.ToString();
            fireEvent = true;
            this.labelNbSituations.Text = string.Concat("/ ", model.getNbSituations());
        }

        private void onTextChanged(object sender, EventArgs e)
        {
            if (!fireEvent)
                return;

            int index;
            if (int.TryParse(this.boxCurrentSituation.Text, out index))
                switchSituation(index - 1);
        }

        private void onClickNext(object sender, EventArgs e)
        {
            switchSituation(currentSituation + 1);
        }

        private void onClickPrevious(object sender, EventArgs e)
        {
            switchSituation(currentSituation - 1);
        }

        private void onClickBoxNbPage(object sender, EventArgs e)
        {
            this.boxCurrentSituation.SelectAll();
        }
    }
}
