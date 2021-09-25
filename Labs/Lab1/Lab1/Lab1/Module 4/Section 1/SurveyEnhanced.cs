//using System;

//namespace Lab1
//{
//    enum Month
//    { 
//        January, February, March, April, May, June, July, August, September, October, November, December
//    }
//    class Data
//    {
//        private string name;
//        private int age;
//        private Month month;
//        private int date;

//        public string getName()
//        {
//            return this.name;
//        }

//        public void setName(string n)
//        {
//            this.name = n;
//        }

//        public int getAge()
//        {
//            return this.age;
//        }

//        public void setAge(int a)
//        {
//            this.age = a;
//        }

//        public Month getMonth()
//        {
//            return this.month;
//        }

//        public void setMonth(int m)
//        {
//            this.month = (Month)m;
//        }

//        public int getDate()
//        {
//            return this.date;
//        }

//        public void setDate(int d)
//        {
//            this.date = d;
//        }
//    }
//    class ZodiacCalculator
//    {
//        static void Main(string[] args)
//        {
//            var data = new Data();

//            Console.WriteLine("What is your name?");
//            data.setName(validString());

//            Console.WriteLine("What is your age?");
//            data.setAge(validInt());

//            Console.WriteLine("What is your birth month (#)");
//            data.setMonth((validInt())-1);

//            Console.WriteLine("What is birth day (#)");
//            data.setDate(validInt());

//            Console.WriteLine(CalculateDisplayData(data));
//        }

//        static string validString() //validate strings to not be empty
//        {
//            string valid = Console.ReadLine();

//            while (valid == "")
//            {
//                Console.WriteLine("Error please try again");
//                valid = Console.ReadLine();
//            }

//            return valid;
//        }
//        static int validInt() //validate ints
//        {
//            int valid = 999; //initialize as invalid number for age/month/date (sorry 999 year olds)

//            while (valid == 999)
//            {
//                try
//                {
//                    valid = int.Parse(Console.ReadLine());
//                }
//                catch (Exception)
//                {
//                    Console.WriteLine("Error, input was not a number");
//                }
//            }

//            return valid;
//        }

//        static string CalculateDisplayData(Data data) //calulates zodiac sign and builds and returns a string for output
//        {
//            Month month = data.getMonth();
//            int date = data.getDate();

//            string zodiac = "";

//            switch (month) // https://www.astrology-zodiac-signs.com/ is where I got all the dates from
//            {
//                case Month.January:
//                    {
//                        if (date >= 20)
//                        {
//                            zodiac = "Aquarius";
//                        }
//                        else
//                        {
//                            zodiac = "Capricorn";
//                        }
//                        break;
//                    }

//                case Month.February:
//                    {
//                        if (date >= 19)
//                        {
//                            zodiac = "Pisces";
//                        }
//                        else
//                        {
//                            zodiac = "Aquarius";
//                        }
//                        break;
//                    }
//                case Month.March:
//                    {
//                        if (date >= 21)
//                        {
//                            zodiac = "Aries";
//                        }
//                        else
//                        {
//                            zodiac = "Pisces";
//                        }
//                        break;
//                    }
//                case Month.April:
//                    {
//                        if (date >= 20)
//                        {
//                            zodiac = "Taurus";
//                        }
//                        else
//                        {
//                            zodiac = "Aries";
//                        }
//                        break;
//                    }
//                case Month.May:
//                    {
//                        if (date >= 21)
//                        {
//                            zodiac = "Gemini";
//                        }
//                        else
//                        {
//                            zodiac = "Taurus";
//                        }
//                        break;
//                    }
//                case Month.June:
//                    {
//                        if (date >= 21)
//                        {
//                            zodiac = "Cancer";
//                        }
//                        else
//                        {
//                            zodiac = "Gemini";
//                        }
//                        break;
//                    }
//                case Month.July:
//                    {
//                        if (date >= 23)
//                        {
//                            zodiac = "Leo";
//                        }
//                        else
//                        {
//                            zodiac = "Cancer";
//                        }
//                        break;
//                    }
//                case Month.August:
//                    {
//                        if (date >= 23)
//                        {
//                            zodiac = "Virgo";
//                        }
//                        else
//                        {
//                            zodiac = "Leo";
//                        }
//                        break;
//                    }
//                case Month.September:
//                    {
//                        if (date >= 23)
//                        {
//                            zodiac = "Libra";
//                        }
//                        else
//                        {
//                            zodiac = "Virgo";
//                        }
//                        break;
//                    }
//                case Month.October:
//                    {
//                        if (date >= 23)
//                        {
//                            zodiac = "Scorpio";
//                        }
//                        else
//                        {
//                            zodiac = "Libra";
//                        }
//                        break;
//                    }
//                case Month.November:
//                    {
//                        if (date >= 22)
//                        {
//                            zodiac = "Sagittarius";
//                        }
//                        else
//                        {
//                            zodiac = "Scorpio";
//                        }
//                        break;
//                    }
//                case Month.December:
//                    {
//                        if (date >= 22)
//                        {
//                            zodiac = "Capricorn";
//                        }
//                        else
//                        {
//                            zodiac = "Sagittarius";
//                        }
//                        break;
//                    }
//            }


//            string display = string.Format("You are {0}, {1} years old, born on {2}/{3}. This means your zodiac sign is {4}.",
//                                            data.getName(), data.getAge(), month, date, zodiac);

//            return display;
//        }
//    }
//}
