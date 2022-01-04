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
    public partial class SecondBTNOfMenu : Page
    {
        public SecondBTNOfMenu()
        {
            InitializeComponent();
        }

        public Frame RemoteGetterFrame { get; set; }
        private void AddNewTeacher(object sender, RoutedEventArgs e)
        {
            using (var db = new DBBinContext())
            {
                if (EnterName.Text != "" &&
                    EnterLogin.Text != "" &&
                     EnterPassword.Text != "" &&
                     EnterAge.Text != "")
                {
                    try
                    {
                        int age = Convert.ToInt32(EnterAge.Text);
                        Teachers newTeacher = new Teachers();
                        newTeacher.Name = EnterName.Text;
                        newTeacher.Age = age;
                        newTeacher.Login = EnterLogin.Text;
                        newTeacher.Password = EnterPassword.Text;
                        db.Teachers.Add(newTeacher);
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
            EnterName.Text = "";
            EnterAge.Text = "";
            EnterLogin.Text = "";
            EnterPassword.Text = "";
        }
    }
}