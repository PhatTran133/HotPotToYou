using HotPotToYou.Domain.Common.Interfaces;
using HotPotToYou.Domain.Entity;
using HotPotToYou.Domain.Entity.ConfigTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotToYou.Infrastructure
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ActivityTypeEntity> ActivityType { get; set; }
        public DbSet<HotPotTypeEntity> HotPotType { get; set; }
        public DbSet<IngredientGroupEntity> IngredientGroup { get; set; }
        public DbSet<PaymentEntity> Payment { get; set; }
        public DbSet<RoleEntity> Role { get; set; }

        public DbSet<CustomerEntity> Customer { get; set; }
        public DbSet<HotPotEntity> HotPot { get; set; }
        public DbSet<HotPotIngredientEntity> HotPotIngredient { get; set; }
        public DbSet<HotPotPackageEntity> HotPotPackage { get; set; }
        public DbSet<HotPotUtensilTypeEntity> HotPotUtensilType { get; set; }
        public DbSet<IngredientEntity> Ingredient { get; set; }
        public DbSet<OrderActivityEntity> OrderActivity { get; set; }
        public DbSet<OrderEntity> Order { get; set; }
        public DbSet<OrderUtensilEntity> OrderUtensil { get; set; }
        public DbSet<UserEntity> User { get; set; }
        public DbSet<UtensilDetailEntity> UtensilDetail { get; set; }
        public DbSet<UtensilEntity> Utensil { get; set; }
        public DbSet<UtensilPackageEntity> UtensilPackage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new RoleConfiguration());
            ConfigureModel(modelBuilder);
        }

        private void ConfigureModel(ModelBuilder modelBuilder)
        {


        }
    }
}
