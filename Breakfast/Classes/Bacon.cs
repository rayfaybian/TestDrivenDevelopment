using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Classes
{
    public class Bacon
    {
        int quantity;

        public Bacon(int quantity)
        {
            this.quantity = quantity;
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public int Length
        {
            get { return this.quantity; }

        }

        public void EatBacon(int quantity)
        {
            if (this.quantity >= quantity)
            {
                this.quantity = this.quantity - quantity;
            }
            else
            {
                Console.WriteLine("You can't eat more than you have on your plate.");
            }
        }

    }
}