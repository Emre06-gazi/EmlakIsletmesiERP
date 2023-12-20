using EmlakOffice_UI.Dtos.KategoriDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace EmlakOffice_UI.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public KategoriController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7158/api/Kategori");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<KategoriSonucDto>>(jsonData); //Listeleme için deserialize
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult KategoriOlustur()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> KategoriOlustur(KategoriOlustur kategoriOlustur)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(kategoriOlustur); // Ekleme ve guncellem için serializite
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7158/api/Kategori", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> KategoriSil(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7158/api/Kategori/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public async Task<IActionResult> KategoriGuncelle(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7158/api/Kategori/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<KategoriGuncelle>(jsonData); //Listeleme için deserialize
                return View(values);
            }
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> KategoriGuncelle(KategoriGuncelle kategoriGuncelle)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(kategoriGuncelle);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7158/api/Kategori/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
