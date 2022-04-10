using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {



            InitializeComponent();
            
            //Создаём цикл для обработки кнопок
            foreach (UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        //Класс для Button_Click
        private void Button_Click(object sender, RoutedEventArgs e)
        
        {
            string str = (string)((Button)e.OriginalSource).Content;
            
            //Условие для вычисления
            if (str == "AC")
                textLable.Text = "";
            else if (str == "=")
            {
                string value = new DataTable().Compute(textLable.Text, null).ToString();
                textLable.Text = value;
            }
            else
                textLable.Text += str;

           
        }
    }
}
