using EmlakOffice_API.Dto.KategoriDtos;
using EmlakOffice_API.Repos.KategoriRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        private readonly AraBirimKategoriRepos _kategoriRepos;

        public KategoriController(AraBirimKategoriRepos kategoriRepos)
        {
            _kategoriRepos = kategoriRepos;
        }
        [HttpGet]
        public async Task<IActionResult> KategoriList()
        {
            var values = await _kategoriRepos.GetAllKategoriAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> KategoriOlustur(KategoriOlustur kategoriOlustur)
        {
            _kategoriRepos.KategoriOlustur(kategoriOlustur);
            return Ok("Kategori Eklendi!");
        }
        [HttpDelete]
        public async Task<IActionResult> KategoriSil(int id)
        {
            _kategoriRepos.KategoriSil(id);
            return Ok("Kategori Silindi!");
        }
        [HttpPut]
        public async Task<IActionResult> KategoriGuncelle(KategoriGuncelle kategoriGuncelle)
        {
            _kategoriRepos.KategoriGuncelle(kategoriGuncelle);
            return Ok("Kategori Güncellendi!");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetKategori(int id)
        {
            var value = await _kategoriRepos.GetKategori(id);
            return Ok(value);
        }
    }
}
