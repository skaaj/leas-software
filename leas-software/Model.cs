using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace leas_software
{
    public class Model
    {
        private DatabaseAdapter database;

        private List<Situation> sList;
        private List<Word>      wList;
        private User            currentUser;

        public Model()
        {
            database = new DatabaseAdapter("../../leas_db.s3db;UseUTF8Encoding=True;");
            this.LoadSituations();
            this.LoadWords();
        }

        public DatabaseAdapter Database
        {
            get
            {
                return database;
            }
        }

        public List<Word> Words
        {
            get
            {
                return wList;
            }
        }

        public List<String> Lexicals
        {
            get
            {
                List<String> lexicals = new List<string>();
                foreach (Word w in wList)
                    lexicals.Add(w.Lexical);

                return lexicals;
            }
        }

        /* Situations */
        private void LoadSituations()
        {
            sList = new List<Situation>();

            DataRowCollection situations = database.GetSituations();
            if (situations == null) return;

            foreach (DataRow situation in situations)
            {
                sList.Add(new Situation(int.Parse(situation["id"].ToString()), situation["label"].ToString()));
            }
        }

        private void LoadAnswers()
        {
            DataRowCollection answers = database.GetAnswers();
            if (answers == null) return;

            foreach (DataRow answer in answers)
            {
                currentUser.Answers.Add(int.Parse(answer["id_situation"].ToString()), answer["p_answers"].ToString());
                currentUser.OtherAnswers.Add(int.Parse(answer["id_situation"].ToString()), answer["o_answers"].ToString());
                currentUser.Scores.Add(int.Parse(answer["id_situation"].ToString()), answer["scores"].ToString());
            }
        }

        public void UpdateAnswers(int id, string answers)
        {
            database.ExecuteNonQuery(String.Format("update answers set p_answers = '{0}' WHERE id_patient = {1} AND id_situation = {2}", answers, currentUser.ID, id));

            currentUser.Answers[id] = answers;
        }

        public void UpdateOtherAnswers(int id, string answers)
        {
            database.ExecuteNonQuery(String.Format("update answers set o_answers = '{0}' WHERE id_patient = {1} AND id_situation = {2}", answers, currentUser.ID, id));

            currentUser.OtherAnswers[id] = answers;
        }

        public Situation getSituation(int index)
        {
            if (index < 0 || index >= sList.Count)
                return null;

            return sList[index];
        }

        public int getNbSituations()
        {
            return sList.Count;
        }

        /* Words */
        private void LoadWords()
        {
            wList = new List<Word>();

            DataRowCollection words = database.GetWords();
            if (words == null) return;

            foreach (DataRow word in words)
            {
                string label = word["label"].ToString();
                string level = word["level"].ToString();
                string lexical = word["lexical"].ToString();

                wList.Add(new Word(label, int.Parse(level), lexical));
            }
        }

        public Word getWord(int index)
        {
            if (index < 0 || index >= wList.Count)
                return null;

            return wList[index];
        }

        public void AddWord(Word word)
        {
            string lexicalID = database.GetLexicalID(word.Lexical);

            if (lexicalID == null)
                lexicalID = AddLexical(word.Lexical);

            database.ExecuteNonQuery(String.Format("insert into words values (null, '{0}', {1}, {2})", word.Label, word.Level, lexicalID));
            wList.Add(word);
        }

        public int UpdateWord(string newWord, string oldWord)
        {
            int updated = 0;
            if (!WordAlreadyExists(newWord))
            {
                updated = database.ExecuteNonQuery(String.Format("update words set label = '{0}' WHERE label = '{1}'", newWord, oldWord));

                if (updated == 0)
                    return updated;

                int i = 0;
                while (i < wList.Count)
                {
                    if (wList[i].Label == oldWord)
                    {
                        wList[i].Label = newWord;
                        i = wList.Count;
                    }

                    i++;
                }
            }

            return updated;
        }

        public int UpdateLevel(string level, string word)
        {
            int updated = 0;

            updated = database.ExecuteNonQuery(String.Format("update words set level = '{0}' WHERE label = '{1}'", level, word));
            
            if (updated == 0)
                return updated;

            int i = 0;
            while (i < wList.Count)
            {
                if (wList[i].Label == word)
                {
                    wList[i].Level = int.Parse(level);
                    i = wList.Count;
                }

                i++;
            }

            return updated;
        }

        public int UpdateLexical(string newLexical, string word)
        {
            int updated = 0;
            string lexicalID = database.GetLexicalID(newLexical);

            if (lexicalID == null)
                lexicalID = AddLexical(newLexical);

            updated = database.ExecuteNonQuery(String.Format("update words set fk_lexicals = {0} WHERE label = '{1}'", lexicalID, word));
            
            if (updated == 0)
                return updated;

            int i = 0;
            while (i < wList.Count)
            {
                if (wList[i].Label == word)
                {
                    wList[i].Lexical = newLexical;
                    i = wList.Count;
                }

                i++;
            }

            return updated;
        }

        private string AddLexical(string lexical)
        {
            database.ExecuteNonQuery(String.Format("insert into lexicals values (null, '{0}')", lexical));
            
            return database.GetLexicalID(lexical);
        }

        public bool WordAlreadyExists(string word)
        {
            int i = 0;
            while (i < wList.Count)
                if (wList[i++].Label == word)
                    return true;

            return false;
        }

        /* User */
        public void SetCurrentUser(int id)
        {
            DataRowCollection db_results = database.GetUserInfos(id);
            if (db_results.Count > 0)
            {
                string name = db_results[0]["name"].ToString();
                int age = int.Parse(db_results[0]["age"].ToString());
                bool sex = (db_results[0]["sex"].ToString() == "True") ? true : false;
                currentUser = new User(id, name, age, sex);
                this.LoadAnswers();
            }
            else
            {
                MessageBox.Show("Impossible de charger la saisie.");
                currentUser = new User(0, "Bug", 0, true);
            }
        }

        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
        }

        public int AddUser(string name, int age, bool sex, int category)
        {
            int bool_sex = (sex == true) ? 1 : 0;
            database.ExecuteNonQuery(String.Format("insert into patients values (null, '{0}', {1}, {2}, {3})", name, age, bool_sex, category));

            return database.GetUserID(name, age, sex);
        }
    }
}
