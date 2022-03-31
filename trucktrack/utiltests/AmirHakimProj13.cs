using System;
using Xunit;
using util;

namespace utiltests
{
    public class AmirHakimProj13
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
            
            double xLat = 35.087344;
            double xLong = -80.863706;
            double yLat = 35.855636;
            double yLong = -78.571072;
            // act
            double expected = 139.5;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 0.25);
          
          

Xunit.Assert.True(difference <= 0.25,
       "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());


        }

    }
}
