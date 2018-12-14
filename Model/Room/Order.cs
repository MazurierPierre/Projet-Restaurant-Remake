using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Kitchen;

namespace Model.Room
{
    public class Order
    {
        public List<Menu> orderList { get; set; }
        public int tableNumber { get; set; }

        public Order(List<Menu> orderList, int tableNumber)
        {
            this.orderList = orderList;
            this.tableNumber = tableNumber;
        }
    }
}
