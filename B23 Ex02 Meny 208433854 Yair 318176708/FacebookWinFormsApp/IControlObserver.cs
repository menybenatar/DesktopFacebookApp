﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IControlObserver
    {
        void UpdateControlState(bool i_IsLoggedIn);
    }
}
