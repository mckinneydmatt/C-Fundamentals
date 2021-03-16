using RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class Movie : StreamingContent
    {
        //we get all the properties from a streaming content because a movie "is a" streaming content//
        public double RunTime { get; set; }

        //empty constructor
        public Movie() { }

        public Movie(string title, string description, MaturityRating maturityRating, GenreType genreType, double starRating, double runTime)
                    :base(title,description,maturityRating,genreType,starRating)
        {
            RunTime = runTime;
        }
    }
}
