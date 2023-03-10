using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data_AccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HKAH8F2;Initial Catalog=DenemeDb;Integrated Security=True");

            //CoreMVCKampProjeDB
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.WriterSender)
                .HasForeignKey(z=>z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                 .HasOne(x => x.RecieverUser)
                .WithMany(y => y.WriterReciever)
                .HasForeignKey(z => z.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<About> abouts { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Writer> writers { get; set; }
        public DbSet<NewsLetter> newsLetters { get; set; }
        public DbSet<BlogRayting> blogRaytings { get; set; }
        public DbSet<Notification> notifications { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Message2> messages2 { get; set; }
        public DbSet<Admin> admins { get; set; }

    }
}
