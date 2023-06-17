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
