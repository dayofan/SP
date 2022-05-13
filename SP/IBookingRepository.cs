namespace SP
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetBookings();
        IEnumerable<Booking> GetBookings(DateTime date);
        void AddBooking(Booking booking);
        IEnumerable<int> GetHotelRooms();
    }
}