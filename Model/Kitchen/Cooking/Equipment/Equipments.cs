using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Equipment
{
    public abstract class Equipments
    {
        protected Equipments(string name)
        {
            this.name = name;
        }

        public string name { get; set; }
    }
}
