using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for CSRegF.xaml
    /// </summary>
    public partial class CSRegF : Window
    {
        public CSRegF()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(Image_PreviewKeyDown);

        }

        public User regU = new User();
        RegGenUserBll register = new RegGenUserBll();
        MesBClass msg = new MesBClass();
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
        }

        List<ChargingStation> CSs = new List<ChargingStation>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Input.SPCheck(statId.Text, Address.Text, CPName.Text, CPAmount.Text))
            {
                msg.MessShow("Alert", "Please input all the required fields", false);
            }
            else
            {
                ChargingStation cs = new ChargingStation();

                cs.StationID = statId.Text;

                ComboBoxItem typeItem = (ComboBoxItem)stateValue.SelectedItem;
                cs.State = typeItem.Content.ToString();

                cs.StationAddress = Address.Text;
                cs.EstabDate = EstaDate.SelectedDate.Value.Date;
                cs.User = regU;

                foreach (var item in CPs)
                {
                    cs.ChargingPoints.Add(item);
                }

                CSs.Add(cs);
                regU.CSs = CSs;

                msg.MessShow("Registration", register.Create(regU), false);
                this.Hide();
            }  
        }

        List<ChargingPoint> CPs = new List<ChargingPoint>();
        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (!Input.ChargerCheck(CPName.Text, CPAmount.Text))
            {
                msg.MessShow("Charger Data", "Please input all the reguired fields to add the charger", false);
            }
            else
            {
                ChargingPoint cp = new ChargingPoint();

                ComboBoxItem ChType = (ComboBoxItem)CPTypeValue.SelectedItem;
                cp.ChargerCategory = ChType.Content.ToString();
                cp.ChName = CPName.Text;
                cp.Amount = Convert.ToInt32(CPAmount.Text);

                CPs.Add(cp);

                CPDetListB.ItemsSource = null;
                CPDetListB.ItemsSource = CPs.ToList();
                CPDetListB.DisplayMemberPath = "ListBox";

                CPName.Text = "";
                CPAmount.Text = "";
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!Input.SPCheck(statId.Text, Address.Text, CPName.Text, CPAmount.Text))
            {
                msg.MessShow("Adding Charging Station", "Please input all the required fields in order to add another Charging Station", false);
            }
            else
            {
                ChargingStation cs = new ChargingStation();

                cs.StationID = statId.Text;

                ComboBoxItem typeItem = (ComboBoxItem)stateValue.SelectedItem;
                cs.State = typeItem.Content.ToString();

                cs.StationAddress = Address.Text;
                cs.EstabDate = EstaDate.SelectedDate.Value.Date;
                cs.User = regU;

                foreach (var item in CPs)
                {
                    cs.ChargingPoints.Add(item);
                }

                CSs.Add(cs);

                statId.Text = "";
                stateValue.SelectedIndex = 13;
                Address.Text = "";
                CPDetListB.ItemsSource = null;
                CPs.Clear();
            }        
        }

        private void Image_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }


        private void CPAmount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Input.IsTextAllowed(e.Text);
        }
    }
}
