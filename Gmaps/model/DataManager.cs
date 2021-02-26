using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps.model
{
    class DataManager
    {
        private const string PATH = "..\\..\\data\\COVID.csv";
        private List<Location> locations;

        public DataManager() 
        {
            locations = new List<Location>();
            readInfo();
        }

        private void readInfo() 
        {
            var reader = new StreamReader(File.OpenRead(PATH));
            for (int i = 0; !reader.EndOfStream && i < 100; i++)
            {
                var ln = reader.ReadLine();
                var col = ln.Split(',');
                var rec = 0;

                if (col[9].Equals("Recuperado"))
                {
                    rec = 1;
                } 
                else if (col[9].Equals("Fallecido"))
                {
                    rec = 2;
                }

                addLocation(col[4], rec);
            }
        }

        private void addLocation(string name, int recDec) 
        {
            Location nloc = findLocation(name);

            if (nloc == null)
            {
                Location nloc1 = null;
                if (recDec == 1)
                {
                    nloc1 = new Location(name, 1, 1, 0);
                }
                else if (recDec == 2)
                {
                    nloc1 = new Location(name, 1, 0, 1);
                }
                else
                {
                    nloc1 = new Location(name, 1, 0, 0);
                }

                locations.Add(nloc1);
            }
            else {
                nloc.setCases();

                if (recDec == 1)
                {
                    nloc.setRecovered();
                }
                else if (recDec == 2)
                {
                    nloc.setDeceased();
                }
            }
        }

        private Location findLocation(string name)
        {
            bool found = false;
            Location loc = null;
            for (int i = 0; i < locations.Count && !found; i++)
            {
                if (name.Equals(locations[i].getName())) {
                    found = true;
                    loc = locations[i];
                }
            }

            return loc;
        }

        public List<Location> getLocations()
        {
            return locations;
        }
    }
}
