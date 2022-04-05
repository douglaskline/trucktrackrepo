using System;
using Xunit;
using util;

namespace utiltests
{
    public class utilTest1
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
            
            double xLat = 34.22697;
            double xLong = -77.86989;
            double yLat = 34.24539;
            double yLong = -77.95102;
            // act
            double expected = 4.802481904079362;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 0.01);
          
          
        }

    }
}
