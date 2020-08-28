using System;
using System.Collections.Generic;

namespace StandTheLine
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<Pearls> perles = new Queue<Pearls>();
            perles.Enqueue(new Pearls() {Color = "red"});
            perles.Enqueue(new Pearls() {Color = "black"});
            perles.Enqueue(new Pearls() {Color = "yellow"});
            perles.Enqueue(new Pearls() {Color = "green"});
            perles.Enqueue(new Pearls() {Color = "brown"});
            
            Console.WriteLine(@"
             __________________________________
            |                                  |
            | ################################ |
            |                                  |
            | Type the number of the fallowing |
            |                                  |
            | 1. Add red pearl                 |
            | 2. Delete pearl                  |
            | 3. Show the number of pearls     |
            | 4. Find a pearl                  |
            | 5. Print all pearls              |
            | 6. Print off-coming pearl        |
            | 7. Exit                          |
            |                                  |
            | ################################ |
            |__________________________________|           
            
");
            //this makes sure that the user can enter a number from the list
            int type = int.Parse(Console.ReadLine());
            

            switch (type)
            {
                case 1:
                    perles.Enqueue(new Pearls() {Color = Console.ReadLine()});
                    break;
                case 2:
                    Pearls firstToLeave = perles.Dequeue();
                    Console.WriteLine(string.Format("First to leave: {0}", firstToLeave.Color));
                    break;
                case 3:
                    Console.WriteLine(perles.Count);
                    break;
                case 4:
                    foreach (Pearls x in perles)
                    {
                        if (x.Color.Equals(Console.ReadLine()))
                        {
                            Console.WriteLine("you'w got it - its somewhere in the chain");
                        }
                        else
                        {
                            Console.WriteLine("sory, no pearl match your value");
                        }
                    }
                    break;
                //Writng the queue out in the console. I only have one value at every pearl,
                //therefor I only ask for the value of index 0.
                //If I had more values to pick I would use the index number of the proper value to get it.
                case 5:
                    foreach (Pearls pearl in perles)
                    {
                        Console.WriteLine("{0}", pearl.Color);
                    }                    break;
                case 6:
                    Pearls soonToLeave = perles.Peek();
                    Console.WriteLine(string.Format("Just checking who'll leave next: {0}", soonToLeave.Color));
                    break;
                case 7:
                    Console.WriteLine("End");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}