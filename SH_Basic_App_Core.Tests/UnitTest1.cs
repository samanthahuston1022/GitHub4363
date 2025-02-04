using SH_Basic_App_GitHub;

namespace SH_Basic_App_Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Class1 tp = new Class1();

            //Act
            var result = tp.Name;

            //Assert
            Assert.Equal("Samantha Huston - The Code Master", result);

        }
    }
}