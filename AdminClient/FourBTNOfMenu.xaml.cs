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
    public partial class FourBTNOfMenu : Page
    {
        public FourBTNOfMenu()
        {
            InitializeComponent();
        }

        public Frame RemoteGetterFrame { get; set; }
        private void AddNewClass(object sender, RoutedEventArgs e)
        {
            using (var db = new DBBinContext())
            {
                if (EnterNameOfDisc.Text != "" && EnterHours.Text != "")
                {
                    try
                    {
                        int Hours = Convert.ToInt32(EnterHours.Text);
                        Discipline newDisc = new Discipline();
                        newDisc.Name = EnterNameOfDisc.Text;
                        newDisc.Hours = Hours;
                        db.Discipline.Add(newDisc);
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
            EnterNameOfDisc.Text = "";
            EnterHours.Text = "";
        }
    }
}
