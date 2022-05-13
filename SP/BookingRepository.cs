namespace SP
{
    public class BookingRepository : IBookingRepository
    {
        public void AddBooking(Booking booking) => BookingsStore.AddBooking(booking);
        public IEnumerable<Booking> GetBookings() => BookingsStore.GetBookings();
        public IEnumerable<Booking> GetBookings(DateTime date) => BookingsStore.GetBookings().Where(b => b.Date == date);
        public IEnumerable<int> GetHotelRooms() => BookingsStore.GetHotelRooms();
    }
}
