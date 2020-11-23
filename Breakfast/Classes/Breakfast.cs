using TestDrivenDevelopment.Classes;
using System;
using System.Collections.Generic;
using System.Text;



namespace TestDrivenDevelopment.Classes
{
    public class Breakfast
    {

        public static Coffee PourCoffee()
        {
            Console.WriteLine("Here's your Coffee.");
            return new Coffee();
        }

        public static Bacon FryBacon(int quantity)
        {
            Console.WriteLine("Here's your " + quantity + " strips of fried bacon.");
            return new Bacon(quantity);
        }

        public static Bacon EatBacon(ref Bacon bacon, int quantityEat)
        {
            
            bacon.EatBacon(quantityEat);
            Console.WriteLine("You ate " + quantityEat +" strips of bacon and have " + bacon.Length +" strips left.");
            return bacon;
        }

        public static Eggs FryEggs(int quantity)
        {
            Eggs eggs = new Eggs();
            eggs.FryEggs(quantity);
            Console.WriteLine("Here's your " + quantity + " fried eggs.");
            return eggs;
        }

        public static Toast[] ToastBread(int quantity)
        {
            Toast[] toasts = new Toast[quantity];

            for (int i = 0; i < quantity; i++)
            {
                toasts[i] = new Toast();
            }
            Console.WriteLine("Here's your " + quantity + " toasts.");
            return toasts;
        }

        public static void ApplyButter(Toast toast) => toast.ApplyButter();
        public static void ApplyJam(Toast toast) => toast.ApplyJam();

    }
}