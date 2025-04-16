using bookepub.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookepub.Data;

public class BookepubContext : DbContext
{
    public BookepubContext(DbContextOptions<BookepubContext> options)
        : base(options)
    {
    }
    public DbSet<Admin> Admin { get; set; }

public DbSet<Announcement> Announcement { get; set; } = default!;

public DbSet<Author> Author { get; set; } = default!;

public DbSet<Book> Book { get; set; } = default!;

public DbSet<Publisher> Publisher { get; set; } = default!;


    // public DbSet<Incident> Incident { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);
    //
    //     // modelBuilder.Entity<IncidentDistrictSummary>().HasNoKey();
    //     // modelBuilder.Entity<BeneficiaryDistrictSummary>().HasNoKey();
    //     // modelBuilder.Entity<FiscalYearRepositories.AnalyticsCount>().HasNoKey();
    //     // modelBuilder.Entity<GroupDistrictSummary>().HasNoKey();
    //     // modelBuilder.Entity<GroupBeneficiariesDistrictSummary>().HasNoKey();
    //
    // }
}