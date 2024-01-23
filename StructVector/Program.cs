namespace StructVector
{
    internal class Program
    {
        public struct DisplacmentVector
        {
            public int X { get; set; }
            public int Y { get; set; }

            public DisplacmentVector(int initialX, int initialY)
            {
                X = initialX;
                Y = initialY;
            }

            public static DisplacmentVector operator + (
                DisplacmentVector vector1,
                DisplacmentVector vector2)
            {
                return new(
                    vector1.X + vector2.X,
                    vector1.Y + vector2.Y);
            }

        }

        static void Main(string[] args)
        {
            DisplacmentVector dv1 = new(3, 5);
            DisplacmentVector dv2 = new(-2, 7);
            DisplacmentVector dv3 = dv1 + dv2;

            DisplacmentVector dv4 = new();

            Console.WriteLine($"({dv1.X}),({dv1.Y}) + ({dv2.X}),({dv2.Y}) = ({dv3.X}),({dv3.Y})");

            Console.WriteLine($"({dv4.X}),({dv4.Y})");
        }
    }
}
