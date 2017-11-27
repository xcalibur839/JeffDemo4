using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDemo4
{
    //Wait to introduce enum until arrays are solid. Might be worth skipping for this lesson.
    //If there is time and opportunity, show the studentId example using the enum names and 
    //values to access the elements of the array
    enum Students
    {
        Jeff,
        Tyler,
        Kevin,
        Mike
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string[] studentIds = new string[Enum.GetNames(typeof(Students)).Length];
            string[] tools = new string[3]; //Wait to show this example until after playing around with args
            int toolCounter = 0;
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

            Console.WriteLine("Enter the name of the first tool");
            tools[toolCounter++] = Console.ReadLine(); //Use the literal numbers first, then demonstrate incrementing

            Console.WriteLine("Enter the name of the second tool");
            tools[toolCounter++] = Console.ReadLine();

            Console.WriteLine("Enter the name of the third tool");
            tools[toolCounter] = Console.ReadLine(); //Demonstrate out of bounds exception by including increment of toolCounter

            Console.WriteLine("Which tool number would you like to see?");
            int.TryParse(Console.ReadLine(), out toolCounter);
            Console.WriteLine("The name of the tool at position {0} is {1}", toolCounter, tools[toolCounter - 1]); //Another example of 
                                                                                                                   //out of bounds, and 
                                                                                                                   //the difference 
                                                                                                                   //between inc/dec
            Console.ReadLine();

            //Show different ways enum can be used if enum can fit in this lesson. Casting would be nice to show as well.
            //Console.Write(Students.Jeff.ToString());
            //Console.WriteLine($" - ID: {StudentIds[(int)Students.Jeff]}"); //Show casting if he's got a solid understanding so far
        }
    }
}
