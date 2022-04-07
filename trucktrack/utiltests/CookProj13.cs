using System;
using Xunit;
using util;

namespace utiltests
{
    public class CookProj13
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
        public void EmpireStateBuildingToCapeFloridaLighthouseTest()
        {
            // arrange

            double EmpireStateBuildingLat = 40.74865897078839;
            double EmpireStateBuildingLong = -73.98576350176455;
            double CapeFloridaLighthouseLat = 25.679659625991004;
            double CapeFloridaLighthouseLong = -80.15462229392472;
            // act
            double expected = 1099.52;
            double actual = DistanceCalculator.EuclideanDistance(EmpireStateBuildingLat, EmpireStateBuildingLong, CapeFloridaLighthouseLat, CapeFloridaLighthouseLong);

            //Console.WriteLine("actual: " + actual.ToString());
            // assert
            double difference = Math.Abs(expected - actual);
            
            Xunit.Assert.True(difference <= 0.000000025,
                              "actual: " + actual.ToString() + " expected: " + expected.ToString() + 
                              " diff: " + difference.ToString());
        }

    }
}
