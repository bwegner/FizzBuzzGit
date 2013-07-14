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
            return result;
        }
        
    }

    [TestFixture]
    public class TestClass
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void ShouldReturnNotNullWhenStart()
        {
            Assert.That(_fizzBuzz.Start(), Is.Not.Null);
        }
    }
}