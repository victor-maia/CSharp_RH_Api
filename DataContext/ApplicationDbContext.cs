namespace WebApi_RH.DataContext;
using Microsoft.EntityFrameworkCore;
using WebApi_RH.Models;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<FuncionarioModel> Funcionarios { get; set; }
}
