using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine {
    internal class Reflector {
        public string left, right;
        public Reflector(string wiring) {
            left = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            right = wiring;
        }

        public int Reflect(int index) {
            char letter = right[index];
            index = left.IndexOf(letter);
            return index;
        }
    }
}
