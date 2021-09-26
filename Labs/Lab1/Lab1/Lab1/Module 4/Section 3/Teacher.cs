using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Teacher : Member, IPayee
    {
        public string Subject;

        public void Pay()
        {
            Console.WriteLine("Teacher paid");
        }
    }
}

