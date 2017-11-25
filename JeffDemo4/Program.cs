using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDemo4
{
    //Wait to introduce enum until arrays are solid
    enum Students
    {
        Jeff,
        Mike
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] StudentIds = { 1234, 9876 }; //Wait to show this example until after playing around with args
            //Students students; //Wait to show this until after playing with arrays
            //Start with an example using the existing array args
            if(args.Length > 1)
            {
                Console.WriteLine($"The second argument entered was {args[1]}");
            }
            else if(args.Length > 0)
            {
                Console.WriteLine($"The first argument entered was {args[0]}");
            }
            else
            {
                Console.WriteLine("You did not enter any arguments");
            }

            //Show different ways enum can be used
            Console.Write(Students.Jeff.ToString());
            Console.WriteLine($" - ID: {StudentIds[(int)Students.Jeff]}"); //Show casting if he's got a solid understanding so far
        }
    }
}
