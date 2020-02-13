using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonParticipation
{
    class AllPokemonAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public string pervious { get; set; }
        public List<AllPokemonResult> results { get; set; }

    }
    public class AllPokemonResult
    {
        public string name { get; set; }
        public string url { get; set; }
        public string front_default { get; set; }
        public double height { get; set; }
        public double weight { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
    public class sprites
    {
        public string front_default { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public string url { get; set; }

    }
 
}
