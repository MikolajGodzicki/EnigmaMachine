using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine {
    internal class Plugboard {
        public string left, right;

        public Plugboard(IEnumerable<IEnumerable<char>> pairs) {
            left = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            right = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach (IEnumerable<char> pair in pairs) { 
                char A = pair.ElementAt(0);
                char B = pair.ElementAt(1);
                int posA = left.IndexOf(A);
                int posB = right.IndexOf(B);
                left = left.Substring(0, posA) + B + left.Substring(posA + 1);
                left = left.Substring(0, posB) + A + left.Substring(posB + 1);
            }
        }

        public int Forward(int index) {
            char letter = right[index];
            index = left.IndexOf(letter);
            return index;
        }

        public int Backward(int index) {
            char letter = left[index];
            index = right.IndexOf(letter);
            return index;
        }
    }
}
 