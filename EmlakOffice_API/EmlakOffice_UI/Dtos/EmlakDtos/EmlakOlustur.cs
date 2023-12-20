namespace EmlakOffice_UI.Dtos.EmlakDtos
{
    public class EmlakOlustur
    {
        //Düzen - Özel Yapıştır- Json

        public int emlakId { get; set; }
        public string basligi { get; set; }
        public decimal fiyati { get; set; }
        public string sehir { get; set; }
        public string ilce { get; set; }
        public string aciklama { get; set; }
        public int kategoriId { get; set; }
        public string resmi { get; set; }
        public string tip { get; set; }
        public string adres { get; set; }
    }
}
