using System.Collections.Generic;
using Model.Kitchen.Cooking;

namespace Model.Room
{
    public class Card
    {
        public List<Menu> menus = new List<Menu>();
        public List<Drink> drinks = new List<Drink>();

        public Card(List<Menu> menus, List<Drink> drinks)
        {
            this.menus = menus;
            this.drinks = drinks;
        }
    }
}
