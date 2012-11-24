namespace CodeWizards.Contracts
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Vector
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public static Vector Zero = new Vector(0, 0);
        public static Vector Forward = new Vector(0, 1);
        public static Vector Backward = new Vector(0, -1);
        public static Vector Left = new Vector(-1, 0);
        public static Vector Right = new Vector(1, 0);

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        // TODO: Math
    }
}
