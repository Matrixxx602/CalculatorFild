﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFieldApp.Models
{
    public class Circle : GeometricFigure
    {
        private const double Pi = Math.PI;
        private double _r;
        public Circle(double r)
        {
            _r = r;
        }

        public override double CalculateGeometricFigureField()
        {
            return Pi * _r * _r;
        }
    }
}
