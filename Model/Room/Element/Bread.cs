using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Room.Element
{
    public class Bread : RoomStuff
    {
        public Bread(EnumRoom.BreadType type, EnumRoom.MaterialState state) : base("Bread", type, state)
        {
        }
    }
}
