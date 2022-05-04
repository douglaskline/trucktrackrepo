using System;
using Xunit;
using util;

namespace utiltests
{
    public class VanderhoofProj13
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
        public void NewYorkToRomeDistanceTest()
        {
            // arrange

            double NewYorkLat = 40.70808095013751;
            double NewYorkLong = -74.0126731064848;
            double RomeLat = 41.903848184672505;
            double RomeLong = 12.49912753921051;
            // act
            double expected = 4281.915095793622;
            double actual = DistanceCalculator.EuclideanDistance(NewYorkLat, NewYorkLong, RomeLat, RomeLong);

            //Console.WriteLine("actual: " + actual.ToString());
            // assert
            double difference = Math.Abs(expected - actual);
            
            
            Xunit.Assert.True(difference <= 0.002000025,
                              "actual: " + actual.ToString() + " expected: " + expected.ToString() + 
                              " diff: " + difference.ToString());
        }

    }
}
