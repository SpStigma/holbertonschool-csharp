using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

/// <summary>
/// Represent the ImageProcessor class.
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Method to invert the color of multiple images with thread.
    /// </summary>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            // Load the original image
            Bitmap originalImage = new Bitmap(filename);

            // Create a new bitmap with the same dimensions
            Bitmap invertedImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Iterate through each pixel in the original image
            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    // Get the color of the current pixel
                    Color originalColor = originalImage.GetPixel(x, y);

                    // Invert the color by subtracting each RGB component from 255
                    Color invertedColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);

                    // Set the color of the corresponding pixel in the new image
                    invertedImage.SetPixel(x, y, invertedColor);
                }
            }

            // Get the original file name without extension
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filename);

            // Get the original file extension
            string fileExtension = Path.GetExtension(filename);

            // Generate the new file name
            string newFileName = $"{fileNameWithoutExtension}_inverse{fileExtension}";

            // Save the inverted image
            invertedImage.Save(newFileName);
        });
    }
}
