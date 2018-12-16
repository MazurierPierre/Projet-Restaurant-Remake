using Controller.Interfaces;
using Model.Kitchen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Common
{
    public class FindDishSimilarities : IAct
    {
        public void act()
        {
            InitKitchen.Instance.orderTable.orderList.Sort();
        }
    }
}
