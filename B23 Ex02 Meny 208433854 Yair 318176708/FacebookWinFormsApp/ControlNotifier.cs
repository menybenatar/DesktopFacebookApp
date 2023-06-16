using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class ControlNotifier
    {
        private readonly List<IControlObserver> m_ControlObservers = new List<IControlObserver>();

        public void AttachObserver(IControlObserver i_ControlObserver)
        {
            m_ControlObservers.Add(i_ControlObserver);
        }

        public void DetachObserver(IControlObserver i_ControlObserver)
        {
            m_ControlObservers.Remove(i_ControlObserver);
        }

        public void NotifyControlObservers(bool i_State)
        {
            foreach (IControlObserver observer in m_ControlObservers)
            {
                observer.UpdateControlState(i_State);
            }
        }
    }
}
