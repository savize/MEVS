using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KeyEventHandler = System.Windows.Input.KeyEventHandler;

namespace MEVS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(BackBtn_PreviewKeyDown);
            this.PreviewKeyDown += new KeyEventHandler(Button_PreviewKeyDown);
        }

        public RegisUser Ureg = new RegisUser();
        public User u = new User();
        RegGenUserBll UserBll = new RegGenUserBll();
        EVOLoged EVOLog = new EVOLoged();
        MesBClass msg = new MesBClass();

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainBody.Visibility = Visibility.Hidden;
            ContBody.Children.Clear();
            ContBody.Children.Add(Ureg);          
            BackBtn.Visibility = Visibility.Visible;
        }

        public void BackBtnAut()
        {
            MainBody.Visibility = Visibility.Visible;
            ContBody.Children.Clear();
            BackBtn.Visibility = Visibility.Hidden;
        }
        public void BackBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            BackBtnAut();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            u = UserBll.Login(UnameValue.Text, PassValue.Password.ToString());
            
            if (u != null)
            {
                err.Visibility = Visibility.Hidden;
                if (u.UserCategory == "EVOwner")
                {
                    EVOLog.loggedU = u;
                    this.Hide();
                    EVOLog.ShowDialog();

                }
                else if(u.UserCategory == "ChargingStation")
                {

                }
                else if(u.UserCategory == "ServiceProvider")
                {

                }              
            }
            else if ((UnameValue.Text == "Admin" || UnameValue.Text == "admin") && PassValue.Password.ToString() == "1234")
            {
                AdminLogged AdminF = new AdminLogged();
                this.Hide();
                AdminF.ShowDialog();
            }
            else
            {
                err.Visibility = Visibility.Visible;
            }
        }

        private void BackBtn_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                BackBtnAut();
            }
        }

        private void Button_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click(sender, e);
            }
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DialogResult dr = msg.MessShow("Alert", "Do you want to shut down the system?", true);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }
    }
}
