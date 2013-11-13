using System;
using System.Collections.Generic;
using System.Text;

namespace LiveFacialFeatures_VS2008.EmotionRecognition
{
    public class EvaluateFace
    {
        private FaceProperties _faceProperties { get; set; }
        private FaceAnalysis _faceAnalysis { get; set; }

        public EvaluateFace(FaceProperties faceProperties)
        {
            _faceProperties = faceProperties;
            _faceAnalysis = new FaceAnalysis();
            Evaluate();
        }

        public FaceAnalysis Evaluate()
        {
            _faceAnalysis.FacePoints = new FacePoints();

            _faceAnalysis.FaceRectangleArea =
                _faceProperties.FaceRectangle.Height*_faceProperties.FaceRectangle.Width;

            EvaluateShin();
            EvaluateNose();
            EvaluateMouth();
            EvaluateLeftEyeBrow();
            EvaluateRightEyeBrow();
            EvaluateRightEye();
            EvaluateLeftEye();

            return _faceAnalysis;
        }

        private void EvaluateShin()
        {
            _faceAnalysis.FacePoints.ShinPoints = new Shin();

            _faceAnalysis.FacePoints.ShinPoints.Point1 
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[5]);

            _faceAnalysis.FacePoints.ShinPoints.Point2
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[7]);

            _faceAnalysis.FacePoints.ShinPoints.Point3
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[9]);

            _faceAnalysis.FacePoints.ShinPoints.Point4
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[11]);

            _faceAnalysis.FacePoints.ShinPoints.Point5
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[10]);

            _faceAnalysis.FacePoints.ShinPoints.Point6
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[8]);

            _faceAnalysis.FacePoints.ShinPoints.Point7
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[6]);
        }
        private void EvaluateNose()
        {
            _faceAnalysis.FacePoints.NosePoints = new Nose();

            _faceAnalysis.FacePoints.NosePoints.Point19
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[52]);

            _faceAnalysis.FacePoints.NosePoints.Point20
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[50]);

            _faceAnalysis.FacePoints.NosePoints.Point21
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[45]);

            _faceAnalysis.FacePoints.NosePoints.Point22
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[43]);

            _faceAnalysis.FacePoints.NosePoints.Point23
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[44]);

            _faceAnalysis.FacePoints.NosePoints.Point24
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[46]);

            _faceAnalysis.FacePoints.NosePoints.Point25
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[51]);

            _faceAnalysis.FacePoints.NosePoints.Point26
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[53]);

            _faceAnalysis.FacePoints.NosePoints.Point27
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[2]);

            _faceAnalysis.FacePoints.NosePoints.Point28
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[47]);

            _faceAnalysis.FacePoints.NosePoints.Point29
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[48]);

            _faceAnalysis.FacePoints.NosePoints.Point30
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[49]);

            _faceAnalysis.FacePoints.NosePoints.Point41
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[22]);
        }
        private void EvaluateMouth()
        {
            _faceAnalysis.FacePoints.MouthPoints = new Mouth();

            _faceAnalysis.FacePoints.MouthPoints.Point8
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[3]);

            _faceAnalysis.FacePoints.MouthPoints.Point9
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[56]);

            _faceAnalysis.FacePoints.MouthPoints.Point10
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[54]);

            _faceAnalysis.FacePoints.MouthPoints.Point11
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[57]);

            _faceAnalysis.FacePoints.MouthPoints.Point12
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[4]);

            _faceAnalysis.FacePoints.MouthPoints.Point13
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[59]);

            _faceAnalysis.FacePoints.MouthPoints.Point14
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[55]);

            _faceAnalysis.FacePoints.MouthPoints.Point15
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[58]);

            _faceAnalysis.FacePoints.MouthPoints.Point16
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[63]);

            _faceAnalysis.FacePoints.MouthPoints.Point17
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[64]);

            _faceAnalysis.FacePoints.MouthPoints.Point18
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[65]);
        }
        private void EvaluateLeftEyeBrow()
        {
            _faceAnalysis.FacePoints.LeftEyeBrowPoints = new LeftEyeBrow();

            _faceAnalysis.FacePoints.LeftEyeBrowPoints.Point31
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[14]);

            _faceAnalysis.FacePoints.LeftEyeBrowPoints.Point32
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[20]);

            _faceAnalysis.FacePoints.LeftEyeBrowPoints.Point33
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[17]);

            _faceAnalysis.FacePoints.LeftEyeBrowPoints.Point34
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[21]);

            _faceAnalysis.FacePoints.LeftEyeBrowPoints.Point35
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[9]);
        }
        private void EvaluateRightEyeBrow()
        {
            _faceAnalysis.FacePoints.RightEyeBrowPoints = new RightEyeBrow();

            _faceAnalysis.FacePoints.RightEyeBrowPoints.Point36
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[13]);

            _faceAnalysis.FacePoints.RightEyeBrowPoints.Point37
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[19]);

            _faceAnalysis.FacePoints.RightEyeBrowPoints.Point38
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[16]);

            _faceAnalysis.FacePoints.RightEyeBrowPoints.Point39
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[18]);

            _faceAnalysis.FacePoints.RightEyeBrowPoints.Point40
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[24]);
        }
        private void EvaluateRightEye()
        {
            _faceAnalysis.FacePoints.RightEyePoints = new RightEye();

            _faceAnalysis.FacePoints.RightEyePoints.Point42
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[23]);

            _faceAnalysis.FacePoints.RightEyePoints.Point43
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[35]);

            _faceAnalysis.FacePoints.RightEyePoints.Point44
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[28]);

            _faceAnalysis.FacePoints.RightEyePoints.Point45
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[36]);

            _faceAnalysis.FacePoints.RightEyePoints.Point46
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[24]);

            _faceAnalysis.FacePoints.RightEyePoints.Point52
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[38]);

            _faceAnalysis.FacePoints.RightEyePoints.Point51
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[27]);

            _faceAnalysis.FacePoints.RightEyePoints.Point50
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[37]);

            _faceAnalysis.FacePoints.RightEyePoints.Point47
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[29]);

            _faceAnalysis.FacePoints.RightEyePoints.Point48
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[0]);

            _faceAnalysis.FacePoints.RightEyePoints.Point49
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[30]);
        }
        private void EvaluateLeftEye()
        {
            _faceAnalysis.FacePoints.LeftEyePoints = new LeftEye();

            _faceAnalysis.FacePoints.LeftEyePoints.Point53
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[25]);

            _faceAnalysis.FacePoints.LeftEyePoints.Point54
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[39]);

            _faceAnalysis.FacePoints.LeftEyePoints.Point55
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[32]);

            _faceAnalysis.FacePoints.LeftEyePoints.Point56
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[40]);

            _faceAnalysis.FacePoints.LeftEyePoints.Point57
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[26]);

            _faceAnalysis.FacePoints.LeftEyePoints.Point58
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[42]);

            _faceAnalysis.FacePoints.LeftEyePoints.Point59
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[31]);

            _faceAnalysis.FacePoints.LeftEyePoints.Point60
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[41]);

            _faceAnalysis.FacePoints.LeftEyePoints.Point61
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[33]);

            _faceAnalysis.FacePoints.LeftEyePoints.Point62
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[1]);

            _faceAnalysis.FacePoints.LeftEyePoints.Point63
                = FacePointHelpers.SdkPointToFacePoint(_faceProperties.SDKFacePoints[34]);
        }

    }
}
