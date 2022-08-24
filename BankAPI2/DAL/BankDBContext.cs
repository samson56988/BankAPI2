using BankAPI2.Model;
using Microsoft.EntityFrameworkCore;

namespace BankAPI2.DAL
{
    public class BankDBContext:DbContext
    {
        public BankDBContext(DbContextOptions<BankDBContext> options):base(options)
        {

        }

        public DbSet<CardRequest> CardRequests { get; set; }
    }
}
