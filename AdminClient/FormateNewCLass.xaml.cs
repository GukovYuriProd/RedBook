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

        private void ClassCheck_DropDownClosed(object sender, EventArgs e)
        {
            if (ClassCheck.SelectedItem != null)
            {
                LabelTOP.Content = "Формирование " + ClassCheck.SelectedItem.ToString() + " класса";
            }

        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            AddStudentToSearch(Search.Text);
        }
        public string Something = null;
        public List<Button> Students = new List<Button>();
        public void AddStudentToSearch(string StudentName)
        {
            Button BackButton = new Button();
            BackButton.Width = 184;
            BackButton.Height = 34;
            BackButton.Background = Brushes.Transparent;
            BackButton.Opacity = 1;
            BackButton.BorderThickness = new Thickness(0);
            BackButton.Click += ClickOnStudent;
            BackButton.FontSize = 17;
            BackButton.Content = StudentName;
            Students.Add(BackButton);

            Border Obolochka = new Border();
            Obolochka.BorderThickness = new Thickness(4);
            Obolochka.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 159, 220));
            Obolochka.Width = 180;
            Obolochka.Height = 30;
            Obolochka.CornerRadius = new CornerRadius(11);
            Obolochka.Child = BackButton;

            var ouput = Obolochka;
            SearchResults.Children.Add(ouput);
        }
        public void ClickOnStudent (object sender, RoutedEventArgs e)
        {
            MessageBox.Show((sender as Button).Content.ToString());
        }
    }
}
