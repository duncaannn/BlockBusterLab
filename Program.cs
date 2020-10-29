using System;
using System.Text.RegularExpressions;

namespace BlockBusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster bob = new Blockbuster();
            while(true)
            {
                
                Console.WriteLine("Welcome to Blockbuster");
               Movie userMovie= bob.CheckOut();

                Console.Write("Do you want to watch the movie? y/n:");
                var userInput=Console.ReadLine();
                int inOut;
               
                    if (userInput == "y")

                    {
                        if (userMovie is DVD)
                        {

                            DVD dvd = (DVD)userMovie;
                            Console.WriteLine($"Which scene of the  DVD  {dvd.Title} would you like to watch? Select 0-{dvd.Scenes.Count}");

                            while (userInput == "y")
                            {
                                dvd.Play();
                                Console.WriteLine("Would you like to select another scene? y/n");
                                userInput = Console.ReadLine();
                            }
                        }
                        else if (userMovie is VHS)
                        {
                            VHS vhs = (VHS)userMovie;
                        }
                    }
                

            }
        }
    }
}
