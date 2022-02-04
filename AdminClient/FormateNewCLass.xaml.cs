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
        List<string> TeachersFromDB = new List<string>();
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
                List<Teachers> teachers = db.Teachers.ToList();
                foreach (var teacher in teachers)
                {
                    TeachersFromDB.Add(teacher.Name.ToString());
                }
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
                        Search.Text = "Введите название дисциплины";
                        break;
                }
        }
        private void Search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Search.Text == "Введите имя ученика" ||
                Search.Text == "Введите название дисциплины")
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
                            var selectedDisciplines = db.Discipline.Where(x => x.Name.Contains(Search.Text));
                            foreach (var discipline in selectedDisciplines)
                            {
                                AddInfoToSearch(discipline.Name);
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
            Obolochka.Height = 28;
            Obolochka.CornerRadius = new CornerRadius(6);
            Obolochka.Child = BackButton;

            SearchResults.Children.Add(Obolochka);
        }

        private void AddStudentToStudentStackPanel(string TextFromLabel)
        {
            TextBlock textinborder = new TextBlock();
            textinborder.Text = TextFromLabel;
            textinborder.HorizontalAlignment = HorizontalAlignment.Left;
            textinborder.FontSize = 17;
            textinborder.Background = Brushes.Transparent;

            Border Obolochka = new Border();
            Obolochka.BorderThickness = new Thickness(2);
            Obolochka.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 159, 220));
            Obolochka.Width = 300;
            Obolochka.Height = 28;
            Obolochka.CornerRadius = new CornerRadius(6);
            Obolochka.Child = textinborder;
            Obolochka.HorizontalAlignment = HorizontalAlignment.Left;
            StudentsInCLass.Children.Add(Obolochka);
        }

        private void AddDisciplineToDisciplineStackPanel(string TextFromLabel)
        {
            TextBlock textinborder = new TextBlock();
            textinborder.Text = TextFromLabel;
            textinborder.HorizontalAlignment = HorizontalAlignment.Left;
            textinborder.FontSize = 17;
            textinborder.Background = Brushes.Transparent;
            textinborder.HorizontalAlignment = HorizontalAlignment.Center;

            ComboBox ChooseTeacher = new ComboBox();
            ChooseTeacher.ItemsSource = TeachersFromDB;
            ChooseTeacher.Height = 28;
            ChooseTeacher.Width = 330;
            ChooseTeacher.FontSize = 17;
            ChooseTeacher.HorizontalAlignment = HorizontalAlignment.Center;
            ChooseTeacher.HorizontalContentAlignment = HorizontalAlignment.Center;

            StackPanel Karkas = new StackPanel();
            Karkas.Orientation = Orientation.Vertical;
            Karkas.Children.Add(textinborder);
            Karkas.Children.Add(ChooseTeacher);

            Border Obolochka = new Border();
            Obolochka.BorderThickness = new Thickness(2);
            Obolochka.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 159, 220));
            Obolochka.Width = 360;
            Obolochka.Height = 58;
            Obolochka.CornerRadius = new CornerRadius(6);
            Obolochka.Child = Karkas;
            Obolochka.HorizontalAlignment = HorizontalAlignment.Left;
            DisciplinesInCLass.Children.Add(Obolochka);
        }
        List<string> Students = new List<string>();
        List<string> Disciplines = new List<string>();
        private void ClickOnLabel(object sender, RoutedEventArgs e)
        {
            string newone = (sender as Button).Content.ToString();
            if (SearchStatus == 1)
            {
                int checker = 0;
                foreach (var smth in Students)
                {
                    if (smth == newone) checker++;
                }
                if (checker == 0)
                {
                    Students.Add(newone);
                    AddStudentToStudentStackPanel(newone);
                }
                else MessageBox.Show("Такой ученик уже добавлен");
            }
            else if (SearchStatus == 2)
            {
                int checker = 0;
                foreach (var smth in Disciplines)
                {
                    if (smth == newone) checker++;
                }
                if (checker == 0)
                {
                    Disciplines.Add(newone);
                    AddDisciplineToDisciplineStackPanel(newone);
                }
                else MessageBox.Show("Такая дисциплина уже добавлена");
            }
        }
        //End

        //Selector for different kinds of searches
        private void StudentSearchSelected(object sender, RoutedEventArgs e)
        {
            SearchStatus = 1;
            if (Search.Text == "Введите название дисциплины")
            {
                Search.Text = "Введите имя ученика";
            }
            else Search.Text = Search.Text + " ";
            Search.Text = Search.Text.Trim();
            SwitchToStudentSearch.BorderThickness = new Thickness(2);
            SwitchToDisciplineSearch.BorderThickness = new Thickness(0);
        }
        private void DisciplineSearchSelected(object sender, RoutedEventArgs e)
        {
            SearchStatus = 2;
            if (Search.Text == "Введите имя ученика")
            {
                Search.Text = "Введите название дисциплины";
            }
            else Search.Text = Search.Text + " ";
            Search.Text = Search.Text.Trim();
            SwitchToStudentSearch.BorderThickness = new Thickness(0);
            SwitchToDisciplineSearch.BorderThickness = new Thickness(2);
        }

        private void ConfigurateClass_Click(object sender, RoutedEventArgs e)
        {

        }
        //End
    }
}