﻿using System;
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

namespace RedBook.AdminClient
{
    public partial class MainWIndow : Window
    {
        public MainWIndow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstBTNOfMenu firstBTNOfMenu = new FirstBTNOfMenu();
            firstBTNOfMenu.RemoteGetterFrame = AdminWorkArea;
            AdminWorkArea.Navigate(firstBTNOfMenu);
        }
    }
}
