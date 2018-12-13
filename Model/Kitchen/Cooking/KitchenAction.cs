using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Cooking
{
    public class KitchenAction
    {
        public KitchenAction(string name, int duration)
        {
            this.name = name;
            this.duration = duration;
        }

        public string name { get; set; }
        public int duration { get; set; }
        
    }
}
