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
            
            double xLat = 28.37820;
            double xLong = -81.57040;
            double yLat = 36.21718;
            double yLong = -86.69049;
            // act
            double expected = 4.802481904079362;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 0.0001);
          
          
        }

    }
}
