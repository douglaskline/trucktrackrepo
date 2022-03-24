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
            string priceRange = "$$$";
            string tagLine = "Asian fusion street food, brought to your streets";
            string foodStyle = "Asian Fusion";
            int truckId = 17;

            // act
            dal.truck tr = new dal.truck();
            tr.truckName = truckName;
            tr.homeCity = homeCity;
            tr.homeState = homeState;
            tr.truckURL = url;
            tr.priceRange = priceRange;
            tr.tagLine = tagLine;
            tr.foodStyle = foodStyle;
            tr.truckId = truckId;

            // assert
            Assert.Equal(tr.truckName,truckName);
            Assert.Equal(tr.homeCity,homeCity);
            Assert.Equal(tr.homeState,homeState);
            Assert.Equal(tr.truckURL,url);
            Assert.Equal(tr.priceRange, priceRange);
            Assert.Equal(tr.tagLine, tagLine);
            Assert.Equal(tr.foodStyle, foodStyle);
            Assert.Equal(tr.truckId, truckId) ;         
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
