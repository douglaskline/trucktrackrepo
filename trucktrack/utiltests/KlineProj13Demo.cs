using System;
using Xunit;
using util;

namespace utiltests
{
    public class KlineProj13Demo
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
            // red hat amphitheatre
            double RHLat =35.77409844306696;
            double RHLong = -78.6429419700229;

            //congdon hall
            double CHLat = 34.225749963941446;
            double CHLong = -77.87173435272524;

            // act
            double expected = 129.4;
            double actual = DistanceCalculator.EuclideanDistance(RHLat,RHLong,CHLat,CHLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True(difference <= 15, "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());

          
          
        }

    }
}
