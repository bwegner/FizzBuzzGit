using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NUnit.Framework;

namespace FizzBuzzGit
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Start();
            Console.WriteLine(result);

            var waitingClosing = Console.ReadKey();
            
        }
    }
    public class FizzBuzz
    {
        public string Start()
        {
            var result = string.Empty;
            for (int i = 1; i < 101; i++)
            {
                result = result + i;
            }
            return result;
        }
        
    }

    [TestFixture]
    public class TestClass
    {
        private FizzBuzz _FizzBuzz;

        [SetUp]
        public void Setup()
        {
            _FizzBuzz = new FizzBuzz();
        }

        [Test]
        public void ShouldReturnNotNullWhenStart()
        {
            Assert.That(_FizzBuzz.Start(), Is.Not.Null);
        }

        [Test]
        public void ShouldStartWithOne()
        {
            Assert.That(_FizzBuzz.Start(), Is.StringStarting("1"));
        }

        [Test]
        public void ShouldEndWithOnehundred()
        {
            Assert.That(_FizzBuzz.Start(), Is.StringEnding("100"));
        }
    }
}