using DevExpress.Internal;
using System.Windows;

namespace InfiniteAsyncSourceEFSample {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        public App() {
            DbEngineDetector.PatchConnectionStringsAndConfigureEntityFrameworkDefaultConnectionFactory();
        }
    }
}
