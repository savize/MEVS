using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace MEVS
{
    /// <summary>
    /// Interaction logic for USubscription.xaml
    /// </summary>
    public partial class USubscription : System.Windows.Controls.UserControl
    {
        public USubscription()
        {
            InitializeComponent();
        }

        public User LOG = new User();
        RegGenUserBll userBll = new RegGenUserBll();
        PlanBll planBll = new PlanBll();
        Plan p = new Plan();
        int id;
        MesBClass msg = new MesBClass();

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            plansDG.ItemsSource = null;
            plansDG.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = planBll.ReadPlans() });
            plansDG.Columns[0].Visibility = Visibility.Hidden;
            plansDG.Columns[7].Visibility = Visibility.Hidden;               
        }

        
        private void plansDG_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row_selected = dg.SelectedItem as DataRowView;

            if (row_selected != null)
            {
                id = Convert.ToInt32(row_selected["Item Id"]);
            }

            p = userBll.ReadPlan(id);
            msg.MessShow("Subscription Status",userBll.UpPlan(LOG, p), false);
            msg.MessShow("MEVS", "Please log out after any update to see the changes", false);
        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            p = userBll.readSubsU(LOG);

            if (p == null)
            {
                NotSubsc.Visibility = Visibility.Visible;
                Subsc.Visibility = Visibility.Hidden;
                plansDG.Height = 330;

                Thickness margin = plansDG.Margin;
                margin.Top = -70;
                plansDG.Margin = margin;
            }
            else
            {
                NotSubsc.Visibility = Visibility.Hidden;
                Subsc.Visibility = Visibility.Visible;
                p = planBll.ReadPlan(p);

                CompName.Content = p.ServiceProvider.CompanyName;
                PTitle.Content = p.Title;
                Lenght.Content = p.Duration;
                descr.Content = p.Description;
                PurchD.Content = LOG.PurchasedDate.Value.Date;

                DateTime due = LOG.PurchasedDate.Value.Date.AddDays(p.Duration * 30);              
                int rem = (int)(due - DateTime.Now).TotalDays;
                RemDays.Content = rem.ToString();
            }
        }
    }
}
