using System;
using Xunit;
using util;

namespace utiltests
{
    public class NguyenProj13
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
            double actual = DistanceCalculator.EuclideanDistance(BatmanLat,BatmanLong,CongdonHallLat,CongdonHallLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

         Xunit.Assert.True(difference <= 5000, "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());
          
          
        }

    }
}
