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
            Assert.ThrowsException<InvalidCastException>(Action);
        }

        [TestMethod]
        public void Should_Return_the_Result()
        {
            var calculator = new Calculator("10", "20");
            var result =calculator.SumOperands();

            Assert.AreEqual(30,result);
        }
    }
}