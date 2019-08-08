using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Site.Data
{
	public interface IPostalCodeRepository
	{
		Task<string> Get(string pc);
	}

	public class PostalCodeRepository : IPostalCodeRepository
	{
		private readonly HttpClient _client;

		public PostalCodeRepository()
		{
			_client = new HttpClient {
				BaseAddress = new Uri("http://api.zippopotam.us")
			};
		}

		public async Task<string> Get(string pc)
		{
			var r = await _client.GetAsync($"/us/{pc}");

			return await r.Content.ReadAsStringAsync();
		}
	}
}
