using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsItALeapYear;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Year_2001_Is_not_a_leap_year()

        {

            // Arrange

            var p = new Program();

            var expected = false;

            // Act

            var actual = p.IsItALeapYearTest(2001);

            // Assert

            Assert.AreEqual(expected, actual);

        }

        public void Year_1996_Is_a_leap_year()

        {

            // Arrange

            var p = new Program();

            var expected = false;

            // Act

            var actual = p.IsItALeapYearTest(1996);

            // Assert

            Assert.AreEqual(expected, actual);

        }

        public void Year_1900_Is_not_a_leap_year()

        {

            // Arrange

            var p = new Program();

            var expected = false;

            // Act

            var actual = p.IsItALeapYearTest(1900);

            // Assert

            Assert.AreEqual(expected, actual);

        }


    }
}
