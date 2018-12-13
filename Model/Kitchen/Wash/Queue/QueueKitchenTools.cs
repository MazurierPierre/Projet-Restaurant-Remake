using Model.Kitchen.Cooking.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen
{
    public class QueueKitchenTools
    {
        public List<KitchenTool> kitchenToolsList;

        public QueueKitchenTools(List<KitchenTool> kitchenToolsList)
        {
            this.kitchenToolsList = kitchenToolsList;
        }
    }
}
