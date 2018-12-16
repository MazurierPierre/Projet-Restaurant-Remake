using Model.Kitchen.Cooking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen
{
    public class TMPOrder
    {
        //C'est en attendant Gilly
        public List<Menu> listeMenu { get; set; } = new List<Menu>();
        public int tableNumber;
    }
}
