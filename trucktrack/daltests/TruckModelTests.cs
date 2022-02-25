using System;
using Xunit;
using dal;

namespace daltests
{
    public class TruckModelTests
    {   
        [Fact]
        public void CreateTruckObject()
        {
            // arrange
            string truckName = "Banh Sai";
            string homeCity = "Wilmington";
            string homeState = "NC";
            string url = "https://www.banhsaifoodtruck.com/";

            // act
            dal.truck tr = new dal.truck();
            tr.truckName = truckName;
            tr.homeCity = homeCity;
            tr.homeState = homeState;
            tr.truckURL = url;

            // assert
            Assert.Equal(tr.truckName,truckName);
            Assert.Equal(tr.homeCity,homeCity);
            Assert.Equal(tr.homeState,homeState);
            Assert.Equal(tr.truckURL,url);
          
        }

 


        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

    }
}
