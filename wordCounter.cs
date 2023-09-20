using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountAppNB
{
    internal class wordCounter
    {
        public string word { get; set; }
        public int frequency { get; set; } 
        

        public wordCounter(String word, int frequency) {
            this.word = word;
            this.frequency = frequency;
        }

    }
}
