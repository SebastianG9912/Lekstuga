using System;
using System.Diagnostics;
using Xunit;

namespace Tester
{
    public class Tester
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void AlwaysFail()
        {
            //Assert.True(false);
        }

        [Fact]
        public void TestaVariabler()
        {
            Assert.True("Jag har fyllt " + 29 == "Jag har fyllt 29");

            //Test below will fail
            /*int bigNumber = 2147483647;
            int biggerNumber = bigNumber + 1;
            Assert.True(biggerNumber > bigNumber);*/

            string purchaseDrink;
            int age = 28;

            if (age > 18)
            {
                purchaseDrink = "Beer";
            }
            else
            {
                purchaseDrink = "Coca-cola";
            }

            Assert.Equal("Beer", purchaseDrink);
        }

        [Fact]
        public void TestaEmptyString()
        {
            Assert.Equal(String.Empty, "");
        }
    }
}
