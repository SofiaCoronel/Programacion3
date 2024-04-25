using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.App.Entities.Test
{
    public class StructTest
    {
        [Fact]
        public void demo_struct()
        {

            var point1 = new System.Drawing.Point()
            {
                X = 100,
                Y = 200
            };

            var jedi1 = new Jedi();
            jedi1.Move(point1);

            Assert.Equal(100, point1.X);
            Assert.Equal(200, point1.Y);
        }

    }
}
