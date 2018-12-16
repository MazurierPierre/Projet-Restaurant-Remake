namespace Model.Room.Element
{
    public class Bread : RoomStuff
    {
        public Bread(EnumRoom.BreadType type, EnumRoom.MaterialState state) : base("Bread", type, state)
        {
        }
    }
}
