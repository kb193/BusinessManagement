using BusinessManagement.Data;
using BusinessManagement.MVVM.ViewModel;
using BusinessManagement.Services;
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
using Unity;

namespace BusinessManagement.MVVM.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IUserRepository userRepo;
        private readonly MainWindowViewModel mainWindowVm;
        private readonly HomeView homeView;

        public MainWindow(MainWindowViewModel mainWindowVm, HomeView homeView)
        {
            InitializeComponent();
            this.mainWindowVm = mainWindowVm;
            this.homeView = homeView;
            // userRepo = _userRepo;
        }

        public void Login()
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //Login logic

            homeView.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
