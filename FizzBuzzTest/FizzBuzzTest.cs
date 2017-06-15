using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTest
{
    
    [TestClass]
    public class FizzBuzzTest
    {
        private Fizz fizzbuzz;

        [TestInitialize]
        public void Setup()
        {
            fizzbuzz = new Fizz();
        }

        [TestMethod]
        public void NoFizzOrBuzz_0()
        {
            var result = fizzbuzz.FizzOrBuzz(0);

            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void NoFizzOrBuzz_1()
        {
            var result = fizzbuzz.FizzOrBuzz(1);

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void NoFizzOrBuzz_2()
        {
            var result = fizzbuzz.FizzOrBuzz(2);

            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void Fizz_3()
        {
            var result = fizzbuzz.FizzOrBuzz(3);

            Assert.AreEqual("fizz", result);
        }

        [TestMethod]
        public void Buzz_5()
        {
            var result = fizzbuzz.FizzOrBuzz(5);

            Assert.AreEqual("buzz", result);
        }

        [TestMethod]
        public void Fizz_6()
        {
            var result = fizzbuzz.FizzOrBuzz(6);

            Assert.AreEqual("fizz", result);
        }

        [TestMethod]
        public void FizzBuzz_15()
        {
            var result = fizzbuzz.FizzOrBuzz(15);

            Assert.AreEqual("fizzbuzz", result);
        }
    }
}
