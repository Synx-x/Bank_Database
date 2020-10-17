using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Database
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //variables 
            int x;
            int y;
            int validate = 0;

            //Login variable
            //50 usernames, 50 passwords
            string[,] Login = new string[50, 50];

            //loading screen
            for(int i=0; i<=3; i++)
            {
                //4x4 square looping in a circle

             //Loop 1
                System.Threading.Thread.Sleep(150);
                Console.Clear();
                x = 24;
                y = 12;
                Console.SetCursorPosition(x,y);
                Console.WriteLine("X");

                //move 1 step to left
                x--;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step to right
                x++;

                //move 1 step up
                y--;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step to right
                x--;

                
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 2 steps to right
                x += 2;

                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step down
                y++;


                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");


             //Loop 2
                
                //waits for 150ms while loop 1 runs
                System.Threading.Thread.Sleep(150);
                //clears whats already been drawn from loop 1
                Console.Clear();

                //moves 2 steps to the right
                x -= 4;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step to left
                x--;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step to right
                x++;

                //move 1 step up
                y--;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step to right
                x--;


                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 2 steps to right
                x += 2;


                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step down
                y++;


                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");


             //Loop 3

                //waits for 150ms while loop 1 runs
                System.Threading.Thread.Sleep(150);
                //clears whats already been drawn from loop 1
                Console.Clear();

                //moves 2 steps to the right
                y -= 3;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step to left
                x--;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step to right
                x++;

                //move 1 step up
                y--;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step to right
                x--;


                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 2 steps to right
                x += 2;

                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step down
                y++;


                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");


             //Loop 4

                //waits for 150ms while loop 1 runs
                System.Threading.Thread.Sleep(150);
                //clears whats already been drawn from loop 1
                Console.Clear();

                //moves 2 steps to the right
                x += 3;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step to left
                x--;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step to right
                x++;

                //move 1 step up
                y--;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step to right
                x--;


                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 2 steps to right
                x += 2;


                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");

                //move 1 step down
                y++;


                Console.SetCursorPosition(x, y);
                Console.WriteLine("X");
            }

            //Main Interface UI for login/register
            do
            {
                Console.Clear();
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("1 to Login");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("2 to Register a new Account.");

                Console.SetCursorPosition(3, 7);
                int response = Convert.ToInt32(Console.ReadLine());

                if(response == 1 || response == 2)
                {
                    validate = 1;
               
                }
                else
                {
                    Console.SetCursorPosition(3, 10);
                    Console.WriteLine("Option Unavailable. \nPress Enter  and try again.");
                    Console.ReadLine();
                }

            } while (validate == 0);

            //Registration UI

            
        }
    }
}
