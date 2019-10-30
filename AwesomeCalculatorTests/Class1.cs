using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AwesomeCalculator;

namespace AwesomeCalculatorTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetAddition_Input11point4and66point6_Returns78point0()
        {

            //Arrange
            double number1 = 11.4;
            double number2 = 66.6;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetAddition_Input200point3and210point7_Returns410point0()
        {

            //Arrange
            double number1 = 200.3;
            double number2 = 210.7;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetAddition_Input444point4and220point4_Returns664point8()
        {

            //Arrange
            double number1 = 444.4;
            double number2 = 220.4;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetSubtraction_Input700point6and400point3_Returns300point3()
        {

            //Arrange
            double number1 = 700.6;
            double number2 = 400.3;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetSubtraction_Input50point5and11point4_Returns39point1()
        {

            //Arrange
            double number1 = 50.5;
            double number2 = 11.4;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetSubtraction_Input17point3and10point3_Returns7point0()
        {

            //Arrange
            double number1 = 17.3;
            double number2 = 10.3;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetMultiplication_Input22point0and10point0_Returns220point0()
        {

            //Arrange
            double number1 = 22.0;
            double number2 = 10.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetMultiplication_Input6point0and5point0_Returns48point0()
        {

            //Arrange
            double number1 = 6.0;
            double number2 = 8.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetMultiplication_Input50point0and9point0_Returns450point0()
        {

            //Arrange
            double number1 = 50.0;
            double number2 = 9.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetDivision_Input48point0and6point0_Returns8point0()
        {

            //Arrange
            double number1 = 48.0;
            double number2 = 6.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetDivision_Input80point0and10point0_Returns8point0()
        {

            //Arrange
            double number1 = 80.0;
            double number2 = 10.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetDivision_Input6point0and12point0_Returns0point5()
        {

            //Arrange
            double number1 = 6.0;
            double number2 = 12.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}