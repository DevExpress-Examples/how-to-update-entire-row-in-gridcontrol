using System.Data.Entity;

namespace InfiniteAsyncSourceEFSample {
    public class IssuesContext : DbContext {
        static IssuesContext() {
            Database.SetInitializer(new IssuesContextInitializer());
        }
        public IssuesContext() { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Issue>()
                .Property(x => x.Subject)
                .IsRequired();
        }

        public DbSet<Issue> Issues { get; set; }
    }
}
