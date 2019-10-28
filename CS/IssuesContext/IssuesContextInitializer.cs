using System;
using System.Data.Entity;
using System.Linq;

namespace InfiniteAsyncSourceEFSample {
    public class IssuesContextInitializer : DropCreateDatabaseIfModelChanges<IssuesContext> { 

        protected override void Seed(IssuesContext context) {
            base.Seed(context);
            var rnd = new Random();
            var issues = Enumerable.Range(0, 1000)
                .Select(i => new Issue() {
                    Subject = OutlookDataGenerator.GetSubject(),
                    Created = DateTime.Today.AddDays(-rnd.Next(30)),
                    Priority = OutlookDataGenerator.GetPriority(),
                    Votes = rnd.Next(100),
                })
                .ToArray();
            context.Issues.AddRange(issues);

            context.SaveChanges();
        }
    }
}
