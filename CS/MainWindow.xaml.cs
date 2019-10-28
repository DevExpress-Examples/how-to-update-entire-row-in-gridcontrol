using DevExpress.Xpf.Grid;
using System.Linq;
using System.Windows;

namespace InfiniteAsyncSourceEFSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            var context = new IssuesContext();
            grid.ItemsSource = context.Issues.ToArray();
        }

        void TableView_ValidateRow(object sender, GridRowValidationEventArgs e) {
            var issue = (Issue)e.Row;
            using(var context = new IssuesContext()) {
                var result = context.Issues.SingleOrDefault(b => b.Id == issue.Id);
                if(result != null) {
                    result.Subject = issue.Subject;
                    result.Priority = issue.Priority;
                    result.Votes = issue.Votes;
                    result.Priority = issue.Priority;
                    context.SaveChanges();
                }
            }
        }
    }
}
