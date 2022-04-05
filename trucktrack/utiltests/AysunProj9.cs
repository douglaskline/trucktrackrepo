using System;
using Xunit;
using util;

namespace utiltests
{
    public class AysunProj9
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
            
            double IstanbullsLat = 34.24356113740563;
            double IstanbullsLong = -77.87264911762053;
            double CongdonHallLat = 34.22576772424139;
            double CongdonHallLong = -77.87173435994941;
            // act
            double expected = 1.23;
            double actual = DistanceCalculator.EuclideanDistance(IstanbullsLat,IstanbullsLong,CongdonHallLat,CongdonHallLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True(difference <= 0.25);
                       "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString();
          
        }

    }
}
