namespace Addermatic.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Should_Throw_Invalid_Argument()
        {
            void Action() => Calculator.Sum("A", "20");
            Assert.ThrowsException<InvalidCastException>(Action);
        }

        [TestMethod]
        public void Should_Throw_When_Is_Empty()
        {

            void Action() => Calculator.Sum(String.Empty, "20");
            Assert.ThrowsException<ArgumentNullException>(Action);
        }

        [TestMethod]
        public void Should_Return_the_Result()
        {
            var result = Calculator.Sum("10", "20");
            Assert.AreEqual(30,result);
        }

        [TestMethod]
        public void Should_Throw_When_Is_Not_integer()
        {
            void Action() => Calculator.Sum("10.5", "1542.02");
            Assert.ThrowsException<InvalidCastException>(Action);
        }

        [TestMethod]
        public void Should_Throw_ArgumentNull_When_Is_Empty_And_Have_A_String()
        {
            void Action() => Calculator.Sum(String.Empty, "A");
            Assert.ThrowsException<ArgumentNullException>(Action);
        }

        [TestMethod]
        public void Should_Replace_Non_Natural_by_Zero()
        {
            var result = Calculator.Sum("-10", "-20");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Should_Replace_Non_Natural_by_Zero_And_Keep_The_Natural_Number()
        {
            var result = Calculator.Sum("-10", "20");
            Assert.AreEqual(20, result);
        }

    }
}