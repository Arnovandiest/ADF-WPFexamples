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

namespace addTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Label saveEdit;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Label todo = new Label();
            todo.Content = txtBoxTask.Text;



            Button edit = new Button();
            edit.CommandParameter = todo;
            edit.Height = 20;
            edit.Width = 40;
            edit.Content = "_edit";
            edit.Click += Edit_Click;

            Button remove = new Button();
            remove.Height = 20;
            remove.Width = 40;
            remove.Content = "_delete";
            remove.Click += Remove_Click;
            

            StackPanel panel = new StackPanel();
            remove.CommandParameter = panel;
            panel.Orientation = Orientation.Horizontal;
            panel.Children.Add(remove);
            panel.Children.Add(edit);
            panel.Children.Add(todo);
            listTask.Items.Add(panel);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var editButton = ((Button)sender);
            txtBoxTask.Text = ((Label)editButton.CommandParameter).Content.ToString();
            btnSave.Visibility = Visibility.Visible;
            btnAdd.Visibility = Visibility.Hidden;
            saveEdit = ((Label)editButton.CommandParameter);
            
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            
            listTask.Items.Remove(((Button)sender).CommandParameter);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            saveEdit.Content = txtBoxTask.Text;

        }
    }
}
