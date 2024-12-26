using lab01;

namespace lab1._1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 1);
            Point p3 = new Point(2, 1);
            Point p4 = new Point(2, 0);
            Figure rectangle = new Figure(p1, p2, p3, p4);

            double per = 6;
            double perimetr = rectangle.PerimeterCalculator();
            Assert.AreEqual(perimetr, per);
        }
    }
}