using System;
using System.Windows;
using System.Windows.Controls;

namespace MyCalculatorv1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        float cache = 0;
        string op = "";
        bool opcheck = false;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Button b = (Button)sender;
            if (opcheck)
            {
                opcheck = false;
                tb.Text = "";
            }
            tb.Text += b.Content.ToString();

        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
         
            
            if(op == "+")
            {
                cache = cache + float.Parse(tb.Text); 
            }else if(op == "-")
            {
                cache = cache - float.Parse(tb.Text);
            }else if(op == "/")
            {
                cache = cache / float.Parse(tb.Text);
            }else if(op == "*")
            {
                cache = cache * float.Parse(tb.Text);
            }else if(op == "")
            {
                cache = float.Parse(tb.Text);
                tb.Text = "";
            }
            if (op != "")
            {
                tb.Text = cache.ToString();
            }
            Button b = (Button)sender;
            this.op = b.Content.ToString();
            opcheck = true;
                       

        }

    }
    
}
