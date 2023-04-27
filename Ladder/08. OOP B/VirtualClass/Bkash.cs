using System;
namespace OOPB
{
    internal class Bkash : VirtualMobileBank
    {
        internal override void SendMoney(double amount)
        {
            Console.WriteLine("Sending money...");
        }
        internal override void CashOut(double amount)
        {
            Console.WriteLine("Cash out...");
        }
    }
}
