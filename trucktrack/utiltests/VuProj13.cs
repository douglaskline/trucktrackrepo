using System; 
using Xunit;
using util;

namespace utiltests
{
    public class VuProj13
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
         public void RandallLibraryToMadisonSquareGardenTest()
        {
            // arrange
            
            double RandallLibraryLat = 34.22799004747062;
            double RandallLibraryLong = -77.87426608846991;
            double MadisonSquareGardenLat = 40.75074018304554;
            double MadisonSquareGardenLong = -73.99343870183384;
            // act
            double expected = 498.23;
            double actual = DistanceCalculator.EuclideanDistance(RandallLibraryLat,RandallLibraryLong,MadisonSquareGardenLat,MadisonSquareGardenLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True(difference <= 1.25,
       "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());
          
          
        }

    }
}

