using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers
{
	[Route("/")]
	[ApiController]
	public class DefaultController : ControllerBase
	{
		[HttpGet]
		public string Get() => DateTime.UtcNow.ToString();
	}
}
