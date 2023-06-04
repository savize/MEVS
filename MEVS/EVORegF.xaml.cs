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
using System.Windows.Shapes;

namespace MEVS
{
    /// <summary>
    /// Interaction logic for EVORegF.xaml
    /// </summary>
    public partial class EVORegF : Window
    {
        public EVORegF()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(Image_PreviewKeyDown);
        }
      
        public User regU = new User();
        Vehicle vhc = new Vehicle();
        Bank bank = new Bank();
        RegVehiBll regV = new RegVehiBll();
        BankBll bankB = new BankBll();
        RegGenUserBll register = new RegGenUserBll();
        string selectedIt;
        MesBClass msg = new MesBClass();    


        private void Button_Click(object sender, RoutedEventArgs e)
        {     
            if (!Input.EVRegCk(modelValue.Text, bankValue.Text, addressValue.Text))
            {
                msg.MessShow("Alert", "Please input all the required fields", false);
            }
            else
            {
                vhc.Brand = selectedIt;
                vhc.Model = modelValue.Text;
                vhc.EVUsers = regU;
                vhc.Address = addressValue.Text;
                bank.Account = bankValue.Text;
                bank.EVUser = regU;

                msg.MessShow("Registration", register.Create(regU), false);
                regV.Create(vhc, regU);
                bankB.Create(bank, regU);

                this.Hide();
            }        
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void brandComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedIt = comboBox.SelectedItem as string;
        }

        private void Image_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                Close();
            }
        }
    }
}
