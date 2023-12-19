using EmlakOffice_UI.Dtos.KategoriDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmlakOffice_UI.ViewComponents.HomePage
{
	public class _DefaultPropertiesViewPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultPropertiesViewPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7158/api/Emlak/EmlakListKategoriyle");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();	
				var values = JsonConvert.DeserializeObject<List<EmlakSonucDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
