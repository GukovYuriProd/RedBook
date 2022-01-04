using System;
using RedBook.AdminClient;
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
    public partial class FirstBTNOfMenu : Page
    {
        public FirstBTNOfMenu()
        {
            InitializeComponent();
        }
        public Frame RemoteGetterFrame { get; set; }
        private void AddNewStudent(object sender, RoutedEventArgs e)
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
                        Students newStudent = new Students();
                        newStudent.Name = EnterName.Text;
                        newStudent.Age = age;
                        newStudent.Login = EnterLogin.Text;
                        newStudent.Password = EnterPassword.Text;
                        db.Students.Add(newStudent);
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
