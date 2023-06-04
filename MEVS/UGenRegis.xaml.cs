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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BE;
using BLL;
using MEVS;

namespace MEVS
{
    /// <summary>
    /// Interaction logic for RegisUser.xaml
    /// </summary>
    public partial class RegisUser : UserControl
    {
        public RegisUser()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(Button_PreviewKeyDown);
        }

        MesBClass msg = new MesBClass();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User u = new User();
            OpenWin ow = new OpenWin();

            u.FullName = fName.Text + " " + lName.Text;
            u.Email = emailValue.Text;
            u.Phone = phoneValue.Text;
            u.Username = UsernameValue.Text;
            u.Password = PassValue.Text;
            u.RegDate = DateTime.Now;

            if(!RegGenUserBll.InputCheck(fName.Text, lName.Text, phoneValue.Text, emailValue.Text, UsernameValue.Text, PassValue.Text))
            {
                msg.MessShow("Data entry", "Please fill up all the required fields", false);
            }
            else
            {
                if (EVRB.IsChecked == true)
                {
                    u.UserCategory = "EVOwner";

                    EVORegF EVReg = new EVORegF();
                    EVReg.regU = u;
                    ow.OpenForm(EVReg);
                }
                else if (CSRB.IsChecked == true)
                {
                    u.UserCategory = "ChargingStation";

                    CSRegF CSReg = new CSRegF();
                    CSReg.regU = u;
                    ow.OpenForm(CSReg);
                }
                else
                {
                    u.UserCategory = "ServiceProvider";

                    SPRegF SPReg = new SPRegF();
                    SPReg.RegU = u;
                    ow.OpenForm(SPReg);
                }

                fName.Text = "";
                lName.Text = "";
                emailValue.Text = "";
                phoneValue.Text = "";
                UsernameValue.Text = "";
                PassValue.Text = "";
            }   
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
