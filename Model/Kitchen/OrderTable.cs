using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen
{
    public class OrderTable
    {
        // /!\ les indices doivent-être respectés
        public List<TMPOrder> orderList { get; set; } //A modifier avec Order
        public int[] tableNumberTable { get; set; }

    }
}
