using ChatAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ChatAPI.Context
{
    public class DBChatContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DBChatContext(DbContextOptions<DBChatContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=DBChatApi;Username=postgres;Password=ig+XT8sVC6llO#-%");
            //optionsBuilder.UseNpgsql("Host=db.zpgnifgksqsiolvxerts.supabase.co;Database=postgres;Username=postgres;Password=ig+XT8sVC6llO#-%;SSL Mode=Require;Trust Server Certificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
