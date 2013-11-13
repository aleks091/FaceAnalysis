using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LiveFacialFeatures_VS2008;
using LiveFacialFeatures_VS2008.EmotionRecognition;
using Luxand;

namespace LiveRecognition
{
    public partial class Form1 : Form
    {
        String cameraName;
        bool needClose = false;
        private int tracker = 0;
        private int cameraHandle = 0;
        private FaceAnalysis _faceAnalysis;
        private List<FaceAnalysis> _faceAnalysisCalibradas;
        private FaceGestureRecognitionAnalysis _gestureRecognitionAnalysis;
        private bool _estaCalibrado;
        private bool _verPuntosDeReferencia;

        // WinAPI procedure to release HBITMAP handles returned by FSDKCam.GrabFrame
        [DllImport("gdi32.dll")]
        static extern bool DeleteObject(IntPtr hObject);

        public Form1()
        {
            InitializeComponent();
            _faceAnalysisCalibradas = new List<FaceAnalysis>();
            _gestureRecognitionAnalysis = new FaceGestureRecognitionAnalysis();
            _estaCalibrado = false;
            _verPuntosDeReferencia = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (FSDK.FSDKE_OK != FSDK.ActivateLibrary("q8CGEtWTd/xAE0ZjHtojZQG6e37uDKLuMFMv1yQMIQJVjgX2l3902bj+UBiY5lR8FJhk0emgAoMgSCh3hRBT7D76yJxx5twgCdDZ8tvz5riqFxNYkX/5irHGLRebH3Jj5rZFaH+7jcbBzlSy4VsqlLv2iHM/lma2PGbbfMWmR5E="))
            {
                MessageBox.Show("Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", "Error activating FaceSDK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            FSDK.InitializeLibrary();
            FSDKCam.InitializeCapturing();

            string [] cameraList;
            int count;
            FSDKCam.GetCameraList(out cameraList, out count);

            if (0 == count) {
                MessageBox.Show("Please attach a camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            cameraName = cameraList[0];

            FSDKCam.VideoFormatInfo [] formatList;
            FSDKCam.GetVideoFormatList(ref cameraName, out formatList, out count);

            int VideoFormat = 0; // choose a video format
            pictureBox1.Width = formatList[VideoFormat].Width;
            pictureBox1.Height = formatList[VideoFormat].Height;
            //this.Width = formatList[VideoFormat].Width + 48;
            //this.Height = formatList[VideoFormat].Height + 96;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            needClose = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            

            int r = FSDKCam.OpenVideoCamera(ref cameraName, ref cameraHandle);
            if (r != FSDK.FSDKE_OK)
            {
                MessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            
            FSDK.CreateTracker(ref tracker);

            int err = 0; // set realtime face detection parameters
            FSDK.SetTrackerMultipleParameters(tracker, "RecognizeFaces=false; DetectFacialFeatures=true; HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=100; FaceDetectionThreshold=5;", ref err);
            var programFirstStarted = true;
            while (!needClose) 
            {
                Int32 imageHandle = 0;
                if (FSDK.FSDKE_OK != FSDKCam.GrabFrame(cameraHandle, ref imageHandle)) // grab the current frame from the camera
                {
                    Application.DoEvents();
                    continue;
                }
                FSDK.CImage image = new FSDK.CImage(imageHandle);
                
                long[] IDs;
                long faceCount = 0;
                FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256); // maximum of 256 faces detected
                Array.Resize(ref IDs, (int)faceCount);

                Image frameImage = image.ToCLRImage();
                Graphics gr = Graphics.FromImage(frameImage);

                for (int i = 0; i < IDs.Length; ++i)
                {
                    FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
                    FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);
                    
                    FSDK.TPoint[] facialFeatures;
                    FSDK.GetTrackerFacialFeatures(tracker, 0, IDs[i], out facialFeatures);

                    int left = facePosition.xc - (int)(facePosition.w * 0.6);
                    int top = facePosition.yc - (int)(facePosition.w * 0.5);

                    var faceProperties = new FaceProperties
                    {
                        FaceRectangle = new FaceRectangle
                        {
                            X = left,
                            Y = top,
                            Width = (int)(facePosition.w * 1.2),
                            Height = (int)(facePosition.w * 1.2)
                        },
                        SDKFacePoints = facialFeatures
                    };

                    var evaluateFace = new EvaluateFace(faceProperties);
                    _faceAnalysis = evaluateFace.Evaluate();

                    if (_estaCalibrado)
                    {
                        lblStatus.Text = "Status: Analizando";
                        //Aqui se muestra el resultado de las expresiones faciales en la
                        //interfaz de usuario
                        AnalisarCara();
                        lblPerCara.Invoke(new SetLabeltext(VerAreaCara), _faceAnalysis.FaceRectangleArea.ToString());
                    }

                    if (programFirstStarted)
                        Task.Run(() => CalibrarCara());

                    if (_verPuntosDeReferencia)
                    {
                        gr.DrawRectangle(Pens.LightGreen, 
                                         faceProperties.FaceRectangle.X, 
                                         faceProperties.FaceRectangle.Y, 
                                         faceProperties.FaceRectangle.Width, 
                                         faceProperties.FaceRectangle.Height);

                        
                        for (var index = 0; index < facialFeatures.Length; index++)
                        {
                            FSDK.TPoint point = facialFeatures[index];
                            
                                gr.FillEllipse(Brushes.DarkBlue, point.x, point.y, 5, 5);

                        }
                    }
                }

                // display current frame
                pictureBox1.Image = frameImage;

                GC.Collect(); // collect the garbage after the deletion

                // make UI controls accessible
                Application.DoEvents();

                programFirstStarted = false;
            }
                     
        }

        private void AnalisarCara()
        {
            AnalisarSonriza();
            AnalisarSorpresa();
        }

        private void AnalisarSonriza()
        {
            var isSmiling = _gestureRecognitionAnalysis.IsSmiling(_faceAnalysisCalibradas, _faceAnalysis);
            if (isSmiling)
                lblSonriza.Text = "Sonriza: Si";
            else
                lblSonriza.Text = "Sonriza: No";
        }

        private void AnalisarSorpresa()
        {
            var isSurprized = _gestureRecognitionAnalysis.IsSurprized(_faceAnalysisCalibradas, _faceAnalysis);
            if (isSurprized)
                lblSorpresa.Text = "Sorpresa: Si";
            else
                lblSorpresa.Text = "Sorpresa: No";
        }

        private void PrintFaceAnalysisResult(FaceAnalysis faceAnalysis)
        {
            
            PrintMouthPoints(faceAnalysis.FacePoints.MouthPoints);
            //PrintShinPoints(faceAnalysis.FacePoints.ShinPoints);
            PrintNosePoints(faceAnalysis.FacePoints.NosePoints);
            PrintRightEyeBrowPoints(faceAnalysis.FacePoints.RightEyeBrowPoints);
            PrintRightEyePoints(faceAnalysis.FacePoints.RightEyePoints);
            PrintLeftEyeBrowPoints(faceAnalysis.FacePoints.LeftEyeBrowPoints);
            PrintLeftEyePoints(faceAnalysis.FacePoints.LeftEyePoints);
            
            GC.Collect();
        }

        private void PrintMouthPoints(Mouth mouth)
        {
            PrintInTextBox(mouth.Point8, "Mouth", "8");
            PrintInTextBox(mouth.Point9, "Mouth", "9");
            PrintInTextBox(mouth.Point10, "Mouth", "10");
            PrintInTextBox(mouth.Point11, "Mouth", "11");
            PrintInTextBox(mouth.Point12, "Mouth", "12");
            PrintInTextBox(mouth.Point13, "Mouth", "13");
            PrintInTextBox(mouth.Point14, "Mouth", "14");
            PrintInTextBox(mouth.Point15, "Mouth", "15");
            PrintInTextBox(mouth.Point16, "Mouth", "16");
            PrintInTextBox(mouth.Point17, "Mouth", "17");
            PrintInTextBox(mouth.Point18, "Mouth", "18");

            var xs = mouth.Point8.X - mouth.Point12.X;
            var xsPow = Math.Pow(xs, 2);

            var ys = mouth.Point8.Y - mouth.Point12.Y;
            var ysPow = Math.Pow(ys, 2);

            var sum = xsPow + ysPow;

            var distancia = Math.Sqrt(sum);

            txtEstadisticas.Invoke(new DistanceTextDelagate(PrintDistance), distancia);
        }

        private void PrintShinPoints(Shin shin)
        {
            PrintInTextBox(shin.Point1, "Shin", "1");
            PrintInTextBox(shin.Point2, "Shin", "2");
            PrintInTextBox(shin.Point3, "Shin", "3");
            PrintInTextBox(shin.Point4, "Shin", "4");
            PrintInTextBox(shin.Point5, "Shin", "5");
            PrintInTextBox(shin.Point6, "Shin", "6");
            PrintInTextBox(shin.Point7, "Shin", "7");
        }

        private void PrintNosePoints(Nose nose)
        {

        }

        private void PrintRightEyeBrowPoints(RightEyeBrow rightEyeBrow)
        {

        }

        private void PrintRightEyePoints(RightEye rightEye)
        {

        }

        private void PrintLeftEyeBrowPoints(LeftEyeBrow leftEyeBrow)
        {

        }

        private void PrintLeftEyePoints(LeftEye leftEye)
        {

        }

        private void PrintInTextBox(FacePoint facePoint, string className, string id)
        {
            txtEstadisticas.Invoke(new SetTextDelegate(SetText), facePoint, className, id);
        }

        private delegate void SetTextDelegate(FacePoint facePoint, string className, string id);

        private delegate void DistanceTextDelagate(double distance);

        private delegate void SetLabeltext(string text);

        private delegate void SetFaceInfo(FaceAnalysis faceAnalysis);

        private void VerCalibracionInfo(FaceAnalysis faceAnalysis)
        {
            var minInterval = faceAnalysis.FaceRectangleArea - 3000;
            var maxInterval = faceAnalysis.FaceRectangleArea + 3000;
            txtCalibrada.Text += string.Format("Calibrado a: {0} - {1}\r\n", 
                minInterval, maxInterval);
        }

        private void VerAreaCara(string text)
        {
            lblPerCara.Text = string.Format("Perimetro de Cara: {0}", text);
        }

        private void VerStatusDeApplicacion(string text)
        {
            lblStatus.Text = "Status: Calibrando";
        }

        private void PrintDistance(double distance)
        {
            txtEstadisticas.Text += string.Format("Distancia entre 8 y 12: {0}\r\n", distance);
        }

        private void SetText(FacePoint facePoint, string className, string id)
        {
            txtEstadisticas.Text += string.Format("{0} -> {1}: X {2} - Y {3}\r\n",
                className, id, facePoint.X, facePoint.Y);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            FSDK.FreeTracker(tracker);

            FSDKCam.CloseVideoCamera(cameraHandle);
            FSDKCam.FinalizeCapturing();

            button1.Enabled = true;
        }

        private void btnFaceAnalysis_Click(object sender, EventArgs e)
        {
            Task.Run(() => PrintFaceAnalysisResult(_faceAnalysis));
        }

        private void CalibrarCara()
        {
            while(_faceAnalysisCalibradas.Count < 20)
            {
                Thread.Sleep(500);
                var copiedAnalysis = ObjectCopier.Clone(_faceAnalysis);
                _faceAnalysisCalibradas.Add(copiedAnalysis);
                lblStatus.Invoke(new SetLabeltext(VerStatusDeApplicacion), "Status: Calibrando");
                txtCalibrada.Invoke(new SetFaceInfo(VerCalibracionInfo), copiedAnalysis);
            }
            
            _estaCalibrado = true;
        }

        private void cbVerRefs_CheckedChanged(object sender, EventArgs e)
        {
            _verPuntosDeReferencia = cbVerRefs.Checked;
        }
    }
}
