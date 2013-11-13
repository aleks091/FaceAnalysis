using System;
using System.Runtime.Serialization;
using Luxand;

namespace LiveFacialFeatures_VS2008.EmotionRecognition
{
    public class FaceProperties
    {
        public FaceRectangle FaceRectangle { get; set; }
        public FSDK.TPoint[] SDKFacePoints { get; set; }
    }

    [Serializable]
    public class FaceAnalysis 
    {
        public FacePoints FacePoints { get; set; }
        public double FaceRectangleArea { get; set; }

        
    }

    public class FaceRectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
