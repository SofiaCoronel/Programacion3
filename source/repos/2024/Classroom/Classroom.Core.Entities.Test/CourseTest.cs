﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Test
{
    public class CourseTest
    {
        [Fact]
        public void Test1()
        {
            var course1 = new Course();
            course1.Title = "NET with C#";

            Assert.NotNull(course1);
            Assert.Equal("NET with C#", course1.Title);
        }

       /* [Fact]
        public void Test2()
        {
            var course1 = new Course();
            course1.Teacher = new Teacher()
            {
                FirstName = "lionel"
            };

            Assert.Equal("NET with C#", course1.Teacher.FirstName);
            Assert.Equal("NET with C#", course1.Teacher.FirstName);
        }
       */
    }
    }

