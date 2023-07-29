using Mahendra_054.Models;
using MySqlConnector;

namespace Mahendra_054.DAL
{
    public class PersonCraditDAL
    {
        static string constr = @"server=localhost;userid=root;password=mkmeena97;database=creditcarddb";
        public static List<PersonCradit> GetPerson(int pid)
        {
           List<PersonCradit> pc = new List<PersonCradit>();
          //  CraditCard card = new CraditCard();
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.Connection = con;
                   // cmd.CommandText = "select * from Person p where pid=@pid;";
                    cmd.CommandText = "Select * from person p , creditcard c  where p.pid = c.pid and p.pid=@pid;";
                   // cmd.CommandText = "Select * from craditcard where pid = @pid;";
                    cmd.Parameters.AddWithValue("@pid", pid);
                    MySqlDataReader rd = cmd.ExecuteReader();

                    Console.WriteLine("\n\n");
                    while (rd.Read())
                    {
                        PersonCradit p = new PersonCradit()
                        {
                            Pid = rd.GetInt32(0),
                            Fname = rd.GetString(1),
                            Lname = rd.GetString(2),
                            Cardno = rd.GetInt32(3),
                            Expirydate = rd.GetDateTime(4),
                            Bankname = rd.GetString(5),
                            
                     
                        };

                        pc.Add(p);
                    }

                    con.Close();
                }
                return pc;

            }
        }
    }
}
