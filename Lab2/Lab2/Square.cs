namespace Lab2
{
    class Square: Rectangle
    {        
        public Square(double length) : base(length, length) {}

        public override string ToString()
        {
            return "Сторона квадрата = "+length+"; Площадь = "+area();
        }
    }
}