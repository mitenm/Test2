using NUnit.Framework;

namespace Test2
{
    [TestFixture]
    class ProgramTest
    {
        [Test]
        public void TestInt()
        {
            Assert.AreEqual(Program.ReturnFixDigit(), 6);
        }
    }
}
