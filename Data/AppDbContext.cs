using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Data
{
    class AppDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public const string ConnectString = "Server=localhost;Database=DB_Behavioural;Trusted_Connection=True;MultipleActiveResultSets=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectString)
                          .UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
        }

        //User
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        
        //assessment
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Ana_Antecedents_Activity> Ana_Antecedents_Activities { get; set; }
        public DbSet<Ana_Antecedents_Enviromental> Ana_Antecedents_Enviromentals { get; set; }
        public DbSet<Ana_Antecedents_Perceived> Ana_Antecedents_Perceiveds { get; set; }
        
        //Intervention
        public DbSet<Intervention> Interventions { get; set; }
        public DbSet<Profile_Extreme> Profile_Extremes { get; set; }
        public DbSet<Profile_Mild> Profile_Milds { get; set; }
        public DbSet<Profile_Moderate> Profile_Moderates { get; set; }
        public DbSet<Profile_Recovery> Profile_Recoverys { get; set; }



    }
}
