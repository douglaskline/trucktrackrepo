using System;

namespace util
{
    // referred to this page: http://www.movable-type.co.uk/scripts/gis-faq-5.1.html
    public class DistanceCalculator
    {
        public const double RadiusOfEarthInMiles = 3958.898781;
        public const double MilesPerLatitudeDegree = 69.0;

        public static double EuclideanDistance(double xLat,
                                               double xLong,
                                               double yLat,
                                               double yLong)
        {

            double radianDenominator = 180.0/Math.PI;

            double xLatRad = xLat / radianDenominator;
            double xLongRad = xLong / radianDenominator;
            double yLatRad = yLat / radianDenominator;
            double yLongRad = yLong / radianDenominator;

            double c = Math.Acos(  Math.Sin(xLatRad)
                                 * Math.Sin(yLatRad)
                                 + Math.Cos(xLatRad)
                                 * Math.Cos(yLatRad)
                                 * Math.Cos(yLongRad - xLongRad));

            double d = RadiusOfEarthInMiles * c;
            ;

            return d;
        }
        public static double NSDistance(double xLat,
                                        double yLat)
        {
            return Math.Abs(xLat-yLat) * MilesPerLatitudeDegree;

        }
        public static double EWDistance(double xLat,
                                        double xLong,
                                        double yLat,
                                        double yLong)
        {
            // NSDistance gives on side of right trangle
            // Euclidean distance gives hypotenuse
            // c^2 = a^2 + b^b
            double c = DistanceCalculator.EuclideanDistance(xLat, xLong, yLat, yLong);
            double a = DistanceCalculator.NSDistance(xLat, yLat);

            return Math.Sqrt(c*c - a*a);
        }

        public static double RectilinearDistance(double xLat,
                                        double xLong,
                                        double yLat,
                                        double yLong)
        {
            return DistanceCalculator.NSDistance(xLat, yLat)
                    + DistanceCalculator.EWDistance(xLat, xLong, yLat, yLong);
        }
    }
}
