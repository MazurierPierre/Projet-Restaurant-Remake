using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Room.Element
{
    public class Glass : RoomStuff
    {
        public Glass(EnumRoom.GlassType type, EnumRoom.MaterialState state) : base("Glass", type, state)
        {
        }
    }
}
