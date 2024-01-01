using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class UCMiniEvent : UserControl
    {
        private User user;
        public UCMiniEvent(User user)
        {
            InitializeComponent();
            this.user = user;

            lbEventName.Text = user.FulName.ToUpper().ToString();
            lbTime.Text = user.Information.Gender.ToUpper().ToString();
            //lbStartTime.Text = user.Information.PhoneNumber.ToString();
            lbStartTime.Visible = false;
            lbNumOfAttendances.Visible = false;

            if (user.Information.Image == null)
            {

            }   
            else
            {
                guna2CirclePictureBox1.Image = new System.Drawing.Bitmap(user.Information.Image);
            }    
        }
    }
}
