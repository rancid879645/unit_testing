namespace Addermatic.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Should_Throw_Invalid_Argument()
        {
            void Action() => new Calculator("A", "20");
            Assert.ThrowsException<InvalidCastException>(Action);
        }

        [TestMethod]
        public void Should_Throw_When_Is_Empty()
        {
            void Action() => new Calculator(String.Empty, "20");
            Assert.ThrowsException<ArgumentNullException>(Action);
        }

        [TestMethod]
        public void Should_Return_the_Result()
        {
            var calculator = new Calculator("10", "20");
            var result =calculator.SumOperands();

            Assert.AreEqual(30,result);
        }

        [TestMethod]
        public void Should_Throw_When_Is_Not_integer()
        {
            void Action() => new Calculator("10.5", "1542.02");
            Assert.ThrowsException<InvalidCastException>(Action);
        }

        [TestMethod]
        public void Should_Throw_ArgumentNull_When_Is_Empty_And_Have_A_String()
        {
            void Action() => new Calculator(String.Empty, "A");
            Assert.ThrowsException<ArgumentNullException>(Action);
        }

        [TestMethod]
        public void Should_Replace_Non_Natural_by_Zero()
        {
            var calculator = new Calculator("-10", "-20");
            var result = calculator.SumOperands();

            Assert.AreEqual(0, result);
        }

    }
}