namespace Lab2
{
    class Rectangle: Figure
    {
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        
        public double width { get; set; }
        public double length { get; set; }
        
        public override double area()
        {
            return length * width;
        }
        
        public override string ToString()
        {
            return "Длина прямоугольника = "+length+"; Ширина прямоугольника = "+width+"; Площадь = "+area();
        }
    }
}