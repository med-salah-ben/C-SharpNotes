using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Movies
    {
        public string MovieName;
        public string MovieTest;
        private string MovieID;

        //Constructor
        public Movies(string aMovieName, string aMovieTest, string aMovieID)
        {
            this.MovieName = aMovieName;
            this.MovieTest = aMovieTest;
            this.MovieID = aMovieID;
        }

        public string movieId
        {
            get { return MovieID; }
            set {
                if(value == "abc" || value == "xyz" || value == "123")
                {
                    MovieID = value;
                }
                else
                {
                    MovieID = "NoID";
                }
            }
        }
    }
}
