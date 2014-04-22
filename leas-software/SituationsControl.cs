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

        public SituationsControl(MainForm context)
        {
            InitializeComponent();

            this.model = context.Model;

            // Situations
            this.currentSituation = 0;
            switchSituation(currentSituation);

            // User
            this.labelUserName.Text = model.CurrentUser.Name;
        }

        private void switchSituation(int index, bool updateNbSituation = true){
            Situation s = model.getSituation(index);

            if (s != null)
            {
                this.labelSituation.Text = s.Text;
                currentSituation = index;

                refreshUI(updateNbSituation);
            }
        }

        private void refreshUI(bool updateNbSituation = true)
        {
            if (updateNbSituation)
            {
                int nbSituation = currentSituation + 1;
                this.boxCurrentSituation.Text = nbSituation.ToString();
            }

            this.labelNbSituations.Text = string.Concat("/ ", model.getNbSituations());
        }

        private void onTextChanged(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(this.boxCurrentSituation.Text, out index))
                switchSituation(index - 1, false);
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

        private void onResize(object sender, EventArgs e)
        {
            TableLayoutPanel table = this.tableLayoutPanel;
            table.SetBounds(table.Left, table.Top, table.Width, this.buttonNext.Top - table.Top);
        }
    }
}
