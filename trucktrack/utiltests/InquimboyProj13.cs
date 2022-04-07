using System;
using Xunit;
using util;

namespace utiltests
{
    public class InquimboyProj13
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
         public void DisneyWorldtoDisneyLandTest()
        {
            // arrange
            
            double DWLat = 28.377412233552544;
            double DWLong = -81.57067562902132;
            double DLLat = 34.47334799137856;
            double DLLong = -118.02744321919174;
            // act
            double expected = 2177.11;
            double actual = DistanceCalculator.EuclideanDistance(DWLat,DWLong,DLLat,DLLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 10);
          
          
        }

    }
}