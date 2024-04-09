using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Test
{
    public class PrinterTest
    {
        [Fact]
        public void print_iWithFullName() 
        {
            var teacher1 = new Teacher()
            {
                FirstName = "lionel"
            };

          // Assert.Equal("lionel", Printer.Print(teacher1));
        }
    }
}
