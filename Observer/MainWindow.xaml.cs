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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Observer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Store store { get; set; } = new Store();
        public CustomerwithMail customer { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            store.Customers = new List<ICustomer>();

        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            store.Customers.Add(customer=new CustomerwithMail { email = EmailTxtBox.Text, ProductName = NameTxtBox.Text });
            productListBox.Items.Add($"{customer.ProductName}   -     {customer.email}");
        }

        private void NotifyAll_Click(object sender, RoutedEventArgs e)
        {
            store.Notify();
        }
    }
}
