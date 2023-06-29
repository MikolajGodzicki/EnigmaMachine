using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine {
    internal class Rotor {
        public string left, right;
        char notch;
        public Rotor(string wiring, char notch) {
            left = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            right = wiring;
            this.notch = notch;
        }

        public void Render() {
            Console.WriteLine(left);
            Console.WriteLine(right);
            Console.WriteLine();
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

        public void Rotate(int n = 0) {
            for (int i = 0; i < n; i++) {
                left = left.Substring(1) + left[0];
                right = right.Substring(1) + right[0];
            }
        }

        public void RotateToLetter(char letter) {
            int n = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(letter);
            Rotate(n);
        }
    }
}
