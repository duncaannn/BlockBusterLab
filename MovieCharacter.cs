using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
   

        class MovieCharacter
        {
            public string Name { get; set; }
            public bool Good { get; set; }
            public string Role { get; set; }
            public int Age { get; set; }
            public MovieCharacter(string name, bool good, string role, int age)
            {
                Name = name;
                Good = good;
                Role = role;
                Age = age;
            }
            public MovieCharacter() { }
            public static List<MovieCharacter> GetMovieCharacters()
            {
                List<MovieCharacter> character = new List<MovieCharacter>()
            {
                new MovieCharacter("Neo", true, "Lead", 30),
                new MovieCharacter("McLovin'", true, "Lead", 21),
                new MovieCharacter("Nemo", true, "Lead", 2),
                new MovieCharacter("Thor", true, "Lead", 1000),
                new MovieCharacter("Iago", false, "Supporting Parrot", 5)
            };
                return character;
            }
        }


    
}
