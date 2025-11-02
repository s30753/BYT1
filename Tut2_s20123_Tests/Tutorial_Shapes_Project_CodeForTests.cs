using Tut2_s20123;
using NUnit.Framework;

namespace Tut2_s20123_Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly IShape sphere = new Sphere(5);

        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }

        [Test]
        public void TestSphereInvalidRadius_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Sphere(0));
        }

        //todo : Complete the remaning tests here
        private readonly IShape cylinder = new Cylinder(3, 7);

        [Test]
        public void TestCylinderCalculateArea()
        {
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.496).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
        }
        
        [Test]
        public void TestCylinderInvalidRadius_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(-1, 7));
        }
        
        [Test]
        public void TestCylinderInvalidHeight_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(3, -7));
        }

        private readonly IShape rectangle = new Rectangle(4, 8);

        [Test]
        public void TestRectangleCalculateArea()
        {
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(32).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateVolume()
        {
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
        }
        
        [Test]
        public void TestRectangleInvalidLength_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(0, 5));
        }
        
        [Test]
        public void TestRectangleInvalidHeight_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(2, -5));
        }

        private readonly IShape cube = new Cube(4);

        [Test]
        public void TestCubeCalculateArea()
        {
            Assert.That(cube.CalculateArea(), Is.EqualTo(96).Within(0.001));
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64).Within(0.001));
        }
        
        [Test]
        public void TestCubeInvalidSide_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Cube(0));
        }
    }
}