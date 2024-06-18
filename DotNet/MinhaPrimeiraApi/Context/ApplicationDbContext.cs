using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Context;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        
    }

    public DbSet<Cliente> Clientes { get; set; }
}