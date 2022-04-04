using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.CsharpAdv.Class01.Exercise03
{
    public class Player 
    {
        public int CounterPlayer { get; set; }  
        public int CounterComputer { get; set; }


        public Player()
        {
            CounterPlayer = 0;  
            CounterComputer = 0;
        }
        
        public void Play (RPC choice)
        {
            
            Random rand = new Random ();
            int gameChoice = rand.Next(1,4);
            RPC gameChoiceEnum = (RPC)gameChoice;

            if ((choice==gameChoiceEnum))
                {
                Console.WriteLine("Try again!");

            }

            else if(choice == RPC.Rock && gameChoiceEnum == RPC.Scisors || choice == RPC.Scisors && gameChoiceEnum == RPC.Paper || choice == RPC.Paper && gameChoiceEnum == RPC.Scisors)
            {
                Console.WriteLine("You won!");
               
                    CounterPlayer++;
                
            }

           else
            {
                Console.WriteLine("The computer won :( ");
                CounterComputer++;

            }
                

            }

            
        }
    }

