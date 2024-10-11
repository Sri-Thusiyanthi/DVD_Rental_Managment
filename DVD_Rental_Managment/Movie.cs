using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Rental_Managment
{
    internal class Movie
    {
        public string movieID { get; set; }
        private string title { get; set; }

        private string director { get; set; }
        private string rentalPrice { get; set; }



        public Movie(string MovieId, string Title, string Director, string RentalPrice)
        {
            movieID = MovieId;
            title = Title;
            director = Director;
            rentalPrice = RentalPrice;
        }
        public override string ToString()
        {
            return $"movieIdId: {movieID}, title: {title}, director: {director}, rentalPrice: {rentalPrice}";
        }

    }
}
