using System.Collections;
using System.Collections.Generic;

namespace EnigmaMachine {
    internal class Program {
        static void Main(string[] args) {
            Rotor I = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", 'Q');
            Rotor II = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", 'E');
            Rotor III = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", 'V');
            Rotor IV = new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", 'J');
            Rotor V = new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", 'Z');

            Reflector A = new Reflector("EJMZALYXVBWFCRQUONTSPIKHGD");
            Reflector B = new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
            Reflector C = new Reflector("FVPJIAOYEDRZXWGCTKUQSBNMHL");

            Keyboard keyboard = new Keyboard();

            Plugboard plugboard = new Plugboard(new List<List<char>> {
                new List<char>() { 'A', 'R' },
                new List<char>() { 'G', 'K' },
                new List<char>() { 'O', 'X' }
            });

            
            char letter = 'A';
            int signal = keyboard.Forward(letter);
            signal = plugboard.Forward(signal);
            signal = III.Forward(signal);
            signal = II.Forward(signal);
            signal = I.Forward(signal);
            signal = A.Reflect(signal);
            signal = I.Backward(signal);
            signal = II.Backward(signal);
            signal = III.Backward(signal);
            signal = plugboard.Backward(signal);
            letter = keyboard.Backward(signal);
            

            I.Render();
            I.RotateToLetter('G');
            I.Render();
        }
    }
}