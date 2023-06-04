using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Effects;

namespace MEVS
{
    public class OpenWin
    {
        public void OpenForm(Window f)
        {
            Window g = Application.Current.MainWindow;
            BlurBitmapEffect blur = new BlurBitmapEffect();
            blur.Radius = 15;

            g.BitmapEffect = blur;

            f.ShowDialog();
            blur.Radius = 0;
            g.BitmapEffect = blur;
        }
    }
}
