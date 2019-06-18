using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    class Movie
    {
        public string title;
        private int rate;

        public Movie(string Otitle, int Orate)
        {
            title = Otitle;
            Rate = Orate;
        }
        public int Rate //this is property lie method
        {
            get
            {
                return rate;
            }
            set
            {
                if (value == 1 || value == 2 || value == 3 || value == 4 || value == 5)
                {
                    rate = value;
                }
                else
                {
                    rate = -1;
                }
            }
        }
    }
}
