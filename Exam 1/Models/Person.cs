namespace Mahendra_054.Models
{
    public class Person
    {
       

        public int Pid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        

        public Person()
        {
        }

        public Person(int pid, string fname, string lname)
        {
            Pid = pid;
            this.Fname = fname;
            this.Lname = lname;
        }
    }
}
