using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }
    }
}
