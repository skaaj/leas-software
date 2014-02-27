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
        private List<String> answers;
        private List<String> other_answers;

        public User(int id, string name, int age, bool sex)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.score = 0;
            this.answers = new List<String>();
            this.other_answers = new List<String>();
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
