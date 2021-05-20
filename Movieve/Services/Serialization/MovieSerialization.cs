using Movieve.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Movieve.Services.Serialization
{
    public class MovieSerialization
    {
       public static SendRequest sender = new SendRequest();
        public List<Movie> Movies = new List<Movie>()
        {
            new Movie
            {
                Title= sender.GetTitle("Kurtlar Vadisi"),
                Genre = sender.GetGenre("Kurtlar Vadisi"),
                Year = sender.GetYear("Kurtlar Vadisi"),
                Plot = sender.GetPlot("Kurtlar Vadisi")
            },
        };
        Random random = new Random();
        //var list = new List<string> { "one", "two", "three", "four" };
        //int index = random.Next(list.Count);

    }
}
