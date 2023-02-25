//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SOLID
//{
//    public class SPR
//    {
//        public static void Main(string[] args)
//        {
//            DiscountCalculator discountCalculator = new DiscountCalculator();
//            Console.WriteLine("Discount:{0}", discountCalculator.CalculateDiscount(1000, "Chrismath"));
//            PaymentCalculator paymentCalculator = new PaymentCalculator();
//            Console.WriteLine("paymentValue={0}", paymentCalculator.CalculatePaymentAfterDiscount(1000, discountCalculator.CalculateDiscount(1000, "Chrismath")));
//            Console.ReadLine();
//        }
//    }
//    public class DiscountCalculator
//    {
//        public int DiscountValue = 0;
//        public int CalculateDiscount(int amount, string role)
//        {
//            if (role.Equals("Summer"))
//            {
//                DiscountValue = Convert.ToInt32(amount * 0.15);
//            }
//            else if (role.Equals("Winter"))
//            {
//                DiscountValue = Convert.ToInt32(amount * 0.10);
//            }
//            else if (role.Equals("Chrismath"))
//            {
//                DiscountValue = Convert.ToInt32(amount * 0.30);
//            }
//            return DiscountValue;
//        }
//    }
//    public class PaymentCalculator
//    {
//        public int PaymentValue = 0;
//        public int CalculatePaymentAfterDiscount(int amount, int DiscountValue)
//        {
//            DiscountCalculator discountCalculator = new DiscountCalculator();
//            discountCalculator.CalculateDiscount(1000, "Chrismath");
//            PaymentValue = amount - DiscountValue;
//            return PaymentValue;
//        }
//    }
//}
