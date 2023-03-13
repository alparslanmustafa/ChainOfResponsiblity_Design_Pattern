using ChainOfResponsiblity_Design_Pattern.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsiblity_Design_Pattern.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VG05C7A\\SQLEXPRESS;initial catalog=ChainOfRespDb;integrated security=true");
        }
        public DbSet<CustomerProccess> CustomerProcesses { get; set; }
    }
}
