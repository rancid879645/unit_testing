namespace CalcStats.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Should_Throw_For_Digit_A_Char_in_the_list()
        {
            void Action() => new Operations("1-2-3-k-5");
            Assert.ThrowsException<InvalidCastException>(Action);
        }

        [TestMethod]
        public void Should_Throw_When_Is_Empty()
        {
            void Action() => new Operations(string.Empty);
            Assert.ThrowsException<ArgumentNullException>(Action);
        }

        [TestMethod]
        public void Should_Throw_When_The_Separator_Is_Different()
        {
            void Action() => new Operations("1*2*3*4*5");
            Assert.ThrowsException<ArgumentException>(Action);
        }

        [TestMethod]
        public void Should_Return_The_Min_Integer()
        {
            var numbers = new Operations("1-2-3-4-5");
            int Action() => numbers.GetMinValue();
            Assert.AreEqual(1,Action());
        }

        [TestMethod]
        public void Should_Return_The_Max_Number()
        {
            var numbers = new Operations("1-20-35-4-5");
            int Action() => numbers.GetMaxValue();
            Assert.AreEqual(35, Action());
        }

        [TestMethod]
        public void Should_Return_The_Average()
        {
            var numbers = new Operations("1-25-30-68-94");
            float Action() => numbers.GetAverageValue();
            Assert.AreEqual(43.599998474121094, Action());
        }

        [TestMethod]
        public void Should_Return_The_total_of_Element_in_the_list()
        {
            var numbers = new Operations("30-68");
            int Action() => numbers.CountElements();
            Assert.AreEqual(2, Action());
        }

    }
}