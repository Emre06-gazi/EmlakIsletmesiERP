
using EmlakOffice_API.Dto.KategoriDtos;
using EmlakOffice_API.İslemlerKategori.KategoriContract;

namespace EmlakOffice_API.Repos.KategoriRepos
{
    public interface AraBirimKategoriRepos
    {
        Task<List<KategoriSonuc>> GetAllKategoriAsync();
        void KategoriOlustur(KategoriOlustur kategori);
        void KategoriSil(int id);
        void KategoriGuncelle(KategoriGuncelle kategori);
        Task<IdKategori> GetKategori(int id);
    }
}
