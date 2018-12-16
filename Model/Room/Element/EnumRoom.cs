using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Room.Element
{
    public class EnumRoom
    {
        public enum BreadType { White };
        public enum GlassType { Wine, Water, Flute };
        public enum JugType { Sparkling, Tap };
        public enum PlateType { Flat, Small, Dessert, Soup };
        public enum TableclothType { Square, Round };
        public enum NapkinType { Paper, Napkin };
        public enum DrinkType { Coca, Wine }
        public enum MaterialState { OK, Dirt };
    }
}