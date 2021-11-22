using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private calculationClass calc = new calculationClass();
        //keeping track of things
        private String firstNum = "";
        private String op = "";
        private String secondNum = "";
        private bool opStarted = false; //checks if an initial op has been pressed
        private bool swap = false; //buttons will track first num and trigger swap when an op is pressed, when swap is active secondNum will begin being tracked
                                      //swap will remain active after equations because the rolling calc number will be stored in firstNum

        public Calculator()
        {
            InitializeComponent();
        }


        public void decidePlacement(String n) //decide whether string will be placed in the first or second number
        {
            if (swap && opStarted)
            {
                secondNum = createPlacement(n, secondNum);
            }
            else
            {
                firstNum = createPlacement(n, firstNum);
            }
        }

        public String createPlacement(String n, String num) //takes existing string and appends whatever button was pushed to the end of it
        {
            if (num == ("0")) //if there's just a zero replace it
            {
                num = n; //for example displays 15 instead of 015
            }
            else
            {
                num = appendToString(num, n);
            }

            if (num == (".")) //if a lone decimal was placed, assume 0.
            {
                num = "0.";
            }

            return num;
        }

        public void resolveOperator(String o)
        {
            if (opStarted && secondNum != ("")) //if this isn't the first op pressed and secondnum has something
            {
                firstNum = calc.calculate(Convert.ToDouble(firstNum), op, Convert.ToDouble(secondNum)); //resolve equation and store it in firstNum
                resetStates();
                op = o; //set op after resetting
                opStarted = true; //set op started after resetting
            }
            else if (firstNum != (""))
            {
                op = o; //only sets if number has been entered first
                opStarted = true;
                swap = true;
            }
        }

        public void resolveEquals()
        {
            if (swap && op != ("") && secondNum != ("")) //if in swap state and op/secondnum isn't empty, resolve equation
            {
                firstNum = calc.calculate(Convert.ToDouble(firstNum), op, Convert.ToDouble(secondNum)); //resolve equation and store it in firstNum
                resetStates();
            }
        }

        public void resolveClear()
        {
            //reset all trackers
            firstNum = "";
            swap = false;
            resetStates();
        }

        public void resolveClearEntry()
        {
            if (opStarted)
            {
                secondNum = "";
            }
            else
            {
                firstNum = "";
            }
        }

        public void resolveBackspace() //decide whether first or second number is being backspaced
        {
            if (swap && opStarted)
            {
                secondNum = createBackspaceString(secondNum);
            }
            else
            {
                firstNum = createBackspaceString(firstNum);
            }
        }

        public String createBackspaceString(String n)
        {
            String str;
            StringBuilder newstr = new StringBuilder();
            str = n;

            if (str != "") //if string isn't empty append all but last digit to new string
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    newstr.Append(str[i]);
                }
                n = newstr.ToString();
                
            }
            if (n == "-")//if all that remains is -, remove it to avoid crashes
            {
                n = "";
            }

            return n;
        }

        public void resolveFlip()
        {

            if (swap && opStarted)//decide whether first or second number is being flipped
            {
                secondNum = createFlipString(secondNum);
            }
            else
            {
                firstNum = createFlipString(firstNum);
            }
        }

        public String createFlipString(String n)
        {
            String str;
            StringBuilder newstr = new StringBuilder();
            str = n;

            if (str == ("0") || str == ("0.")) //don't flip 0
            {
                return str;
            }

            if (str != (""))
            {
                newstr.Append(str[0]); //test first char to see if it's a negative
                if (newstr.ToString() != ("-"))//if its not negative
                {
                    //newstr.deleteCharAt(0);
                    newstr.Remove(0, 1);
                    newstr.Append("-");//turn it negative and rebuild the string with every digit
                    for (int i = 0; i < str.Length; i++)
                    {
                        newstr.Append(str[i]);
                    }
                    n = newstr.ToString();
                }
                else//if it is negative
                {
                    newstr.Remove(0,1);
                    //delete char0 and start loop at 1 to skip -
                    for (int i = 1; i < str.Length; i++)
                    {
                        newstr.Append(str[i]);
                    }
                    n = newstr.ToString();
                }

            }
            return n;
        }

        public void resetStates()
        {
            //resets trackers with the exception of first number and swap, used when equation is executed
            op = ""; //reset op
            opStarted = false;
            secondNum = ""; //reset secondNum
        }

        public String appendToString(String num, String i) //on number button, appends new digit to end of current number
        {
            if (num.Contains(".") && i == (".")) //avoiding double decimals
            {
                return num;
            }
            else
            {
                return num + i;
            }
        }

        public void updateDisplays()
        {
            String str;
            str = firstNum + " " + op + " " + secondNum;
            textDisplay.Text = str;//setText(str); //displays current rolling equation
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textDisplay_TextChanged(object sender, EventArgs e)
        {

        }




        private void btn0_Click(object sender, EventArgs e)
        {
            decidePlacement("0");
            updateDisplays();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            decidePlacement("1");
            updateDisplays();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            decidePlacement("2");
            updateDisplays();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            decidePlacement("3");
            updateDisplays();

        }
        private void btn4_Click(object sender, EventArgs e)
        {
            decidePlacement("4");
            updateDisplays();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            decidePlacement("5");
            updateDisplays();

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            decidePlacement("6");
            updateDisplays();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            decidePlacement("7");
            updateDisplays();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            decidePlacement("8");
            updateDisplays();


        }

        private void btn9_Click(object sender, EventArgs e)
        {
            decidePlacement("9");
            updateDisplays();


        }




        private void btnSwap_Click(object sender, EventArgs e)
        {
            resolveFlip();
            updateDisplays();

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            resolveBackspace();
            updateDisplays();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resolveClear();
            updateDisplays();

        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            resolveClearEntry();
            updateDisplays();

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            resolveOperator("/");
            updateDisplays();

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            resolveOperator("*");
            updateDisplays();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            resolveOperator("-");
            updateDisplays();

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            resolveOperator("+");
            updateDisplays();

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decidePlacement(".");
            updateDisplays();

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            resolveEquals();
            updateDisplays();

        }

        private void btnNINE_Click(object sender, EventArgs e)
        {
            resolveClear();
            decidePlacement("9");
            updateDisplays();
        }
    }
}
