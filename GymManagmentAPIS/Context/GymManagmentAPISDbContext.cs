using GymManagmentAPIS.Models.Entity;
using GymManagmentAPIS.Models.EntityConfigriation;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace GymManagmentAPIS.Context
{
    public class GymManagmentAPISDbContext : DbContext
    {
        public GymManagmentAPISDbContext(DbContextOptions<GymManagmentAPISDbContext> Options) : base(Options)
        {


        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // db configuration 

            modelBuilder.ApplyConfiguration(new AdminEntityConfigriation ());

            modelBuilder.ApplyConfiguration(new ClientEntityConfigriation ());

            modelBuilder.ApplyConfiguration(new CoachEntityConfigriation ());

            modelBuilder.ApplyConfiguration(new DepartmentEntityConfigriation ());

            modelBuilder.ApplyConfiguration(new EmployeeEntityConfigriation ());

            modelBuilder.ApplyConfiguration(new SubscriptionEntityConfigriation ());






        }


        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Client > Clients { get; set; }

        public virtual DbSet<Coach > Coachs { get; set; }

        public virtual DbSet<Department > Departments { get; set; }

        public virtual DbSet<Employee > Employees { get; set; }

        public virtual DbSet<Subscription > Subscriptions { get; set; }

    }
}
