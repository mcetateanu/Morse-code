using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_code_learning
{
    class Morse_Code
    {
       


        // Definirea codurilor Morse
        private Morse_Code ( string letter ) 
        {

            int Tone = 800;   // Hz
            int Time = 80;  // msec
            int Dot = Time;
            int Dash = 3 * Time;


            if (letter == "A")
            {
                Console.WriteLine("A ");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "a")
            {
                Console.WriteLine("A ");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "B")
            {
                Console.WriteLine("B");
               
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "b")
            {
                Console.WriteLine("B");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "C")
            {
                Console.WriteLine("C");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "c")
            {
                Console.WriteLine("C");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "D")
            {
                Console.WriteLine("D");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "d")
            {
                Console.WriteLine("D");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "E")
            {
                Console.WriteLine("E");

                Console.Beep(Tone, Dot);
            }
            if (letter == "e")
            {
                Console.WriteLine("E");

                Console.Beep(Tone, Dot);
            }

            if (letter == "F")
            {
                Console.WriteLine("F");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "f")
            {
                Console.WriteLine("F");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "G")
            {
                Console.WriteLine("G");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "g")
            {
                Console.WriteLine("G");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "H")
            {
                Console.WriteLine("H");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "h")
            {
                Console.WriteLine("H");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "I")
            {
                Console.WriteLine("I");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "i")
            {
                Console.WriteLine("I");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "J")
            {
                Console.WriteLine("J");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "j")
            {
                Console.WriteLine("J");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "K")
            {
                Console.WriteLine("K");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "k")
            {
                Console.WriteLine("K");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "L")
            {
                Console.WriteLine("L");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "l")
            {
                Console.WriteLine("L");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "M")
            {
                Console.WriteLine("M");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "m")
            {
                Console.WriteLine("M");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "N")
            {
                Console.WriteLine("N");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "O")
            {
                Console.WriteLine("O");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "o")
            {
                Console.WriteLine("O");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "P")
            {
                Console.WriteLine("P");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "p")
            {
                Console.WriteLine("P");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "Q")
            {
                Console.WriteLine("Q");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "q")
            {
                Console.WriteLine("Q");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "R")
            {
                Console.WriteLine("R");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "r")
            {
                Console.WriteLine("R");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "S")
            {
                Console.WriteLine("S");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "s")
            {
                Console.WriteLine("S");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "T")
            {
                Console.WriteLine("T");

                Console.Beep(Tone, Dash);
            }
            if (letter == "t")
            {
                Console.WriteLine("T");

                Console.Beep(Tone, Dash);
            }
            if (letter == "U")
            {
                Console.WriteLine("U");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "u")
            {
                Console.WriteLine("U");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "V")
            {
                Console.WriteLine("V");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "v")
            {
                Console.WriteLine("V");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "W")
            {
                Console.WriteLine("W");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "w")
            {
                Console.WriteLine("W");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "X")
            {
                Console.WriteLine("X");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "x")
            {
                Console.WriteLine("X");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "Y")
            {
                Console.WriteLine("Y");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "y")
            {
                Console.WriteLine("Y");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "Z")
            {
                Console.WriteLine("Z");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "z")
            {
                Console.WriteLine("Z");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "1")
            {
                Console.WriteLine("1");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "2")
            {
                Console.WriteLine("2");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "3")
            {
                Console.WriteLine("3");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "4")
            {
                Console.WriteLine("4");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "5")
            {
                Console.WriteLine("5");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "6")
            {
                Console.WriteLine("6");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "7")
            {
                Console.WriteLine("7");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "8")
            {
                Console.WriteLine("8");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "9")
            {
                Console.WriteLine("9");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "0")
            {
                Console.WriteLine("0");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == ".")
            {
                Console.WriteLine(".");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == ",")
            {
                Console.WriteLine(",");

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "?")
            {
                Console.WriteLine("?");

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }


        }
    }
}
