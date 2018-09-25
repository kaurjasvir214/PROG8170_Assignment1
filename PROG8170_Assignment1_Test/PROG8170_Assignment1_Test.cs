using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG8170_Assignment1;
using NUnit.Framework;
namespace PROG8170_Assignment1_Test
{
    [TestFixture]
    public class PROG8170_Assignment1_Test
    {
        [Test]
        public void GetLength_InputValue_15_ExpectedLength_15()
        {
            // Arrange
            int len = 15;
            int wid = 15;
            Rectangle rectangle = new Rectangle(len, wid);
            // Act
            int length = rectangle.GetLength();
            // Assert
            Assert.AreEqual(length, len);
        }

        [Test]
        public void SetLength_InputValue_4_ExpectedLength_4()
        {
            // Arranage
            int len = 4;
            Rectangle rectangle = new Rectangle();
            rectangle.SetLength(len);
            // Act
            int length = rectangle.GetLength();
            // Assert
            Assert.AreEqual(length, len);
        }

        [Test]
        public void GetWidth_InputValue_30_ExpectedWidth_30()
        {
            // Arranage
            int len = 30;
            int wid = 30;
            Rectangle rectangle = new Rectangle(len, wid);
            // Act
            int width = rectangle.GetWidth();
            // Assert
            Assert.AreEqual(width, wid);
        }

        [Test]
        public void SetWidth_InputValue_12_ExpectedWidth_12()
        {
            // Arranage
            int len = 12;
            int wid = 12;
            Rectangle rectangle = new Rectangle(len, wid);
            // Act
            int width = rectangle.SetWidth(wid);
            // Assert
            Assert.AreEqual(width, wid);
        }

        [Test]
        public void GetPerimeter_InputLength_5_InputWidth_5_ExpectedPerimeter_20()
        {
            // Arranage
            int len = 5;
            int wid = 5;
            int per = 2 * (5 + 5);

            Rectangle rectangle = new Rectangle(len, wid);
            // Act
            int perimeter = rectangle.GetPerimeter();
            // Assert
            Assert.AreEqual(perimeter, per);
        }

        [Test]
        public void GetArea_InputLength_15_InputWidth_15_ExpectedArea_225()
        {
            // Arranage
            int len = 15;
            int wid = 15;
            int ar = len * wid;
            Rectangle rectangle = new Rectangle(len, wid);
            // Act
            int area = rectangle.GetArea();
            // Assert
            Assert.AreEqual(area, ar);
        }

    }
}
