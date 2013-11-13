using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveFacialFeatures_VS2008.EmotionRecognition
{
    //Todo: Use this class
    internal class FaceGestureRecognition
    {
        public bool IsSmiling(FaceAnalysis normalFace, FaceAnalysis smilingFace)
        {
            var normalDistance =
                DistanceBetweenPoints(normalFace.FacePoints.MouthPoints.Point8, normalFace.FacePoints.MouthPoints.Point12);

            var smilingDistance =
                DistanceBetweenPoints(smilingFace.FacePoints.MouthPoints.Point8, smilingFace.FacePoints.MouthPoints.Point12);

            var isSmiling = isMoreThanPercent(normalDistance, smilingDistance, 15);
            return isSmiling;
        }

        internal bool IsSurprized(FaceAnalysis normalFace, FaceAnalysis surprizeFace)
        {
            var normalDistance =
                DistanceBetweenPoints(normalFace.FacePoints.MouthPoints.Point10, normalFace.FacePoints.MouthPoints.Point14);

            var surprizeDistance =
                DistanceBetweenPoints(surprizeFace.FacePoints.MouthPoints.Point10, surprizeFace.FacePoints.MouthPoints.Point14);

            var isSurprized = isMoreThanPercent(normalDistance, surprizeDistance, 15);
            return isSurprized;
        }

        internal bool IsUpset()
        {
            //Todo: make method
            return false;
        }

        private double DistanceBetweenPoints(FacePoint point1, FacePoint point2)
        {
            var xs = point1.X - point2.X;
            var xsPow = Math.Pow(xs, 2);

            var ys = point1.Y - point2.Y;
            var ysPow = Math.Pow(ys, 2);

            var sum = xsPow + ysPow;

            return Math.Sqrt(sum);
        }

        private bool isMoreThanPercent(double normalValue, double increasedValue, double desiredPercent)
        {
            return (normalValue + (normalValue*(desiredPercent/100))) < increasedValue;
        }
    }
}
