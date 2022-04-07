using System;
using Xunit;
using util;

namespace utiltests
{
    public class MitchellProj13
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
        public void WilmingtonToHomeTest()
        {
            // arrange

            double WilmHouseLat = 36.487242669524576;
            double WilmHouseLong = -77.68794394820785;


            double HomeLat = 34.22617908276649;
            double HomeLong = -77.86933152852716;
            // act
            double expected = 155.70;
            double actual = DistanceCalculator.EuclideanDistance(WilmHouseLat, WilmHouseLong, HomeLat, HomeLong);

            //Console.WriteLine("actual: " + actual.ToString());
            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True(difference <= 1.00, "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());


        }

    }
}
