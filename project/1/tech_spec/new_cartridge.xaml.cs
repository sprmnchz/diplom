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

namespace tech_spec
{
    /// <summary>
    /// Логика взаимодействия для new_cartridge.xaml
    /// </summary>
    public partial class new_cartridge : Window
    {
        public new_cartridge()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            client client_form = new client();
            client_form.Show();

        }
    }
}