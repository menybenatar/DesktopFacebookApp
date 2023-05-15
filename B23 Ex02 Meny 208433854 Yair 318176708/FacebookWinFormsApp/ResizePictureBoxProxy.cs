using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ResizePictureBoxProxy : PictureBox
    {
        private bool IsOpen { get; set; } = false;
        
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if(IsOpen)
            {
                this.Dock = System.Windows.Forms.DockStyle.None;
            }
            else
            {
                this.Dock = System.Windows.Forms.DockStyle.Fill;
            }

            IsOpen = !IsOpen; 
        }

    }
}
