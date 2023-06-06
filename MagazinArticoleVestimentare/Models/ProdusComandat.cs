namespace MagazinArticoleVestimentare.Models
{
    public class ProdusComandat
    {
        public int ComandaId { get; set; }
        public Comanda Comanda { get; set; }
        public int ProdusId { get; set; }
        public Produse Produse { get; set; }
        public int CantitateComandata { get; set; }
    }
}
