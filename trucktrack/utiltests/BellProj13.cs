using System;
using Xunit;
using util;

namespace utiltests
{
    public class BellProj13
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
         public async void DistanceCalculatorEuclideanDistance()
        {
            // arrange
            
            double TapTeaLat = 34.23932;
            double TapTeaLong = -77.86711;
            double ChopdLat = 34.23542;
            double ChopdLong = -77.82751;
            // act
            double expected = 2.28;
            double actual = DistanceCalculator.EuclideanDistance(TapTeaLat,TapTeaLong,ChopdLat,ChopdLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 0.025, "actual: " + actual.ToString() + "expected: " + expected.ToString() + " diff: " + difference.ToString());
          
          
        }

    }
}
