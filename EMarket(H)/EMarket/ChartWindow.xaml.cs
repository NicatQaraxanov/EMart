using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ChartWindow.xaml
    /// </summary>
    /// 



    public partial class ChartWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        public ChartWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(Products.Count > 0 && ChartListBox.SelectedIndex != -1)
            Products.Remove(Products[ChartListBox.SelectedIndex]);
        }
    }
}
