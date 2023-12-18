using Dapper;
using EmlakOffice_API.Dto.KategoriDtos;
using EmlakOffice_API.İslemlerKategori.KategoriContract;
using EmlakOffice_API.Models.DbContext;

namespace EmlakOffice_API.Repos.KategoriRepos
{
    public class KategoriRepos : AraBirimKategoriRepos
    {
        private readonly Context _context;

        public KategoriRepos(Context context)
        {
            _context = context;
        }
        public async Task<List<KategoriSonuc>> GetAllKategoriAsync()
        {
            string query = "Select * FROM Kategori";
            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<KategoriSonuc>(query); 
                return values.ToList(); 
            }
        }

        public async Task<IdKategori> GetKategori(int id)
        {
            string query = "SELECT * FROM Kategori WHERE KategoriId=@KategoriId";
            var parameters = new DynamicParameters();
            parameters.Add("@KategoriId", id);
            using (var connectiont = _context.CreateConnection())
            {
                var valuesId = await connectiont.QueryFirstOrDefaultAsync<IdKategori>(query, parameters);
                return valuesId;
            }
        }

        public async void KategoriGuncelle(KategoriGuncelle kategori)
        {
            string query = "UPDATE Kategori SET KIsim = @kategoriAdi, KDurumu = @kategoriDurumu WHERE KategoriId = @kategoriId";
            var parameters = new DynamicParameters();
            parameters.Add("@kategoriAdi", kategori.KIsim);
            parameters.Add("@kategoriDurumu", kategori.KDurumu);
            parameters.Add("@kategoriId", kategori.KategoriId);
            using (var connectiont = _context.CreateConnection())
            {
                await connectiont.ExecuteAsync(query, parameters);
            }
        }

        public async void KategoriOlustur(KategoriOlustur kategori)
        {
            string query = "INSERT INTO Kategori (KIsim, KDurumu) VALUES (@kategoriAdi, @kategoriDurumu)";
            var parameters = new DynamicParameters();
            parameters.Add("@kategoriAdi", kategori.KIsim);
            parameters.Add("@kategoriDurumu", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void KategoriSil(int id)
        {
            string query = "DELETE FROM Kategori WHERE KategoriId = @kategoriId";
            var parameters = new DynamicParameters();
            parameters.Add("@kategoriId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);

            }
        }


    }
}
