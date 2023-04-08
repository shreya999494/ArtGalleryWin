using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CGS
{
    public class EventListener
    {
        public EventListener()
        {
        }
        //private string Curator;
        Curator curator = new Curator();
        
        public EventListener(Curator curator)
        {
            curator = curator;
            curator.CommissionChangedEvent += CommissionChangedEvent;
        }
        private void CommissionChangedEvent(object Sender,EventArgs e)
        {
            Console.WriteLine("The Curator was paid commission");
        }
        public void Detach()
        {
            curator = null;
        }
    }
}
