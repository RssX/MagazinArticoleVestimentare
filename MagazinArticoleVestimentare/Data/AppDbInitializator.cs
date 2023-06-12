using MagazinArticoleVestimentare.Data.Enums;
using MagazinArticoleVestimentare.Models;

namespace MagazinArticoleVestimentare.Data
{
    public class AppDbInitializator
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Add Clienti
                if (!context.Clienti.Any())
                {

                }
                //Add Comanda
                if (!context.Comanda.Any())
                {

                }
                //Add Produse
                if (!context.Produse.Any())
                {
                    context.Produse.AddRange(new List<Produse>()
                    {
                        new Produse() {
                            Nume= "Champion, Bermude sport cu snur, Negru",
                            Marime = "M",
                            Pret = 79.99,
                            CantitateInStoc = 3,
                            CategorieProdus = CategorieProdus.Imbracaminte,
                            ImagineProdusUrle = "https://s13emagst.akamaized.net/products/52550/52549723/images/res_d09bda3676b0aa6ce43fc79cd2d3914d.jpg?width=450&height=450&hash=23BF94A0940C34C7F73B6348B57AF6EC"
                        },
                    });
                    context.SaveChanges();
                }
                //Add relationships Comanda & Produse
                if (!context.ProdusComandat.Any())
                {

                }


            }
        }
    }
}
