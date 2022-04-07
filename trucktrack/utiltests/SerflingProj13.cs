using System;
using Xunit;
using util;

namespace utiltests
{
    public class SerflingProj13
    {
        [Fact]
        public void DistanceCalculatorConstructorWorks()
        {
            // arrange
            util.DistanceCalculator d = new DistanceCalculator();

            // act

            // assert
          Assert.IsType<util.DistanceCalculator>(d);       
        }

        [Fact]
         public void DistanceCalculatorEuclideanDistance()
        {

            // 4206 Academy Cove to Aspire 349 bus stop

            // arrange
            
            double xLat = 34.23521;
            double xLong = -77.89001;
            double yLat = 34.23526;
            double yLong = -77.89130;
            // act
            double expected = 0.0740965909;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);


            Xunit.Assert.True(difference <= 0.25,"actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());



        }

    }
}
