using System;
using RedBook.Model;
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

namespace RedBook.AdminClient
{
    public partial class ThirdBTNOfMenu : Page
    {
        public ThirdBTNOfMenu()
        {
            InitializeComponent();
        }

        public Frame RemoteGetterFrame { get; set; }
        private void AddNewClass(object sender, RoutedEventArgs e)
        {
            using (var db = new DBBinContext())
            {
                if (EnterLevel.Text != null &&
                    EnterLitera.Text != null)
                {
                    try
                    {
                        int level = Convert.ToInt32(EnterLevel.Text);
                        String stroka = EnterLitera.Text;
                        Class newClass = new Class();
                        newClass.Level = level;
                        newClass.Letter = stroka[0];
                        db.Classe.Add(newClass);
                        db.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка");
                    }
                }
                else MessageBox.Show("Для добавления заполните все поля", "Внимание!");
            }
            EraserEnters();
        }

        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            EraserEnters();
            defaultEmpty defaultEmpty = new defaultEmpty();
            RemoteGetterFrame.Navigate(defaultEmpty);
        }

        public void EraserEnters()
        {
            EnterLevel.Text = "";
            EnterLitera.Text = "";
        }
    }
}
