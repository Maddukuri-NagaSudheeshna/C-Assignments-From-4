using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPlayerClasses  
{
    internal class Player  
    {
        Player[] data = null;
        public String Name { get; set; }    
        public int Runs { get; set; }  
        
        public Player()
        {
            data = new Player[11];
        }
        public void Add(Player runs)
        {
            data[0] = runs;
        }

        
    }
}
