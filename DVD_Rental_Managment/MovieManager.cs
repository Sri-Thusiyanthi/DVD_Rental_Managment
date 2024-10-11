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

    }
}
