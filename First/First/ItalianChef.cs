using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    class ItalianChef : Chef 
    {
        public void Makepasta()
        {
            Console.WriteLine("Chef makes pasta");
        }
        public override void MakeSpeciolDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}
