using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class PokemonAPI
    {
        
        public List<AllResults> Results { get; set; }
       
        


    }
    public class AllResults
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return CapFirstLetter();
            
        }
        private string CapFirstLetter()
        {
            return name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1);
        }
        



    }
    public class Stats
    {

        public string Url { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public Sprite sprites { get; set; }
        
    }
    public class Sprite 
    {
        
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
}
