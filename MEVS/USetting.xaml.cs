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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MEVS
{
    /// <summary>
    /// Interaction logic for USetting.xaml
    /// </summary>
    public partial class USetting : UserControl
    {
        public USetting()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(Button_PreviewKeyDown);
        }

        public User SetLoggedU = new User();
        RegGenUserBll userbll = new RegGenUserBll();
        Vehicle v = new Vehicle();
        Bank b = new Bank();
        Plan p = new Plan();

        void refresh()
        {
            fullnameValue.Text = SetLoggedU.FullName;
            emValue.Text = SetLoggedU.Email;
            PhoneValue.Text = SetLoggedU.Phone;
            UsernValue.Text = SetLoggedU.Username;
            PassValue.Text = SetLoggedU.Password;

            v = userbll.ReadUVeh(SetLoggedU);
            string brand = v.Brand.ToString();
            VehicBrandValue.Text = brand;
            VehicModValue.Text = v.Model;

            b = userbll.ReadUBank(SetLoggedU);
            BankValue.Text = b.Account;
            AddValue.Text = v.Address;
            p = userbll.readSubsU(SetLoggedU);
            SubscPlanValue.Text = p.Title;
        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            refresh();
        }

        string selectedIt;
        MesBClass msg = new MesBClass();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetLoggedU.FullName = fullnameValue.Text;
            SetLoggedU.Email = emValue.Text;
            SetLoggedU.Phone = PhoneValue.Text;
            SetLoggedU.Username = UsernValue.Text;
            SetLoggedU.Password = PassValue.Text;

            v = userbll.ReadUVeh(SetLoggedU);
            v.Brand = selectedIt;
            v.Model = VehicModValue.Text;
            v.Address = AddValue.Text;

            b = userbll.ReadUBank(SetLoggedU);
            b.Account = BankValue.Text;

            msg.MessShow("Update",userbll.UpdateU(SetLoggedU, b, v),false);
            msg.MessShow("MEVS", "Please log out after any update to see the changes", false);
        }

        private void VehicBrandValue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedIt = comboBox.SelectedItem as string;
        }

        private void Button_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click(sender, e);
            }
        }
    }
}
