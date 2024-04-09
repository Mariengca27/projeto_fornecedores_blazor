using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using fornecedores.Models;


namespace Fornecedores.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
public DbSet<Material> Material { get; set; }
public DbSet<Cliente> Cliente { get; set; }


}
