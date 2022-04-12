using System;
using Xunit;
using util;

namespace utiltests
{
    public class utilTest1
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
            
            double xLat = 34.22697;
            double xLong = -77.86989;
            double yLat = 34.24539;
            double yLong = -77.95102;
            // act
            double expected = 4.802481904079362;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 0.01);
          
          
        }

        [Fact]
        public void NSDistanceTest()
        {
            // arrange
            
            double xLat = 34.22697;
            double yLat = 34.24539;

            // act
            double expected = 1.27;
            double actual = DistanceCalculator.NSDistance(xLat, yLat);

            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True (difference <= 0.01,
              "actual: " + actual.ToString() + " expected: " + expected.ToString());
    
        }

      [Fact]
        public void NSDistanceTestNguyen()
        {
            // arrange
            
            double xLat = 34.22369;
            double yLat = 34.28423;

            // act
            double expected = 1.27;
            double actual = DistanceCalculator.NSDistance(xLat, yLat);

            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True (difference <= 0.01,
              "actual: " + actual.ToString() + " expected: " + expected.ToString());
    
        }

        [Fact]
         public void DistanceCalculatorEWDistance()
        {
            // arrange
            
            double xLat = 34.22697;
            double xLong = -77.86989;
            double yLat = 34.24539;
            double yLong = -77.95102;
            // act
            double expected = 4.63;
            double actual = DistanceCalculator.EWDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 0.01,
             "expected: " + expected.ToString() + " actual: "+ actual.ToString());
        }

                [Fact]
         public void DistanceCalculatorRectilinear()
        {
            // arrange
            
            double xLat = 34.22697;
            double xLong = -77.86989;
            double yLat = 34.24539;
            double yLong = -77.95102;
            // act
            double expected = 4.63 + 1.27;
            double actual = DistanceCalculator.RectilinearDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

          Xunit.Assert.True (difference <= 0.01,
             "expected: " + expected.ToString() + " actual: "+ actual.ToString());
        }

[Fact] 
public void NSDistanceTestAmirHakim()
        {
            // arrange
            
            double xLat = 42.27307;
            double yLat = 34.2111;


            // act
            double expected = 556.27593;
   
            double actual = DistanceCalculator.NSDistance(xLat, yLat);

            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True (difference <= 0.01,
              "actual: " + actual.ToString() + " expected: " + expected.ToString());
    
        }
   
         [Fact]
        public void NSDistanceTestWatters()
        {
            // arrange
            
            double xLat = 34.26305291591299;
            double yLat = 34.26759268197306;

            // act
            double expected = 0.31;

            double actual = DistanceCalculator.NSDistance(xLat, yLat);

            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True (difference <= 0.01,
              "actual: " + actual.ToString() + " expected: " + expected.ToString());
    
        }

    }
}
