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

        public void FormateNewClass (object sender, RoutedEventArgs e)
        {
            FormateNewCLass formateNewClass = new FormateNewCLass();
            formateNewClass.RemoteGetterFrame = AdminWorkArea;
            AdminWorkArea.Navigate(formateNewClass);
        }

        //5 функций для первой линии кнопок. Добавление в бд самих юнитов
        private void ClickFirst(object sender, RoutedEventArgs e) //добавление Ученика в БД (лист)
        {
            FirstBTNOfMenu firstBTNOfMenu = new FirstBTNOfMenu();
            firstBTNOfMenu.RemoteGetterFrame = AdminWorkArea;
            AdminWorkArea.Navigate(firstBTNOfMenu);
        }
        private void ClickSecond(object sender, RoutedEventArgs e) //добавление Учителя в БД (лист)
        {
            SecondBTNOfMenu secondBTNOfMenu = new SecondBTNOfMenu();
            secondBTNOfMenu.RemoteGetterFrame = AdminWorkArea;
            AdminWorkArea.Navigate(secondBTNOfMenu);
        }
        private void ClickThird(object sender, RoutedEventArgs e) //добавление Класса в БД (лист)
        {
            ThirdBTNOfMenu thirdBTNOfMenu = new ThirdBTNOfMenu();
            thirdBTNOfMenu.RemoteGetterFrame = AdminWorkArea;
            AdminWorkArea.Navigate(thirdBTNOfMenu);
        }
        private void ClickFour(object sender, RoutedEventArgs e) //добавление Дисциплины в БД (лист)
        {
            FourBTNOfMenu fourBTNOfMenu = new FourBTNOfMenu();
            fourBTNOfMenu.RemoteGetterFrame = AdminWorkArea;
            AdminWorkArea.Navigate(fourBTNOfMenu);
        }
        private void ClickFive(object sender, RoutedEventArgs e) //добавление Типа работы в БД (лист)
        {
            FiveBTNOfMenu fiveBTNOfMenu = new FiveBTNOfMenu();
            fiveBTNOfMenu.RemoteGetterFrame = AdminWorkArea;
            AdminWorkArea.Navigate(fiveBTNOfMenu);
        }
    }
}