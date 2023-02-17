using SquareCalc;
namespace SqureCalculaton.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Circle_4radios_50_27returned()
    {
        //arrange
        var circle = new Circle("Circle", 4);
        double expected = 50.26548245743669;
        //act
        var result = circle.Square();
        //assert
        Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void Triangle_3_4_5_sides_6returned()
    {
        //arrange
        var triangle = new Triangle("Triangle",3, 4, 5);
        double expected = 6;
        //act
        var result = triangle.Square();
        //assert
        Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void IsRightTriangle_returned_true()
    {
        //arrange
        var triangle = new Triangle("Triangle",6,8, 10);
        //assert
        bool check = triangle.IsRightTriangle();
        //assert
        Assert.IsTrue(check);
    }
   
}
