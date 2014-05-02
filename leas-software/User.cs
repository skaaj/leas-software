using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leas_software
{
    public class User
    {
        private int id;
        private string name;
        private int age;
        private bool sex;
        private Dictionary<int, String> answers;
        private Dictionary<int, String> other_answers;
        private Dictionary<int, String> scores;

        public User()
        {
            this.answers = new Dictionary<int, String>();
            this.other_answers = new Dictionary<int, String>();
            this.scores = new Dictionary<int, String>();
        }

        public User(int id, string name, int age, bool sex) : this()
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public List<string> GetAnswersFor(int id)
        {
            string result;

            if (answers.TryGetValue(id, out result))
            {
                List<string> output = new List<string>();
                foreach (string a in result.Split('#'))
                    output.Add(a);
                return output;
            }

            return null;
        }

        public List<string> GetScoresFor(int id, bool other)
        {
            string result;

            if (scores.TryGetValue(id, out result))
            {
                List<string> output = new List<string>();

                string[] firstSplit = result.Split('@');
                string[] secondSplit;
                
                if(other)
                    secondSplit = firstSplit[1].Split('#');
                else
                    secondSplit = firstSplit[0].Split('#');

                foreach (var s in secondSplit)
                    output.Add(s);

                return output;
            }

            return null;
        }

        public List<string> GetOAnswersFor(int id)
        {
            string result;

            if (other_answers.TryGetValue(id, out result))
            {
                List<string> output = new List<string>();
                foreach (string a in result.Split('#'))
                    output.Add(a);
                return output;
            }

            return null;
        }

        public Dictionary<int, String> Answers
        {
            get
            {
                return answers;
            }
            set
            {
                answers = value;
            }
        }

        public Dictionary<int, String> OtherAnswers
        {
            get
            {
                return other_answers;
            }
            set
            {
                other_answers = value;
            }
        }

        public Dictionary<int, String> Scores
        {
            get
            {
                return scores;
            }
            set
            {
                scores = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
        }
    }
}
