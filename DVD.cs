using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BlockBusterLab
{
    public class DVD : Movie
    {
        public override void Play()
        {
            Console.WriteLine("What scene would you like to watch?");
            Console.WriteLine();
            string userResponse = Console.ReadLine();
            //PrintScenes();
            int sceneIndex = int.Parse(userResponse);
            for (int i = 0; sceneIndex < 7; i++)
            {
                Console.WriteLine(Scenes[sceneIndex]);
                if (sceneIndex > 6)
                {

                    Console.WriteLine("Please enter a valid number");
                }

                break;

            }
            
        }
        public DVD () //Default constructor has no parameters
        { }
            public DVD( string title, Genre category, int runTime, List<string> scenes): base(title, category, runTime, scenes) 
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes=scenes;
        }
        public void PlayWholeMovie()
        {

        }

    }
}
