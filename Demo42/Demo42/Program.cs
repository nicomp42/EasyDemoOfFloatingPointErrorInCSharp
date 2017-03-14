using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo42 {
    class Program {
        static void Main(string[] args) {
            float alpha = 42.0F;
            float delta = .000001F;
            Console.WriteLine("Floating Point demo...");
            Console.WriteLine("Start with a float: " + alpha);
            Console.WriteLine("Add " + delta);
            alpha += delta;
            Console.WriteLine("Result = " + alpha);
            // Whoosh

            alpha = 42.0F;
            Console.WriteLine("Start with = " + alpha);
            float tax = alpha * .0725F;
            Console.WriteLine("Multiply by 7.25% to get sales tax = " + tax);
            float amount = alpha += tax;
            Console.WriteLine("Add to " + alpha + " to  get " + amount);


        }
    }
}
