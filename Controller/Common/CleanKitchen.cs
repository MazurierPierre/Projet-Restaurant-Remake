using Controller.Interfaces;
using Model.Kitchen;
using Model.Kitchen.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Common
{
    public class CleanKitchen : IAct
    {
        public void act()
        {
            InitKitchen.Instance.kitchen.kitchenState = EnumKitchen.KitchenState.Clean;
        }
    }
}
