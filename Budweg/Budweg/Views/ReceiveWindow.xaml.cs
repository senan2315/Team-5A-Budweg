using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Budweg.Models;
using Budweg.Persistence;

namespace Budweg.Views
{
 
    public partial class ReceiveWindow : Window
    {
        private BrakeCaliperRepository _repo = new BrakeCaliperRepository();
        public ReceiveWindow()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            BrakeCaliper newCaliper = new BrakeCaliper(0)
            {
                Barcode = txtBarcode.Text,
                CaliperStatus = ProcessingStatus.Received,
                CaliperNumber = "WB" + txtBarcode.Text
            };

            _repo.CreateBrakeCaliper(newCaliper);

            MessageBox.Show("Bremsekaliber registreret! ....hopefully");
            this.Close();

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
