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
    public partial class FiveBTNOfMenu : Page
    {
        public FiveBTNOfMenu()
        {
            InitializeComponent();
        }
        public Frame RemoteGetterFrame { get; set; }

        public void AddNewClass(object sender, RoutedEventArgs e)
        {
            using (var db = new DBBinContext())
            {
                if (EnterNameOfWork.Text != "")
                {
                    try
                    {
                        WorkType newWorkType = new WorkType();
                        newWorkType.ClassOfWork = EnterNameOfWork.Text;
                        db.WorkType.Add(newWorkType);
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
            EnterNameOfWork.Text = "";
        }

    }
}
