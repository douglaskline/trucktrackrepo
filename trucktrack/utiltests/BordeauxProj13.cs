using System;
using Xunit;
using util;

namespace utiltests
{
    public class BordeauxProj13
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
            
            double xLat = 36.20710;
            double xLong = -86.69208;
            double yLat = 28.37832;
            double yLong = -81.57010;
            // act
            double expected = 618;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 2,
                  "actual: " + actual.ToString() + " expected: " + expected.ToString() +" diff: " + difference.ToString());
          
          
        }

    }
}
