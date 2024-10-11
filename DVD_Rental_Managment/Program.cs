using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Rental_Managment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            MovieManager manager = new MovieManager();

            do
            {
                Console.WriteLine("Movie Rental Managment System");
                Console.WriteLine("1.Add a Movie");
                Console.WriteLine("2.View All Movie");
                Console.WriteLine("3.Update a Movie");
                Console.WriteLine("4.Delete a Movie");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Choose an option:");

                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Enter the Id");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter the Title");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the director");
                        string director = Console.ReadLine();
                        Console.WriteLine("Enter the rentalPrice");
                        string rentaldate = Console.ReadLine();

                        //manager.CreateMovie(id, title, director, rentaldate,);
                        break;


                    case 2:
                        manager.ReadMovie();
                        break;

                    case 3:
                        Console.WriteLine("Enter the new title");
                        string newtitle = Console.ReadLine();
                        Console.WriteLine("Enter the director");
                        string newdirector = Console.ReadLine();
                        Console.WriteLine("Enter the rentalPrice");
                        string newrentaldate = Console.ReadLine();
                        //manager.UpdateMovie(newtitle, newdirector, newrentaldate,);
                        break;

                    case 4:
                        Console.WriteLine("Enter the id");
                        string newid = Console.ReadLine();
                        manager.Deletemovie(newid);
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("choose an option");
                        break;





                }






            }
            while (true);
        }


    }
}

