namespace DesignPatterns.PrototypePattern.Models
{
    public class Oyun : PrototypeOyun
    {
       
        public int OyunId { get; set; }
        public string OyunAdi { get; set; }
        public string OyunTuru { get; set; }
        public bool Durum { get; set; }
        public Oyun(int oyunId, string oyunAdi, string oyunTuru, bool durum)
        {
            OyunId = oyunId;
            OyunAdi = oyunAdi;
            OyunTuru = oyunTuru;
            Durum = durum;
        }

        public override PrototypeOyun Clone()
        {
            return this.MemberwiseClone() as PrototypeOyun;
        }
    }
}
