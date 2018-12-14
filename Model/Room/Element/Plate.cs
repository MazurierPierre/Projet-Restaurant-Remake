using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Room.Element
{
    public class Plate : RoomStuff
    {
        public Plate(EnumRoom.PlateType type, EnumRoom.MaterialState state) : base("Plate", type, state)
        {
        }
    }
}
