using EmlakOffice_UI.Dtos.ReferansDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmlakOffice_UI.ViewComponents.HomePage
{
    public class _DefaultHappyCustomerViewPartial : ViewComponent
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultHappyCustomerViewPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7158/api/Referans");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ReferansSonucDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}