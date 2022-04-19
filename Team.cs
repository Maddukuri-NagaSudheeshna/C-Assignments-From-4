using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPlayerClasses
{
    internal class Team : Player, IEnumerable  
    {
        Team[] members = null;   
        int freeIndex = 0;
        public String Name { get; set; }
        public String surName { get; set; }

        public Team()  //Zero argument constructor
        {
            members = new Team[11];
        }
        public void Add(Team member)   
        {
            members[freeIndex] = member;
            freeIndex++;
        }
        public IEnumerator GetEnumerator() 
        {
            foreach (Object obj in members)
            {
                if (obj == null)
                {
                    break;
                }
                yield return obj;
            }
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Country Name to view Player Names");
            String CountryName = Console.ReadLine();
            if (CountryName == "India")
            {
                Console.WriteLine("Below Players are selected for Lord's Battle");
            }
            else
            {
                Console.WriteLine("we have a player list for India Please enter Valid Country ...!Yet this is Confidential");

            }

            Console.ReadLine();
            List<Team> myList = new List<Team>();
            Team t1 = new Team();
            t1.Name = "Virat";
            t1.surName = "Kohli";
            Team t2 = new Team();
            t2.Name = "Nihar";
            t2.surName = "Srivathsa";
            Team t3 = new Team();
            t3.Name = "MS";
            t3.surName = "Dhoni";
            Team t4 = new Team();
            t4.Name = "KL";
            t4.surName = "Rahul";
            Team t5 = new Team();
            t5.Name = "Rohit";
            t5.surName = "Sharma";
            Team t6 = new Team();
            t6.Name = "Rishab";
            t6.surName = "Pant";
            Team t7 = new Team();
            t7.Name = "Mayank ";
            t7.surName = "Agarwal";
            Team t8 = new Team();
            t8.Name = "Manish";
            t8.surName = "Pandey";
            Team t9 = new Team();
            t9.Name = "Harshal";
            t9.surName = "Patel";
            Team t10 = new Team();
            t10.Name = "Suresh";
            t10.surName = "Raina";
            Team t11 = new Team();
            t11.Name = "Glenn";
            t11.surName = "Maxwell";
            myList.Add(t1);
            myList.Add(t2);
            myList.Add(t3);
            myList.Add(t4);
            myList.Add(t5);
            myList.Add(t6);
            myList.Add(t7);
            myList.Add(t8);
            myList.Add(t9);
            myList.Add(t10);
            myList.Add(t11);

            Console.WriteLine("Next Match Scedule will be in Lords Ground England ");
            Console.ReadKey();


            foreach (Team team in myList)
            {
                Console.WriteLine("Player Name : " + team.Name + "    " + "SurName : " + team.surName);
            }
            Console.WriteLine("Enter Admin Credentials to view runs scored by the individual players");
            Console.ReadLine();
            Console.WriteLine("Enter Player names Manually to view runs they scored");
            Console.ReadLine();

            Player player1Scored = new Player();
            player1Scored.Runs = 89;
            Player player2Scored = new Player();
            player2Scored.Runs = 108;
            Player player3Scored = new Player();
            player3Scored.Runs = 23;
            Player player4Scored = new Player();
            player4Scored.Runs = 12;
            Player player5Scored = new Player();
            player5Scored.Runs = 13;
            Player player6Scored = new Player();
            player6Scored.Runs = 19;
            Player player7Scored = new Player();    
            player7Scored.Runs = 20;
            Player player8Scored = new Player();    
            player8Scored.Runs = 21;
            Player player9Scored = new Player();
            player9Scored.Runs = 10;
            Player player10Scored = new Player();
            player10Scored.Runs = 51;
            Player player11Scored = new Player();
            player11Scored.Runs = 2;

            List<Player> playerList = new List<Player>();   
            playerList.Add(player1Scored);
            playerList.Add(player2Scored);
            playerList.Add(player3Scored);
            playerList.Add(player4Scored);
            playerList.Add(player5Scored);
            playerList.Add(player6Scored);
            playerList.Add(player7Scored);
            playerList.Add(player8Scored);
            playerList.Add(player9Scored);
            playerList.Add(player10Scored);
            playerList.Add(player11Scored);
            //Console.WriteLine("Enter Player names Manually to view runs they scored");
            foreach (Player player in playerList)
            {
                
                Console.WriteLine("Players Scored : "+player.Runs);
                Console.ReadLine();
            }


        }
    }
}