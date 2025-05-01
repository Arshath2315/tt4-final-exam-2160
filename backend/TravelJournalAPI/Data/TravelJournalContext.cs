using Microsoft.EntityFrameworkCore;
using TravelJournalAPI.Models;

namespace TravelJournalAPI.Data
{
    public class TravelJournalContext : DbContext
    {
        public TravelJournalContext(DbContextOptions<TravelJournalContext> options)
            : base(options) { }

        // DbSet property to interact with the TravelEntries table
        public DbSet<TravelEntry> TravelEntries { get; set; }

        // Optional: You can override OnModelCreating if you want to configure the model more explicitly
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Example of customizing the model if needed, like setting up table names or relationships
            modelBuilder.Entity<TravelEntry>()
                .ToTable("TravelEntries"); // This is already the default behavior
        }
    }
}
