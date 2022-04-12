using System;
using Xunit;
using util;

namespace utiltests
{
    public class RobertProj13
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
            // Home - 34.74312621775176, -77.48137988644639
            // Myu Myu - 38.58415147377761, -121.74067207927031
            // total distance - 2443.92 mi / 3933.1 km
            double xLat = 34.74312;
            double xLong = -77.48137;
            double yLat = 38.58415;
            double yLong = -121.74067;
            // act
            double expected = 2443.92;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True(difference <= 2.5,
       "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());
          
          
        }

    }
}
