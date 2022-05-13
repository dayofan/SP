namespace SP
{
    public class BookingManager : IBookingManager
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingManager(IBookingRepository bookingRepository) =>
            _bookingRepository = bookingRepository ?? throw new ArgumentNullException(nameof(bookingRepository));

        public void AddBooking(string guest, int room, DateTime date)
        {
            if (!IsRoomAvailable(room, date)) throw new InvalidOperationException("Room is not available.");
            _bookingRepository.AddBooking(new Booking(guest, room, date));
        }

        public bool IsRoomAvailable(int room, DateTime date) =>
            _bookingRepository.GetHotelRooms().Any(r => r == room) && !_bookingRepository.GetBookings().Any(b => b.Room == room && b.Date == date);

        public IEnumerable<int> GetAvailableRooms(DateTime date)
        {
            var bookedRooms = _bookingRepository.GetBookings(date).Select(b => b.Room);
            return _bookingRepository.GetHotelRooms().Where(r => !bookedRooms.Contains(r));
        }
    }
}
