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
        private string sexe;
        private int score;
        private List<String> answers;
        private List<String> other_answers;

        public User(string name, int age, string sexe)
        {
            this.id = 0;
            this.name = name;
            this.age = age;
            this.sexe = sexe;
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
