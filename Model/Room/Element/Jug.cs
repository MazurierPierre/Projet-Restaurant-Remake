using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Room.Element
{
    public class Jug : RoomStuff
    {
        public Jug(EnumRoom.JugType type, EnumRoom.MaterialState state) : base("Jug", type, state)
        {
        }
    }
}
