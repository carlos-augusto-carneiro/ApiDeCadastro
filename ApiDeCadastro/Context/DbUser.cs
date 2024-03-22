using ApiDeCadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDeCadastro.Context;

public class DbUser : DbContext
{
    public DbUser(DbContextOptions options) : base(options){}

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserMapping());
    }
}
