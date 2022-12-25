namespace vector_manipulation
{
    class Position
    {
        private double x, y;
        public Position(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public static double GetDistance(Position a, Position b)
        {
            double output = Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
            return output;
        }
        public static double GetDistance(Vector a)
        {
            return Math.Sqrt(a.value.x * a.value.x + a.value.y * a.value.y);
        }

    }
    class Vector
    {
        public Position? start, end;
        public Position value;
        public Vector(Position start, Position end)
        {
            this.start = start;
            this.end = end;
            value = new Position(end.X - start.X, end.Y - start.Y);

        }
        public Vector(double x1, double y1, double x2, double y2)
        {
            this.start = new Position(x1, y1);
            this.end = new Position(x2, y2);
            value = new Position(end.X - start.X, end.Y - start.Y);
        }
        public Vector(double X, double Y)
        {

            value = new Position(X, Y);

        }
        public static Vector operator +(Vector a, Vector b)
        {
            double X = b.value.X + a.value.X;
            double Y = b.value.Y + a.value.Y;
            return new Vector(X, Y);
        }
        public override string ToString()
        {

            if (start != null && end != null)
            {
                return $"Start({start.X};{start.Y}) End({end.X};{end.Y}) Lenght:{Position.GetDistance(start, end)} Vector({value.X};{value.Y})";
            }
            return $"Lenght:{Position.GetDistance(this)} Vector({value.X};{value.Y})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Position A = new Position(0, 0);
            Position B = new Position(0, 1);
            Vector AB = new Vector(A, B);
            Position C = new Position(2, 2);
            Position D = new Position(2, 3);
            Vector CD = new Vector(C, D);
            Console.WriteLine(AB.ToString());
            Console.WriteLine(CD.ToString());
            Console.WriteLine((AB + CD).ToString());
        }
    }
}