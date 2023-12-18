namespace PrimeComposite.Tests
{
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Should_Throw_Invalid_Argument()
        {
            void Action() => ValidatorNumberType.Validate("A", "20");
            Assert.ThrowsException<InvalidCastException>(Action);
        }

        [TestMethod]
        public void Should_Throw_Null_Argument()
        {
            void Action() => ValidatorNumberType.Validate(string.Empty, "20");
            Assert.ThrowsException<ArgumentNullException>(Action);
        }

        [TestMethod]
        public void Should_Throw_Invalid_Range()
        {
            void Action() => ValidatorNumberType.Validate("40", "20");
            Assert.ThrowsException<InvalidDataException>(Action);
        }

        [TestMethod]
        public void Should_Print_Composite()
        {
            var sw = new StringWriter();
            Console.SetOut(sw);
            ValidatorNumberType.Validate("4", "4");

            Assert.AreEqual("Composite", sw.ToString().Trim());
        }

        [TestMethod]
        public void Should_Print_Prime()
        {
            var sw = new StringWriter();
            Console.SetOut(sw);
            ValidatorNumberType.Validate("2", "2");

            Assert.AreEqual("Prime", sw.ToString().Trim());
        }

    }
}