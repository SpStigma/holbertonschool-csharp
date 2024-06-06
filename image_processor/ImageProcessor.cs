using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

/// <summary>
/// Represent the ImageProcessor class.
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Method to invert the color of multiple images with threads.
    /// </summary>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            // Load the original image
            using (Bitmap originalImage = new Bitmap(filename))
            {
                // Create a new bitmap with the same dimensions
                Bitmap invertedImage = new Bitmap(originalImage.Width, originalImage.Height);

                // Lock the bits of the original image and the new image
                BitmapData originalData = originalImage.LockBits(new Rectangle(0, 0, originalImage.Width, originalImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                BitmapData invertedData = invertedImage.LockBits(new Rectangle(0, 0, invertedImage.Width, invertedImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

                int bytesPerPixel = Image.GetPixelFormatSize(originalData.PixelFormat) / 8;
                int byteCount = originalData.Stride * originalImage.Height;
                byte[] pixelBuffer = new byte[byteCount];

                // Copy the original image data to the array
                System.Runtime.InteropServices.Marshal.Copy(originalData.Scan0, pixelBuffer, 0, byteCount);

                // Invert the colors
                for (int i = 0; i < byteCount; i += bytesPerPixel)
                {
                    pixelBuffer[i] = (byte)(255 - pixelBuffer[i]);       // Blue
                    pixelBuffer[i + 1] = (byte)(255 - pixelBuffer[i + 1]); // Green
                    pixelBuffer[i + 2] = (byte)(255 - pixelBuffer[i + 2]); // Red
                }

                // Copy the inverted image data back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(pixelBuffer, 0, invertedData.Scan0, byteCount);

                // Unlock the bits
                originalImage.UnlockBits(originalData);
                invertedImage.UnlockBits(invertedData);

                // Get the original file name without extension
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filename);

                // Get the original file extension
                string fileExtension = Path.GetExtension(filename);

                // Generate the new file name
                string newFileName = $"{fileNameWithoutExtension}_inverse{fileExtension}";

                // Save the inverted image
                invertedImage.Save(newFileName);
            }
        });
    }
}
