using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilateral
{


    abstract class Quadrilateral
    {
        public int length { get; set; }

        public Quadrilateral()
        {

        }

        public Quadrilateral(int len)
        {
            length = len;
        }

        public abstract int Area();
    }




    class Square : Quadrilateral
    {
        public Square()
        {

        }

        public Square(int len):base(len)
        {

        }

        public override int Area()
        {
            
            return length*length;
        }
    }




    class Rectangle : Quadrilateral
    {


        public int breadth { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(int len, int br) : base(len)
        {
            breadth = br;
        }

        public override int Area()
        {
            
            return length * breadth;
        }

        bool _IsSquare;

        public bool IsSquare
        {
            get
            {
                return _IsSquare;
            }

            set
            {

                if (length == breadth)
                {
                    _IsSquare = value;
                }
               
            }
        }
    }




    class Program
    {
        

        static void Main(string[] args)
        {

            Rectangle rec = new Rectangle(5,6);
            Console.WriteLine($"area of rectangle {rec.Area()}");
            
            Square sq = new Square(4);
            Console.WriteLine($"area of square is {sq.Area()}");

            int _rec = rec.Area();
            int _sq = rec.Area();

            if (_rec >= _sq)
            {
                Console.WriteLine("Rectangle area is greater than Square area");
            }
            else {
                Console.WriteLine("Square area is greater than Rectangle area");
            }

            Console.WriteLine($"Rectangle is a Square : {rec.IsSquare}");

        }
    }
}
