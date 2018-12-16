using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Room.Element
{
    public class Tablecloth : RoomStuff
    {
        public Tablecloth(EnumRoom.TableclothType type, EnumRoom.MaterialState state) : base("Tablecloth", type, state)
        {
        }
    }
}
