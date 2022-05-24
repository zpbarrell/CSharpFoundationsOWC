using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Car
    {
        public string Model { get; set;}
        public string Make { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public bool IsNew { get; set; }

        public Car(string model, string make, string year, string color, bool isNew)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car() {}
    }

    public class Movie
    {
        // we want to build a class OBJECT
        public string Title { get; set; } //Property
        public string DirectorName { get; set; }
        public int Stars { get; set; }
        //build property for MOvie Genre, and rating- these will be enums. enums but be on the NAMESPACE lvl
        public Rating MovieRating { get; set; }
        public Genre MovieGenre { get; set; }
        //FULL CONSTRUCTOR
        public Movie(string title, string director, int stars, Rating movieRating, Genre movieGenre) // no return type. a constructor shares the name of the class its operating in
        {
            Title = ; 
            DirectorName = b;
            Stars = c;
            MovieRating = d;
            MovieGenre = e;

        }

    }
    //this is where our enums will go
    public enum Rating { G, PG, PG_13, R, MA }
    public enum Genre { Action, Comedy, Drama, Horror, Romance, RomCom, Thriller, SciFi_Fantasy }
}