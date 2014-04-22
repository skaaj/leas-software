using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leas_software
{
    public class Word
    {
        private string _label;
        private int _level;
        private string _lexical;

        public Word(string label, int level, string lexical)
        {
            _label = label;
            _level = level;
            _lexical = lexical;
        }

        public string Lexical
        {
            get { return _lexical; }
            set { _lexical = value; }
        }
        
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
    }
}
