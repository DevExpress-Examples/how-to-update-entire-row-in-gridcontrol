using System.Collections.Generic;

namespace InfiniteAsyncSourceEFSample {
    public class User {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
    }
}
