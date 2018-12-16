using Model.Room;
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
        public List<Order> orderList { get; set; } = new List<Order>();//A modifier avec Order
        public int[] tableNumberTable { get; set; }

    }
}
