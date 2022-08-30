using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod("Testing Circle Area")]
        public void CircleAreaTest()
        {
            double Expected = 28.2743;
            double[] Params = { 3 };
            Circle TestCircle = new Circle(Params);
            double Actual = Math.Round(TestCircle.Area(), 4);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod("Testing Triangle Area")]
        public void TriangleAreaTest()
        {
            double Expected = 8.94;
            double[] Params = { 3, 7, 6 };
            Triangle TestTriangle = new Triangle(Params);
            double Actual = Math.Round(TestTriangle.Area(), 2);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod("Testing If A Triangle Is Right")]
        public void TriangleRightTest()
        {
            double[] ParamsFalse = { 3, 7, 6 };
            double[] ParamsTrue = { 3, 4, 5 };
            Triangle AcuteTriangle = new Triangle(ParamsFalse);
            Triangle RightTriangle = new Triangle(ParamsTrue);
            Assert.IsFalse(AcuteTriangle.IsRight());
            Assert.IsTrue(RightTriangle.IsRight());
        }

        public void RectangleAreaTest()
        {
            double Expected = 15;
            double[] Params = { 3, 5 };
            Rectangle TestRectangle = new Rectangle(Params);
            double Actual = Math.Round(TestRectangle.Area(), 0);
            Assert.AreEqual(Expected, Actual);
        }

        public void RectangleSquareTest()
        {
            double[] ParamsFalse = { 7, 5 };
            double[] ParamsTrue = { 6, 6 };
            Rectangle TestRectangle = new Rectangle(ParamsFalse);
            Rectangle TestSquare = new Rectangle(ParamsTrue);
            Assert.IsFalse(TestRectangle.IsSquare());
            Assert.IsTrue(TestSquare.IsSquare());
        }

        [TestMethod("Testing General Figure Area")]
        public void GeneralFigureAreaTest()
        {
            double Expected, Actual;
            double[] Params;
            Figure TestFigure;

            Assert.ThrowsException<ArgumentNullException>(() => TestFigure = FigureSelector.Select(null));

            Expected = 28.2743;
            Params = new double[] { 3 };
            TestFigure = FigureSelector.Select(Params);
            Actual = Math.Round(TestFigure.Area(), 4);
            Assert.AreEqual(Expected, Actual);

            Expected = 15;
            Params = new double[] { 3, 5 };
            TestFigure = FigureSelector.Select(Params);
            Actual = Math.Round(TestFigure.Area(), 0);
            Assert.AreEqual(Expected, Actual);

            Expected = 8.94;
            Params = new double[] { 3, 7, 6 };
            TestFigure = FigureSelector.Select(Params);
            Actual = Math.Round(TestFigure.Area(), 2);
            Assert.AreEqual(Expected, Actual);

            Params = new double[] { 0, 1, 2, 3 };
            Assert.ThrowsException<NullReferenceException>(() => TestFigure = FigureSelector.Select(Params));
        }
    }
}