using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obliczanie_pół_i_objętości_figur.Models
{
    internal class Rectangle : GeometricFigure
    {
        private double _side1;
        private double _side2;
        public bool IsSquare
        {
            get; 
        }



        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
            IsSquare = side1 == side2;
        }

        public override double CalculateGeometricFigureField()
        {
            return _side1 * _side2;
        }

        
    }
}
