using Microsoft.EntityFrameworkCore;

public class BancoDeDados : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseMySQL("server=127.0.0.1;port=3306;database=arrozdoce;user=root;password=11");
    }

    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Compra> Compra { get; set; }
    public DbSet<Venda> Venda { get; set; }
    public DbSet<Games> Games { get; set; }

}

