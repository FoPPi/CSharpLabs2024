namespace CSharpLabs2024.Task2
{
    public class Figure
    {
        private readonly Point[] _points;

        public Figure(Point A, Point B)
        {
            _points = new Point[2] { A, B };
        }

        public Figure(Point A, Point B, Point C)
        {
            _points = new Point[3] { A, B, C };
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            _points = new Point[4] { A, B, C, D };
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            _points = new Point[5] { A, B, C, D, E };
        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < _points.Length - 1; i++)
            {
                perimeter += LengthSide(_points[i], _points[i + 1]);
            }
            perimeter += LengthSide(_points[_points.Length - 1], _points[0]);

            Console.WriteLine($"Периметр {_points.Length}-кутника: {perimeter}");
        }
    }
}
