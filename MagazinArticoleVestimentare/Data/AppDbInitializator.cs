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

                }
                //Add relationships Comanda & Produse
                if (!context.ProdusComandat.Any())
                {

                }


            }
        }
    }
}
