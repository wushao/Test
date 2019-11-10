using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.QrCode;

namespace WinForm.Common
{
    public class QRCodeHelper
    {
        public static string CreateQRCodeImage(QRCodeMsg entity)
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

            Bitmap map = writer.Write(entity.Content);
            string filePath = $"{entity.FilePath}\\{entity.ImageName}.PNG";
            map.Save(filePath, ImageFormat.Png);
            map.Dispose();
            return filePath;
        }

        public static string GetQRCodeImageMsg(QRCodeMsg entity)
        {
            IBarcodeReader reader = new BarcodeReader();
            var barcodeBitmap = (Bitmap)Image.FromFile($"{entity.FilePath}\\{entity.ImageName}.PNG");
            var result = reader.Decode(barcodeBitmap);
            if (result != null)
            {
                return result.Text;
            }
            return string.Empty;
        }
    }

    public class QRCodeMsg
    {
        public string Content { get; set; }

        public string ImageName { get; set; }

        public string FilePath { get; set; }
    }
}
