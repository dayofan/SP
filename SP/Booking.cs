namespace SP
{
    public class Booking
    {
        public Booking(string guest, int room, DateTime date)
        {
            Guest = guest;
            Room = room;
            Date = date;
        }

        public string Guest { get; }
        public int Room { get; }
        public DateTime Date { get; }
    }
}
