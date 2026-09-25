using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int x = 10;
            int y = 10;
            int z = -15;

            // Act
            int res = MyMath.Sum(x, y);
            int res2 = MyMath.Sum(x, z);

            // Assert
            Assert.AreEqual(20, res);
            Assert.AreEqual(-5, res2);
        }
    }
}
