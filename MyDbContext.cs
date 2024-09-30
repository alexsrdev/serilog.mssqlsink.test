using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=myDataBase;User=sa;Password=Password1234;TrustServerCertificate=true");
    }
}