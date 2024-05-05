using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using System.IO;

class Program {
	static void Main(string[] args) {
		if (args.Length < 1) {
			Console.WriteLine("Usage: webp-to-jpg <input.webp>");
			return;
		}

		string inputPath = args[0];
		string outputPath = Path.ChangeExtension(inputPath, ".jpg");

		using Image image = Image.Load(inputPath);
		image.SaveAsJpeg(outputPath, new JpegEncoder { Quality = 100 });
	}
}
