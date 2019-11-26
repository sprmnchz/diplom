using System.Windows;

namespace tech_spec
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            task task_Form = new task();
            task_Form.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cartridge cartridge_form = new cartridge();
            cartridge_form.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new_data new_data_form = new new_data();
            new_data_form.Show();
        }

       
    }
}
