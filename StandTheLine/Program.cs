using System;
using System.Collections.Generic;

namespace StandTheLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Pearls> perles = new Queue<Pearls>();
            perles.Enqueue(new Pearls() {Colour = "red"});
            perles.Enqueue(new Pearls() {Colour = "black"});
            perles.Enqueue(new Pearls() {Colour = "red"});
            perles.Enqueue(new Pearls() {Colour = "black"});
            perles.Enqueue(new Pearls() {Colour = "red"});
            
            Console.WriteLine(@"
             __________________________________
            |                                  |
            | ################################ |
            |                                  |
            | Type the number of the fallowing |
            |                                  |
            | 1. Add items                     |
            | 2. Delete items                  |
            | 3. Show the number of items      |
            | 4. Show min and max items        |
            | 5. Find an item                  |
            | 6. Print all items               |
            | 7. Exit                          |
            |                                  |
            | ################################ |
            |__________________________________|           
            
");
            string type = Console.ReadLine();
            
            
            //Writng the queue out in the console. I only have one value at every pearl,
            //therefor I only ask for the value of index 0.
            //If I had more values to pick I would use the index number of the proper value to get it.
            foreach (Pearls pearl in perles)
            {
                Console.WriteLine("{0}", pearl.Colour);
            }
            
        }
    }
}