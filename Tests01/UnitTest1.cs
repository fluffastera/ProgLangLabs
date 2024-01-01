using lab01_1;

namespace Tests01
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestProduct()
        {
            Assert.That(Program.FindProduct([1, 2, 3, 4], 0, 4), Is.EqualTo(2 * 3 * 4));
            Assert.That(Program.FindProduct([1, 3, 5, 7], 1, 3), Is.EqualTo(3 * 5));
        }

        [Test]
        public void TestFindZero() {
            Assert.That(Program.FindZero([1, 2, 0, 3, 4]), Is.EqualTo(2));
            Assert.That(Program.FindZero([1, 2, 0, 3, 0]), Is.EqualTo(2));
            Assert.That(Program.FindZero([1, 2, 0, 3, 0], 3), Is.EqualTo(4));
            Assert.That(Program.FindZero([1, 2, 3]), Is.EqualTo(-1));
        }

        [Test]
        public void TestFindMaxIndex()
        {
            Assert.That(Program.FindMaxIndex([-1, 2, 0, 5, 1000, -100]), Is.EqualTo(4));
        }

        [Test]
        public void Test()
        {
            Assert.That(Program.MoveOddToTheFront([0, 1, 2, 3, 4, 5]), Is.EqualTo(new int[] { 0, 2, 4, 1, 3, 5 }));
            Assert.That(Program.MoveOddToTheFront([0, 1, 2, 3, 4]), Is.EqualTo(new int[] { 0, 2, 4, 1, 3 }));
        }
    }
}