using System;
namespace CGS
{
    public class Curator : Person
    {
        
        public string CuratorId { get; set; }
        public double Commission { get; set; }
        const double CommRate = 0.10;
        

        public Curator()
        {
            
        }

        public Curator(string firstName, string lastName, string curatorId ) : base(firstName, lastName)
        {
            CuratorId = curatorId;
            //Commission = 0;
            Random rand = new Random();
            Commission = rand.Next(100, 500);
        }

        public override string ToString()
        {
            string conservateurInformation = "\nName:" + base.FirstName  +
            base.ToString()+","+ "\nCurator ID: " + CuratorId + "\nCommissions paid: " +
                Commission;

            return conservateurInformation;
        }

        public string GetID()
        {
            return CuratorId;
        }

        public void SetComm(double Commission)
        {
            Commission = CommRate*Commission;
        }

        public void ClearComm()
        {
            Commission=0;
            Console.WriteLine("setting commisson to"+Commission);
            OnChangeCommission(EventArgs.Empty);
        }
        public virtual void OnChangeCommission(EventArgs e)
        {
            CommissionPaidHandler changed = CommissionChangedEvent;
            if(changed != null)
            {
                changed(this,e);
            }
        }
        public event CommissionPaidHandler CommissionChangedEvent;
        public delegate void  CommissionPaidHandler (object Sender,EventArgs e);//event
    }
} 