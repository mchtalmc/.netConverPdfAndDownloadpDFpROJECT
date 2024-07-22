using ConverPdf.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace ConverPdf.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public FileResult Export()
		{
			string[] columnNames = new string[] { "Id","Name","City","Country"};
			var employess = new EmployeeList().EmpList;

			string word = string.Empty;

			foreach (string columnName in columnNames)
			{
				word += columnName + ",";
			}
			word += "\r\n";
			foreach (var employee in employess)
			{
				word += employee.Id.ToString().Replace("," , ";");
				word += employee.Name.ToString().Replace(",", ";");
				word += employee.City.ToString().Replace(",", ";");
				word += employee.Country.ToString().Replace(",", ";");

				word += "\r\n";
			}
			byte[] bytes= Encoding.ASCII.GetBytes(word);
			return File(bytes, "application/vnd.ms-word", "TriyngConvertPdf.doc");
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
