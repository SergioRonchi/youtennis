using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.DAL;
using YouTennis.Model;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CouchRepository<Player> cr = new CouchRepository<Player>();
            Player player = cr.Find("U1");
         
            if (player == null)
            {
                player = new Player() {Id="U1",  FirstName = "Sergio", SecondName = "Ronchi" };
                player.Profiles.Add(new PlayerProfile() { DateOfBirth = new DateTime(1964, 11, 27) });

               
            }
            else
            {
              
                player.Follower.Add(new Player() { Id = "2", FirstName = "Pippo" });
            }

        

            cr.Save(player);
           
            //c.Basics();
        }
    }
}
