using System;
using Xunit;
using util;

namespace utiltests
{
    public class KlineProj13
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
        public void CongdonToKureBeachPierTest()
        {
            // arrange

            double CongdonHallLat = 34.22408243140725;
            double CongdonHallLong = -77.86957140799039;
            double KureBeachPierLat = 33.99806282719807;
            double KureBeachPierLong = -77.90575492327699;
            // act
            double expected = 15.90;
            double actual = DistanceCalculator.EuclideanDistance(CongdonHallLat, CongdonHallLong, KureBeachPierLat, KureBeachPierLong);

            //Console.WriteLine("actual: " + actual.ToString());
            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True(difference <= 0.25);


        }

    }
}
