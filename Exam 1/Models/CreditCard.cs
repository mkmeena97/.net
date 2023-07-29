using System.ComponentModel.DataAnnotations.Schema;

namespace Mahendra_054.Models
{
    public class CreditCard
    {
        

        public int Cardno { get; set; }
        public DateTime Expirydate { get; set; }
        public string Bankname { get; set; }
       
        public int Spid { get; set; }

        public CreditCard()
        {
        }

        public CreditCard(int cardno, DateTime exprirydate, string bankname, int pid)
        {
            this.Cardno = cardno;
            this.Expirydate = exprirydate;
            this.Bankname = bankname;
            this.Spid = pid;
            
        }
    }
}
