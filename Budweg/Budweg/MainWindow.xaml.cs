using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Budweg
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var brakeRepo = new BrakeCaliperRepository("");
            var stationRepo = new StationRepository("");
            var spareRepo = new SparePartRepository("");

            var viewModel = new MainViewModel(brakeRepo, stationRepo, spareRepo);

            DataContext = viewModel;
        }

        private void BtnNote_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}