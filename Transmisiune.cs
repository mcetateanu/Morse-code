﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_code
{
    class Transmisiune
    {
        public int TX;


        public Transmisiune(int termen1)
        {
            if (termen1 > 1) TX = termen1;
        }
    }
}


