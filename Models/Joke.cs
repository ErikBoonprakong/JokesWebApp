using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public string Author { get; set; } = "Unknown";
        public int Score { get; set; } = 0;

        public Joke()
        {
        }
    }
}
