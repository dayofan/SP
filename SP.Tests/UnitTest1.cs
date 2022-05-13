namespace SP.Tests
{
    public class BookingManagerTests
    {
        [Fact]
        public void Test1()
        {
            var sut = new BookingManager(new BookingRepository());

        }
    }
}