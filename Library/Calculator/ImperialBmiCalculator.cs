﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Calculator
{
    public class ImperialBmiCalculator : IBmiCalculator
    {
        public double CalculateBmi(double weight, double height)
        {
            if (weight <= 0)
            {
                throw new ArgumentException("Weight is not a valid number");
            }

            if (height <= 0)
            {
                throw new ArgumentException("Height is not a valid number");
            }

            var bmiResult = weight / Math.Pow(height, 2) * 703;
            return Math.Round(bmiResult, 2);
        }
    }
}
