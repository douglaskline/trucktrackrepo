using System;
using Xunit;
using util;

namespace utiltests
{
    public class RoweProj13
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
            
            //Lighthouse Apts
            double LALat = 34.23139276818082;
            double LALong = -77.87990892948537;
            //Pour Taproom
            double PTLat = 34.23787111250938;
            double PTLong = -77.94921627366021;
            // act
            double expected = 4.00;
            double actual = DistanceCalculator.EuclideanDistance(LALat,LALong,PTLat,PTLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True(difference <= 0.25, "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());
          
          
        }

    }
}
