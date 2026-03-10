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

namespace Budweg
{
    public partial class NoteWindow : Window
    {
        public NoteWindow()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewNote.Text))
            {
                string timestamp = DateTime.Now.ToString("HH:mm");
                string newEntry = $"\n[{timestamp} - Bruger]: {txtNewNote.Text}";

                
                txtPreviousNotes.Text += newEntry;

                MessageBox.Show("Noten er gemt!");
                txtNewNote.Clear();
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }
    }
}
