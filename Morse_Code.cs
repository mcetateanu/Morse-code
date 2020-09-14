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
        public Morse_Code ( string letter ) 
        {

            int Tone = 800;   // Hz
            int Time = 120;  // msec
            int Dot = Time;
            int Dash = 3 * Time;


            if (letter == "A")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "a")
            {
            

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "B")
            {
           
               
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "b")
            {
              

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "C")
            {
            

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "c")
            {
            

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "D")
            {
               

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "d")
            {
              

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "E")
            {
             
                Console.Beep(Tone, Dot);
            }
            if (letter == "e")
            {
              

                Console.Beep(Tone, Dot);
            }

            if (letter == "F")
            {
               

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "f")
            {
             

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "G")
            {

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "g")
            {
             

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "H")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "h")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "I")
            {

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "i")
            {
               

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "J")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "j")
            {
              

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "K")
            {
              

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "k")
            {
               

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "L")
            {
               

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "l")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "M")
            {
              

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "m")
            {
               

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "N")
            {
             

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "O")
            {
             

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "o")
            {

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "P")
            {

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "p")
            {
               

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "Q")
            {
               

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "q")
            {
               

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "R")
            {
             

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "r")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "S")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "s")
            {
             

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "T")
            {
              

                Console.Beep(Tone, Dash);
            }
            if (letter == "t")
            {
               

                Console.Beep(Tone, Dash);
            }
            if (letter == "U")
            {

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "u")
            {
 

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "V")
            {
       

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "v")
            {
          

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "W")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "w")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "X")
            {

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "x")
            {
              

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "Y")
            {
             

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "y")
            {
               

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "Z")
            {
             

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "z")
            {
              

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "1")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "2")
            {

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "3")
            {
             

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "4")
            {
             

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == "5")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "6")
            {
            

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "7")
            {
             

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "8")
            {
              

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "9")
            {
              

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
            }
            if (letter == "0")
            {
              

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == ".")
            {
              

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }
            if (letter == " , ")
            {
           

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
            }
            if (letter == "?")
            {
   

                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
            }
            if (letter == "=")
            {
                

                Console.Beep(Tone, Dash);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dot);
                Console.Beep(Tone, Dash);
            }


        }
    }
}
