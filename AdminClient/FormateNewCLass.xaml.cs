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
            LabelTOP.Content = "Формирование " + ClassCheck.SelectedItem.ToString() + " класса";
        }
    }
}
