//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLID
//{
//    public class OCP
//    {
//        public static void Main(string[] args)
//        {
//            int Height;
//            int Width;
//            int Raduis;
//            string Type;
//            int Area;
//            Console.WriteLine("Please Define Your Shape (Rectangle,Circle):");
//            Type = Console.ReadLine();
//            if (Type == "Rectangle")
//            {
//                Console.WriteLine("Please Enter Height");
//                Height = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Please Enter Width");
//                Width = Convert.ToInt32(Console.ReadLine());
//                Area = Height * Width;
//                Console.WriteLine("Area={0}", Area);
//            }
//            else
//            {
//                Console.WriteLine("Please Enter Radius");
//                Raduis = Convert.ToInt32(Console.ReadLine());
//                Area = Convert.ToInt32(Raduis * Raduis * Math.PI);
//                Console.WriteLine("Area={0}", Area);

//            }
//            Console.ReadLine();
//        }
//        public double Area(Shape[]shapes)
//        {
//            double area = 0;
//            foreach (var shape in shapes)
//            {
//                area+=shape.Area();
//            }
//            return area;
//        }
//    }
//    public abstract class Shape
//    {
//        public abstract double Area();
//    }
//    public class Rectangle : Shape
//    {
//        public double Height { get; set; }
//        public double Width { get; set; }

//        public override double Area()
//        {
//            return Height*Width;
//        }
//    }
//    public class Circle : Shape
//    {
//        public double Raduis { get; set; }
//        public double PI = 3.14;
//        public override double Area()
//        {
//            return Raduis*Raduis*Math.PI;
//        }
//    }

//}
