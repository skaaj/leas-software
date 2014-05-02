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
        private int score;
        private Dictionary<int, String> answers;
        private Dictionary<int, String> other_answers;

        public User()
        {
            this.score = 0;
            this.answers = new Dictionary<int, String>();
            this.other_answers = new Dictionary<int, String>();
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
