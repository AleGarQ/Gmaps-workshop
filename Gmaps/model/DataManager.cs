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
        List<string> locations;

        public DataManager() 
        {
            locations = new List<string>();
            readInfo();
        }

        private void readInfo() 
        {
            var reader = new StreamReader(File.OpenRead(PATH));
            for (int i = 0; !reader.EndOfStream && i < 300; i++)
            {
                var ln = reader.ReadLine();
                var col = ln.Split(',');

                locations.Add(col[4] + ", Bogota, Colombia");
            }
        }

        public List<String> getLocations() 
        {
            return locations;
        }
    }
}
