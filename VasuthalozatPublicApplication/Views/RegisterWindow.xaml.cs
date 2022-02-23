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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VasuthalozatPublicApplication.Controllers;
using VasuthalozatCommonLibrary.Exceptions;

namespace VasuthalozatPublicApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RegisterController controller = new RegisterController();
                controller.Register(name.Text, email.Text, userName.Text, password1.Text, password2.Text);
            }
            catch (VasuthalozatException exc)
            {
                MessageBox.Show(exc.Message, "Nem sikerült a regisztráció", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void loginPage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
