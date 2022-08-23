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

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

            AddItem("Coca ", 1);
            AddItem("Fanta ", 3);
            AddItem("Sprite ", 2);

        }
      

        

        private void lstArticles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var name = ((ListBoxItem)lstArticles.SelectedItem).Content;
            var price = ((ListBoxItem)lstArticles.SelectedItem).Tag;
            txtOrder.Text = name + ": " + price + " €";
           
        }
       
        private void AddItem(String name, int price)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = name;
            item.Tag = price;
            lstArticles.Items.Add(item);
        }
      

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            lstHistory.Items.Add(txtOrder.Text);
            
            txtOrder.Clear();
            
        }
    }
}
