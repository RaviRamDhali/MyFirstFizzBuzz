using FixxBuzz;
using NUnit.Framework;

namespace FizzBuzzTestProject
{
    public class Tests
    {
        public DoFizzBuzz srv;

        [SetUp]
        public void Setup()
        {
            srv = new FixxBuzz.DoFizzBuzz(100, "Fizz","Buzz");
        }

        [Test]
        public void Divisible3()
        {   
            Assert.AreEqual("Fizz", srv.GetPrintableString(3));
            Assert.AreEqual("Fizz", srv.GetPrintableString(6));
            Assert.AreEqual("Fizz", srv.GetPrintableString(9));
        }

        [Test]
        public void Divisible5()
        {
            Assert.AreEqual("Buzz", srv.GetPrintableString(5));
            Assert.AreEqual("Buzz", srv.GetPrintableString(10));
        }

        [Test]
        public void Fifteen()
        {
            Assert.AreEqual("Fizz Buzz", srv.GetPrintableString(15));
        }

        [Test]
        public void Default()
        {
            int one = 1;
            Assert.AreEqual(one.ToString(), srv.GetPrintableString(one));

            int oneone = 11;
            Assert.AreEqual(oneone.ToString(), srv.GetPrintableString(oneone));

        }
    }
}