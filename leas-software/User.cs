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

        public int GetTotalFor(int scoreUser, int scoreOther)
        {
            int score = 0;

            if (scoreUser == scoreOther && scoreUser == 4)
                score = 5;
            else if (scoreOther >= scoreUser)
                score = scoreOther;
            else if (scoreOther < scoreUser)
                score = scoreUser;

            return score;
        }

        public int GetUserTotalFor(int id)
        {
            if (!answers.ContainsKey(id)) return 0;

            List<Answer> al = answers[id];
            int score = 0;
            int nbLevel3 = 0;
            foreach (Answer a in al)
            {
                if (a.AType != 1)
                {
                    if (a.Score == 3)
                        nbLevel3++;
                    if (a.Score > score)
                        score = a.Score;
                    if (nbLevel3 >= 2)
                        score = 4;
                }
            }

            return score;
        }


        public int GetOtherTotalFor(int id)
        {
            if (!answers.ContainsKey(id)) return 0;

            List<Answer> al = answers[id];
            int score = 0;
            int nbLevel3 = 0;
            foreach (Answer a in al)
            {
                if (a.AType == 1)
                {
                    if (a.Score == 3)
                        nbLevel3++;
                    if (a.Score > score)
                        score = a.Score;
                    if (nbLevel3 >= 2)
                        score = 4;
                }
            }

            return score;
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
