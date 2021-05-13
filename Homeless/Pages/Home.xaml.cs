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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homeless.Pages
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        #region pages_click
        private void Client_Click(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Client());
        private void Material_Click(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Material());
        private void Order_Click(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Order());
        private void Product_Click(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Product());
        private void LostSoul_Click(object sender, RoutedEventArgs e) => NavigationService.Navigate(new LostSoul());
        private void Settings_Click(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Settings());
        #endregion
    }
}
