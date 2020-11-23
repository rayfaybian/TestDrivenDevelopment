using System;
using TestDrivenDevelopment.Classes;


namespace TestDrivenDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = Breakfast.PourCoffee();

            while (!coffee.Temperature.Equals("Cold"))
            {
                Console.WriteLine("Coffee temperature: " + coffee.Temperature);
            }
            Console.WriteLine("Coffee temperature: " + coffee.Temperature);

            var bacon = Breakfast.FryBacon(5);
            Breakfast.EatBacon(ref bacon, 2);

            var eggs = Breakfast.FryEggs(4);
            eggs.Print();

            var toasts = Breakfast.ToastBread(6);
            Breakfast.ApplyButter(toasts[1]);
            Breakfast.ApplyButter(toasts[4]);

            for (int i = 0; i < toasts.Length; i++)
            {
                var buttered = toasts[i].ButterApplied;
                var jamed = toasts[i].JamApplied;

                Console.WriteLine("Butter on Toast #" + i + ": " + buttered);
                Console.WriteLine("Jam on Toast #" + i + ": " + jamed);

            }
        }
    }
}
