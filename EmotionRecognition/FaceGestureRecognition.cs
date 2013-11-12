using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveFacialFeatures_VS2008.EmotionRecognition
{
    public class FaceGestureRecognition
    {
        public bool IsSmiling(Mouth normalMouth, Mouth smilingMouth)
        {
            var normalDistance =
                DistanceBetweenPoints(normalMouth.Point8, normalMouth.Point12);

            var smilingDistance = 
                DistanceBetweenPoints(smilingMouth.Point8, smilingMouth.Point12);

            var isSmiling = isMoreThanPercent(normalDistance, smilingDistance, 15);
            return isSmiling;
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
