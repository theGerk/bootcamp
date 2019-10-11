using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealthClinicPDFScraping
{
	class Program
	{
		static void Main(string[] args)
		{
			var pdf = new IronPdf.PdfDocument(Rescource.nmhss_directory_2018);

			Console.WriteLine(pdf.ExtractTextFromPage(100));

			Console.ReadKey();
		}
	}
}
