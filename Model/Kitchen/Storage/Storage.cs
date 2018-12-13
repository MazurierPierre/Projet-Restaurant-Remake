using Model.Kitchen.Cooking.Ingredients;
using Model.Kitchen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Storage
{
    public abstract class Storage : IStorage
    {
        protected Storage(int temperature, int maxCapacity, List<Ingredient> ingredientsList)
        {
            this.temperature = temperature;
            this.maxCapacity = maxCapacity;
            this.ingredientsList = ingredientsList;
        }

        public int temperature { get; set; }
        public int maxCapacity { get; set; }
        public List<Ingredient> ingredientsList { get; set; }

        public List<Ingredient> chechStorage()
        {
            return this.ingredientsList;
        }

        public void fillStorage(int nb, Ingredient ingredient)
        {
            for (int i = 0; i < nb; i++)
            {
                this.ingredientsList.Add(ingredient);
            }
        }

        public void removeFromStorage(int nb, Ingredient ingredient)
        {
            for (int i = 0; i < nb; i++)
            {
                this.ingredientsList.Remove(ingredient);
            }
        }
    }
}
