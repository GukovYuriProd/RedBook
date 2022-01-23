using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RedBook.Model;
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
    public partial class FormateNewCLass : Page
    {
        public FormateNewCLass()
        {
            InitializeComponent();
            using (var db = new DBBinContext())
            {
                List<Class> classes = db.Classe.ToList();
                List<string> levels = new List<string>();
                foreach (var classi in classes)
                {
                    levels.Add(classi.Level.ToString());
                }
                ClassCheck.ItemsSource = levels;
            }
        }

        public Frame RemoteGetterFrame { get; set; }

        //Editing the Text label on the top
        private void ClassCheck_DropDownClosed(object sender, EventArgs e)
        {
            if (ClassCheck.SelectedItem != null)
            {
                LabelTOP.Content = "Формирование " + ClassCheck.SelectedItem.ToString() + " класса";
            }
        }
        //End

        //Scripts for Search line
        private int SearchStatus = 1;
        private void Search_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Search.Text == "")
                switch (SearchStatus)
                {
                    case 1:
                        Search.Opacity = 0.7;
                        Search.Text = "Введите имя ученика";
                        break;
                    case 2:
                        Search.Opacity = 0.7;
                        Search.Text = "Введите имя преподавателя";
                        break;
                    case 3:
                        Search.Opacity = 0.7;
                        Search.Text = "Введите дисциплину";
                        break;
                }
        }
        private void Search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Search.Text == "Введите имя ученика" ||
                Search.Text == "Введите имя преподавателя" ||
                Search.Text == "Введите дисциплину")
            {
                Search.Opacity = 1;
                Search.Text = "";
            }
        }

        private int? CharCounter;
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            CharCounter = Search.Text.Length;
            if (CharCounter > 3)
            {
                //Here will be a "case" for "switch search option"
                if (SearchResults != null)
                    SearchResults.Children.Clear();
                using (var db = new DBBinContext())
                {
                    switch (SearchStatus)
                    {
                        case 1:
                            var selectedStudents = db.Students.Where(x => x.Name.Contains(Search.Text));
                            foreach (var user in selectedStudents)
                            {
                                AddInfoToSearch(user.Name);
                            }
                            break;
                        case 2:
                            var selectedTeachers = db.Teachers.Where(x => x.Name.Contains(Search.Text));
                            foreach (var user in selectedTeachers)
                            {
                                AddInfoToSearch(user.Name);
                            }
                            break;
                    }
                }
            }
        }

        private void AddInfoToSearch(string SearchingText)
        {
            Button BackButton = new Button();
            BackButton.Width = 304;
            BackButton.Height = 30;
            BackButton.Background = Brushes.Transparent;
            BackButton.BorderThickness = new Thickness(0);
            BackButton.Click += ClickOnLabel;
            BackButton.FontSize = 17;
            BackButton.Content = " " + SearchingText;
            BackButton.VerticalAlignment = VerticalAlignment.Center;
            BackButton.HorizontalContentAlignment = HorizontalAlignment.Left;
            
            Border Obolochka = new Border();
            Obolochka.BorderThickness = new Thickness(2);
            Obolochka.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 159, 220));
            Obolochka.Width = 300;
            Obolochka.Height = 30;
            Obolochka.CornerRadius = new CornerRadius(6);
            Obolochka.Child = BackButton;

            var output = Obolochka;
            SearchResults.Children.Add(output);
        }

        private void AddInfoToListOfStudentsToConfig(string TextFromLabel)
        {
            TextBlock student = new TextBlock();
            student.Text = " " + TextFromLabel;
            student.HorizontalAlignment = HorizontalAlignment.Left;
            student.FontSize = 17;
            student.Background = Brushes.Transparent;

            Border Obolochka = new Border();
            Obolochka.Background = new SolidColorBrush(Color.FromRgb(112, 159, 220));
            Obolochka.Width = 300;
            Obolochka.Height = 30;
            Obolochka.CornerRadius = new CornerRadius(6);
            Obolochka.Child = student;

            StudentsInCLass.Children.Add(Obolochka);
        }

        private void ClickOnLabel(object sender, RoutedEventArgs e)
        {
            AddInfoToListOfStudentsToConfig((sender as Button).Content.ToString());
        }
        //End

        //Selector for different kinds of searches
        private void StudentSearchSelected(object sender, RoutedEventArgs e)
        {
            SearchStatus = 1;
            if (Search.Text == "Введите имя преподавателя")
            {
                Search.Text = "Введите имя ученика";
            }
            else Search.Text = Search.Text + " ";
            Search.Text = Search.Text.Trim();
            SwitchToStudentSearch.BorderThickness = new Thickness(2);
            SwitchToTeacherSearch.BorderThickness = new Thickness(0);
        }
        private void TeacherSearchSelected(object sender, RoutedEventArgs e)
        {
            SearchStatus = 2;
            if (Search.Text == "Введите имя ученика")
            {
                Search.Text = "Введите имя преподавателя";
            }
            else Search.Text = Search.Text + " ";
            Search.Text = Search.Text.Trim();
            SwitchToStudentSearch.BorderThickness = new Thickness(0);
            SwitchToTeacherSearch.BorderThickness = new Thickness(2);
        }

    }
}