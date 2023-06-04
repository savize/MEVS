using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEVS
{
    public class MesBClass
    {
        public DialogResult MessShow(string Title, string Detail, bool buttons)
        {
            MesB message = new MesB();
            message.Title.Text = Title;
            message.Det.Text = Detail;

            if (buttons)
            {
                message.YesBtn.Visible = true;
                message.NoBtn.Visible = true;
                message.CanBtn.Visible = false;
            }
            else
            {
                message.YesBtn.Visible = false;
                message.NoBtn.Visible = false;
                message.CanBtn.Visible = true;
            }

            message.ShowDialog();
            return message.DialogResult;
        }
    }
}
