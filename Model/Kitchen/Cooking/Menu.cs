using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Cooking
{
    public class Menu
    {
        public Menu(string name, List<Dish> dishList, bool isMenuOfTheDay)
        {
            this.name = name;
            this.dishList = dishList;
            this.isMenuOfTheDay = isMenuOfTheDay;
        }

        public string name { get; set; }
        public List<Dish> dishList { get; set; }
        public Boolean isMenuOfTheDay { get; set; }

    }
}
