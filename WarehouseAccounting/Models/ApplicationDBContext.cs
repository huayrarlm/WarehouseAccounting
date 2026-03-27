using Microsoft.EntityFrameworkCore;
using WarehouseAccounting.Models;

namespace WarehouseAccounting
{
    /// <summary>
    /// ТАБЛИЦЫ ИЗ БД, ПОДКЛЮЧЕНИЕ, СВЯЗЬ
    /// </summary>
    public class ApplicationDBContext : DbContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<History> History { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Настраиваем подключение к PostgreSQL
            string connectionString = "Host=localhost;Port=5432;Database=WarehouseDB;Username=postgres;Password=QWERTY";

            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Настраиваем таблицу Users
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users"); // Имя таблицы в БД
                entity.HasKey(e => e.id); // Первичный ключ
                entity.Property(e => e.name).HasColumnName("name");
                entity.Property(e => e.email).HasColumnName("email");
                entity.Property(e => e.password).HasColumnName("password");
                entity.Property(e => e.role).HasColumnName("role");

                entity.Property(e => e.role)
                    .HasColumnName("role")
                    .HasConversion<string>();

                // Устанавливаем уникальность email
                entity.HasIndex(e => e.email).IsUnique();
            });

            //Настраиваем таблицу Products
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Products");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.SKU)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasIndex(e => e.SKU)
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Category)
                    .HasMaxLength(100);

                entity.Property(e => e.Unit)
                    .HasMaxLength(20);

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Quantity)
                    .HasDefaultValue(0);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Clients");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.FirstName)
                    .HasColumnName("Имя")
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .HasColumnName("Фамилия")
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("Отчество")
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasColumnName("Контакты")
                    .HasMaxLength(20);

                entity.Property(e => e.City)
                    .HasColumnName("Город")
                    .HasMaxLength(100);

                entity.Property(e => e.Address)
                    .HasColumnName("Адрес")
                    .HasMaxLength(200);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Дата")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.HasKey(e => e.Id);

                // Внешний ключ на клиента
                //entity.HasOne(e => e.Client)
                //    .WithMany()
                //    .HasForeignKey(e => e.ClientId)
                //    .HasConstraintName("FK_Order_Client_IDклиента")
                //    .OnDelete(DeleteBehavior.Restrict);

                //// Внешний ключ на товар
                //entity.HasOne(e => e.Product)
                //    .WithMany()
                //    .HasForeignKey(e => e.ProductId)
                //    .HasConstraintName("FK_Order_Product_IDтовара")
                //    .OnDelete(DeleteBehavior.Restrict);

                // Поля
                entity.Property(e => e.ClientId)
                    .HasColumnName("IDклиента")
                    .IsRequired();

                entity.Property(e => e.ProductId)
                    .HasColumnName("IDтовара")
                    .IsRequired();

                entity.Property(e => e.SKU)
                    .HasColumnName("Артикул")
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("Название")
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Category)
                    .HasColumnName("Категория")
                    .HasMaxLength(100);

                entity.Property(e => e.Unit)
                    .HasColumnName("ЕдИзмерения")
                    .HasMaxLength(20);

                entity.Property(e => e.Price)
                    .HasColumnName("Цена")
                    .HasColumnType("decimal(10,2)")
                    .IsRequired();

                entity.Property(e => e.Quantity)
                    .HasColumnName("Количество")
                    .IsRequired()
                    .HasDefaultValue(1);
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.ToTable("Shipments");

                entity.HasKey(e => e.Id);

                //// Связь с Product
                //entity.HasOne(e => e.Product)
                //    .WithMany()
                //    .HasForeignKey(e => e.ProductId)
                //    .OnDelete(DeleteBehavior.Restrict);

                //// Связь с Client
                //entity.HasOne(e => e.Client)
                //    .WithMany()
                //    .HasForeignKey(e => e.ClientId)
                //    .OnDelete(DeleteBehavior.Restrict);

                //// Связь с User
                //entity.HasOne(e => e.User)
                //    .WithMany()
                //    .HasForeignKey(e => e.UserId)
                //    .OnDelete(DeleteBehavior.Restrict);

                // Настройка полей
                entity.Property(e => e.SKU)
                    .HasColumnName("Артикул")
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("Название")
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Category)
                    .HasColumnName("Категория")
                    .HasMaxLength(100);

                entity.Property(e => e.Unit)
                    .HasColumnName("ЕдИзмерения")
                    .HasMaxLength(20);

                entity.Property(e => e.Price)
                    .HasColumnName("Цена")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("Количество")
                    .IsRequired();

                entity.Property(e => e.RemainingAfter)
                    .HasColumnName("ОстатокПосле");

                entity.Property(e => e.IsAvailable)
                    .HasColumnName("Наличие")
                    .HasDefaultValue(true);
            });


            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("History");

                entity.HasKey(e => e.Id);

                //// Связь с Product
                //entity.HasOne(e => e.Product)
                //    .WithMany()
                //    .HasForeignKey(e => e.ProductId)
                //    .OnDelete(DeleteBehavior.Restrict);

                //// Связь с Client
                //entity.HasOne(e => e.Client)
                //    .WithMany()
                //    .HasForeignKey(e => e.ClientId)
                //    .OnDelete(DeleteBehavior.Restrict);

                //// Связь с User
                //entity.HasOne(e => e.User)
                //    .WithMany()
                //    .HasForeignKey(e => e.UserId)
                //    .OnDelete(DeleteBehavior.Restrict);

                // Поля
                entity.Property(e => e.ProductId)
                    .HasColumnName("IDтовара")
                    .IsRequired();

                entity.Property(e => e.ClientId)
                    .HasColumnName("IDклиента")
                    .IsRequired();

                entity.Property(e => e.UserId)
                    .HasColumnName("IDпользователя")
                    .IsRequired();

                entity.Property(e => e.SKU)
                    .HasColumnName("Артикул")
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("Название")
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Category)
                    .HasColumnName("Категория")
                    .HasMaxLength(100);

                entity.Property(e => e.Unit)
                    .HasColumnName("ЕдИзмерения")
                    .HasMaxLength(20);

                entity.Property(e => e.Price)
                    .HasColumnName("Цена")
                    .HasColumnType("decimal(10,2)")
                    .IsRequired();

                entity.Property(e => e.Quantity)
                    .HasColumnName("Количество")
                    .IsRequired();

                entity.Property(e => e.ClientFullName)
                    .HasColumnName("ФИО")
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.City)
                    .HasColumnName("Город")
                    .HasMaxLength(100);

                entity.Property(e => e.Address)
                    .HasColumnName("Адрес")
                    .HasMaxLength(200);

                entity.Property(e => e.OperationDate)
                    .HasColumnName("Дата")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Storekeeper)
                    .HasColumnName("Кладовщик")
                    .HasMaxLength(100);
            });
        }
    }
}
