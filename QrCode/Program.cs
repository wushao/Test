using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using ThoughtWorks.QRCode.Codec;
using ZXing;
using ZXing.QrCode;

namespace QrCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewQRCodeByThoughtWorks($"{Environment.CurrentDirectory}\\test.png","1年，1楼", ImageFormat.Png);

            //StringBuilder str = new StringBuilder();
            //str.Append("1年");
            ////str.Append("\r\n");
            //str.Append("1楼");
            ////NewQRCodeByThoughtWorks($"{Environment.CurrentDirectory}\\test.png", "1年", ImageFormat.Png);
            //CreateCode_Choose(str.ToString(), "Byte", "Q", 8, 4);

            //QRCodeHelper.CreateQRimg("楼1", $"{Environment.CurrentDirectory}\\test.png", ImageFormat.Png);

            //Generate1("1年\r\n1楼");

            GetData();
        }


        static void Generate1(string text)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.DisableECI = true;
            //设置内容编码
            options.CharacterSet = "UTF-8";
            //设置二维码的宽度和高度
            options.Width = 500;
            options.Height = 500;
            //设置二维码的边距,单位不是固定像素
            options.Margin = 1;
            writer.Options = options;

            Bitmap map = writer.Write(text);
            string filename = $"{Environment.CurrentDirectory}\\test11.png";
            map.Save(filename, ImageFormat.Png);
            map.Dispose();
        }

        static void GetData()
        {
            // create a barcode reader instance
            IBarcodeReader reader = new BarcodeReader();
            // load a bitmap
            var barcodeBitmap = (Bitmap)Image.FromFile($"{Environment.CurrentDirectory}\\test11.png");
            // detect and decode the barcode inside the bitmap
            var result = reader.Decode(barcodeBitmap);
            // do something with the result
            if (result != null)
            {
                var tt = result.BarcodeFormat.ToString();
                var ttt = result.Text;
            }
        }

        public static string NewQRCodeByThoughtWorks(string imgPath, string codeContent, ImageFormat imgType)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//编码方式(注意：BYTE能支持中文，ALPHA_NUMERIC扫描出来的都是数字)
            encoder.QRCodeScale = 4;//大小(值越大生成的二维码图片像素越高)
            encoder.QRCodeVersion = 0;//版本(注意：设置为0主要是防止编码的字符串太长时发生错误)
            encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;//错误效验、错误更正(有4个等级)
            
            var bcodeBitmap = encoder.Encode(codeContent, Encoding.Unicode);
            bcodeBitmap.Save(imgPath, imgType);//@"E:\test.png"      ImageFormat.Png
            bcodeBitmap.Dispose();
            return imgPath;
        }

        /// <summary>
        /// 选择生成二维码的相关类型
        /// <param name="strData">要生成的文字或者数字，支持中文。如： "4408810820 深圳－广州" 或者：4444444444</param>
        /// <param name="qrEncoding">三种尺寸：BYTE ，ALPHA_NUMERIC，NUMERIC</param>
        /// <param name="level">大小：L M Q H</param>
        /// <param name="version">版本：如 8</param>
        /// <param name="scale">比例：如 4</param>
        /// <returns></returns>
        /// </summary>
        public static void CreateCode_Choose(string strData, string qrEncoding, string level, int version, int scale)
        {
            if (string.IsNullOrEmpty(strData))
            {
                throw new ArgumentNullException(strData);
            }
            if (string.IsNullOrEmpty(qrEncoding))
            {
                throw new ArgumentNullException(qrEncoding);
            }
            if (string.IsNullOrEmpty(level))
            {
                throw new ArgumentNullException(level);
            }
            var qrCodeEncoder = new QRCodeEncoder();
            var encoding = qrEncoding;
            switch (encoding)
            {
                case "Byte":
                    qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                    break;
                case "AlphaNumeric":
                    qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                    break;
                case "Numeric":
                    qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                    break;
                default:
                    qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                    break;
            }
            qrCodeEncoder.QRCodeScale = scale;
            qrCodeEncoder.QRCodeVersion = version;
            switch (level)
            {
                case "L":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                    break;
                case "M":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                    break;
                case "Q":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                    break;
                default:
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                    break;
            }
            Image image = null;
            FileStream fs = null;
            try
            {
                //文字生成图片
                image = qrCodeEncoder.Encode (strData, Encoding.UTF8);
                var filename = $"{DateTime.Now.ToString("yyyymmddhhmmssfff")}.jpg";
                var filepath = $"{Environment.CurrentDirectory}\\{filename}";
                fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
                image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (IOException ioex)
            {
                throw new IOException(ioex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
                if (image != null) image.Dispose();
            }
        }
    }

    public class QRCodeHelper
    {
        /// <summary>
        /// 生成二维码图片
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public  static Bitmap CreateQRimg(string str, string imgPath, ImageFormat imgType)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);
            Bitmap bt = qrCode.GetGraphic(20);
            bt.Save(imgPath, imgType);//@"E:\test.png"      ImageFormat.Png
            bt.Dispose();
            return bt;
        }

        /// <summary>
        /// 生成二维码图片流（二维码上含文字）
        /// </summary>
        /// <param name="str1">二维码中要传递的数据（地址）</param>
        /// <param name="str2">二维码上显示的文字说明</param>
        //public byte[] GenerateQRCode(string str1, string str2)
        //{
        //    using (Image codeImage = CreateQRimg(str1), strImage = ConvertStringToImage(str2))
        //    {
        //        Image img = CombineImage(600, 600, codeImage, 60, 50, strImage, 0, 530);
        //        using (var stream = new MemoryStream())
        //        {
        //            img.Save(stream, ImageFormat.Jpeg);
        //            //输出图片流
        //            return stream.ToArray();
        //        }
        //    }
        //}

        /// <summary>
        /// 生成二维码图片流（不含文字）
        /// </summary>
        /// <param name="str">二维码中要传递的数据（地址）</param>
        /// <returns></returns>
        //public byte[] GenerateQRCode(string str)
        //{
        //    using (Image codeImage = CreateQRimg(str))
        //    {
        //        using (var stream = new MemoryStream())
        //        {
        //            codeImage.Save(stream, ImageFormat.Jpeg);

        //            return stream.ToArray();
        //        }
        //    }
        //}

        /// <summary>
        /// 生成文字图片
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public Image ConvertStringToImage(string str)
        {
            Bitmap image = new Bitmap(600, 40, PixelFormat.Format24bppRgb);

            Graphics g = Graphics.FromImage(image);

            try
            {
                Font font = new Font("SimHei", 14, FontStyle.Regular);

                g.Clear(Color.White);

                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                Rectangle rectangle = new Rectangle(0, 0, 600, 40);

                g.DrawString(str, font, new SolidBrush(Color.Black), rectangle, format);

                return image;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                GC.Collect();
            }
        }

        /// <summary>
        /// 在画板中合并二维码图片和文字图片
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="imgLeft"></param>
        /// <param name="imgLeft_left"></param>
        /// <param name="imgLeft_top"></param>
        /// <param name="imgRight"></param>
        /// <param name="imgRight_left"></param>
        /// <param name="imgRight_top"></param>
        /// <returns></returns>
        public Image CombineImage(int width, int height, Image imgLeft, int imgLeft_left, int imgLeft_top, Image imgRight, int imgRight_left, int imgRight_top)
        {
            Bitmap image = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            Graphics g = Graphics.FromImage(image);

            try
            {
                g.Clear(Color.White);
                g.DrawImage(imgLeft, imgLeft_left, imgLeft_top, 500, 500);
                g.DrawImage(imgRight, imgRight_left, imgRight_top, imgRight.Width, imgRight.Height);

                return image;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                g.Dispose();
            }
        }
    }

}
