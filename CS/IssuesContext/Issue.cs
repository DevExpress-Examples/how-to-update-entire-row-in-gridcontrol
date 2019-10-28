using System;

namespace InfiniteAsyncSourceEFSample {
    public class Issue {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime Created { get; set; }
        public int Votes { get; set; }
        public Priority Priority { get; set; }
    }
    public enum Priority { Low, BelowNormal, Normal, AboveNormal, High }
}
