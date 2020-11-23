using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Classes
{
    public class Eggs
    {
        int quantity;

        public Eggs()
        {
           
        }

        public void FryEggs(int quantity)
        {

            this.quantity += quantity;
        }

        public int Length
        {
            get { return this.quantity; }
        }


        public string Print()
        {
            return this.quantity + " eggs";
        }

    }
}