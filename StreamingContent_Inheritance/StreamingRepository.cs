using RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {

        // using this _contentDirectory from streamingcontentrepo.cs - protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //Read - shows
        public Show GetShowByTitle(string title)
        {
            //to find a specific show
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show)) 
                {
                    return (Show)content;
                }
            }

            return null;
        }

        //Read - Movies
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }

            }

            return null;
        }

        //Read get all
        public List<Show> GetAllShows()
        {
            //use to add our shows - starts empty - this is a "newed-up" version of the list
            List<Show> allshows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                //if the content we find is of type SHOW...
                if (content is Show)
                {
                    //add the show to the allshows list
                    allshows.Add((Show)content);
                }
            }
            return allshows;
        }

        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add(content as Movie);
                }
            }

            return allMovies;

        }

        //get by other parameters, such as runtime/avg runtime,shows with over x episodes, get shows or movie by rating

    }
}
