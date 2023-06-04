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
using Stimulsoft.Report;
using System.Windows.Forms;
using Binding = System.Windows.Data.Binding;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Data;
using DataGrid = System.Windows.Controls.DataGrid;

namespace MEVS
{
    /// <summary>
    /// Interaction logic for AdminLogged.xaml
    /// </summary>
    public partial class AdminLogged : Window
    {
        public AdminLogged()
        {
            InitializeComponent();
        }

        int id;
        AdminBll Abll = new AdminBll();
        string tab;
        MaintainBll mbll = new MaintainBll();
        MesBClass msg = new MesBClass();

        void DgEVO()
        {
            mainCon.Visibility = Visibility.Visible;
            Dg.ItemsSource = null;
            Dg.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = Abll.ReadEVOwners() });
            Dg.Columns[0].Visibility = Visibility.Hidden;
            tab = "EV";
        }

        void DgCS()
        {
            mainCon.Visibility = Visibility.Visible;
            Dg.ItemsSource = null;
            Dg.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = Abll.ReadCS() });
            Dg.Columns[13].Visibility = Visibility.Hidden;
            tab = "CS";
        }

        void DgSP()
        {
            mainCon.Visibility = Visibility.Visible;
            Dg.ItemsSource = null;
            Dg.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = Abll.ReadSP() });
            Dg.Columns[12].Visibility = Visibility.Hidden;
            tab = "SP";
        }

        private void EvOwnTab_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DgEVO();
        }

        private void CSTab_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DgCS();
        }

        private void SPTab_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DgSP();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StiReport rep = new StiReport();
            if (tab == "EV")
            {
                rep.Load(@"C:\Users\Savize\source\repos\MEVS\EVORep.mrt");
                rep.Render();
                rep.Show();
            }
            else if (tab == "CS")
            {
                rep.Load(@"C:\Users\Savize\source\repos\MEVS\CSRep.mrt");
                rep.Render();
                rep.Show();
            }
            else if (tab == "SP")
            {
                rep.Load(@"C:\Users\Savize\source\repos\MEVS\SPRep.mrt");
                rep.Render();
                rep.Show();
            }
        }

        private void bk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mainCon.Visibility = Visibility.Hidden;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            msg.MessShow("Backup Result", mbll.Backup(fbd.SelectedPath), false);
        }

        private void rest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mainCon.Visibility = Visibility.Hidden;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            msg.MessShow("Restore Data Result", mbll.Restore(ofd.FileName), false);
        }

        private void Dg_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row_selected = dg.SelectedItem as DataRowView;

            if (row_selected != null)
            {
                if (tab == "CS")
                {
                    id = Convert.ToInt32(row_selected["RId"]);
                    DialogResult dr = msg.MessShow("Alert", "Do you want to deactive the selected Charging Station?", true);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        msg.MessShow("Result", Abll.UpdateCS(id), false);
                        DgCS();
                    }
                }
                else if (tab == "EV")
                {
                    id = Convert.ToInt32(row_selected["Id"]);
                    DialogResult dr = msg.MessShow("Alert", "Do you want to deactive the selected user?", true);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        msg.MessShow("Result", Abll.UpdateEVO(id), false);
                        DgEVO();
                    }
                }
                else if (tab == "SP")
                {
                    id = Convert.ToInt32(row_selected["RId"]);
                    DialogResult dr = msg.MessShow("Alert", "Do you want to deactive the selected Service Provider?", true);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        msg.MessShow("Result", Abll.UpdateSP(id), false);
                        DgSP();
                    }
                }
            }
            else
            {
                msg.MessShow("Alert", "Selected item not found", false);
            }
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DialogResult dr = msg.MessShow("Alert", "Do you want to log out of the system?", true);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                MainWindow mw = new MainWindow();

                this.Hide();
                mw.Show();
            }
        }
    }
}

