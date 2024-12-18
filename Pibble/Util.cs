﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pibble
{
    static class Util
    {

        //https://stackoverflow.com/questions/3176602/how-to-force-a-number-to-be-in-a-range-in-c
        public static int LimitToRange( this int value, int inclusiveMinimum, int inclusiveMaximum){
            if (value < inclusiveMinimum) { return inclusiveMinimum; }
            if (inclusiveMaximum != -1) {
                if (value > inclusiveMaximum) { return inclusiveMaximum; }
            }        
            return value;

        }

        public static int Distance(int x1, int y1, int x2, int y2) {


            return (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

    }
}
