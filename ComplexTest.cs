using ComplexNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ComplexNumberTest
{
    [TestClass]
    public class ComplexTest
    {

        [TestMethod]
        public void Add_AddTwoComplexNumbers_CorrectSum()
        {
            // Arrange
            IComplexN complex1 = new ComplexN(2, 3);
            IComplexN complex2 = new ComplexN(4, 5);
            ComplexN expected = new ComplexN(6, 8);

            // Act
            ComplexN result = complex1.Add(complex2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddToReal_AddRealToComplexNumber_CorrectSumWithReal()
        {
            // Arrange
            IComplexN complex = new ComplexN(2, 3);
            double realToAdd = 5;
            ComplexN expected = new ComplexN(7, 3);

            // Act
            ComplexN result = complex.AddToReal(realToAdd);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Argument_CalculateArgumentOfComplexNumber_ReturnsDoubleValue()
        {
            // Arrange
            IComplexN complex = new ComplexN(1, 1);
            double expected = Math.PI / 4;

            // Act
            double result = complex.Argument();

            // Assert
            Assert.AreEqual(expected, result, 0.01, "Argument calculation test error");
        }


        [TestMethod]
        public void Module_CalculateModuleOfComplexNumber_ReturnsDoubleValue()
        {
            // Arrange
            IComplexN complex = new ComplexN(3, 4);
            double expected = 5;

            // Act
            double result = complex.Module();

            // Assert
            Assert.AreEqual(expected, result, 0.1, "Module calculation test error");
        }

        [TestMethod]
        public void Multiply_MultiplyTwoComplexNumbers_CorrectMultiplication()
        {
            // Arrange
            IComplexN complex1 = new ComplexN(1, 2);
            IComplexN complex2 = new ComplexN(3, 4);
            ComplexN expected = new ComplexN(-5, 10);

            // Act
            ComplexN result = complex1.Multiply(complex2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MultiplyByReal_MultiplyRealToComplexNumber_CorrectMultiplicationByReal()
        {
            // Arrange
            IComplexN complex = new ComplexN(1, 2);
            double realToMultiply = 3;
            ComplexN expected = new ComplexN(3, 6);

            // Act
            ComplexN result = complex.MultiplyByReal(realToMultiply);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Subtract_SubtractTwoComplexNumbers_CorrectSubtraction()
        {
            // Arrange
            IComplexN complex1 = new ComplexN(7, 5);
            IComplexN complex2 = new ComplexN(3, 4);
            ComplexN expected = new ComplexN(4, 1);

            // Act
            ComplexN result = complex1.Subtract(complex2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Equals_CompareTwoEqualComplexNumbers_ReturnsTrue()
        {
            // Arrange
            IComplexN complex1 = new ComplexN(3, 4);
            IComplexN complex2 = new ComplexN(3, 4);

            // Act & Assert
            Assert.IsTrue(complex1.Equals(complex2), "The two complex numbers should be equal.");
        }

        [TestMethod]
        public void Equals_CompareTwoDifferentComplexNumbers_ReturnsFalse()
        {
            // Arrange
            IComplexN complex1 = new ComplexN(3, 4);
            IComplexN complex2 = new ComplexN(5, 6);

            // Act & Assert
            Assert.IsFalse(complex1.Equals(complex2), "The two complex numbers should not be equal.");
        }

        [TestMethod]
        public void ToString_ReturnsCorrectStringRepresentation()
        {
            // Arrange
            IComplexN complex = new ComplexN(2, 3);
            string expected = "2 + 3i";

            // Act
            string result = complex.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
