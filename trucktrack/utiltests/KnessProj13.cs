using System;
using Xunit;
using util;

namespace utiltests
{
    public class KnessPoj13
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
            
            double SUdaysLat = 34.1939862028932;
            double SUndaysLong = -77.80631623408838;
            double SolaCafeLat = 35.88619510327714;
            double SolaCafeLong = -78.66041715229247;
            // act
            double expected = 126.45;
            double actual = DistanceCalculator.EuclideanDistance(SUdaysLat,SUndaysLong,SolaCafeLat,SolaCafeLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 0.25, "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());
          
          
          
        }

    }
}
