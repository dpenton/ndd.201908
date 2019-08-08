using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site.Data;

namespace Site.Controllers
{
	[Route("api/postalcode/{pc}")]
	[ApiController]
	public class PostalCodeController : ControllerBase
	{
		private readonly IPostalCodeRepository _repository;

		public PostalCodeController(IPostalCodeRepository repository)
		{
			_repository = repository;
		}

		[HttpGet]
		public async Task<string> Get(string pc)
		{
			return await _repository.Get(pc);
		}
	}
}
