//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static SOLID.Apple;

//namespace SOLID
//{
//    public class LSP
//    {
//        public static void Main(string[] args)
//        {
//            Fruit fruit = new Orange();
//        Console.WriteLine(fruit.GetColor());
//            fruit = new Apple();
//        Console.WriteLine(fruit.GetColor());
//            Console.ReadLine();
//        }
//}
//    public abstract class Fruit
//    {
//        public abstract string GetColor();    
//    }
//    public class Apple : Fruit
//    {
//        public override string GetColor()
//        {
//            return "Red";
//        }
//        public class Orange : Fruit
//        {
//            public override string GetColor()
//            {
//                return "Orange";
//            }
//        }
//    }
//}
