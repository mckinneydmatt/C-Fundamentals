using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatterns
{

    public enum MaturityRating { G, PG, PG_13, R, NC_17, TV_Y, TV_G, TV_PG, TV_14, TV_MA}
    public enum GenreType { Horror = 1, RomCom, SciFi, Documentary, Bromance, Drama, Action}
    public class StreamingContent
    {
        public string Title { get; set; }
        public String Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public GenreType GenreType { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_Y:
                    case MaturityRating.TV_G:
                    case MaturityRating.TV_PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_MA:
                    default:
                        return false;

                }
                //another way to do the case
                //if ((int)MaturityRating > 4)
                //{
                    //return false;
                //}
                //else
                //{
                    //return true;
                //}

            }
        }
        
        public StreamingContent() {} //required

        public StreamingContent(string title, string description, MaturityRating maturityRating, GenreType genreType, double starRating)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            GenreType = genreType;
            StarRating = starRating;

        }

    }
}
