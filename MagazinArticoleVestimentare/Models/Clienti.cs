using System.ComponentModel.DataAnnotations;

namespace MagazinArticoleVestimentare.Models
{
    public class Clienti
    {
        [Key]
        public int ClientId { get; set; }

        public string Nume { get; set; }

        public string Adresa { get; set; }

        public string Tara { get; set; }
    }
}
