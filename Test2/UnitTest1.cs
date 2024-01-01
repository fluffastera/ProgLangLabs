using lab01_2;


namespace Test2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFindSumsOfNegativeRows()
        {
            Assert.That(Program.FindSumsOfNegativeRows(new int[,] { { 1, 2, 3 }, { -1, 4, 5 }, { -6, -7, -8 } }), Is.EqualTo(new List<int>([8, -6 + -7 + -8])));
        }

        [Test]
        public void TestFindMatchingRowsColumns()
        {
            Assert.That(Program.FindMatchingRowsColumns(new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } }), Is.EqualTo(new List<int>([0, 1, 2])));
            Assert.That(Program.FindMatchingRowsColumns(new int[,] { { 1, 11, 3, 0 }, { 11, 15, 4, 11 }, { 3, 0, 0, 0 }, { 0, 11, 0, 9 } }), Is.EqualTo(new List<int>([0, 3])));
            Assert.That(Program.FindMatchingRowsColumns(new int[,] { { 1, 2, 11 }, { 2, 79, 4 }, { 11, 138, 5 } }), Is.EqualTo(new List<int>([0])));
            Assert.That(Program.FindMatchingRowsColumns(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }), Is.EqualTo(new List<int>()));
        }
    }
}