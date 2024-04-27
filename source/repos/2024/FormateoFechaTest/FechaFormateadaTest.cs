using FormateoFecha;

namespace FormateoFechaTest
{
    public class FechaFormateadaTests
    {
        [Fact]
        public void TestFormatearFecha()
        {
            // Arrange
            DateTime miNacimiento = new DateTime(2024, 11, 1);
            string expected = "Mi cumple es el viernes 1 de noviembre de 2024";

            // Act
            string actual = FechaFormateada.FormatearFecha(miNacimiento);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}