using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ResizePicturesBoxProxy : PictureBox
    {
        bool m_IsOpen = false;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if(m_IsOpen)
            {
                this.Dock = System.Windows.Forms.DockStyle.None;
            }
            else
            {
                this.Dock = System.Windows.Forms.DockStyle.Fill;
            }

            m_IsOpen = !m_IsOpen; 
        }

    }
}
