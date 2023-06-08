using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagazinArticoleVestimentare.Models
{
    public class Comanda
    {
        [Key]
        public int ComandaId { get; set; }

        [Required]
        public DataType DataComenzii { get; set; }

        //Relantionships

        public List<ProdusComandat> ProdusComandat { get; set; }

        //Clienti
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Clienti Clienti { get; set; }


    }
}
