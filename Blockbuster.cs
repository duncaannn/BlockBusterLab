using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    public class Blockbuster
    {
       public List<Movie> Movies { get; set; }

        public Blockbuster()
        {
            Movies = new List<Movie>
            {
                new DVD("The Big Lebowski", Genre.Comedy, 98, new List<string>{"Beat up", "Nobody messes with the Jesus", "Cowboy", "Wife", "Carpet", "Steve Buscemi dies" }),
                new DVD("Halloween", Genre.Horror, 121, new List<string>{"Michael kills mom", "Gets sent to hospital", "Escapes", "Kills some teens", "Walks around looking for sister", "Gets captured" }),
                new DVD ("Terminator", Genre.Action, 134, new List<string>{"From the future,", "Saves Sarah Conner", "Arnold come again","Run for life", "Michael dies", "Sarah escapes"  }),
                new VHS ("Cool Runnings", Genre.Comedy, 90, new List<string>{"Fail to qualify", "Recruit bobsled legend", "Who is he", "Training montage","Crash", "Jamaica wins"  }),
                new VHS ("The Shining", Genre.Horror, 134, new List<string> {"Vacation", "Caretaker", "The Shine", "The Room", "The Running", "Here's Johnny" }),
                new VHS("The Matrix", Genre.Action, 144, new List<string> {"White Rabbit", "Escape from office building", "Bellybutton", "Red pill blue pill", "Kung Fu", "Mr. Smith" })
            };
        }
        public void PrintMovies()
        {
            int inOut;
            string userInput = Console.ReadLine();
            //while (!int.TryParse(userInput, out inOut))
            //{
                for (int i = 0; i < Movies.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {Movies[i].Title}");
                }
            //}
        }

        public Movie CheckOut()
        {
            Console.WriteLine("Press any button to select Movie");
            PrintMovies();
           string userResponse = Console.ReadLine();
            int userNumber;
            while (!Int32.TryParse(userResponse, out userNumber))
            {
                Console.WriteLine("This entry is not valid, please enter a number.");
                userResponse = Console.ReadLine();
            }
           
            //while (string.IsNullOrEmpty(userResponse))
            //{
            //    Console.WriteLine("Input can't be empty");
            //    userResponse = Console.ReadLine();
            //}

            int movieIndex= int.Parse(userResponse);
            movieIndex = movieIndex - 1;
            Movies[movieIndex].PrintInfo();

            return Movies[movieIndex];
          
        }
    }
}
