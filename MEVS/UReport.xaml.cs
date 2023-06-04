using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
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
using BE;
using LiveCharts;
using LiveCharts.Wpf;
using ScottPlot;
using Color = System.Drawing.Color;

namespace MEVS
{
    /// <summary>
    /// Interaction logic for UReport.xaml
    /// </summary>
    public partial class UReport : UserControl
    {
        public UReport()
        {
            InitializeComponent();
        }

        public User RlogU = new User();
        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
        System.Drawing.Color cl = System.Drawing.Color.FromArgb(100, 22, 100, 49);

        double[] values = { 90, 110, 180, 95, 175 };
        double[] positions = { 0, 1, 2, 3, 4 };
        string[] labels = { "Jan", "Feb", "Mar", "Apr", "May" };

        double[] a = { 7, 11, 5, 7, 12 };

        Color[] sliceColors ={
                ColorTranslator.FromHtml("#0B2C44"),
                ColorTranslator.FromHtml("#166495"),
                ColorTranslator.FromHtml("#0C9DC9"),
                ColorTranslator.FromHtml("#1D3D59"),
                ColorTranslator.FromHtml("#030B11"),
             };
       
        private void Border_Loaded(object sender, RoutedEventArgs e)
        {         
            chartWpf.Plot.Clear();
            chartWpf.Plot.AddBar(values, positions, cl);
            chartWpf.Plot.AddBar(values, positions, cl).ShowValuesAboveBars = true;
            chartWpf.Plot.XTicks(positions, labels);
            chartWpf.Plot.SetAxisLimits(yMin: 0);
            chartWpf.Plot.Style(figureBackground: newColor, dataBackground: newColor);
            chartWpf.Refresh();
  
            chargeChart.Plot.Clear();
            var pie = chargeChart.Plot.AddPie(a);         
            pie.Explode = true;
            pie.SliceLabels = labels;
            pie.ShowLabels = true;
            pie.ShowValues = true;
            pie.SliceFillColors = sliceColors;

            chargeChart.Plot.Style(figureBackground: newColor, dataBackground: newColor);
            chargeChart.Refresh();
        }

    }
}
