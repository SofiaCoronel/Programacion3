namespace Classroom.Core.Entities.Test
{
    public class TeacherTest
    {
        [Fact]
        public void prueba_crear_un_profesor_con_nombre()
        {
            var teacher1 = new Teacher()
            {
                FirstName = "lionel"
            };

            Assert.NotNull(teacher1);
            Assert.Equal("lionel", teacher1.FirstName);

        }

        [Fact]
        public void obtener_nombre_completo_solo_nombre()
        {
            var teacher1 = new Teacher()
            {
                FirstName = "lionel"
            };

            Assert.NotNull(teacher1);
            Assert.Equal("lionel", teacher1.FullName);

        }

        [Fact]
        public void obtener_nombre_completo()
        {
            var teacher1 = new Teacher()
            {
                FirstName = "lionel",
                LastName = "messi"
            };

            Assert.NotNull(teacher1);
            Assert.Equal("lionel messi", teacher1.FullName);

        }
    }
}
