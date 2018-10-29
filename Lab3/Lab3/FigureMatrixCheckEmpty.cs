using Lab2;

namespace Lab3
{
    class FigureMatrixCheckEmpty : IMatrixCheckEmpty<Figure>
    {
        public Figure getEmptyElement() => null;

        public bool checkEmptyElement(Figure element) => element == null;
        
    }
}