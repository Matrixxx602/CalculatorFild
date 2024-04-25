using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFieldApp.Models
{
    public class Triangle : GeometricFigure
    {
        private double _side1;
        private double _height;
        public Triangle(double side1, double height)
        {
            _side1 = side1;
            _height = height;
        }

        public override double CalculateGeometricFigureField()
        {
            return _side1 * _height;
        }
    }
}
