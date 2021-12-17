using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_dec_2021_24087.question3.models
{
    public class allMovies
    {
        //creating public list to store Movies
        public List<Movie> listOfMovie = new List<Movie>()
        {
            //Adding movies to List
            new Movie("No Way Home","4",1.30,"Steve Harvey"),
            new Movie("Planet Of Apes","5",2.15,"George Bush"),
            new Movie("Iron Man","2",2.30,"Randy Ortan"),
        };//End of list
    //Display method to Print string.
        public void display()
        {
           
            Console.WriteLine("---------------------------------------------------");
            //creating loop which will loop through list and will get information given in{}.
            foreach (Movie m in listOfMovie)
            {
                Console.WriteLine($"\"{m.name()}\" movie was \"{m.setRunningTime()}\" long and was directed by \"{m.DirectorName()}\", and its rating was \"{m.setRating()}\"");

            }
            Console.WriteLine("---------------------------------------------------");
        }//End of display method
    }
}
