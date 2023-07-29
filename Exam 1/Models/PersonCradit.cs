using System.ComponentModel.DataAnnotations;

namespace Mahendra_054.Models
{
    public class PersonCradit
    {
        

        public Person Person { get;  set; }
        public CreditCard CreditCard { get; set; }
        public int Pid { get;internal set; }
        public String  Fname { get;internal set; }
        public string Lname { get;internal set; }
        public int Cardno { get;internal set; }
        public string Bankname { get; internal set; }
        public DateTime Expirydate { get;internal set; }
        public  int Spid { get;internal set; }

        public PersonCradit()
        {
        }
        public PersonCradit(Person person, CreditCard creditCard, int pid, string fname, string lname, int cardno, string bankname, DateTime datetime, int spid)
        {
            Person = person;
            CreditCard = creditCard;
            Person.Pid = pid;
            Person.Fname = fname;
            Person.Lname = lname;
            CreditCard.Cardno = cardno;
            CreditCard.Bankname = bankname;
            CreditCard.Expirydate = datetime;
            CreditCard.Spid = spid;
        }
    }
}
