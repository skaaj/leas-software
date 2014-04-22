using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leas_software
{
    public class DatabaseAdapter : SQLiteDatabase
    {
        public DatabaseAdapter(string dbFile) : base(dbFile) {}

        // 
        // USERS
        //

        public DataRowCollection GetPatients()
        {
            return this.Select("select * from patients");
        }

        public int GetUserID(string name, int age, bool sex)
        {
            try
            {
                int db_sex = (sex == true) ? 1 : 0;
                DataTable table = this.GetDataTable(String.Format("select id from patients where name='{0}' AND age='{1}' AND sex='{2}'", name, age, db_sex));
                if (table == null) return 0;
                else return int.Parse(table.Rows[0]["id"].ToString());
            }
            catch (Exception exception)
            {
                PromptException(exception);
            }

            return 0;
        }

        public DataRowCollection GetUserInfos(int id)
        {
            return this.Select(String.Format("select * from patients where id='{0}'", id));
        }

        // 
        // GLOSSARY
        //

        public DataRowCollection GetWords()
        {
            return this.Select("select words.label, words.level, lexicals.label as lexical from words, lexicals where words.fk_lexicals == lexicals.id");
        }

        public DataRowCollection GetWordLabels()
        {
            return this.Select("select words.label from words");
        }

        public DataRowCollection GetLexicals()
        {
            return this.Select("select distinct label from lexicals");
        }

        public string GetLexicalID(string newLexical)
        {
            DataRowCollection results = this.Select(String.Format("select id from lexicals where label = '{0}'", newLexical));

            if (results.Count != 0)
                return results[0]["id"].ToString();
            else
                return null;
        }

        // 
        // SITUATIONS
        //

        public DataRowCollection GetSituations()
        {
            return this.Select("select * from situations");
        }

        //
        // UTILS
        //

        public bool AlreadyExists(string value, string query)
        {
            DataRowCollection results = this.Select(query);
            if (results == null)
                return false;

            bool alreadyExists = false;

            int i = 0;
            while(!alreadyExists && i < results.Count)
                if (results[i++]["value"].ToString().Equals(value))
                    alreadyExists = true;

            return alreadyExists;
        }

        public DataRowCollection Select(string query)
        {
            try
            {
                DataTable table = this.GetDataTable(query);
                return table.Rows;
            }
            catch (Exception exception)
            {
                PromptException(exception);
            }

            return null;
        }

        private void PromptException(Exception exception)
        {
            String error = "The following error has occurred:\n\n";
            error += exception.Message.ToString() + "\n\n";

            MessageBox.Show(error);
        }
    }
}
