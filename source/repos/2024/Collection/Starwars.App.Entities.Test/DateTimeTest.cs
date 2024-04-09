namespace Starwars.App.Entities.Test
{
    public class DateTimeTest
    {

        [Fact]
        public void demo()
        {
            var now = DateTime.Now;


            Assert.NotNull(now);
        }

        [Fact]
        public void initial_datetime()
        {
            var d1 = new DateTime();

            Assert.Equal(1, d1.Year);
            Assert.Equal(1, d1.Month);
            Assert.Equal(1, d1.Day);
            Assert.Equal(DayOfWeek.Monday, d1.DayOfWeek);
        }

        [Fact]
        public void datetime_subtract()
        {
            var d1 = new DateTime(2024, 3, 22, 18, 0, 0);
            var d2 = new DateTime(2024, 3, 22, 18, 28, 0);

            var result = d2.Subtract(d1);

            Assert.Equal(28, result.TotalMinutes);
            Assert.Equal(1680, result.TotalSeconds);
            Assert.Equal(1680000, result.TotalMilliseconds);
        }

        [Fact]
        public void datetime_toString()
        {
            var d1 = new DateTime(2024, 3, 22, 18, 28, 0);

            Assert.Equal("22/3/2024 18:28:00", d1.ToString());
        }

    }
}