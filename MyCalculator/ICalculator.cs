﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    internal interface ICalculator
    {
        int plus(int number1, int number2);
        int minus(int number1, int number2);
        int multiple(int number1, int number2); 
        int divide(int number1, int number2);   
    }
}
