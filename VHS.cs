using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
   public class VHS : Movie
    {
       public int CurrentTime { get; private set; }

        public override void Play()
        {
            CurrentTime++;
        }
        public void PlayWholeMovie()
        {
            
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
        public VHS(string title, Genre category, int runTime, List<string> scenes) : base(title, category, runTime, scenes)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes = scenes;

        }
    }
}
