using EFCodeFirst_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.Models.ContextClasses
{
    //DbContext sınıfınız veritabanı işlemlerinizin hepsini yapabilen bir sınıfınızdır...Siz veritabanı işlemlerinizi yapabilmek icin DbContext'ten miras alırsınız

    //Bir sınıf DbContext'ten miras alıyor ise o bir veritabanı sınıfıdır...



    //Migration kodları
    //enable-migrations -enableautomaticmigrations

    //update-database



    public class MyContext : DbContext
    {
        #region Notlar
        //Asagıdaki adres belirleme sistemi tercih ettigimiz bir yöntem degildir...Cünkü esnekligi bitirir

        //public MyContext()
        //{
        //    Database.Connection.ConnectionString = "server = . ; database = ...";
        //} 
        #endregion


        //BUradaki base'in (DbContext Constructor'inin) string parametre alan overload'i calısacak ve projenin (su anda tek bir projemiz var, eger birden fazla olsaydı startup olarak set edilen projenin) config dosyasındaki connectionString isimlerini arayacak...Oradan ismini buldugu adresi algılayacak...

        //Ef entegrasyonlarında bir connectionString ismi algılandıgı anda mevcut solution'da hangi proje calısmak icin görevlendirildi ise o projenin config'ine bakılır...
        public MyContext() : base("WindowsAuthConnection")
        {

           
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Category>().ToTable("Kategoriler");

            //modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasColumnName("Kategori Ismi");

            modelBuilder.Entity<Product>().Property(x => x.UnitPrice).HasColumnType("money"); //Burada Product Entity'sine ulasıp onun UnitPrice isimli property'sine eriştik ve o property SQL'deki Products tablosunda bir sütun olacagı zaman onun tipinin money olacagını söyledik...


            modelBuilder.Entity<AppUser>().HasOptional(x => x.Profile).WithRequired(x => x.AppUser); //Birebir ilişki ifadesinin ikinci fazının tamamlanmıs halidir...BUrada anlatılmak istenen ifade : Bir AppUser'in Profil'i olmayabilir (HasOptional(x => x.Profile))...Lakin bir Profilin AppUser'i olmak zorundadır (WithRequired(x=>x.AppUser)) HasOptional(Opsiyonel), WithRequired(Gerekli)

            modelBuilder.Entity<OrderDetail>().Ignore(x => x.Id); //BUradaki Ignore metodu bizim belirledigimiz bir property'nin SQL'e gönderilmesini engeller...

            modelBuilder.Entity<OrderDetail>().HasKey(x => new
            {
                x.OrderId,
                x.ProductId
            }); //HasKey metodu sizin tablo olacak calss'ınız tablo olacagı zaman nasıl bir key'e sahip olacagını belirtir...Biz diger class'larda böyle bir tanımlama yapmadık cünkü onlar Id isimli bir property'e sahip oldugu icin otomatik olarak key'leri belirleniyordu...Ama OrderDetail tarafında Id'yi ignore ettigimiz icin artık acıkca belirlemek durumunda kaldık...

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> Profiles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


    }
}
