using Model.Kitchen.Cooking.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Interfaces
{
    public interface IStorage
    {
        void fillStorage(int nb,Ingredient ingredient);
        void removeFromStorage(int nb, Ingredient ingredient);
        List<Ingredient> chechStorage();
    }
}
