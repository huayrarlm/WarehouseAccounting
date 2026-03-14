using Microsoft.EntityFrameworkCore;

namespace WarehouseAccounting
{
    public class ApplicationDBContext : DbContext 
    {
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Настраиваем подключение к PostgreSQL
            // ВАЖНО: Замени строку подключения на свои параметры!
            string connectionString = "Host=localhost;Port=5432;Database=WarehouseDB;Username=postgres;Password=QWERTY";

            // Указываем, что используем PostgreSQL с нашей строкой подключения
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настраиваем таблицу Users
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users"); // Имя таблицы в БД
                entity.HasKey(e => e.id); // Первичный ключ
                entity.Property(e => e.name).HasColumnName("name");
                entity.Property(e => e.email).HasColumnName("email");
                entity.Property(e => e.password).HasColumnName("password");
                entity.Property(e => e.role).HasColumnName("role");

                // Устанавливаем уникальность email
                entity.HasIndex(e => e.email).IsUnique();
            });
        }
    }
}
