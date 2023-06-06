using MagazinArticoleVestimentare.Data.Enums;

namespace MagazinArticoleVestimentare.Models
{
    public class Produse
    {
        public int ProdusId { get; set; }
        public string Nume { get; set; }
        public string Marime { get; set; }
        public string ImagineProdusUrle { get; set; }
        public int CantitateInStoc { get; set; }

        public double Pret { get; set; }

        public CategorieProdus CategorieProdus { get; set; }

        //Relationships
        public List<ProdusComandat> ProduseComandate { get; set; }
    }
}
