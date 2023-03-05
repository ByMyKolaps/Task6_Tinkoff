using Task6;

namespace Task6_Tests
{
    public class Tests
    {
        [TestCase(new long[] { 1, 2 }, -1, -1)]
        [TestCase(new long[] { 2, 1 }, 1, 2)]
        [TestCase(new long[] { 1, 1 }, -1, -1)]
        [TestCase(new long[] { 2, 2 }, -1, -1)]
        [TestCase(new long[] { 1, 2, 1 }, 1, 3)]
        [TestCase(new long[] { 1, 2, 2 }, -1, -1)]
        [TestCase(new long[] { 2, 1, 1 }, 1, 2)]
        [TestCase(new long[] { 2, 1, 2 }, -1, -1)]
        [TestCase(new long[] { 1, 1, 2 }, 2, 3)]
        [TestCase(new long[] { 1, 1, 1 }, -1, -1)]
        [TestCase(new long[] { 2, 2, 1 }, -1, -1)]
        [TestCase(new long[] { 2, 2, 2 }, -1, -1)]
        [TestCase(new long[] { 2, 1, 2, 1 }, -1, -1)]
        [TestCase(new long[] { 1, 2, 1, 2 }, 1, 3)]
        [TestCase(new long[] { 2, 1, 1, 2 }, 1, 2)]
        [TestCase(new long[] { 1, 1, 2, 2 }, 2, 3)]
        [TestCase(new long[] { 1, 2, 2, 1 }, 3, 4)]
        [TestCase(new long[] { 2, 2, 1, 2 }, -1, -1)]
        [TestCase(new long[] { 1, 1, 1, 2 }, -1, -1)]
        [TestCase(new long[] { 1, 2, 1, 1 }, -1, -1)]
        [TestCase(new long[] { 2, 1, 2, 2 }, -1, -1)]
        public void Task6_Tests(long[] longs, int expectedI, int expectedJ)
        {
            var actual = Program.Task6(longs.Length, longs);
            Assert.That(expectedI, Is.EqualTo(actual.Item1));
            Assert.That(expectedJ, Is.EqualTo(actual.Item2));
        }
    }
}