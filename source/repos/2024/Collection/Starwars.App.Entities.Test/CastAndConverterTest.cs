using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.App.Entities.Test
{
    public class CastAndConverterTest
    {
        [Fact]
        public void cast_test()
        {
            var jedi1 = new Jedi()
            {
                Name = "Yoda"
            };

            var d1 = DateTime.Now;

            //jedi1 = (Jedi)d1;
            //jedi1 = d1 as Jedi;


            var obj1 = (object)jedi1;
            var obj2 = (object)d1;

            jedi1 = (Jedi)obj2;

        }


        [Fact]
        public void list_generic_add()
        {
            var jedi1 = new Jedi()
            {
                Name = "Yoda"
            };

            var jedis = new System.Collections.Generic.List<Jedi>();

            jedis.Add(jedi1);
            //jedis.Add(".NET");

            Assert.True(jedis.Contains(jedi1));
            Assert.Equal(1, jedis.Count);

        }




    }
}
