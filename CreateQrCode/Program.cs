namespace CreateQrCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một ký tự ASCII 29 (GS - Group Separator)
            char GS = (char)29;

            // Định dạng chuỗi dữ liệu với GS (Group Separator)
            string data = $"{GS}2401234567890{GS}10AA12345{GS}11123456211{GS}961234567";

            // Tạo BarcodeWriter để sinh mã Data Matrix
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.DATA_MATRIX, // Định dạng là Data Matrix
                Options = new EncodingOptions
                {
                    Width = 300,          // Chiều rộng ảnh
                    Height = 300,         // Chiều cao ảnh
                    Margin = 0            // Lề (tùy chỉnh nếu cần)
                }
            };

            // Tạo hình ảnh mã Data Matrix
            using (var bitmap = writer.Write(data))
            {
                // Lưu hình ảnh mã vào tệp PNG
                string outputPath = @"F:\Linh\ReadMatrxData\ReadMatrxData\bin\Debug\net8.0\Images\matrx1.png";
                bitmap.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);
                Console.WriteLine("Mã Data Matrix đã được tạo và lưu thành công.");
            }

            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
