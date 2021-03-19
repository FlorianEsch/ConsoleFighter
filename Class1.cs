using System;
using System.Collections.Generic;
using System.Text;

namespace fightGame
{
    enum Action
    {
        atk,
        def,
        heal,
        dft
    }
    class Fighter
    {
        string name;
        public Action action;       
        int live;
        public bool checklive = true;
     
        public Fighter(string fighterName, int fighterLive) 
        {
            this.name = fighterName;
            this.live = fighterLive;
        }
        public void Fighterhello()
        {
        Console.WriteLine("You are " + name + " you have " + live + "% Live.");
        }
        
        public bool Alive { get { return live > 0; } }
      
        public void Livepad(int x)
        {
            live += x;
        }
       
        public void Wapon()
        {
            Console.WriteLine("What is your action {0}?", name);
            Console.WriteLine("You can choose between:");
            Console.WriteLine("1: fight 2: defent 3: heal");
            Console.WriteLine("You choose your action with the Number! {0}");
            try
            {
                 string selectaction = Console.ReadLine();
                int chosenAction = int.Parse(selectaction);
            if (chosenAction == 1)
            {
                    action = Action.atk;
                
            }
            else if (chosenAction == 2)
            {
                    action = Action.def;
            } else
            {
                    action = Action.heal;
            }
            Console.Clear();
             }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
      
        public void FighterEnde()
        {
            Console.WriteLine("You are " + name + " you have " + live + "% Live.");
        }

    }

     
}

   
