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

namespace RedBook.AdminClient
{
    public partial class MainWIndow : Window
    {
        public MainWIndow()
        {
            InitializeComponent();
        }

        private void ClickFirst(object sender, RoutedEventArgs e) //добавление Ученика в БД
        {
            FirstBTNOfMenu firstBTNOfMenu = new FirstBTNOfMenu();
            firstBTNOfMenu.RemoteGetterFrame = AdminWorkArea;
            AdminWorkArea.Navigate(firstBTNOfMenu);
        }
        private void ClickSecond(object sender, RoutedEventArgs e) //добавление Учителя в БД
        {
            SecondBTNOfMenu secondBTNOfMenu = new SecondBTNOfMenu();
            secondBTNOfMenu.RemoteGetterFrame = AdminWorkArea;
            AdminWorkArea.Navigate(secondBTNOfMenu);
        }
        private void ClickThird(object sender, RoutedEventArgs e) //добавление Класса в БД
        {
            ThirdBTNOfMenu thirdBTNOfMenu = new ThirdBTNOfMenu();
            thirdBTNOfMenu.RemoteGetterFrame = AdminWorkArea;
            AdminWorkArea.Navigate(thirdBTNOfMenu);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ведуться технические работы");
        }
    }
}