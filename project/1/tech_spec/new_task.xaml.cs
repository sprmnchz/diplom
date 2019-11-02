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

namespace tech_spec
{
    /// <summary>
    /// Логика взаимодействия для new_task.xaml
    /// </summary>
    public partial class new_task : Window
    {
        public new_task()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            client client_form = new client();
            client_form.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new_data new_data_form = new new_data();
            new_data_form.Show();
        }
    }
}
