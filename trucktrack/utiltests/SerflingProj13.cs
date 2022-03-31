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
            // arrange
            
            double xLat = 39.92495;
            double xLong = -74.86540;
            double yLat = 36.11603;
            double yLong = -75.74566;
            // act
            double expected = 4.802481904079362;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True(difference <= 0.000000025, "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());
        }

    }
}
