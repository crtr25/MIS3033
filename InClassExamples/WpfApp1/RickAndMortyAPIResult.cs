using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class RickAndMortyAPIResult
    {
        // know these are objects from json converter and whats inside of it
        public InfoObject info{ get; set; }
        public List<ResultObject> results { get; set; }
    }
    
    public class ResultObject
    {// has roughly 12 properties but only using 6

        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string gender { get; set; }
        public string image { get; set; }
        public override string ToString()
        {
            return $"({id}) {name}";
        }

    }

    public class InfoObject
    { // get this from the json converter. has 4 properties
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    }
}
