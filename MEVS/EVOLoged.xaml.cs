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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.MessageBox;

namespace MEVS
{
    /// <summary>
    /// Interaction logic for EVOLoged.xaml
    /// </summary>
    public partial class EVOLoged : Window
    {

        UReport ureport = new UReport();
        public User loggedU = new User();
        Vehicle v = new Vehicle();
        RegGenUserBll userBll = new RegGenUserBll();
        USubscription usubsc = new USubscription();
        PlanBll PlanBl = new PlanBll();
        Plan p = new Plan();
        USetting uusetting = new USetting();
        MesBClass msg = new MesBClass();

        public EVOLoged()
        {
            InitializeComponent();
        }

        public void Refresh()
        {
            p = userBll.readSubsU(loggedU);

            UsernameLbl.Content = loggedU.Username;
            LOGuser.Content = loggedU.FullName;
            v = userBll.ReadUVeh(loggedU);
            EVBrandLbl.Content = v.Brand;
            EVModelLbl.Content = v.Model;

            if (p == null)
            {
                SubscPan.Visibility = Visibility.Hidden;
                NotSubscPan.Visibility = Visibility.Visible;
            }
            else
            {
                p = userBll.readSubsU(loggedU);
                SubscPan.Visibility = Visibility.Visible;
                NotSubscPan.Visibility = Visibility.Hidden;
                p = PlanBl.ReadPlan(p);
                SPNameLbl.Content = p.ServiceProvider.CompanyName;
                PlanTypeLbl.Content = p.Title;

                DateTime due = loggedU.PurchasedDate.Value.AddDays(p.Duration * 30);
                int rem = (int)(due - DateTime.Now).TotalDays;
                SubscRemain.Content = rem.ToString();
            }
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mainCont.Visibility = Visibility.Hidden;
            MainBody.Children.Clear();
            ureport.RlogU = loggedU;
            MainBody.Children.Add(ureport);
        }

        private void Label_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Refresh();
            MainBody.Children.Clear();
            mainCont.Visibility = Visibility.Visible;
        }
      
        private void Label_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            mainCont.Visibility = Visibility.Hidden;
            MainBody.Children.Clear();
            MainBody.Children.Add(usubsc);
            usubsc.LOG = loggedU;
        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void SetBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mainCont.Visibility = Visibility.Hidden;
            MainBody.Children.Clear();
            MainBody.Children.Add(uusetting);
            uusetting.SetLoggedU = loggedU;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DialogResult dr = msg.MessShow("Alert", "Do you want to log out of the system?", true);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                loggedU = null;
                MainWindow mw = new MainWindow();

                this.Hide();
                mw.Show();
            }
        }
    }
}
