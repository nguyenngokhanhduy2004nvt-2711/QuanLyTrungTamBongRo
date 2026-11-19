using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using NguyenNgoKhanhDuy_DH52200571.Models;

namespace NguyenNgoKhanhDuy_DH52200571
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BongRoDB;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}