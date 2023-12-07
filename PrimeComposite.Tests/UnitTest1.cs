namespace PrimeComposite.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Should_Throw_Invalid_Argument()
        {
            void Action() => new ValidatorNumberType("A", "20");
            Assert.ThrowsException<InvalidCastException>(Action);
        }

        [TestMethod]
        public void Should_Throw_Null_Argument()
        {
            void Action() => new ValidatorNumberType(string.Empty, "20");
            Assert.ThrowsException<ArgumentNullException>(Action);
        }

        [TestMethod]
        public void Should_Throw_Invalid_Range()
        {
            var validator = new ValidatorNumberType("40", "20");
            void Action() => validator.Validate();
            Assert.ThrowsException<InvalidDataException>(Action);
        }

        [TestMethod]
        public void Should_Print_Composite()
        {
            var validator = new ValidatorNumberType("4", "4");
            var sw = new StringWriter();
            Console.SetOut(sw);
            validator.Validate();

            Assert.AreEqual("Composite", sw.ToString().Trim());
        }

        [TestMethod]
        public void Should_Print_Prime()
        {
            var validator = new ValidatorNumberType("2", "2");
            var sw = new StringWriter();
            Console.SetOut(sw);
            validator.Validate();

            Assert.AreEqual("Prime", sw.ToString().Trim());
        }

    }
}