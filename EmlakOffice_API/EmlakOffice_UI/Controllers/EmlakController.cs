using EmlakOffice_UI.Dtos.KategoriDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace EmlakOffice_UI.Controllers
{
    public class EmlakController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public EmlakController(IHttpClientFactory httpClientFactory)
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
        [HttpGet]
        public async Task<IActionResult> EmlakOlustur()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7158/api/Kategori");
            
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<KategoriSonucDto>>(jsonData); //Listeleme için deserialize

            List<SelectListItem> kategoriValues = (from i in values.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = i.KIsim,
                                                       Value = i.KategoriId.ToString()
                                                   }).ToList();
            ViewBag.j = kategoriValues; //ViewBag ile view tarafına verileri taşıdım.

            return View();
        }
    }
}
