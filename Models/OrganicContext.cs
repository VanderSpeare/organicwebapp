using Microsoft.EntityFrameworkCore;

namespace WebApp.Models;
public class OrganicContext : DbContext
{
    public OrganicContext(DbContextOptions options) : base(options) { }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<InvoiceDetail>().HasKey(p => new
        {
            p.InvoiceId,
            p.ProductId
        });
    }
}