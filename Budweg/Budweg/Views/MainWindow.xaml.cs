using Budweg.Persistence;
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

namespace Budweg.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      
        private void BtnReceive_Click(object sender, RoutedEventArgs e)
        {
            {
                ReceiveWindow receiveWin = new ReceiveWindow();
                receiveWin.Owner = this;
                receiveWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                receiveWin.ShowDialog();
            }
        }

       
        private void BtnDispatch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Afsend skærm");
        }

        private void BtnScrap_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kassér skærm");
        }

        private void BtnNote_Click(object sender, RoutedEventArgs e)
        {
            NoteWindow noteWin = new NoteWindow();
            noteWin.Owner = this;
            noteWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            noteWin.ShowDialog();
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Info skærm");
        }

    }
}