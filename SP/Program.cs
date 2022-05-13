using SP;

IBookingManager bm = new BookingManager(new BookingRepository());// create your manager here; 
var today = new DateTime(2012, 3, 28);
Console.WriteLine(bm.IsRoomAvailable(101, today)); // outputs true 
bm.AddBooking("Patel", 101, today);
Console.WriteLine(bm.IsRoomAvailable(101, today)); // outputs false 
Console.WriteLine("Available rooms");
foreach (var room in bm.GetAvailableRooms(today))
{
    Console.WriteLine(room);
}
bm.AddBooking("Li", 101, today); // throws an exception