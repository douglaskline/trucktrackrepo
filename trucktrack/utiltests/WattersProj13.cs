using System;
using Xunit;
using util;

namespace utiltests
{
    public class WattersProj13
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
            //old fort
            double OldLat = 34.26305291591299;
            double OldLong = -77.79125228853309;

            //Middle Sound Church
 

            double SoLat = 34.26759268197306;
            double SoLong = -77.77906433123125;
            // act
            double expected = 0.7394317;
            double actual = DistanceCalculator.EuclideanDistance(OldLat,OldLong,SoLat,SoLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

         Xunit.Assert.True (difference <= 0.25,
            "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());
          
          
        }

    }
}
