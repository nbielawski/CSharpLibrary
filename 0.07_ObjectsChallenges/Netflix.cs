using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Netflix

    {

        //properties
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public double MovieRating { get; set; }

        //methods
        public void GetSuggestion()

        {  
        if (MovieRating > 3.5)

               { Console.WriteLine("You should watch!");

               }

        else { 
        Console.WriteLine( "Watch something else");
            
             }
            
            
      }
    }
}
