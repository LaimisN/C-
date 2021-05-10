using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    class Movie
    {
        public String pavadinimas;
        public string autorius;
       private string rating;
        public Movie(String aMovie, string aAutorius, string aPG)
        {
            pavadinimas  = aMovie;
            autorius = aAutorius;
            Rating = aPG;
        }
        public string Rating 
        {
            get
            {
                return rating;
            }
            set
            {
                if (value =="G" ||value =="PG" || value =="PG-13"|| value =="R"||value == "NR")
                {
                    rating = value;
                }else
                {
                    rating = "NR";
                }
            }
        }
    
    
    }


    
}
