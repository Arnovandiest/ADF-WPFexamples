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
        private readonly Dictionary<String,int> _articles;
        int[] _price;
        public MainWindow()
        {
            InitializeComponent();

            _articles = new Dictionary<string, int>();
            _articles.Add("Coca Cola", 2);

            foreach(var article in _articles)
            {
                lstArticles.Items.Add(article.Key);
            }

            
        }
      

        

        private void lstArticles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var name = lstArticles.SelectedItem.ToString();
            var price = _articles[name];
            txtOrder.Text = name + ": " + price + " €";
        }
       

      

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            lstHistory.Items.Add(txtOrder.Text);
            
            txtOrder.Clear();
            
        }
    }
}
