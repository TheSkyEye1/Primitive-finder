using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Microsoft.CSharp.RuntimeBinder;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Management.Instrumentation;

namespace lab4
{
    class Filter_c
    {
        public Image<Bgr, byte> loadfunction(Image<Bgr, byte> image)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;*.png";
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                image = new Image<Bgr, byte>(fileName);
            }
            return image;
        }

        public Image<Gray,byte> blur(Image<Bgr,byte> image, int n1, int n2)
        {
            var grayImage = image.Convert<Gray, byte>();
            var bluredImage = grayImage.SmoothGaussian(n1);
            var color = new Gray(255); 
            var binarizedImage = bluredImage.ThresholdBinary(new Gray(n2), color);

            return binarizedImage;
        }

        public Image<Bgr,byte> findedges(Image<Bgr,byte> image, int n1, int n2, int thicc)
        {
            Image<Gray, byte> binarizedImage = blur(image, n1, n2);
            var contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(
                binarizedImage,
                contours,
                null,
                RetrType.List,
                ChainApproxMethod.ChainApproxSimple);

            var contoursImage = image.Copy();
            for (int i = 0; i < contours.Size; i++)
            {
                var points = contours[i].ToArray();
                contoursImage.Draw(points, new Bgr(Color.GreenYellow), thicc);
            }

            return contoursImage;
        }

        public Image<Bgr,byte> findtriangles(Image<Bgr, byte> image, int n1, int n2, int thicc, int tresh)
        {
            Image<Gray, byte> binarizedImage = blur(image, n1, n2);
            var contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(
                binarizedImage,
                contours,
                null,
                RetrType.List,
                ChainApproxMethod.ChainApproxSimple);

            var contoursImage = image.Copy();

            var approxContour = new VectorOfPoint();

            for (int i = 0; i < contours.Size; i++)
            {
                CvInvoke.ApproxPolyDP(
                    contours[i],
                    approxContour,
                    CvInvoke.ArcLength(contours[i], true) * 0.05,                          
                    true);
                if (CvInvoke.ContourArea(approxContour, false) > tresh)
                {

                    if (approxContour.Size == 3)
                    {
                        var points = approxContour.ToArray();
                        contoursImage.Draw(new Triangle2DF(points[0], points[1], points[2]),
                        new Bgr(Color.GreenYellow), thicc);
                    }
                }
            }

            return contoursImage;
        }

        public Image<Bgr, byte> findrectangles(Image<Bgr, byte> image, int n1, int n2, int thicc, int tresh, int delta)
        {
            Image<Gray, byte> binarizedImage = blur(image, n1, n2);
            var contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(
                binarizedImage,
                contours,
                null,
                RetrType.List,
                ChainApproxMethod.ChainApproxSimple);

            var contoursImage = image.Copy();

            var approxContour = new VectorOfPoint();

            for (int i = 0; i < contours.Size; i++)
            {
                CvInvoke.ApproxPolyDP(
                    contours[i],
                    approxContour,
                    CvInvoke.ArcLength(contours[i], true) * 0.05,
                    true);

                if (CvInvoke.ContourArea(approxContour, false) > tresh)
                {
                    var points = approxContour.ToArray();
                    if (isRectangle(points, delta) == true)
                    {
                        contoursImage.Draw(CvInvoke.MinAreaRect(approxContour), new Bgr(Color.GreenYellow), thicc);
                    }
                } 
            }
            return contoursImage;
        }

        private bool isRectangle(Point[] points, int delta)
        {
            LineSegment2D[] edges = PointCollection.PolyLine(points, true);
            for (int i = 0; i < edges.Length; i++)
            {
                double angle = Math.Abs(edges[(i + 1) %
                edges.Length].GetExteriorAngleDegree(edges[i]));
                if (angle < 90 - delta || angle > 90 + delta)
                {
                    return false;
                }
            }
            return true;
        }

        public Image<Bgr, byte> findcircles(Image<Bgr, byte> image, int k1, int k2, int k3, int k4)
        {
            var grayImage = image.Convert<Gray, byte>();
            var bluredImage = grayImage.SmoothGaussian(9);

            List<CircleF> circles = new List<CircleF>(CvInvoke.HoughCircles(bluredImage,
                 HoughModes.Gradient,
                 1.0,
                 k1,
                 100,
                 k2,
                 k3,
                 k4));

            var resultImage = image.Copy();
            foreach (CircleF circle in circles)
            {
                resultImage.Draw(circle, new Bgr(Color.Blue), 2);
            }

            return resultImage.Resize(640, 480, Inter.Linear);
        }

        public Image<Gray,byte> colorfind(Image<Bgr, byte> image, byte k1, byte k2)
        {
            var hsvImage = image.Convert<Hsv, byte>();
            var hueChannel = hsvImage.Split()[0];
            var resultImage = hueChannel.InRange(new Gray(k1 - k2), new Gray(k2 + k2));
            return resultImage;
        }

    }
}
