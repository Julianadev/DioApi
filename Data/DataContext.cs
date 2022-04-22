using Microsoft.EntityFrameworkCore;
using DioApi.Models;
using Microsoft.Extensions.Options;

namespace DioApi.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           :base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    }
}