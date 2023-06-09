using MagazinArticoleVestimentare.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MagazinArticoleVestimentare.Models
{
    public class Produse
    {
        [Key]
        public int ProdusId { get; set; }
        [Display(Name="Numele produsului")]
        public string Nume { get; set; }
        [Display(Name = "Marimea")]
        public string Marime { get; set; }
        [Display(Name = "Url Imagine")]
        public string ImagineProdusUrle { get; set; }
        [Display(Name = "Cantitatea in stoc")]
        public int CantitateInStoc { get; set; }
        [Display(Name = "Pretul produsului")]
        public double Pret { get; set; }

        public CategorieProdus CategorieProdus { get; set; }

        //Relationships
        public List<ProdusComandat> ProdusComandat { get; set; }
    }
}
