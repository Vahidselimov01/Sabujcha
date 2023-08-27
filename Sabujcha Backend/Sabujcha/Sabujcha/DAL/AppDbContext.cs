using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sabujcha.Models;


namespace Sabujcha.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductsIcons> ProductsIcons { get; set; }
        public DbSet<AboutUsArea> AboutUsAreas { get; set;}
        public DbSet<HeaderNav> HeaderNavs { get; set; }
        public DbSet<HeaderCatagorys> HeaderCatagorys { get;set; }
        public DbSet<CatagoryNames>CatagoryNames { get; set; }

        public DbSet<NavDropName> NavDropNames { get; set; }
        public DbSet<FooterContent>FooterContents { get; set; }
        public DbSet<FooterTitles>FooterTitles { get; set; }
        public DbSet<FooterContact>FooterContacts { get; set; }
        public DbSet<ContactUs>ContactUs { get; set; }
     

    }
   
}

