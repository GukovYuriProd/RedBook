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

namespace RedBook
{
    /// <summary>
    /// Логика взаимодействия для StudentClient.xaml
    /// </summary>
    public partial class StudentClient : Window
    {
        public StudentClient()
        {
            InitializeComponent();
        }
        public string LocalLogin { get; set; }
        public string LocalPassword { get; set; }


    }
}
