using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
  public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			List<DataPoint> dataPoints = new List<DataPoint>{
				new DataPoint(10, 22),
				new DataPoint(20, 36),
				new DataPoint(30, 42),
				new DataPoint(40, 51),
				new DataPoint(50, 46),
			};
 
			ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
 
			return View();
		}
 
 
	}
}
