using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace leas_software
{
    public class Model
    {
        private List<Situation> sList;
        private User currentUser;
        private SQLiteDatabase database;

        public Model()
        {
            database = new SQLiteDatabase();
            this.LoadSituations();
        }

        private void LoadSituations()
        {
            sList = new List<Situation>();

            try
            {
                DataTable db_situations = database.GetDataTable("select * from situations");

                foreach (DataRow r in db_situations.Rows)
                {
                    sList.Add(new Situation(int.Parse(r["id"].ToString()), r["label"].ToString()));
                }
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
            }
        }

        public Situation getSituation(int index)
        {
            if (index < 0 || index >= sList.Count)
                return null;

            return sList[index];
        }

        public void setCurrentUser(string nom, int age, string sexe)
        {
            currentUser = new User(nom, age, sexe);
        }

        public int getNbSituations()
        {
            return sList.Count;
        }

        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
        }

        internal void addUser(string name, int age, string sex)
        {
            int bool_sex = (sex == "Homme") ? 1 : 0;
            database.ExecuteNonQuery(String.Format("insert into patients values (null, '{0}', {1}, {2})", name, age, bool_sex));
        }
    }
}
