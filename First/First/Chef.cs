using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    class Chef
    {
        public void MakeChicken()    //tai yra metodas ka gali daryti chef "objektas"
        {
            Console.WriteLine("The Chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }
        public virtual void MakeSpeciolDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
