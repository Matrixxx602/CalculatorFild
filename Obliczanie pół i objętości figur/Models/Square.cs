using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFieldApp.Models
{
    public class Square : GeometricFigure
    {
        private double _side1;
        public Square(double side1)
        {
            _side1 = side1;
        }

        public override double CalculateGeometricFigureField()
        {
            return _side1 * _side1;
        }
    }
}
