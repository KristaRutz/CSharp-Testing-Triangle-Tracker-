using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests 
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void IsTriangle_AllSidesAreEqual_True()
    {
      Triangle testTriangle = new Triangle(1, 1, 1);
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }

    [TestMethod]
    public void IsTriangle_TwoSidesAreEqual_True()
    {
      Triangle testTriangle = new Triangle(2, 2, 3);
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }

    [TestMethod]
    public void IsTriangle_Scalene_True()
    {
      Triangle testTriangle = new Triangle(2,3,4);
      Assert.AreEqual(true, testTriangle.IsTriangle());      
    }

    [TestMethod]
    public void IsTriangle_NotATriangle_False()
    {
      Triangle testTriangle = new Triangle (1, 2, 5);
      Assert.AreEqual(false, testTriangle.IsTriangle());
    }
  }
}