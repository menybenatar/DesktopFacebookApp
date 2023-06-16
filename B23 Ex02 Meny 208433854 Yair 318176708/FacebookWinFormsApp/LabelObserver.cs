using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class LabelObserver : Label, IControlObserver
    {
        public void UpdateControlState(bool i_IsLoggedIn)
        {
            this.Visible = i_IsLoggedIn;
        }
    }
}
