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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EMarket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>



    public partial class MainWindow : Window
    {

        public ObservableCollection<Product> Products { get; set; }

        public ObservableCollection<Product> Chart { get; set; } = new ObservableCollection<Product>();

        public MainWindow()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>()
            {
                new Product() {ProductName = "Samsung Galaxy Watch 3", ProductPic = "pics/1.jpg", Info = "Great Watch for Samsung Devices", Price = "980$" },
                new Product() {ProductName = "Apple Watch Series 5", ProductPic = "Apple.png", Info = "Great Watch for Apple Devices", Price = "1400$" },
                new Product() {ProductName = "Xiaomi Mi Watch Lite", ProductPic = "Xiaomi.png", Info = "Great Watch for Xiaomi Devices", Price = "150$" }
            };
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Add = new AddProductWindow();
            Add.AddButton.IsEnabled = true;
            var result = Add.ShowDialog();
            if (result == true)
            {
                Products.Add(new Product() { ProductName = Add.ProductName.Text, ProductPic = Add.PicturePath.Text, Info = Add.Info.Text, Price = Add.Price.Text + "$" });
            }
        }

        private void ProductListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var Add = new AddProductWindow();
            Add.AddButton.IsEnabled = false;
            Add.Productt = (sender as ListBox).SelectedItem as Product;
            Add.ShowDialog();
        }

        private void AddToChartButton_click(object sender, RoutedEventArgs e)
        {
            Chart.Add(ProductListBox.SelectedItem as Product);
        }

        private void ObserveChartButton_Click(object sender, RoutedEventArgs e)
        {
            var ChartDialog = new ChartWindow();
            ChartDialog.Products = Chart;
            ChartDialog.ShowDialog();
            Chart = ChartDialog.Products;
        }
    }
}
