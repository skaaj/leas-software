using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leas_software
{
    public class Situation
    {
        private int    id;
        private string label;

        public Situation(int id, string label)
        {
            this.id = id;
            this.label = label;
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Text
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
            }
        }
    }
}
