//using System;

//namespace Lab1
//{
//    class OutReference
//    {
//        static void Main(string[] args)
//        {
//            var test = "1.5";
//            var outDouble = 0.0;
//            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
//            Console.WriteLine("Test type is {0}", outDouble.GetType());
//            test = "Ronan";
//            outDouble = 0.0;
//            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
//            Console.WriteLine("Test value is {0}", outDouble);
//        }

//        static bool parseDouble(string test, out double outDouble)
//        {
//            outDouble = 0.0; //initialize outDouble because we aren't using ref
//            bool result = false; //initialize result as false

//            try
//            {
//                if (double.Parse(test).GetType() == outDouble.GetType()) //if both types are double, cast and set outDouble and result = true
//                {
//                    outDouble = double.Parse(test);
//                    result = true;
//                }
//            }
//            catch (Exception)
//            {
//                result = false;
//            }

//            return result;
//        }
//    }
//}
