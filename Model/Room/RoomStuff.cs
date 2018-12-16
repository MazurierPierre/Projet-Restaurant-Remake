using System;

namespace Model.Room
{
    public abstract class RoomStuff
    {
        public string name { get; set; }
        public Enum type { get; set; }
        public Enum state { get; set; }

        protected RoomStuff(string name, Enum type, Enum state)
        {
            this.name = name;
            this.type = type;
            this.state = state;
        }
    }
}
