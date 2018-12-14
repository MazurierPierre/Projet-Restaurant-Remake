using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Room.Element
{
    public class Napkin : RoomStuff
    {
        public Napkin(EnumRoom.NapkinType type, EnumRoom.MaterialState state) : base("Napkin", type, state)
        {
        }
    }
}
