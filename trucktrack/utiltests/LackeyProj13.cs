using System;
using Xunit;
using util;

namespace utiltests
{
    public class LackeyProj13
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
            


            //Mall of America
            double xLat = 44.85751011608824;
            double xLong = -93.24312224665734;



            //King of Prussia
            double yLat = 40.100600063297016;
            double yLong = -75.3837985407523;
            // act
            double expected = 965.08;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 25,"actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());
          
           
          
          
        }

    }
}
