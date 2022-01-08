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
        }

        public Frame RemoteGetterFrame { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new DBBinContext())
            {
                List<Class> listClass = new List<Class>();
                List<string> listString = new List<string>();
                listClass = db.Classe.ToList();
                foreach (var clas in listClass)
                {
                    listString.Add(clas.Level.ToString() + " " + clas.Letter.ToString());
                }
                ComboBoxClasses.ItemsSource = listString;


            }
        }
    }
}
