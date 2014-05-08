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
    public partial class GlossaryControl : UserControl
    {
        private MainForm context;

        private int rowIndex;
        private int colIndex;
        private string cellValue;

        private enum Column { Word, Level, Lexical };

        private string nullLexical = "Aucun";

        public GlossaryControl(MainForm context)
        {
            InitializeComponent();

            this.context = context;
            this.RefreshData();
        }

        public void RefreshData()
        {
            dataGridView.Rows.Clear();
            foreach (Word word in context.Model.Words)
                dataGridView.Rows.Add(word.Label, word.Level, word.Lexical);

            DataRowCollection lexicals = context.Model.Database.GetLexicals();
            if (lexicals == null) comboBoxLexical.Items.Add(nullLexical);

            comboBoxLexical.Items.Clear();
            foreach (DataRow lexical in lexicals)
                comboBoxLexical.Items.Add(lexical["label"].ToString());

            comboBoxLexical.SelectedItem = nullLexical;
        }

        private void onAdd(object sender, EventArgs e)
        {
            string newWord    = this.textBoxAddWord.Text;
            string newLevel   = this.textBoxAddLevel.Text;
            string newLexical = this.comboBoxLexical.Text;

            if(newWord.Length < 2)
                MessageBox.Show("Le nouveau mot est trop court.");
            else if(!isLevelValid(newLevel))
                MessageBox.Show("Le niveau du mot n'est pas valide.");
            else if (context.Model.WordAlreadyExists(newWord))
                MessageBox.Show("Le nouveau mot existe déjà.");
            else
            {
                //MessageBox.Show("TODO: validation " + newWord + newLevel + newLexical);
                context.Model.AddWord(new Word(newWord, int.Parse(newLevel), newLexical));
                context.NotifySaving();
                RefreshData();
            }
        }

        private bool isLevelValid(string level)
        {
            int levelInt;
            bool parsed = int.TryParse(level, out levelInt);

            if (parsed && levelInt < 5 && levelInt >= 0)
                return true;
            return false;
        }

        private void onCellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            colIndex = e.ColumnIndex;
            cellValue = dataGridView.Rows[rowIndex].Cells[colIndex].Value.ToString();
        }

        private void onCellValidated(object sender, DataGridViewCellEventArgs e)
        {
            object value = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            string newValue = (value != null) ? value.ToString() : String.Empty;

            if (newValue != cellValue)
            {
                switch ((Column)colIndex)
                {
                    case Column.Word:
                        context.Model.UpdateWord(newValue, cellValue);
                        context.NotifySaving();
                        break;
                    case Column.Level:
                        if (isLevelValid(newValue))
                        {
                            context.Model.Database.ExecuteNonQuery(String.Format("update words set level = '{0}' WHERE label = '{1}'", newValue, dataGridView.Rows[rowIndex].Cells[(int)Column.Word].Value.ToString()));
                            context.NotifySaving();
                        }
                        else
                            dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellValue;

                        break;
                    case Column.Lexical:
                        if (newValue == String.Empty){
                            newValue = nullLexical;
                            dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = nullLexical;
                        }

                        context.Model.UpdateLexical(newValue, dataGridView.Rows[rowIndex].Cells[(int)Column.Word].Value.ToString());
                        context.NotifySaving();
                        break;
                    default:
                        MessageBox.Show("Unknown column type");
                        break;
                }
            }
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                string value = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                context.Model.DeleteWord(value);
                context.NotifySaving();
                RefreshData();
            }
        }
    }
}
