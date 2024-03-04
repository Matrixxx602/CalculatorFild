using Obliczanie_pół_i_objętości_figur.Models;

namespace Obliczanie_pol_i_objetosci_figur
{
    internal static class FigureField
    {
        internal static double CalculateCircle()
        {
            var r = UserInputHelper.GetValue("Podaj promien okręgu: ");

            var circle = new Circle(r);
            return circle.CalculateGeometricFigureField();
        }

        internal static double CalculateSquare()
        {
            var side1 = UserInputHelper.GetValue("Podaj bok kwadratu");

            var square = new Square(side1);
            return square.CalculateGeometricFigureField();
        }

        internal static double CalculateRectangle(out bool isSquare)
        {
            var side1 = UserInputHelper.GetValue("Podaj pierwszy bok prostokata: ");
            var side2 = UserInputHelper.GetValue("Podaj drugi bok prostokata: ");

            var rectangle = new Rectangle(side1, side2);

            isSquare = rectangle.IsSquare;

            return rectangle.CalculateGeometricFigureField();
        }

        internal static double CalculateTriangle()
        {
            var side1 = UserInputHelper.GetValue("Podaj dlugosc podstawy trojkata: ");
            var height = UserInputHelper.GetValue("Podaj wysokosc trojkata: ");

            var triangle = new Triangle(side1, height);
            return triangle.CalculateGeometricFigureField();
        }
    }
}
