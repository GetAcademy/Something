using NUnit.Framework;

namespace Something.Test
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            // arrange

            // act
            var magicNumber = Calculator.GetMagicNumber(20, 2);

            // assert
            Assert.AreEqual(10, magicNumber);
        }


        [Test]
        public void Test2()
        {
            // arrange

            // act
            var magicNumber = Calculator.GetMagicNumber(-20, 2);

            // assert
            Assert.AreEqual(10, magicNumber);
        }

        [Test]
        public void Test3()
        {
            // arrange

            // act
            var magicNumber = Calculator.GetMagicNumber(-20, 0);

            // assert
            Assert.AreEqual(null, magicNumber);
        }
    }
}