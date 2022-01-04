using RedBook.AdminClient;
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
using System.Windows.Shapes;

namespace RedBook.AuthWindow
{
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void OpenAdminsPanel(object sender, RoutedEventArgs e)
        {
            //cheker
            if (LoginPageEnterLogin.Text == "gukov" && LoginPageEnterPassword.Password == "moderator")
            {
                AdminClient.MainWIndow hueta = new MainWIndow();
                hueta.Show();
                this.Close();
            }

        }

        private void LoginOnAuthPage(object sender, RoutedEventArgs e) //вход в приложение в выбранном режиме
        {
            if (ClassOfUser.Content.ToString() == "Ученик") //для входа ученика
            {
                //cheker


            }
            else //для входа учителя
            {
                //checker


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
