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

        private int rowIndex;
        private int colIndex;
        private string cellValue;

        private enum Column { Word, Score };

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

        private void LoadAnswers(int id)
        {
            List<string> pAnswers = model.CurrentUser.GetAnswersFor(id);
            this.dataGridViewUser.Rows.Clear();

            if (pAnswers != null)
                foreach (string a in pAnswers)
                    this.dataGridViewUser.Rows.Add(a);

            List<string> oAnswers = model.CurrentUser.GetOAnswersFor(id);
            this.dataGridViewOther.Rows.Clear();

            if (oAnswers != null)
                foreach (string a in oAnswers)
                    this.dataGridViewOther.Rows.Add(a);

            List<string> scores = model.CurrentUser.GetScoresFor(id, false);
            List<string> scoresOther = model.CurrentUser.GetScoresFor(id, true);

            if (scores != null)
            {
                for (int i = 0; i < this.dataGridViewUser.Rows.Count - 1; i++)
                {
                    SetScore(i, 1, scores[i], false);
                    SetScore(i, 1, scoresOther[i], true);
                }
            }
        }

        private void SetScore(int row, int col, string score, bool other)
        {
            if (other)
                this.dataGridViewOther.Rows[row].Cells[col].Value = score;
            else
                this.dataGridViewUser.Rows[row].Cells[col].Value = score;
        }

        private void SaveModifications()
        {
            if (dataGridViewUser.Rows.Count > 1) // if there is something to save
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < dataGridViewUser.Rows.Count; i++)
                {
                    object value = dataGridViewUser.Rows[i].Cells[0].Value;
                    if (value != null)
                        builder.Append(value.ToString() + "#");
                }

                string concatened = builder.ToString();
                if (concatened.Length > 1)
                    concatened = concatened.Remove(concatened.Length - 1); // remove the last #

                model.UpdateAnswers(model.getSituation(currentSituation).ID, concatened);
            }

            if (dataGridViewOther.Rows.Count > 1) // if there is something to save
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < dataGridViewOther.Rows.Count; i++)
                {
                    object value = dataGridViewOther.Rows[i].Cells[0].Value;
                    if (value != null)
                        builder.Append(value.ToString() + "#");
                }

                string concatened = builder.ToString();
                if (concatened.Length > 1)
                    concatened = concatened.Remove(concatened.Length - 1); // remove the last #

                model.UpdateOtherAnswers(model.getSituation(currentSituation).ID, concatened);
            }
        }

        private void switchSituation(int index, bool updateNbSituation = true){
            Situation s = model.getSituation(index);

            if (s != null)
            {
                SaveModifications();

                LoadAnswers(s.ID);
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

        private void onCellEnterUser(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            colIndex = e.ColumnIndex;
            //cellValue = dataGridViewUser.Rows[rowIndex].Cells[colIndex].Value.ToString();
        }
    }
}
