using Microsoft.EntityFrameworkCore;

namespace ASP.NET1.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        public List<Account> getAccounts() => Accounts.ToList();

        public void AddUser(Account user)
        {
            Accounts.Add(user);
            this.SaveChanges();
            return;
        }
    }
}
