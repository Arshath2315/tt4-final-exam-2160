using Microsoft.EntityFrameworkCore;
using TravelJournalAPI.Models;

namespace TravelJournalAPI.Data
{
    public class TravelJournalContext : DbContext
    {
        public TravelJournalContext(DbContextOptions<TravelJournalContext> options)
            : base(options) { }

        public DbSet<TravelEntry> TravelEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<TravelEntry>()
                .ToTable("TravelEntries"); 
        }
    }
}
