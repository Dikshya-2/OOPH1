using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1.Codes
{
    enum BoxType
    {
        lilleBox, 
        mellemBox, 
        storbox
    }

    class Box : IComparable<Box>
    {
        public double Højde { get; set; }
        public double Bredde { get; set; }
        public double Længde { get; set; }
        public double Volume { get; set; }
        public BoxType Type { get; set; }

        public Box() { }
        public Box(double højde, double bredde, double længde, BoxType type)
        {
            Højde = højde;
            Bredde = bredde;
            Længde = længde;
            Type = type;
        }

        public override string ToString()
        {
            return $"Volume of Box1 : {GetVolume()}, {Type.ToString()}";
        }

        /// <summary>
        /// height × width × depth = volume
        /// </summary>
        public double GetVolume()
        {
            Volume = Højde * Bredde * Længde;
            return Volume;
        }

        public int CompareTo(Box other)
        {
            // Positive number if the parameter is "less than" the current one,
            // zero if they are equal, and
            // negative number if the parameter is "greater than".
            return this.GetVolume().CompareTo(other.GetVolume());
        }

        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();

            if (b.Type == BoxType.lilleBox && c.Type == BoxType.lilleBox)
                box.Type = BoxType.mellemBox;
            else
                box.Type = BoxType.storbox;
            
            box.Længde = b.Længde + c.Længde;
            box.Bredde = b.Bredde + c.Bredde;
            box.Højde = b.Højde + c.Højde;
            return box;
        }
    }

    class BoxTester
    {
        public void KørBoxOpgave()
        {
            Box Box1 = new Box(5.0, 7.0, 6.0, BoxType.lilleBox);
            Box Box2 = new Box(10.0, 13.0, 12.0, BoxType.mellemBox);
            Box Box3 = new Box();

            Console.WriteLine(Box1.ToString());
            Console.WriteLine(Box2.ToString());


            // Positive number if the parameter is "less than" the current one,
            // zero if they are equal, and
            // negative number if the parameter is "greater than".
            int x = Box2.CompareTo(Box1);

            Box3 = Box1 + Box2;

            Console.WriteLine(Box3.ToString());

            Console.ReadKey();
        }
    }
}
