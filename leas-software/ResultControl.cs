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
    public partial class ResultControl : UserControl
    {

        private MainForm context;

        public ResultControl()
        {
            InitializeComponent();
        }

        public ResultControl(MainForm context) : this()
        {
            this.context = context;

            int nbSituations = context.Model.getNbSituations();
            for (int i = 0; i < nbSituations; i++)
            {
                Situation s = context.Model.getSituation(i);
                dataGridView1.Rows.Add(s.ID, 0);
            }
        }

        private void onClickBack(object sender, EventArgs e)
        {
            context.SelectSituationControl();
        }

    }
}
