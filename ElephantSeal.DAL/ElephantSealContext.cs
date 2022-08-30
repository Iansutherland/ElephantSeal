using ElephantSearl.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElephantSeal.DAL
{
    public class ElephantSealContext : DbContext
    {
        public DbSet<Recruiter> Recruiters { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<RecruiterReview> RecruiterReviews { get; set; }
        public DbSet<OrganizationReview> OrganizationReviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
