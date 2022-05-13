using System.Collections.Concurrent;

namespace SP
{
    public static class BookingsStore
    {
        private static readonly ConcurrentBag<Booking> _bookings;
        private static readonly int[] _hotelRooms;

        static BookingsStore()
        {
            _bookings = new();
            _hotelRooms = new int[4] { 101, 102, 201, 203 }; //Assuming hotel has only the listed rooms
        }
        public static void AddBooking(Booking booking) => _bookings.Add(booking);

        public static IEnumerable<Booking> GetBookings() => _bookings;

        public static IEnumerable<int> GetHotelRooms() => _hotelRooms;
    }
}
