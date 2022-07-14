using Ookii.Dialogs.Wpf;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EMarket
{
    /// <summary>
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    /// 

    [AddINotifyPropertyChangedInterface]

    public partial class AddProductWindow : Window
    {
        public Product Productt { get; set; }

        public AddProductWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void PicturePath_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            VistaOpenFileDialog dialog = new VistaOpenFileDialog
            {
                Filter = "|*.png"
            };

            var result = dialog.ShowDialog();

            if (result == true)
            {
                PicturePath.Text = dialog.FileName;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProductName.Text) && !string.IsNullOrWhiteSpace(PicturePath.Text) && !string.IsNullOrWhiteSpace(Price.Text) && !string.IsNullOrWhiteSpace(Info.Text))
            {
                this.DialogResult = true;
                this.Close();
            }
        }

    }
}
