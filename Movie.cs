using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    public abstract class Movie
    {
       public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; } = new List<string>();

        public Movie () { }

        public Movie (string Title, Genre Category, int RunTime, List <string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        protected Movie(string title, Genre category, int runTime)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
        }

        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes, List<string> scenes) : this(Title, Category, RunTime, Scenes)
        {
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {RunTime}");
            Console.WriteLine();
        }

        public void PrintScenes()
        {
            int counter = 1;

            foreach(string scene in Scenes)
            {
                Console.WriteLine($"Scene {counter}: {scene}");
                counter++;
            }
        }
        public abstract void Play();


        

        
    }
   
}
