using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;

class Program {
	static void Main(string[] args) {
		if (args.Length < 2) {
			Console.WriteLine("Usage: webp-to-jpg <input.webp> <output.jpg>");
			return;
		}

		string inputPath = args[0];
		string outputPath = args[1];

		using Image image = Image.Load(inputPath);
		image.SaveAsJpeg(outputPath, new JpegEncoder { Quality = 100 });
	}
}
