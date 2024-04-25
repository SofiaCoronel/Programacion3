using Collection2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Entities.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var jedi = new Jedi();
            jedi.Name = "Luke Skywalker";
            Assert.Equal("Luke Skywalker", jedi.Name);
        }
    }
}
