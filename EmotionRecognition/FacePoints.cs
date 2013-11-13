
using System;
using Luxand;

namespace LiveFacialFeatures_VS2008.EmotionRecognition
{
    [Serializable]
    public class FacePoints
    {
        public Shin ShinPoints { get; set; }
        public Mouth MouthPoints { get; set; }
        public Nose NosePoints { get; set; }
        public RightEye RightEyePoints { get; set; }
        public LeftEye LeftEyePoints { get; set; }
        public RightEyeBrow RightEyeBrowPoints { get; set; }
        public LeftEyeBrow LeftEyeBrowPoints { get; set; }
    }
    [Serializable]
    public class Shin
    {
        public FacePoint Point1 { get; set; }
        public FacePoint Point2 { get; set; }
        public FacePoint Point3 { get; set; }
        public FacePoint Point4 { get; set; }
        public FacePoint Point5 { get; set; }
        public FacePoint Point6 { get; set; }
        public FacePoint Point7 { get; set; }
    }
    [Serializable]
    public class Mouth
    {
        public FacePoint Point8 { get; set; }
        public FacePoint Point9 { get; set; }
        public FacePoint Point10 { get; set; }
        public FacePoint Point11 { get; set; }
        public FacePoint Point12 { get; set; }
        public FacePoint Point13 { get; set; }
        public FacePoint Point14 { get; set; }
        public FacePoint Point15 { get; set; }
        public FacePoint Point16 { get; set; }
        public FacePoint Point17 { get; set; }
        public FacePoint Point18 { get; set; }
    }
    [Serializable]
    public class Nose
    {
        public FacePoint Point19 { get; set; }
        public FacePoint Point20 { get; set; }
        public FacePoint Point21 { get; set; }
        public FacePoint Point22 { get; set; }
        public FacePoint Point23 { get; set; }
        public FacePoint Point24 { get; set; }
        public FacePoint Point25 { get; set; }
        public FacePoint Point26 { get; set; }
        public FacePoint Point27 { get; set; }
        public FacePoint Point28 { get; set; }
        public FacePoint Point29 { get; set; }
        public FacePoint Point30 { get; set; }
        public FacePoint Point41 { get; set; }
    }
    [Serializable]
    public class RightEye
    {
        public FacePoint Point42 { get; set; }
        public FacePoint Point43 { get; set; }
        public FacePoint Point44 { get; set; }
        public FacePoint Point45 { get; set; }
        public FacePoint Point46 { get; set; }
        public FacePoint Point47 { get; set; }
        public FacePoint Point48 { get; set; }
        public FacePoint Point49 { get; set; }
        public FacePoint Point50 { get; set; }
        public FacePoint Point51 { get; set; }
        public FacePoint Point52 { get; set; }
    }
    [Serializable]
    public class LeftEye
    {
        public FacePoint Point53 { get; set; }
        public FacePoint Point54 { get; set; }
        public FacePoint Point55 { get; set; }
        public FacePoint Point56 { get; set; }
        public FacePoint Point57 { get; set; }
        public FacePoint Point58 { get; set; }
        public FacePoint Point59 { get; set; }
        public FacePoint Point60 { get; set; }
        public FacePoint Point61 { get; set; }
        public FacePoint Point62 { get; set; }
        public FacePoint Point63 { get; set; }
    }
    [Serializable]
    public class RightEyeBrow
    {
        public FacePoint Point40 { get; set; }
        public FacePoint Point39 { get; set; }
        public FacePoint Point38 { get; set; }
        public FacePoint Point37 { get; set; }
        public FacePoint Point36 { get; set; }
    }
    [Serializable]
    public class LeftEyeBrow
    {
        public FacePoint Point31 { get; set; }
        public FacePoint Point32 { get; set; }
        public FacePoint Point33 { get; set; }
        public FacePoint Point34 { get; set; }
        public FacePoint Point35 { get; set; }
    }
    [Serializable]
    public class FacePoint
    {
        public int PointId { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class FacePointHelpers
    {
        public static FacePoint SdkPointToFacePoint(FSDK.TPoint tPoint)
        {
            return new FacePoint
                       {
                           X = tPoint.x,
                           Y = tPoint.y
                       };
        }
    }
}
