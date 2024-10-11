using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Rental_Managment
{
    internal class MovieManager
    {

        public List<Movie> Movies = new List<Movie>();

        public void CreateMovie(Movie movie)
        {
            Movies.Add(movie);
            Console.WriteLine("Movie Add Successfully");
        }

        public void ReadMovie()
        {
            if (Movies.Count == 0)
            {
                Console.WriteLine("Movie not avaliable");
            }
            Console.WriteLine("movie avaliable");

            foreach (Movie movie in Movies)
            {
                Console.WriteLine(movie);

            }

        }

        public void UpdateMovie(string newmovieid,string newtitle,string newdirector,string newrentalPrice)
        {
            var movie = Movies.FirstOrDefault(m => m.movieID == newmovieid);
            if (movie != null)
            {
                Movies.Add(movie);
                Console.WriteLine(" movie is update");
            
            }
            Console.WriteLine("movie is not update");
        }

        public void Deletemovie(string newmovieid)
        {
            var movie = Movies.FirstOrDefault(m => m.movieID == newmovieid);
            if (movie != null) 
            {
             Movies.Remove(movie);
                Console.WriteLine("movie deleted");
            
            }
            Console.WriteLine("not avaliable");
        }
        
    }
}
