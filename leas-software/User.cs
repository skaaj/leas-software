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
        private Dictionary<int, List<Answer>> answers;

        public User()
        {
            this.score = 0;
            this.answers = new Dictionary<int, List<Answer>>();
        }

        public User(int id, string name, int age, bool sex) : this()
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public Dictionary<int, List<Answer>> Answers
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

        public List<Answer> GetAnswersFor(int id)
        {
            if (!answers.ContainsKey(id))
                answers.Add(id, new List<Answer>());

            return answers[id];
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
