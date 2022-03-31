using System;
using Xunit;
using util;

namespace utiltests
{
    public class KlineProj13
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
            // arrange
            
            double CongdonHallLat = 34.22697;
            double CongdonHallLong = -77.86989;
            double BatmanLat = 37.88954;
            double BatmanLong = -41.12929;
            // act
            double expected = 6103.35;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

         Xunit.Assert.True(difference <= 0.000000025, "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());
          
          
        }

    }
}
