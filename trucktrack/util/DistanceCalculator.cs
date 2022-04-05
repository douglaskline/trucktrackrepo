using System;

namespace util
{
    // referred to this page: http://www.movable-type.co.uk/scripts/gis-faq-5.1.html
    public class DistanceCalculator
    {
        public const double RadiusOfEarthInMiles = 3958.898781;
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
    }
}
