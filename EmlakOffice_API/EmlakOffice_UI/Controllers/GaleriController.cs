using EmlakOffice_UI.Dtos.KategoriDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmlakOffice_UI.Controllers
{
    public class GaleriController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public GaleriController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7158/api/Emlak/EmlakListKategoriyle");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<EmlakSonucDto>>(jsonData); //Listeleme için deserialize
				return View(values);
			}
			return View();
		}
	}
}
