using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.App.Entities.Test
{
    public class DateTimeTest
    {
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
            var d1 = new DateTime();
        }
    }
}
