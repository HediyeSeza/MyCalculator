﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculate : ICalculator
    {
        public int divide(int number1, int number2)
        {
           return number1 / number2;
        }

        public int minus(int number1, int number2)
        {
            return number1 - number2;
        }

        public int multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        public int plus(int number1, int number2)
        {
            return number1+ number2;
        }
    }
}
