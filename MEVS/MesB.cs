using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEVS
{
    public partial class MesB : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
      int nLeftRect,     // x-coordinate of upper-left corner
      int nTopRect,      // y-coordinate of upper-left corner
      int nRightRect,    // x-coordinate of lower-right corner
      int nBottomRect,   // y-coordinate of lower-right corner
      int nWidthEllipse, // width of ellipse
      int nHeightEllipse // height of ellipse
  );

        public MesB()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void CanBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CanBtn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CanBtn_Click(sender, e);
            }
        }

        private void YesBtn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                YesBtn_Click(sender, e);
            }
        }

        private void NoBtn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                NoBtn_Click(sender, e);
            }
        }
    }
}
