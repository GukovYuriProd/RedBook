using RedBook.Model;
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

namespace RedBook
{
    public partial class Authorisation : Window
    {
        public Authorisation()
        {
            InitializeComponent();
        }

        private void LoginOnAuthPage(object sender, RoutedEventArgs e) //вход в приложение в выбранном режиме
        {
            if (ClassOfUser.Content.ToString() == "Ученик") //для входа ученика
            {
                //cheker
                StudentClient studentclientlogin = new StudentClient();
                studentclientlogin.Show();

            } else //для входа учителя
            {
                //checker
                TeacherClient teacherclientlogin = new TeacherClient();
                teacherclientlogin.Show();

            }
        }

        private void SwitchFromTeacherToStudent(object sender, RoutedEventArgs e) //переключатель в положение "ученик"
        {
            RightPin.Opacity = 1;
            LeftPin.Opacity = 0;
            ClassOfUser.Content = "Ученик";
        }

        private void SwitchFromStudentToTeacher(object sender, RoutedEventArgs e) //переключатель в положение "учитель"
        {
            LeftPin.Opacity = 1;
            RightPin.Opacity = 0;
            ClassOfUser.Content = "Учитель";
        }

        //вторичные функции для обнуления изменяемых полей
        private void LoginPageEnterLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (LoginPageEnterLogin.Text == "Введите логин")
            {
                LoginPageEnterLogin.Text = "";
                LoginPageEnterLogin.Opacity = 1;
            }
        }

        private void LoginPageEnterLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (LoginPageEnterLogin.Text == "")
            {
                LoginPageEnterLogin.Text = "Введите логин";
                LoginPageEnterLogin.Opacity = 0.6;
            }
        }

        private void LoginPageEnterPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (LoginPageEnterPassword.Password == "12345678901")
            {
                LoginPageEnterPassword.Password = "";
                LoginPageEnterPassword.Opacity = 1;
            }
        }

        private void LoginPageEnterPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (LoginPageEnterPassword.Password == "")
            {
                LoginPageEnterPassword.Password = "12345678901";
                LoginPageEnterPassword.Opacity = 0.6;
            }
        }
        //конец вторичных функций

    }
}
