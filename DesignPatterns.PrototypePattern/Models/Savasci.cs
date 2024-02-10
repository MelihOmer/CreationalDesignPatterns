namespace DesignPatterns.PrototypePattern.Models
{
    public class Savasci : SavasciPrototype
    {
       
        public int Saglik { get; set; }
        public int Guc { get; set; }
        public string Adı { get; set; }
        public string Turu { get; set; }
        public Savasci(int saglik, int güc, string adı, string turu)
        {
            this.Saglik = saglik;
            this.Guc = güc;
            this.Adı = adı;
            this.Turu = turu;
        }


        public override SavasciPrototype Clone()
        {
           return this.MemberwiseClone() as SavasciPrototype;
        }
    }
}
