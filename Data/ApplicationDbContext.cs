using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAuthenticationCrud.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Premium> Premiums { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }
}
