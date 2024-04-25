using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.App.Entities.Test
{
    public class JediTest
    {
        [Fact]
        public void demo_struct()
        {

            var jedi1 = new Jedi()
            {
                Id = 1,
                Name = "Yoda"
            };


            Assert.Equal("Yoda", jedi1.Name);
            //Assert.Equal("Starwars.App.Entities.Jedi", jedi1.ToString());
            Assert.Equal("Yoda (1)", jedi1.ToString());
        }

    }
}
