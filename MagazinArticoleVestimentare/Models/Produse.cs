using MagazinArticoleVestimentare.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MagazinArticoleVestimentare.Models
{
    public class Produse
    {
        [Key]
        public int ProdusId { get; set; }
        [Display(Name="Produs")]
        [Required(ErrorMessage = "Nume produsului este obligatoriu")]
        public string Nume { get; set; }
        [Display(Name = "Marime")]
        public string Marime { get; set; }
        [Display(Name = "Imagine")]
        public string ImagineProdusUrle { get; set; }
        [Display(Name = "Cantitatea în stoc")]
        public int CantitateInStoc { get; set; }
        [Display(Name = "Preț")]
        public double Pret { get; set; }

        public CategorieProdus CategorieProdus { get; set; }

        //Relationships
        
        public List<ProdusComandat>? ProdusComandat { get; set; }
    }
}
