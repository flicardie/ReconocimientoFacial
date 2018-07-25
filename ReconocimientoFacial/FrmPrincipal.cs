using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ReconocimientoFacial
{
    public partial class FrmPrincipal : Form
    {

        private VideoCapture _capture = null;
        private bool _captureInProgress;
        private Mat _frame;
        private Mat _grayFrame;
        private Mat _smallGrayFrame;
        private Mat _smoothedGrayFrame;
        private Mat _cannyFrame;

        CascadeClassifier _cascadeClassifier1 = new CascadeClassifier(Application.StartupPath + "/haarcascade_frontalface_default.xml");
        CascadeClassifier _cascadeClassifier2 = new CascadeClassifier(Application.StartupPath + "/haarcascade_eye.xml");
        public FrmPrincipal()
        {
            InitializeComponent();

            CvInvoke.UseOpenCL = false;
            try
            {
                _capture = new VideoCapture();
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            _frame = new Mat();
            _grayFrame = new Mat();
            _smallGrayFrame = new Mat();
            _smoothedGrayFrame = new Mat();
            _cannyFrame = new Mat();
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);

                CvInvoke.CvtColor(_frame, _grayFrame, ColorConversion.Bgr2Gray);

                //CvInvoke.PyrDown(_grayFrame, _smallGrayFrame);

                //CvInvoke.PyrUp(_smallGrayFrame, _smoothedGrayFrame);

                //CvInvoke.Canny(_smoothedGrayFrame, _cannyFrame, 100, 60);


                //captureImageBox.Image = _frame;
                imageBoxCamaraNormal.Image = _frame;
                //pictureBoxCamaraNormal.Image = _frame.Bitmap;
                //imageBoxCamaraConDeteccion.Image = _grayFrame;
                //smoothedGrayscaleImageBox.Image = _smoothedGrayFrame;
                //cannyImageBox.Image = _cannyFrame;

                DetectarOjosYCara(_grayFrame);
            }
        }

        private void CapturarVideoClick(object sender, EventArgs e)
        {

            if (_capture != null)
            {
                if (_captureInProgress)
                {  //stop the capture
                    captureButton.Text = "Start Capture";
                    _capture.Pause();
                }
                else
                {
                    //start the capture
                    captureButton.Text = "Stop";
                    _capture.Start();
                }

                _captureInProgress = !_captureInProgress;
            }

        }

        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }

        private void FlipHorizontalButtonClick(object sender, EventArgs e)
        {
            if (_capture != null) _capture.FlipHorizontal = !_capture.FlipHorizontal;
        }

        private void FlipVerticalButtonClick(object sender, EventArgs e)
        {
            if (_capture != null) _capture.FlipVertical = !_capture.FlipVertical;
        }

        private void DetectarOjosYCara(Mat image)
        {

            //convert Mat image to Emgu.CV RGB Image
            using (var imageFrame = image.ToImage<Bgr, byte>())
            {
                if (imageFrame != null)
                {
                    //convert Emgu.CV RGB Image to Emgu.CV GRAY Image 
                    var grayframe = imageFrame.Convert<Gray, byte>();

                    List<Rectangle> faces = new List<Rectangle>();
                    List<Rectangle> eyes = new List<Rectangle>();
                    //the actual face detection happens here
                    long detectionTime;
                    DetectorDeCaras.Detect(
                      imageFrame, "haarcascade_frontalface_default.xml", "haarcascade_eye.xml",
                      faces, eyes,
                      out detectionTime);

                    //LBPHFaceRecognizer faceRecognizer = new LBPHFaceRecognizer();




                    //the detected face(s) are highlighted here using a box that is drawn around it/them
                    foreach (var face in faces)
                    {
                        imageFrame.Draw(face, new Bgr(Color.BurlyWood), 3);
                    }

                    //the detected eye(s) are highlighted here using a box that is drawn around it/them
                    foreach (var eye in eyes)
                    {
                        imageFrame.Draw(eye, new Bgr(Color.Red), 1);
                    }
                }



                //display dected face and eyes Image on ImageBox
                imageBoxCamaraConDeteccion.Image = imageFrame; 
                //pictureBoxCamaraNormal.Image = imageFrame.Bitmap;
            }
        }

    }
}
