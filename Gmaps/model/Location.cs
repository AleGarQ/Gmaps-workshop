using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps.model
{
    class Location
    {
        private string name;
        private int cases { get; set; }
        private int recovered { get; set; }
        private int deceased { get; set; }

        public Location(string name, int cases, int rec, int dec)
        {
            this.name = name;
            this.cases = cases;
            this.recovered = rec;
            this.deceased = dec;
        }

        public string getName() 
        {
            return name;
        }

        public int getCases()
        {
            return cases;
        }

        public int getRecovered()
        {
            return recovered;
        }

        public int getDeceased()
        {
            return deceased;
        }

        public void setCases()
        {
            cases = cases++;
        }

        public void setRecovered()
        {
            recovered = recovered++;
        }

        public void setDeceased()
        {
            deceased = deceased++;
        }
    }
}
