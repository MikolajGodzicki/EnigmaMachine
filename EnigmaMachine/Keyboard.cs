using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine {
    internal class Keyboard {
        public const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public int Forward(char letter) {
            int index = Alphabet.IndexOf(letter);
            return index;
        }

        public char Backward(int index) { 
            char letter = Alphabet[index];
            return letter;
        }
    }
}
