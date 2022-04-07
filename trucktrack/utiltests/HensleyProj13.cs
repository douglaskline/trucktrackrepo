using System;
using Xunit;
using util;

namespace utiltests
{
    public class HensleyProj13
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
            
            double xLat = 24.547247406217483;
            double xLong = -81.78725284822347;
            double yLat = 34.22282496667014;
            double yLong = -77.86343988551839;
            // act
            double expected = 708;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 0.25,
           "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());
          
        }

    }
}
