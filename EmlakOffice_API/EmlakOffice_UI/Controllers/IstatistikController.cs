using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.Controllers
{
    public class IstatistikController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IstatistikController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> IndexAsync()
        {
            #region AktifKategori
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7158/api/Istatistik/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsonData;
            #endregion

            #region DeAktifKategori
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:7158/api/Istatistik/DeActiveCategoryCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.deActiveCategoryCount = jsonData2;
            #endregion

            #region DaireCount
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:7158/api/Istatistik/ApartmentCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.apartmentCount = jsonData3;
            #endregion

            #region TarlaCount
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:7158/api/Istatistik/TarlaCount");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.tarlaCount = jsonData4;
            #endregion

            #region PersonelAktif
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:7158/api/Istatistik/ActiveEmployeeCount");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsonData5;
            #endregion

            #region KiralıkOrt
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:7158/api/Istatistik/AverageProductPriceByRent");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceByRent = jsonData6;
            #endregion

            #region SatılıkOrt
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:7158/api/Istatistik/AverageProductPriceBySale");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceBySale = jsonData7;
            #endregion

            #region OdaOrt
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:7158/api/Istatistik/AvereageRoomCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.avereageRoomCount = jsonData8;
            #endregion

            return View();
        }
    }
}
