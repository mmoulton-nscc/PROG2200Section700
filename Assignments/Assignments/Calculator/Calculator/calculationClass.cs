using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class calculationClass
    {
        public String calculate(double leftNum, String op, double rightNum)
        {
            double calc = 0;
            switch (op)
            {
                case "*":
                   calc = leftNum * rightNum;
                   break;
                case "+":
                    calc = leftNum + rightNum;
                    break;
                case "-":
                    calc = leftNum - rightNum;
                    break;
                case "/":
                    if (rightNum == 0.0)
                    {
                        return "NaN";
                    }
                    calc = leftNum / rightNum;
                    break;
            }
        return calc+"";
        }
    }
}
