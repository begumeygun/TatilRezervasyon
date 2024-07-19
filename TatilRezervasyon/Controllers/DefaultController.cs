using Microsoft.AspNetCore.Mvc;

namespace TatilRezervasyon.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
