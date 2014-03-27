using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace leas_software
{
    public class Model
    {
        private SQLiteDatabase  database;

        private List<Situation> sList;
        private User            currentUser;

        public Model()
        {
            database = new SQLiteDatabase();
            this.LoadSituations();
        }

        public SQLiteDatabase Database
        {
            get
            {
                return database;
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

        public int AddUser(string name, int age, bool sex)
        {
            int bool_sex = (sex == true) ? 1 : 0;
            database.ExecuteNonQuery(String.Format("insert into patients values (null, '{0}', {1}, {2}, 0)", name, age, bool_sex));

            return database.GetUserID(name, age, sex);
        }
    }
}
