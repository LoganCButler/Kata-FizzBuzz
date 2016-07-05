using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InputIs1()
        {
            int input = 1;
            FizzBuzzLogic x = new FizzBuzzLogic();

            string outPut = x.FizzBuzzer(input);

            Assert.AreEqual("1", outPut);
        }

        [TestMethod]
        public void InputIs3()
        {
            int input = 3;
            FizzBuzzLogic x = new FizzBuzzLogic();

            string outPut = x.FizzBuzzer(input);

            Assert.AreEqual("Fizz", outPut);
        }

        [TestMethod]
        public void InputIs5()
        {
            int input = 5;
            FizzBuzzLogic x = new FizzBuzzLogic();

            string outPut = x.FizzBuzzer(input);

            Assert.AreEqual("Buzz", outPut);
        }

        [TestMethod]
        public void InputIs30()
        {
            int input = 30;
            FizzBuzzLogic x = new FizzBuzzLogic();

            string outPut = x.FizzBuzzer(input);

            Assert.AreEqual("FizzBuzz", outPut);
        }


    }
}
