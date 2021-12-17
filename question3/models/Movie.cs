using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_dec_2021_24087.question3.models
{
    public class Movie
    {
        //Default Constructor with null properties
        public Movie()
        {

        }
        //Default Constructor with given properties
        public Movie(string _name, string _rating, double _runningTime, string _director)
        {
            Name = _name;
            Rating = _rating;
            RunningTime = _runningTime;
            Director = _director;
        }
        //getting and setting values
        public string Name { get; set; }
        public string Rating { get; set; }
        public double RunningTime { get; set; }
        public string Director { get; set; }

        //method to return name
        public string name()
        {
            return Name;
        }
        //method to return director Name
        public string DirectorName()
        {
            return Director;
        }
        //method to return appropriate ratings on Scale of 1 to 5.
        public string setRating()
        {
            if (Rating == "1") { Rating = "G"; }
            else if (Rating == "2") { Rating = "PG"; }
            else if (Rating == "3") { Rating = "PG-13"; }
            else if (Rating == "4") { Rating = "R"; }
            else if (Rating == "5") { Rating = "NC_17"; }
            else { Console.WriteLine("InCorrect!"); }
            return Rating;
        }
        //method to return Movie Length in hours format
        public string setRunningTime()
        {
            double hours = RunningTime;
            string time = TimeSpan.FromHours(hours).ToString();
            return time;
        }
    }
}