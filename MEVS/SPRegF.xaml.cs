using BE;
using BLL;
using Microsoft.Win32;
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

namespace MEVS
{
    /// <summary>
    /// Interaction logic for SPRegF.xaml
    /// </summary>
    public partial class SPRegF : Window
    {
        public SPRegF()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(Image_PreviewKeyDown);
        }

        public User RegU = new User();
        List<Plan> Plans = new List<Plan>();
        RegGenUserBll register = new RegGenUserBll();
        SPBll spreg = new SPBll();
        MesBClass msg = new MesBClass();
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
        }

          private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Input.SPRegCk(CompNameValue.Text, PlanTiValue.Text, DurValue.Text, PriceVAlue.Text))
            {
                msg.MessShow("Alert", "Please input all the required fields", false);
            }
            else
            {
                ServiceProvider SP = new ServiceProvider();

                SP.CompanyName = CompNameValue.Text;
                SP.EstablishDate = Estadate.SelectedDate.Value;

                foreach (Plan p in Plans)
                {
                    SP.plans.Add(p);
                }

                msg.MessShow("Registration", register.Create(RegU), false);
                spreg.Create(SP, RegU);

                this.Hide();
            }           
        }


        private void AddBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Input.PlanCk(PlanTiValue.Text, DurValue.Text, PriceVAlue.Text)) 
            {
                msg.MessShow("Plan Data", "Please input all the reguired fields to add the plan", false);
            }
            else
            {
                Plan p = new Plan();

                p.Title = PlanTiValue.Text;
                p.Duration = Convert.ToInt32(DurValue.Text);
                p.Price = Convert.ToInt32(PriceVAlue.Text);
                string ins = new TextRange(descValue.Document.ContentStart, descValue.Document.ContentEnd).Text;
                p.Description = ins;

                Plans.Add(p);

                PlanListB.ItemsSource = null;
                PlanListB.ItemsSource = Plans;
                PlanListB.DisplayMemberPath = "ShowList";

                PlanTiValue.Text = "";
                DurValue.Text = "";
                PriceVAlue.Text = "";
                descValue.Document.Blocks.Clear();
            }         
        }

        private void Image_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key  == Key.Escape)
            {
                Close();
            }
        }

        private void DurValue_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Input.IsTextAllowed(e.Text);
        }

        private void PriceVAlue_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Input.IsTextAllowed(e.Text);
        }
    }
}
