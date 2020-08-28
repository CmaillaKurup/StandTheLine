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
            perles.Enqueue(new Pearls() {Color = "red"});
            perles.Enqueue(new Pearls() {Color = "black"});
            perles.Enqueue(new Pearls() {Color = "red"});

            //This does not work how I wanted it to work - I'll give it a look later
            //The perpurs was to make only the word "red" the color red and same with the word "black"
            //But as it is now it turns it all red - simply because its the first thing it looks at 
            //and because the first pearl are red it returns true
            foreach (Pearls pearl in perles)
            {
                if (pearl.Color == "red")
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            
            
            Console.WriteLine(@"
             __________________________________
            |                                  |
            | ################################ |
            |                                  |
            | Type the number of the fallowing |
            |                                  |
            | 1. Add red pearl                 |
            | 2. Add black pearl               |
            | 3. Delete pearl                  |
            | 4. Show the number of pearls     |
            | 5. Find a pearl                  |
            | 6. Print all pearls              |
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
                    perles.Enqueue(new Pearls() {Color = "red"});
                    break;
                case 2:
                    perles.Enqueue(new Pearls() {Color = "black"});
                    break;
                case 3:
                    Pearls firstToLeave = perles.Dequeue();
                    Console.WriteLine(string.Format("First to leave: {0}", firstToLeave.Color));
                    break;
                case 4:
                    Console.WriteLine(perles.Count);
                    break;
                case 5:
                    Console.WriteLine("Case 1");
                    break;
                case 6:
                    Console.WriteLine("Case 2");
                    break;
                case 7:
                    Console.WriteLine("Case 1");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }


            //Writng the queue out in the console. I only have one value at every pearl,
            //therefor I only ask for the value of index 0.
            //If I had more values to pick I would use the index number of the proper value to get it.
            foreach (Pearls pearl in perles)
            {
                Console.WriteLine("{0}", pearl.Color);
            }
            
        }
    }
}