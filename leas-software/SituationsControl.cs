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
        private MainForm context;

        private int currentSituation;
        private int situationID;

        private int rowIndex;
        private int colIndex;
        private string cellValue;
        private bool lastRow;

        private enum Column { Word, Score };

        public SituationsControl(MainForm context)
        {
            InitializeComponent();

            this.context = context;
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
                situationID = s.ID;

                refreshGrids();

                this.labelSituation.Text = s.Text;
                currentSituation = index;

                refreshUI(updateNbSituation);
            }
        }

        private void refreshGrids()
        {
            dataGridViewOther.Rows.Clear();
            dataGridViewUser.Rows.Clear();
            foreach (Answer a in model.CurrentUser.GetAnswersFor(situationID))
            {
                int type = a.AType;
                switch (a.AType)
                {
                    case 1:
                        dataGridViewOther.Rows.Add(a.Word, a.Score);
                        break;
                    default:
                        dataGridViewUser.Rows.Add(a.Word, a.Score);
                        break;
                }
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

        private void ScoreChanged(int row, int col, bool other)
        {
            string associatedWord = (other) ? GetCellValueOther(row, col - 1) : GetCellValueUser(row, col - 1);
            string newScore = (other) ? GetCellValueOther(row, col) : GetCellValueUser(row, col);

            model.UpdateAnswerScore(situationID, int.Parse(newScore), associatedWord);
            context.NotifySaving();
        }

        private void WordChanged(string newWord, string oldWord, bool other)
        {
            model.UpdateAnswerWord(situationID, newWord, oldWord);
            context.NotifySaving();
        }

        private string GetCellValueUser(int row, int col)
        {
            object value = dataGridViewUser.Rows[row].Cells[col].Value;

            return (value == null) ? String.Empty : value.ToString();
        }

        private string GetCellValueOther(int row, int col)
        {
            object value = dataGridViewOther.Rows[row].Cells[col].Value;

            return (value == null) ? String.Empty : value.ToString();
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

        private int ComputeScore(string word)
        {
            return new Random().Next() % 4;
        }

        private void onCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string newValue = GetCellValueUser(e.RowIndex, e.ColumnIndex);

            if (lastRow)
            {
                int score = ComputeScore(newValue);
                model.AddAnswer(situationID, newValue, score, 0);
                refreshGrids();
                context.NotifySaving();
            }
            else if (newValue != cellValue)
            {
                switch ((Column)colIndex)
                {
                    case Column.Word:
                        WordChanged(newValue, cellValue, false);
                        break;
                    case Column.Score:
                        ScoreChanged(e.RowIndex, e.ColumnIndex, false);
                        break;
                    default:
                        MessageBox.Show("Unknown column type");
                        break;
                }
            }
        }

        private void onCellValueChangedOther(object sender, DataGridViewCellEventArgs e)
        {
            string newValue = GetCellValueOther(e.RowIndex, e.ColumnIndex);

            if (lastRow)
            {
                int score = ComputeScore(newValue);
                model.AddAnswer(situationID, newValue, score, 1);
                refreshGrids();
                context.NotifySaving();
            }
            else if (newValue != cellValue)
            {
                switch ((Column)colIndex)
                {
                    case Column.Word:
                        WordChanged(newValue, cellValue, true);
                        break;
                    case Column.Score:
                        ScoreChanged(e.RowIndex, e.ColumnIndex, true);
                        break;
                    default:
                        MessageBox.Show("Unknown column type");
                        break;
                }
            }
        }

        private void onCellEnterUser(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            colIndex = e.ColumnIndex;
            cellValue = GetCellValueUser(e.RowIndex, e.ColumnIndex);

            lastRow = (e.RowIndex == dataGridViewUser.RowCount - 1) ? true : false;
        }

        private void onCellEnterOther(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            colIndex = e.ColumnIndex;
            cellValue = GetCellValueOther(e.RowIndex, e.ColumnIndex);

            lastRow = (e.RowIndex == dataGridViewOther.RowCount - 1) ? true : false;
        }

        private void onClickEnd(object sender, EventArgs e)
        {
            context.SelectResultControl();
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                string word = GetCellValueUser(rowIndex, colIndex);
                model.DeleteAnswer(situationID, model.CurrentUser.ID, word, 0);
                refreshGrids();
                context.NotifySaving();
            }
        }

        private void onKeyUpOther(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                string word = GetCellValueOther(rowIndex, colIndex);
                model.DeleteAnswer(situationID, model.CurrentUser.ID, word, 1);
                refreshGrids();
                context.NotifySaving();
            }
        }
    }
}
