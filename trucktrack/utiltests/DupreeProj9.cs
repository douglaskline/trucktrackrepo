using System;
using Xunit;
using util;

namespace utiltests
{
    public class DupreeProj9
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
        public void NSDistanceTestRobert()
        {
            // arrange
            
            double xLat = 38.93321;
            double yLat = 34.74316;

            // act
            double expected = 289.11;
            double actual = DistanceCalculator.NSDistance(xLat, yLat);

            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True (difference <= 0.01,
              "actual: " + actual.ToString() + " expected: " + expected.ToString());
        }
     


         [Fact]
        public void NSDistanceTestBordeaux()

        {
            // arrange
            
            double xLat = 36.20710;
            double yLat = 28.37832;

            // act
            double expected = 7.82878*69.0;
            double actual = DistanceCalculator.NSDistance(xLat, yLat);

            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True (difference <= 2,
              "actual: " + actual.ToString() + " expected: " + expected.ToString());
    
        }

    [Fact]
        public void NSDistanceTestLackey()
        {
        // arrange
            
            double xLat = 37.08054;
            double yLat = 34.06821;

            //Walk of Fame to Hollywood Sign 


            // act


            double expected = 208;
            double actual = DistanceCalculator.NSDistance(xLat, yLat);


            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True (difference <= 0.5,
              "actual: " + actual.ToString() + " expected: " + expected.ToString());
    
        }


 [Fact]
 public void NSDistanceTestMitchell()

        {
            // arrange
            
            double xLat = 37.08054;
            double yLat = 34.06821;

            //Walk of Fame to Hollywood Sign 


            // act
            double expected = 208;

            double actual = DistanceCalculator.NSDistance(xLat, yLat);


            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True (difference <= 0.5,
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
        public void NSDistanceTestSerfling()
        {
            // arrange
            
            double xLat = 34.23520;
            double yLat = 34.20898;

            // 4206 Academy Cove to Papa Johns

            // act
            double expected = 1.81;
            double actual = DistanceCalculator.NSDistance(xLat, yLat);
            double difference = Math.Abs(expected-actual);
            // assert
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

         [Fact]
         public void NSDistanceTestInquimboy()
        {
            // arrange
            // Wilmington to Pinehurst
            
            double xLat = 34.2108219546097;
            double yLat = 35.212680293199796;

            // act
            double expected = 69.13;
            double actual = DistanceCalculator.NSDistance(xLat, yLat);

            // assert
            double difference = Math.Abs(expected - actual);

        }
  
          [Fact]
        public void NSDistanceTestRowe()
        {
            //Pour Taproom
            double PTLat = 34.23787111250938;
            double PTLong = 34.23132180570108;
            // act
            double expected = 0.4519021;
            double actual = DistanceCalculator.NSDistance(PTLat,PTLong);
            
            // assert
            double difference = Math.Abs(expected - actual);


            Xunit.Assert.True (difference <= 0.01,
              "actual: " + actual.ToString() + " expected: " + expected.ToString());
    
        }

          [Fact]
        public void NSDistanceTestBell()
        {
            // arrange
            
            double xLat = 34.23932;
            double yLat = 34.23542;

            // act
            double expected = .0039 * 69.0;
            double actual = DistanceCalculator.NSDistance(xLat, yLat);

            // assert
            double difference = Math.Abs(expected - actual);

            Xunit.Assert.True (difference <= 0.025,
              "actual: " + actual.ToString() + " expected: " + expected.ToString());
    
        }

        [Fact]
         public void JamesDupreeDistanceCalculator()
        {
            // arrange
            
            double xLat = 34.22497090039899;
            double xLong = -77.8257258176798;
            double yLat = 34.242835017171124;
            double yLong = -77.83275844281201;
            // act
            double expected = 1.29;
            double actual = DistanceCalculator.EuclideanDistance(xLat,xLong,yLat,yLong);
            
            // assert
            double difference = Math.Abs(expected - actual);

        Xunit.Assert.True(difference <= 0.25,
       "actual: " + actual.ToString() + " expected: " + expected.ToString() + " diff: " + difference.ToString());          
          
        }


    }
}
