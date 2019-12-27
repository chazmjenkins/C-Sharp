using System;

namespace ConditionalsWin10
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var season = Season.Fall;

            switch (season)
            {
                case Season.Fall:
                    //Console.WriteLine("We've got a promotion.");
                    //break;

                case Season.Summer:
                    Console.WriteLine("We've got a promotion.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
            
            
            }
        }
    }
