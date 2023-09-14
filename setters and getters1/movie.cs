using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace setters_and_getters1
{
    internal class movie
    {
        public string title;
        public string director;
        public string rating;

        // constructor
        public movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; // now movie rating is being set by the setter below

        }
                public string Rating
            {

                   get
                   {
                       return rating;

                   } 
                     set
                     {
                          if (value =="G" || value == "PG" || value =="PG-13" || value =="R")
                          { rating = value; }

                            else { rating = "NR"; }



                     }   
            }
        
            

        
    }
}
