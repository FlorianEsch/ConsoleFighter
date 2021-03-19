using System;

namespace fightGame
{
    class Program
    {

        static void Main(string[] args)
        {


            // Name
           

            Console.WriteLine("Give Your Name Player 1:");
           
            Fighter Player1 = new Fighter(Console.ReadLine(),100);
            Player1.Fighterhello();

     
            Console.WriteLine("Give Your Name Player 2:");
          
            Fighter Player2 = new Fighter(Console.ReadLine(),100);
            Player2.Fighterhello();
           



            // Fight

            do
            {

                //Choose Wapon
              
                Player1.Wapon();                    
                Player2.Wapon();



                if (Player1.action == Action.atk)
                {
                    if (Player2.action == Action.atk)
                    {
                      
                        Player1.Livepad(-5);                   
                        Player2.Livepad(-5);
                        Console.WriteLine("strong fight");
                    }
                    else if (Player2.action == Action.def)
                    {                     
                        Player1.Livepad(-10);
                        Console.WriteLine("Player1 get hit");
                    }
                    else
                    {            
                        Player2.Livepad(-10);
                        Console.WriteLine("Player 2 get hit");
                    }
                }
                if (Player1.action == Action.def)
                {
                    if (Player2.action == Action.atk)
                    {                  
                        Player2.Livepad(-10);
                        Console.WriteLine("Player 2 get hit");
                    }
                    else if (Player2.action == Action.def)
                    {
                        Console.WriteLine("all defensiv");
                    }
                    else 
                    {                     
                        Player2.Livepad(10);
                        Console.WriteLine("Player 2 heal");
                    }
                }
                if (Player1.action == Action.heal)
                
                {
                    if (Player2.action == Action.atk)
                    {                      
                        Player1.Livepad(-10);
                        Console.WriteLine("Player1 get hit");
                    }
                    else if (Player2.action == Action.def)
                    {                   
                        Player1.Livepad(10);
                        Console.WriteLine("Player 1 heal");
                    }
                    else
                    {                     
                        Player1.Livepad(10);
                        Player2.Livepad(10);

                        Console.WriteLine("Player 1 heal");                      
                        Console.WriteLine("Player 2 heal");
                    }
                }
                
                Player1.FighterEnde();              
                Player2.FighterEnde();       
                
            } while (Player1.Alive && Player2.Alive);




            
            Player1.FighterEnde();           
            Player2.FighterEnde();




            


        }



    }
}
