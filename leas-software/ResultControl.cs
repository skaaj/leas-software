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
        private int sum;

        public ResultControl()
        {
            InitializeComponent();
        }

        public ResultControl(MainForm context) : this()
        {
            this.context = context;
        }

        public void RefreshGrid()
        {
            dataGridView1.Rows.Clear();
            sum = 0;
            int sumu = 0;
            int sumo = 0;
            int nbSituations = context.Model.getNbSituations();
            for (int i = 0; i < nbSituations; i++)
            {
                Situation s = context.Model.getSituation(i);
                string situationBrief = getSituationBrief(s.Text);
                int utotal = context.Model.CurrentUser.GetUserTotalFor(s.ID);
                int ototal = context.Model.CurrentUser.GetOtherTotalFor(s.ID);
                int total = context.Model.CurrentUser.GetTotalFor(utotal, ototal);
                sum += total;
                sumu += utotal;
                sumo += ototal;
                dataGridView1.Rows.Add(s.ID + ". " + situationBrief, total, utotal, ototal);
            }
            labelTotal.Text = "Score total : " + sum + " | Score utilisateur : " + sumu + " | Score entourage : " + sumo;
        }

        private string getSituationBrief(string text)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(text.Substring(0, 20));
            builder.Append("...");
            return builder.ToString();
        }

        private void onClickBack(object sender, EventArgs e)
        {
            context.SelectSituationControl();
        }
    }
}
