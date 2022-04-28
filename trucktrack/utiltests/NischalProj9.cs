using System;
using Xunit;
using util;

namespace utiltests
{
    public class NischalProj13
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
        public void CongdonToElevationTest()
        {
            // arrange

            double CongdonHallLat = 34.22596219930497;
            double CongdonHallLong = -77.87203493039985;
            double ElevationLat = 34.22008873250409;
            double ElevationLong = -77.89506431694839;
            // act
            double expected = 1.38;
            double actual = DistanceCalculator.EuclideanDistance(CongdonHallLat, CongdonHallLong, ElevationLat, ElevationLong);

            //Console.WriteLine("actual: " + actual.ToString());
            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True(difference <= 0.25,
       "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());


        }

    }
}
